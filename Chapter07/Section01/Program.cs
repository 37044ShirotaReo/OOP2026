namespace Section01 {
    internal class Program {
        static void Main(string[] args) {
            var numbers = new List<int> { 9, 7, 5, 4, 2, 5, 4, 0, 4, 1, 0, 4 };

            var books = Books.GetBooks();
            var priceaverage = books.Average(x => x.Price);
            var pageaverage = books.Sum(x => x.Pages);
            var maxPrice = books.Max(x => x.Price);


            Console.WriteLine("平均金額:" + priceaverage);
            Console.WriteLine("合計ページ:" + pageaverage);
            Console.WriteLine("高価な本" + maxPrice);



            Console.WriteLine("--- 500円以上のタイトル ---");
            foreach (var book in books.Where(x => x.Price >= 500)) {
                Console.WriteLine(book.Title);
            }

            //250ページ以上の本を上位3冊を出力
            Console.WriteLine("---250ページ以上の上位3冊---");
            var page = books.Where(x => 250 <= x.Pages).Take(3);
            foreach (var book in page) {
                Console.WriteLine(book.Title);
            }

        }
    }
}
