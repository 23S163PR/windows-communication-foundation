using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace transaction_scope_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new OrdersDbEntities())
            {
                TransactionOptions options = new TransactionOptions
                {
                    IsolationLevel = IsolationLevel.ReadUncommitted,
                    Timeout = TimeSpan.FromMinutes(2)
                };

                using (var transaction = new TransactionScope(TransactionScopeOption.Required, options))
                {

                    FillCustomers(context.Customer);
                    context.SaveChanges();

                    FillProducts(context.Product);
                    context.SaveChanges();
                    

                    transaction.Complete();
                }
            }
        }

        private static void FillProducts(DbSet<Product> dbSet)
        {
            const int ProductsCount = 20;
            for (int i = 0; i < ProductsCount; i++)
            {
                dbSet.Add(new Product
                {
                    Name = Faker.Internet.GetDomainWord(),
                    Description = Faker.Company.GetCatchPhrase(),
                    Price = (decimal)Faker.FakerRandom.Rand.NextDouble() * 100 + 1,
                });
            }
        }

        private static void FillCustomers(DbSet<Customer> dbSet)
        {
            const int CustomersCount = 10;
            for (int i = 0; i < CustomersCount; i++)
            {
                var firstName = Faker.Name.GetFirstName();
                var lastName = Faker.Name.GetLastName();
                dbSet.Add(new Customer 
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Email = Faker.Internet.GetEmail(string.Format("{0} {1}", firstName, lastName))
                });
            }
        }
    }
}
