using MarketDemo.Context;
using MarketDemo.Contracts;
using MarketDemo.Entities;

namespace MarketDemo.Repository
{
    public class InvoiceRep : IInvoiceRep
    {
		private readonly dbcontainer db;

		public InvoiceRep(dbcontainer db)
        {
			this.db = db;
		}
        public Invoices AddObj(Invoices Obj)
        {
            db.Invoices.Add(Obj);
            db.SaveChanges();
            return Obj;
        }

        public Invoices DeleteObj(int id)
        {
            var OldObj = db.Invoices.Find(id);
            db.Invoices.Remove(OldObj);
            db.SaveChanges();
            return OldObj;
        }

        public Invoices EditObj(Invoices Obj)
        {
            var OldObj = db.Invoices.Find(Obj);
            OldObj.Name = Obj.Name;
            db.SaveChanges();
            return Obj;

        }

        public IEnumerable<Invoices> GetAll()
        {
           
            var data = db.Invoices.Select(d => d);
            return data;
        }

        public Invoices GetById(int id)
        {
           var data = db.Invoices.Find(id);
            return data;
        }
    }
}
