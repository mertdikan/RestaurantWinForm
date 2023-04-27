using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class RestaurantRepository : IRepository<Restaurant>
    {
        Marla_Ado1Entities db = new Marla_Ado1Entities();
        public void Delete(int itemId)
        {
            Restaurant id = db.Restaurant.Find(itemId);
            db.Restaurant.Remove(id);
            db.SaveChanges();
        }

        public List<Restaurant> GetAll()
        {
            return db.Restaurant.ToList();
        }

        public Restaurant GetByID(int id)
        {
            return db.Restaurant.Find(id);
        }

        public void Insert(Restaurant item)
        {
            db.Restaurant.Add(item);
            db.SaveChanges();
        }

        public void Update(Restaurant item)
        {
            Restaurant gelen = db.Restaurant.Find(item.RestaurantID);
            db.Entry(gelen).CurrentValues.SetValues(item);
            db.SaveChanges();
        }
    }
}
