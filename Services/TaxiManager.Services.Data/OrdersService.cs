namespace TaxiManager.Services.Data
{
    using System;

    using TaxiManager.Data;
    using TaxiManager.Data.Models;
    using TaxiManager.Services.Data.Interfaces;
    using TaxiManager.Web.ViewModels.Orders;

    public class OrdersService : IOrdersService
    {
        private readonly ApplicationDbContext dbContext;

        public OrdersService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Accept(string id)
        {
            throw new System.NotImplementedException();
        }

        public void Decline(string id)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(string id)
        {
            throw new System.NotImplementedException();
        }

        public void New(OrderAddViewModel input)
        {
            Order order = new Order
            {
                Accepted = false,
                CreatedOn = DateTime.Now,
                Location = input.Location,
                Destination = input.Destination,
                Kilometers = input.Kilometers,
                Price = input.Price != null ? input.Price : 0,
                UserId = input.UserId,
            };

            this.dbContext.Orders.Add(order);
            this.dbContext.SaveChanges();
        }
    }
}
