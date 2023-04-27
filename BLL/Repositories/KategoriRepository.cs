using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class KategoriRepository : IRepository<MenuKategori>
    {
        Marla_Ado1Entities db = new Marla_Ado1Entities();
        public void Delete(int itemId)
        {
            MenuKategori id = db.MenuKategori.Find(itemId);
            db.MenuKategori.Remove(id);
            db.SaveChanges();
        }

        public List<MenuKategori> GetAll()
        {
            return db.MenuKategori.ToList();
        }

        public MenuKategori GetByID(int id)
        {
            return db.MenuKategori.Find(id);
        }

        public void Insert(MenuKategori item)
        {
            db.MenuKategori.Add(item);
            db.SaveChanges();
        }

        public void Update(MenuKategori item)
        {
            MenuKategori gelen = db.MenuKategori.Find(item.MenuKategoriID);
            db.Entry(gelen).CurrentValues.SetValues(item);
            db.SaveChanges();
        }
    }
}
