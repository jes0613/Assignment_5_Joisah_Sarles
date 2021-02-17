using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_4_Josiah_Sarles.Models
{
    public static class TempStorage
    {
        private static List<AddRestaurant> restaurants = new List<AddRestaurant>();

        public static IEnumerable<AddRestaurant> Restaurants => restaurants;

        public static void AddRestaurant(AddRestaurant restaurant)
        {
            restaurants.Add(restaurant);
        }
    }
}
