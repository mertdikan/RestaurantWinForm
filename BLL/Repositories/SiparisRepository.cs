using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class SiparisRepository : IRepository<Siparis>
    {
        Marla_Ado1Entities db = new Marla_Ado1Entities();
        public void Delete(int itemId)
        {
            Siparis id = db.Siparis.Find(itemId);
            db.Siparis.Remove(id);
            db.SaveChanges();
        }

        public List<Siparis> GetAll()
        {

            return db.Siparis.ToList();
        }

        public Siparis GetByID(int id)
        {
            return db.Siparis.Find(id);
        }

        public void Insert(Siparis item)
        {
            db.Siparis.Add(item);
            db.SaveChanges();
        }

        public void Update(Siparis item)
        {
            Siparis gelen = db.Siparis.Find(item.SiparisID);
            db.Entry(gelen).CurrentValues.SetValues(item);
            db.SaveChanges();
        }
    }
}
