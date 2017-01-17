using System;
using System.Collections.Generic;

namespace TDD_D2
{
    public class ShoppingCart
    {
        public ShoppingCart()
        {
        }

        internal double calculate(List<Book> books, int discountby2, int discountby3, int discountby4, int discountby5)
        {
            double result = 0;

            foreach (Book book in books)
            {
                result += book.Price;
            }

            if (books.Count == 2)
            {
                result = result * (100 - discountby2) / 100;
            }
            else if (books.Count == 3)
            {
                result = result * (100 - discountby3) / 100;
            }

            return result;
        }
    }
}