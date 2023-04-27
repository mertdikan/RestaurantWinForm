using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class MalzemeRepository : IRepository<Malzeme>
    {
        Marla_Ado1Entities db = new Marla_Ado1Entities();

        public void Delete(int itemId)
        {
            Malzeme id = db.Malzeme.Find(itemId);
            db.Malzeme.Remove(id);
            db.SaveChanges();
        }

        public List<Malzeme> GetAll()
        {
            return db.Malzeme.ToList();
        }

        public Malzeme GetByID(int id)
        {
            return db.Malzeme.Find(id);
        }

        public void Insert(Malzeme item)
        {
            db.Malzeme.Add(item);
            db.SaveChanges();
        }

        public void Update(Malzeme item)
        {
            Malzeme gelen = db.Malzeme.Find(item.MalzemeID);
            db.Entry(gelen).CurrentValues.SetValues(item);
            db.SaveChanges();
        }
    }
}
