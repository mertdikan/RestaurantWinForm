using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class UrunSiparisDetayRepository : IRepository<UrunSiparisDetay>
    {
        Marla_Ado1Entities db = new Marla_Ado1Entities();

        public List<UrunSiparisDetay> GetAll()
        {
            return db.UrunSiparisDetay.ToList();
        }

        public UrunSiparisDetay GetByID(int id)
        {
            return db.UrunSiparisDetay.Find(id);
        }

        public void Insert(UrunSiparisDetay item)
        {
            db.UrunSiparisDetay.Add(item);
            db.SaveChanges();
        }

        public void Update(UrunSiparisDetay item)
        {
            UrunSiparisDetay gelen = db.UrunSiparisDetay.Find(item.UrunSiparisDetayID);
            db.Entry(gelen).CurrentValues.SetValues(item);
            db.SaveChanges();
        }

        public void Delete(int itemId)
        {
            UrunSiparisDetay id = db.UrunSiparisDetay.Find(itemId);
            db.UrunSiparisDetay.Remove(id);
            db.SaveChanges();
        }
    }
}
