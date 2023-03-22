namespace TaxiManager.Web.Controllers
{
    using System;
    using System.Security.Claims;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using TaxiManager.Data.Models;
    using TaxiManager.Services.Data;
    using TaxiManager.Services.Data.Interfaces;
    using TaxiManager.Web.ViewModels.Orders;

    public class OrdersController : BaseController
    {
        private readonly IOrdersService ordersService;

        public OrdersController(IOrdersService ordersService)
        {
            this.ordersService = ordersService;
        }

        [Authorize]
        public IActionResult New()
        {
            if (this.User.IsInRole("Taxi"))
            {
                return this.Redirect("/");
            }

            return this.View();
        }

        [HttpPost]
        [Authorize]
        public IActionResult New(OrderAddViewModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }

            if (this.User.IsInRole("Taxi"))
            {
                return this.Redirect("/");
            }

            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

            input.UserId = userId;

            this.ordersService.New(input);

            return this.Redirect("/");
        }
    }
}
