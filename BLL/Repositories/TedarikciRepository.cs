using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class TedarikciRepository : IRepository<Tedarikci>
    {
        Marla_Ado1Entities db = new Marla_Ado1Entities();
        public void Delete(int itemId)
        {
            Tedarikci id = db.Tedarikci.Find(itemId);
            db.Tedarikci.Remove(id);
            db.SaveChanges();
        }

        public List<Tedarikci> GetAll()
        {

            return db.Tedarikci.ToList();
        }

        public Tedarikci GetByID(int id)
        {
            return db.Tedarikci.Find(id);
        }

        public void Insert(Tedarikci item)
        {
            db.Tedarikci.Add(item);
            db.SaveChanges();
        }

        public void Update(Tedarikci item)
        {
            Tedarikci gelen = db.Tedarikci.Find(item.TedarikciID);
            db.Entry(gelen).CurrentValues.SetValues(item);
            db.SaveChanges();
        }
    }
}
