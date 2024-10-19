﻿using MarketDemo.Entities;

namespace MarketDemo.Repository
{
    public interface ISaleRep
    {
        IEnumerable<Sales> GetAll();
        Sales GetByID(int id);
        Sales add(Sales Obj);
        Sales Edit(Sales Obj);
        Sales Delete(int id);
    }
}