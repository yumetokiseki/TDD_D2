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
                result = CalculateDiscount(discountby2, result);
            }
            else if (books.Count == 3)
            {
                result = CalculateDiscount(discountby3, result);
            }
            else if (books.Count == 4)
            {
                result = CalculateDiscount(discountby4, result);
            }

            else if (books.Count == 5)
            {
                result = CalculateDiscount(discountby5, result);
            }

            return result;
        }

        private static double CalculateDiscount(int discount, double result)
        {
            result = result * (100 - discount) / 100;
            return result;
        }
    }
}