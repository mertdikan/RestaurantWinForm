using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class MalzemeKategoriRepository : IRepository<MalzemeKategori>
    {
        Marla_Ado1Entities db = new Marla_Ado1Entities();
        public void Delete(int itemId)
        {
            MalzemeKategori id = db.MalzemeKategori.Find(itemId);
            db.MalzemeKategori.Remove(id);
            db.SaveChanges();
        }

        public List<MalzemeKategori> GetAll()
        {

            return db.MalzemeKategori.ToList();
        }

        public MalzemeKategori GetByID(int id)
        {
            return db.MalzemeKategori.Find(id);
        }

        public void Insert(MalzemeKategori item)
        {
            db.MalzemeKategori.Add(item);
            db.SaveChanges();
        }

        public void Update(MalzemeKategori item)
        {
            MalzemeKategori gelen = db.MalzemeKategori.Find(item.MalzemeKategoriID);
            db.Entry(gelen).CurrentValues.SetValues(item);
            db.SaveChanges();
        }
    }
}
