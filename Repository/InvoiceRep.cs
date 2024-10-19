using MarketDemo.Context;
using MarketDemo.Entities;

namespace MarketDemo.Repository
{
    public class InvoiceRep : IInvoiceRep
    {
        dbcontainer db = new dbcontainer();
        public Invoices AddObj(Invoices Obj)
        {
            db.Invoice.Add(Obj);
            db.SaveChanges();
            return Obj;
        }

        public Invoices DeleteObj(int id)
        {
            var OldObj = db.Invoice.Find(id);
            db.Invoice.Remove(OldObj);
            db.SaveChanges();
            return OldObj;
        }

        public Invoices EditObj(Invoices Obj)
        {
            var OldObj = db.Invoice.Find(Obj);
            OldObj.Name = Obj.Name;
            db.SaveChanges();
            return Obj;

        }

        public IEnumerable<Invoices> GetAll()
        {
           
            var data = db.Invoice.Select(d => d);
            return data;
        }

        public Invoices GetById(int id)
        {
           var data = db.Invoice.Find(id);
            return data;
        }
    }
}
