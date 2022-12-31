using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace AmazonWeb.EF
{
    public class EDbContextFactory : IDesignTimeDbContextFactory<EDbContext>
    {
        private const string ConnectionStrings = @"
                Data Source=localhost,1433;
                Initial Catalog=AmazonDB;
                User ID=root;Password=Quanghuy123";

        public EDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<EDbContext>();
            optionsBuilder.UseMySQL(ConnectionStrings);
            return new EDbContext(optionsBuilder.Options);
        }
    }
}
