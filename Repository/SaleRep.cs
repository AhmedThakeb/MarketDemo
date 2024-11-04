using MarketDemo.Context;
using MarketDemo.Contracts;
using MarketDemo.Entities;

namespace MarketDemo.Repository
{
    public class SaleRep : ISaleRep
    {
		private readonly dbcontainer db;

		public SaleRep(dbcontainer db)
        {
			this.db = db;
		}
        public Sales add(Sales Obj)
        {
          db.Sales.Add(Obj);
            db.SaveChanges();
            return Obj;
        }

        public Sales Delete(int id)
        {
            var data = db.Sales.Find(id);
            db.Sales.Remove(data);
            db.SaveChanges();
            return data;
        }

        public Sales Edit(Sales Obj)
        {
            var OldObj = db.Sales.Find(Obj);
            OldObj.Name = Obj.Name;
            db.SaveChanges();
            return OldObj;
        }

        public IEnumerable<Sales> GetAll()
        {
           var data =  db.Sales.Select(S => S);
            return data;
        }

        public Sales GetByID(int id)
        {
           var data = db.Sales.Find(id);
            return data;
        }
    }
}
