using MarketDemo.Entities;

namespace MarketDemo.Contracts
{
    public interface IInvoiceRep
    {
        IEnumerable<Invoices> GetAll();
        Invoices GetById(int id);
        Invoices AddObj(Invoices Obj);
        Invoices EditObj(Invoices Obj);
        Invoices DeleteObj(int id);
    }
}
