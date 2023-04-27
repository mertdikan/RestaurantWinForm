using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class OdemeYontemiRepository : IRepository<OdemeYontemi>
    {
        Marla_Ado1Entities db = new Marla_Ado1Entities();
        public void Delete(int itemId)
        {
            OdemeYontemi id = db.OdemeYontemi.Find(itemId);
            db.OdemeYontemi.Remove(id);
            db.SaveChanges();
        }

        public List<OdemeYontemi> GetAll()
        {
            return db.OdemeYontemi.ToList();
        }

        public OdemeYontemi GetByID(int id)
        {
            return db.OdemeYontemi.Find(id);
        }

        public void Insert(OdemeYontemi item)
        {
            db.OdemeYontemi.Add(item);
            db.SaveChanges();
        }

        public void Update(OdemeYontemi item)
        {
            OdemeYontemi gelen = db.OdemeYontemi.Find(item.OdemeYontemiID);
            db.Entry(gelen).CurrentValues.SetValues(item);
            db.SaveChanges();
        }
    }
}
