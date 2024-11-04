using MarketDemo.Entities;

namespace MarketDemo.Contracts
{
    public interface IItemRep
    {
        IEnumerable<Items> GetAll();
        Items GetById(int id);
        Items Add(Items Obj);
        Items Edit(Items Obj);
        Items Delete(int id);
    }
}
