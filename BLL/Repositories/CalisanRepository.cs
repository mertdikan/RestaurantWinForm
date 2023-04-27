using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class CalisanRepository:IRepository<Calisan>
    {
        Marla_Ado1Entities db = new Marla_Ado1Entities();


        public void Delete(int itemId)
        {
            Calisan id = db.Calisan.Find(itemId);
            db.Calisan.Remove(id);
            db.SaveChanges();
        }

        public List<Calisan> GetAll()
        {
            return db.Calisan.ToList();
        }

        public Calisan GetByID(int id)
        {
            return db.Calisan.Find(id);
        }

        public void Insert(Calisan item)
        {
            db.Calisan.Add(item);
            db.SaveChanges();
        }

        public void Update(Calisan item)
        {
            Calisan gelen = db.Calisan.Find(item.CalisanID);
            db.Entry(gelen).CurrentValues.SetValues(item);
            db.SaveChanges();
        }
    }
}
