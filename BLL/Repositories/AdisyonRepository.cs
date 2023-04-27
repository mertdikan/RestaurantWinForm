using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class AdisyonRepository : IRepository<Adisyon>
    {
        Marla_Ado1Entities db = new Marla_Ado1Entities();
        public void Delete(int itemId)
        {
            Adisyon id = db.Adisyon.Find(itemId);
            db.Adisyon.Remove(id);
            db.SaveChanges();
        }

        public List<Adisyon> GetAll()
        {
            return db.Adisyon.ToList();
        }

        public Adisyon GetByID(int id)
        {
            return db.Adisyon.Find(id);
        }

        public void Insert(Adisyon item)
        {
            db.Adisyon.Add(item);
            db.SaveChanges();
        }

        public void Update(Adisyon item)
        {
            Adisyon gelen = db.Adisyon.Find(item.AdisyonID);
            db.Entry(gelen).CurrentValues.SetValues(item);
            db.SaveChanges();
        }
    }
}
