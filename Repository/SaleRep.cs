using MarketDemo.Context;
using MarketDemo.Entities;

namespace MarketDemo.Repository
{
    public class SaleRep : ISaleRep
    {
        dbcontainer db = new dbcontainer ();
        public Sales add(Sales Obj)
        {
          db.Sale.Add(Obj);
            db.SaveChanges();
            return Obj;
        }

        public Sales Delete(int id)
        {
            var data = db.Sale.Find(id);
            db.Sale.Remove(data);
            db.SaveChanges();
            return data;
        }

        public Sales Edit(Sales Obj)
        {
            var OldObj = db.Sale.Find(Obj);
            OldObj.Name = Obj.Name;
            db.SaveChanges();
            return OldObj;
        }

        public IEnumerable<Sales> GetAll()
        {
           var data =  db.Sale.Select(S => S);
            return data;
        }

        public Sales GetByID(int id)
        {
           var data = db.Sale.Find(id);
            return data;
        }
    }
}
