﻿namespace TaxiManager.Data.Models
{
    using System;

    using TaxiManager.Data.Common.Models;

    public class Order : BaseDeletableModel<string>
    {
        public Order()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public ApplicationUser User { get; set; }

        public string UserId { get; set; }

        public ApplicationUser Taxi { get; set; }

        public string TaxiId { get; set; }

        public bool Accepted { get; set; } // if false - delete?

        public string Location { get; set; }

        public string Destination { get; set; }

        public double Kilometers { get; set; }

        public double? Price { get; set; }
    }
}
