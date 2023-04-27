using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class MusteriRepository : IRepository<Musteri>
    {
        Marla_Ado1Entities db = new Marla_Ado1Entities();
        public void Delete(int itemId)
        {
            Musteri id = db.Musteri.Find(itemId);
            db.Musteri.Remove(id);
            db.SaveChanges();
        }

        public List<Musteri> GetAll()
        {
            return db.Musteri.ToList();
        }

        public Musteri GetByID(int id)
        {
            return db.Musteri.Find(id);

        }

        public void Insert(Musteri item)
        {
            db.Musteri.Add(item);
            db.SaveChanges();
        }

        public void Update(Musteri item)
        {
            Musteri gelen = db.Musteri.Find(item.MusteriID);
            db.Entry(gelen).CurrentValues.SetValues(item);
            db.SaveChanges();
        }
    }
}
