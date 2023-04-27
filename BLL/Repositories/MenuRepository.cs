
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class MenuRepository : IRepository<Menu>
    {
        Marla_Ado1Entities db = new Marla_Ado1Entities();
        public void Delete(int itemId)
        {
            Menu id = db.Menu.Find(itemId);
            db.Menu.Remove(id);
            db.SaveChanges();
        }

        public List<Menu> GetAll()
        {
            return db.Menu.ToList();
        }

        public Menu GetByID(int id)
        {
            return db.Menu.Find(id);
        }

        public void Insert(Menu item)
        {
            db.Menu.Add(item);
            db.SaveChanges();
        }

        public void Update(Menu item)
        {
            Menu gelen = db.Menu.Find(item.MenuID);
            db.Entry(gelen).CurrentValues.SetValues(item);
            db.SaveChanges();
        }
    }
}
