using Microsoft.EntityFrameworkCore;

public class ProductDbContext : DbContext
{
    #region Конструктор
    public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
    {
        Database.EnsureCreated();
    }
    #endregion

    #region Public свойство
    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>().HasData(GetProducts());
        base.OnModelCreating(modelBuilder);
    }

    #endregion

    #region методы
    private Product[] GetProducts() => new Product[] {
        new Product{
             ProductID = 1,
             ProductName = "Колбаса «Деликатесная» с копчёным ароматом",
             ProductDescription = "Вкусная колбаса высшего сорта с нежным мясом и лёгким дымком. Идеально для бутербродов и нарезки.",
             ProductPrice = 709,
             ProductUnit = 52
             },


    new Product{
             ProductID = 2,
             ProductName = "Сервелат «Премиум» с пряностями",
             ProductDescription = "Элитная колбаса с добавлением отборных специй. Отлично подходит к сырной тарелке и вину.",
             ProductPrice = 899,
             ProductUnit = 35
             },

    new Product{
             ProductID = 3,
             ProductName = "Колбаса «Докторская» классическая",
             ProductDescription = "Нежная варёная колбаса по ГОСТу. Отличный выбор для завтрака и детского питания.",
             ProductPrice = 450,
             ProductUnit = 78
        },

    new Product{
             ProductID = 4,
             ProductName = "Салями «Охотничья» острая",
             ProductDescription = "Пикантная колбаса с острым послевкусием. Хороша к пиву и в качестве закуски.",
             ProductPrice = 650,
             ProductUnit = 43
         },

    new Product{
             ProductID = 5,
             ProductName = "Колбаса «Чоризо» испанская",
             ProductDescription = "Аутентичная копчёная колбаса с паприкой. Идеальна для пасты, пиццы и тапас.",
             ProductPrice = 820,
             ProductUnit = 27
         },

    new Product{
             ProductID = 6,
             ProductName = "Буженина «Домашняя» в натуральной оболочке",
             ProductDescription = "Сочная буженина с чесноком и травами. Отлично подходит для бутербродов и салатов.",
             ProductPrice = 750,
             ProductUnit = 31
         }
    };
    #endregion
}