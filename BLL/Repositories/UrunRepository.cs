using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class UrunRepository :IRepository<Urun>
    {
        Marla_Ado1Entities db = new Marla_Ado1Entities();

        public void Delete(int itemId)
        {
            Urun id = db.Urun.Find(itemId);
            db.Urun.Remove(id);
            db.SaveChanges();
        }

        public List<Urun> GetAll()
        {
            return db.Urun.ToList();
        }

        public Urun GetByID(int id)
        {
            return db.Urun.Find(id);
        }

        public void Insert(Urun item)
        {
            db.Urun.Add(item);
            db.SaveChanges();
        }

        public void Update(Urun item)
        {
            Urun gelen = db.Urun.Find(item.UrunID);
            db.Entry(gelen).CurrentValues.SetValues(item);
            db.SaveChanges();
        }
    }
}
