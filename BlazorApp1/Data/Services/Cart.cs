using System;
using System.Collections.Generic;
using BlazorApp1.Data.Models;

namespace BlazorApp1.Data.Services
{
    public static class Cart
    {
        public static Dictionary<int, CartModel> cart = new Dictionary<int, CartModel>();
    }
}
