using System;
using System.Collections.Generic;

namespace TDD_D2
{
    public class ShoppingCart
    {
        public ShoppingCart()
        {
        }

        internal int calculate(List<Book> books, int v1, int v2, int v3, int v4)
        {
            int result = 0;

            foreach (Book book in books)
            {
                result += book.Price;
            }
            return result;
        }
    }
}