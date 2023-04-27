using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class AdisyonOdemeYontemiDetay : IRepository <AdisyonOdemeDetay>
    {
        Marla_Ado1Entities db = new Marla_Ado1Entities();

        public void Delete(int itemId)
        {
            AdisyonOdemeDetay id = db.AdisyonOdemeDetay.Find(itemId);
            db.AdisyonOdemeDetay.Remove(id);
            db.SaveChanges();
        }

        public List<AdisyonOdemeDetay> GetAll()
        {
            return db.AdisyonOdemeDetay.ToList();
        }

        public AdisyonOdemeDetay GetByID(int id)
        {
            return db.AdisyonOdemeDetay.Find(id);
        }

        public void Insert(AdisyonOdemeDetay item)
        {
            db.AdisyonOdemeDetay.Add(item);
            db.SaveChanges();
        }

        public void Update(AdisyonOdemeDetay item)
        {
            AdisyonOdemeDetay gelen = db.AdisyonOdemeDetay.Find(item.AdisyonOdemeDetayID);
            db.Entry(gelen).CurrentValues.SetValues(item);
            db.SaveChanges();
        }
    }
}
