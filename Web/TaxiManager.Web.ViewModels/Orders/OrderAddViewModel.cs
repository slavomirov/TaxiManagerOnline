namespace TaxiManager.Web.ViewModels.Orders
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class OrderAddViewModel
    {
        public string UserId { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        public string Destination { get; set; }

        [Required]
        public double Kilometers { get; set; }

        public double Price { get; set; }
    }
}
