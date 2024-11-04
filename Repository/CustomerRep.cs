using MarketDemo.Context;
using MarketDemo.Contracts;
using MarketDemo.Entities;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace MarketDemo.Repository
{
    public class CustomerRep : ICustomerRep
    {
		private readonly dbcontainer db;

		public CustomerRep(dbcontainer db)
        {
			this.db = db;
		}
        public Customers AddObj(Customers Obj)
        {
           var data = db.Customers.Add(Obj);
            db.SaveChanges();
            return Obj;
        }

        public Customers DeleteObj(int id)
        {
           var OldObj = db.Customers.Find(id);
            db.Customers.Remove(OldObj);
            db.SaveChanges();
            return OldObj;

        }

        public Customers EditObj(Customers Obj)
        { 
            var OldObj = db.Customers.Find(Obj);
            OldObj.Name = Obj.Name;
            db.SaveChanges();
            return Obj;

        }

        public IEnumerable<Customers> GetAll()
        {
            var data = db.Customers.Select(C => C);
            return data;
        }

        public Customers GetById(int id)
        {
           var data = db.Customers.Find(id);
            return data;
        }
    }
}
