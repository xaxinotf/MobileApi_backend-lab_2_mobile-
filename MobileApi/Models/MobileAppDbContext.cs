using Microsoft.EntityFrameworkCore;

namespace MobileApi.Models
{
    public class MobileAppDbContext : DbContext
    {
        public MobileAppDbContext(DbContextOptions<MobileAppDbContext> options) : base(options) { }

        public virtual DbSet<City> Cities { get; set; } = null!;
        public virtual DbSet<Contact> Contacts { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Додавання початкових даних для Cities
            modelBuilder.Entity<City>().HasData(
                new City { Id = 1, Name = "Київ", Distance = 0, Population = 2884000 },
                new City { Id = 2, Name = "Львів", Distance = 540.7, Population = 717273 },
                new City { Id = 3, Name = "Одеса", Distance = 475.4, Population = 1010537 },
                new City { Id = 4, Name = "Харків", Distance = 489, Population = 1421125 },
                new City { Id = 5, Name = "Дніпро", Distance = 650.5, Population = 1002000 },
                new City { Id = 6, Name = "Запоріжжя", Distance = 550.2, Population = 729000 },
                new City { Id = 7, Name = "Вінниця", Distance = 265.3, Population = 372700 },
                new City { Id = 8, Name = "Чернігів", Distance = 140.6, Population = 285234 },
                new City { Id = 9, Name = "Полтава", Distance = 350.8, Population = 300400 },
                new City { Id = 10, Name = "Івано-Франківськ", Distance = 620.5, Population = 237700 }
            );

            // Додавання початкових даних для Contacts
            modelBuilder.Entity<Contact>().HasData(
                // Контакти з доменом @gmail.com
                new Contact { Id = 1, Name = "Oleksii Symonenko", Email = "oleksii.symonenko@gmail.com" },
                new Contact { Id = 2, Name = "Kateryna Ivanova", Email = "kateryna.ivanova@ukr.net" },
                new Contact { Id = 3, Name = "Dmytro Lysenko", Email = "dmytro.lysenko@gmail.com" },
                new Contact { Id = 4, Name = "Olena Hladka", Email = "olena.hladka@gmail.com" },
                new Contact { Id = 5, Name = "Pavlo Shevchuk", Email = "pavlo.shevchuk@ukr.net" },
                new Contact { Id = 6, Name = "Anatolii Troian", Email = "anatolii.troian@gmail.com" },
                new Contact { Id = 7, Name = "Yana Dubovyk", Email = "yana.dubovyk@gmail.com" },
                new Contact { Id = 8, Name = "Serhii Naumenko", Email = "serhii.naumenko@ukr.net" },
                new Contact { Id = 9, Name = "Oksana Mykhailenko", Email = "oksana.mykhailenko@gmail.com" },
                new Contact { Id = 10, Name = "Andrii Voronenko", Email = "andrii.voronenko@ukr.net" },

                // Додаткові контакти з доменом @knu.ua
                new Contact { Id = 11, Name = "Ihor Zubov", Email = "ihor.zubov@knu.ua" },
                new Contact { Id = 12, Name = "Mariia Pidgorna", Email = "mariia.pidgorna@knu.ua" },
                new Contact { Id = 13, Name = "Mykola Stepanov", Email = "mykola.stepanov@knu.ua" },
                new Contact { Id = 14, Name = "Svitlana Prokopenko", Email = "svitlana.prokopenko@knu.ua" },
                new Contact { Id = 15, Name = "Vasyl Vorobets", Email = "vasyl.vorobets@knu.ua" },
                new Contact { Id = 16, Name = "Olha Poliak", Email = "olha.poliak@knu.ua" },
                new Contact { Id = 17, Name = "Petro Yarema", Email = "petro.yarema@knu.ua" },
                new Contact { Id = 18, Name = "Inna Hrytsenko", Email = "inna.hrytsenko@knu.ua" },
                new Contact { Id = 19, Name = "Natalia Shevchenko", Email = "natalia.shevchenko@knu.ua" },
                new Contact { Id = 20, Name = "Roman Holovko", Email = "roman.holovko@knu.ua" }
            );
        }
    }
}
