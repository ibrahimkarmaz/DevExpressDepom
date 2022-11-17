using EntityLayer.Concrete;
using EntityLayer.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
      
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new EmployeeMAP());
            modelBuilder.Configurations.Add(new CompanyMAP());
            modelBuilder.Configurations.Add(new CustomerMAP());
            modelBuilder.Configurations.Add(new BankMAP());
            modelBuilder.Configurations.Add(new StockMAP());
            modelBuilder.Configurations.Add(new InvoiceMAP());
            //modelBuilder.Configurations.Add(new InvoiceDetailMAP());
            modelBuilder.Configurations.Add(new NoteMAP());
          //  modelBuilder.Configurations.Add(new ExpenseMAP());
            modelBuilder.Configurations.Add(new ProductMAP());
            modelBuilder.Configurations.Add(new CountyMAP());
            modelBuilder.Configurations.Add(new BlandMAP());
            modelBuilder.Configurations.Add(new ModelMAP());
            modelBuilder.Configurations.Add(new DistrictMAP());
            modelBuilder.Configurations.Add(new SectorMAP());
            modelBuilder.Configurations.Add(new DepartmentMAP());
            modelBuilder.Configurations.Add(new ExpenseHeaderMAP());
            modelBuilder.Configurations.Add(new ExpenseContentMAP());
            modelBuilder.Configurations.Add(new CompanyMovementMAP());
            modelBuilder.Configurations.Add(new CompanyMovementDetailMAP());
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Bank> Banks { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
       // public DbSet<InvoiceDetail> InvoiceDetails { get; set; }
        public DbSet<Note> Notes { get; set; }
     //   public DbSet<Expense> Expenses { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<County> Countys { get; set; }
        public DbSet<Bland> Blands { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Sector> Sectors { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<ExpenseHeader> ExpenseHeaders { get; set; }
        public DbSet<ExpenseContent> ExpenseContents { get; set; }
        public DbSet<CompanyMovement> CompanyMovements { get; set; }
        public DbSet<CompanyMovementDetail> CompanyMovementDetails { get; set; }

    }
}
