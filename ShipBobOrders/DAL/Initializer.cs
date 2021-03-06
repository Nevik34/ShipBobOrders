﻿using ShipBobOrders.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShipBobOrders.DAL
{
    public class Initializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ShipBobContext>
    {
        protected override void Seed(ShipBobContext context)
        {
            var users = new List<User>
            {
                new User{FirstName = "Kevin", LastName="Kelley"},
                new User{FirstName = "Ned", LastName="Stark"},
                new User{FirstName = "John", LastName="Smith"},
            };
            users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();

            var orders = new List<Order>
            {
                new Order{UserID=1, TrackingID="ABCDEF", City="Chicago", State="IL", Zip="60606"},
                new Order{UserID=1, TrackingID="GHIJKL", City="Chicago", State="IL", Zip="60618"},
                new Order{UserID=2, TrackingID="123456", City="Austin", State="TX", Zip="12345"},
                new Order{UserID=3, TrackingID="TRACKME", City="Chicago", State="IL", Zip="60618"},
            };
            orders.ForEach(s => context.Orders.Add(s));
            context.SaveChanges();
        }
    }
}