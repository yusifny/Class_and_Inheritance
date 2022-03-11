using System;
using Class_and__Inheritance.Models;

namespace Class_and__Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.productName = "Mars xronikaları";
            book.authorName = "Rey Bredberiv";
            book.pageCount = 288;
            book.discountPercent = 20;
            book.costPrice = 3;
            book.salePrice = 6.99;
            book.getInfo();
            Console.WriteLine($"Cut price:{book.GetDiscountedPrice()}");
        }
    }
}