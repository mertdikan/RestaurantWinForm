using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class AdisyonSiparisDetayRepository : IRepository<AdisyonSiparisDetay>
    {
        Marla_Ado1Entities db = new Marla_Ado1Entities();

        public void Delete(int itemId)
        {
            AdisyonSiparisDetay id = db.AdisyonSiparisDetay.Find(itemId);
            db.AdisyonSiparisDetay.Remove(id);
            db.SaveChanges();
        }

        public List<AdisyonSiparisDetay> GetAll()
        {
            return db.AdisyonSiparisDetay.ToList();
        }

        public AdisyonSiparisDetay GetByID(int id)
        {
            return db.AdisyonSiparisDetay.Find(id);
        }

        public void Insert(AdisyonSiparisDetay item)
        {
            db.AdisyonSiparisDetay.Add(item);
            db.SaveChanges();
        }

        public void Update(AdisyonSiparisDetay item)
        {
            AdisyonSiparisDetay gelen = db.AdisyonSiparisDetay.Find(item.AdisyonSiparisDetayID);
            db.Entry(gelen).CurrentValues.SetValues(item);
            db.SaveChanges();
        }
    }


}
