using RestaurantAPI.Entities;
using System.Collections.Generic;
using System.Linq;

namespace RestaurantAPI
{
    public class RestaurantSeed
    {
        private readonly RestaurantDbContext _dbContext;

        public RestaurantSeed(RestaurantDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Seed()
        {
            if (_dbContext.Database.CanConnect())
            {
                if (!_dbContext.Restaurants.Any())
                {
                    var restaurants = GetRestaurants();
                    _dbContext.Restaurants.AddRange(restaurants);
                }
            }
        }

        private IEnumerable<Restaurant> GetRestaurants()
        {
            
        }
    }
}
