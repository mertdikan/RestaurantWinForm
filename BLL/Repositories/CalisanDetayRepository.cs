using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class CalisanDetayRepository : IRepository<CalisanDetay>
    {
        Marla_Ado1Entities db = new Marla_Ado1Entities();
        public void Delete(int itemId)
        {
            CalisanDetay id = db.CalisanDetay.Find(itemId);
            db.CalisanDetay.Remove(id);
            db.SaveChanges();
        }

        public List<CalisanDetay> GetAll()
        {
            return db.CalisanDetay.ToList();
        }

        public CalisanDetay GetByID(int id)
        {
            return db.CalisanDetay.Find(id);
        }

        public void Insert(CalisanDetay item)
        {
            db.CalisanDetay.Add(item);
            db.SaveChanges();
        }

        public void Update(CalisanDetay item)
        {
            CalisanDetay gelen = db.CalisanDetay.Find(item.CalisanDetayID);
            db.Entry(gelen).CurrentValues.SetValues(item);
            db.SaveChanges();
        }
    }
}
