using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Web;

namespace MyStore.domainDB.Entities
{
    public class Cart
    {
        private List<CartLine> lineCollection = new List<CartLine>();

        //add item in cart
        public void AddItem(Product product, int quantity)
        {
            CartLine line = lineCollection
                .Where(p => p.Product.ProductId == product.ProductId)
                .FirstOrDefault();

            if (line == null)
            {
                lineCollection.Add(new CartLine {Product = product, Quantity = quantity});
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        //remove item from cart
        public void RemoveLine(Product product)
        {
            lineCollection.RemoveAll(l => l.Product.ProductId == product.ProductId);
        }


        //calculate total value
        public decimal ComputeTotalValue()
        {
            return lineCollection.Sum(e => e.Product.Price * e.Quantity);
        }


        //clear the cart
        public void Clear()
        {
            lineCollection.Clear();
        }



        public IEnumerable<CartLine> Lines
        {
            get { return lineCollection; }
        }

    }
}