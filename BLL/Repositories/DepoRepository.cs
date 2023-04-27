using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class DepoRepository : IRepository<Depo>
    {
        Marla_Ado1Entities db = new Marla_Ado1Entities();
        public void Delete(int itemId)
        {
            Depo id = db.Depo.Find(itemId);
            db.Depo.Remove(id);
            db.SaveChanges();
        }

        public List<Depo> GetAll()
        {
            return db.Depo.ToList();
        }

        public Depo GetByID(int id)
        {
            return db.Depo.Find(id);
        }

        public void Insert(Depo item)
        {
            db.Depo.Add(item);
            db.SaveChanges();
        }

        public void Update(Depo item)
        {
            Depo gelen = db.Depo.Find(item.DepoID);
            db.Entry(gelen).CurrentValues.SetValues(item);
            db.SaveChanges();
        }
    }
}
