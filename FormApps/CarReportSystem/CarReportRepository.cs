using CarReportSystem;
using Microsoft.Data.Sqlite;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;

namespace SQLiteProductSample;

//Productsテーブルに対するDB操作をまとめたクラス
//CRUD (Create / Read / Update / Delete) を担当する
public class CarReportRepository
{
    //
    public List<CarReport> GetAll() {

        var carReports = new List<CarReport>();

        using var connection = Database.GetConnection();
        connection.Open();

        //SQLを実行するためのコマンドオブジェクトを作る
        using var command = connection.CreateCommand();

        //Productsテーブルを作るSQL
        command.CommandText =
            """
            SELECT Id, Date, Author, Maker, CarName, Report, Picture
            FROM CarReports
            ORDER BY Id;
            """;

        //SELECTを実行し、複数行の検索結果を読み取る
        using var reader = command.ExecuteReader();

        while (reader.Read()) {
            carReports.Add(new CarReport {
                Id = reader.GetInt32(0),    //0列目:Id
                Date = DateTime.ParseExact(
                    reader.GetString(1),
                    "yyyy-mm-dd",
                    CultureInfo.InvariantCulture),
                Author = reader.GetString(2),
                Maker = (CarReport.MakerGroup)reader.GetInt32(3),
                CarName = reader.GetString(4),
                Report = reader.GetString(5),
                //Picture = 
            });
        }
        return carReports;
    }

    //商品を1件追加する。Create（INSERT）に相当する
    //戻り値として自動採番されたIdを返す
    public int Add(string name, int price) {
        //接続オブジェクトを生成する。
        using var connection = Database.GetConnection();
        connection.Open();
        using var command = connection.CreateCommand();

        command.CommandText =
            """
            INSERT INTO CarReports
            (Date, Author, Maker, CarName, Report, Picture)
            VALUES
            ($date, $author, $maker, $carName, $report, $picture);

            SELECT last_insert_rowid();
            """;

        command.Parameters.AddWithValue("$name", name);
        command.Parameters.AddWithValue("$price", price);

        //結果行を返さないSQLを実行する
        var result = command.ExecuteScalar();

        if(result is null) 
            throw new InvalidOperationException("登録した商品のIDを取得できませんでした。");

        //SQLiteのINTEGERはlongとして返るため、intへ変換する
        return Convert.ToInt32((long)result);
        
    }

    public void Update(Product product) {
        //接続オブジェクトを生成する。
        using var connection = Database.GetConnection();
        connection.Open();
        using var command = connection.CreateCommand();

        command.CommandText =
            """
            UPDATE Products
            SET Name = $name,
                Price = $price
            WHERE Id = $id;
            """;

        command.Parameters.AddWithValue("$name", product.Name);
        command.Parameters.AddWithValue("$price", product.Price);
        command.Parameters.AddWithValue("id", product.Id);

        //更新件数が0なら対象が存在しない
        if (command.ExecuteNonQuery() == 0)
            throw new InvalidOperationException("修正対象の商品が見つかりませんでした。");
    }

    public void Delete(int id) {
        using var connection = Database.GetConnection();
        connection.Open();

        using var command = connection.CreateCommand();
        command.CommandText =
            """
            DELETE FROM Products
            WHERE Id = $id;
            """;

        command.Parameters.AddWithValue("$id", id);
        command.ExecuteNonQuery();
    }

    // ImageをSQLiteへ保存できるbyte[]へ変換する
    private static byte[]? ImageToBytes(Image? image) {
        if (image is null) return null;

        using var stream = new MemoryStream();
        // DBへはPNG形式で保存
        image.Save(stream, ImageFormat.Png);
        return stream.ToArray();
    }

    // SQLiteのBLOB（byte[]）をImageへ変換する
    private static Image BytesToImage(byte[] data) {
        using var stream = new MemoryStream(data);
        using var image = Image.FromStream(stream);
        // MemoryStream破棄後も利用できるようBitmapとしてコピーする。
        return new Bitmap(image);
    }
}
