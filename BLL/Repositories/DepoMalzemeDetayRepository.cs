using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class DepoMalzemeDetayRepository : IRepository<DepoMalzemeDetay>
    {
        Marla_Ado1Entities db = new Marla_Ado1Entities();
        public void Delete(int itemId)
        {
            DepoMalzemeDetay id = db.DepoMalzemeDetay.Find(itemId);
            db.DepoMalzemeDetay.Remove(id);
            db.SaveChanges();
        }

        public List<DepoMalzemeDetay> GetAll()
        {
            return db.DepoMalzemeDetay.ToList();
        }

        public DepoMalzemeDetay GetByID(int id)
        {
            return db.DepoMalzemeDetay.Find(id);
        }

        public void Insert(DepoMalzemeDetay item)
        {
            db.DepoMalzemeDetay.Add(item);
            db.SaveChanges();
        }

        public void Update(DepoMalzemeDetay item)
        {
            DepoMalzemeDetay gelen = db.DepoMalzemeDetay.Find(item.DepoMalzemeID);
            db.Entry(gelen).CurrentValues.SetValues(item);
            db.SaveChanges();
        }
    }
}
