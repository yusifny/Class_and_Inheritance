using System;
using System.Collections.Generic;
using System.Text;

namespace Class_and__Inheritance.Models
{
    internal class Book : Product
    {
        public string authorName;
        public int pageCount;
        public double discountPercent;

        public void getInfo()
        {
            Console.WriteLine($"Author Name:{authorName}\nPage Count:{pageCount}\nDiscount Percent:{discountPercent}\nProduct Name:{productName}\nCost Price:{costPrice}\nSale Price: {salePrice}");
        }


        public double GetDiscountedPrice()
        {
            return (salePrice - ((salePrice * discountPercent) / 100));
        }

    }
}