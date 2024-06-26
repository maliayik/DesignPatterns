﻿using DesignPattern.Facade.DAL;

namespace DesignPattern.Facade.FacadePattern
{
    public class ProductStock
    {
        Context context = new Context();

        public void DecreaseStock(int id,int amount)
        {
            var product = context.Products.Find(id);
            product.ProductStock -= amount;
            context.SaveChanges();
        }
    }
}
