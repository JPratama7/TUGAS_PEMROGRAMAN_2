using System;

namespace P2_1_1204004
{
    class Program
    {
        static void Main(string[] args)
        {
            // Product_1204004 myProduct = new Product_1204004();

            // myProduct.MyType = "DVD";
            
            // Console.WriteLine(myProduct.MyType);


            Book_1204004 mybook = new Book_1204004("Book", "C# Object Oriented Solution", "300");
            DVD_1204004 dvd = new DVD_1204004("Ethernal Sunshine Of The Spotless Mind", "145");
            
            Console.WriteLine("Product 1 is a {0} called \"{1}\" and has {2} pages", mybook.MyType, mybook.MyTitle, mybook.PageCount);
            Console.WriteLine("Product 1 is a {0} called \"{1}\" and has {2} minutes duration", dvd.MyType, dvd.MyTitle, dvd.Duration);
        }
    }
}
