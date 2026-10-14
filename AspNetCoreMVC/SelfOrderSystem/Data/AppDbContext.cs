using Microsoft.EntityFrameworkCore;
using SelfOrderSystem.Models;

namespace SelfOrderSystem.Data;
public class AppDbContext : DbContext {

    // Program.cs で登録した設定技術を受け取る
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { //受け取った設定を
    }

    // Categories テーブルを Category 型として問い合わせるためのプロパティ
    public DbSet<Category> Categories => Set<Category>();
    //
    public DbSet<Product> Products => Set<Product>();
}
