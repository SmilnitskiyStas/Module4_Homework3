using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreateDBByCode.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CreateDBByCode
{
    internal class Starter
    {
        public void Run()
        {
            var builder = new ConfigurationBuilder();

            // установка пути к текущему каталогу
            builder.SetBasePath(Directory.GetCurrentDirectory());

            // получаем конфигурацию из файла appsettings.json
            builder.AddJsonFile("appsettings.json");

            // создаем конфигурацию
            var config = builder.Build();

            // получаем строку подключения
            string connectionString = config.GetConnectionString("DefaultConnection");

            var optionsBuilder = new DbContextOptionsBuilder<AppContent>();
            var options = optionsBuilder.UseSqlServer(connectionString).Options;

            using (AppContent appContext = new AppContent(options))
            {
                appContext.Database.EnsureDeleted();
                appContext.Database.EnsureCreated();
                appContext.SaveChanges();
            }
        }
    }
}
