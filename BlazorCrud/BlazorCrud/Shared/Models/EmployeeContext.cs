using BlazorCrud.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrud.Server.DataAccess
{
    public class EmployeeContext : DbContext
    {
        public virtual DbSet<Employee> tblEmployee { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=myTestDB;Data Source=HP7-W10\SQLEXP2019;");
            }
        }
    }
}
