using System;
using System.Collections.Generic;
using System.Linq;

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
            var booklist = new List<string>();
            Dictionary<Book, int> dictionary = new Dictionary<Book, int>();

            dictionary = InsertDictionary(books, booklist, dictionary);

            if (books.Count == 1)
            {
                result = CalculateDiscount(books, 0);
            }

            else if (books.Count == 2)
            {
                result = CalculateDiscount(books, discountby2);
            }
            else if (books.Count == 3)
            {
                result = CalculateDiscount(books, discountby3);
            }
            else if (books.Count == 4)
            {
                if (dictionary.Count == books.Count)
                {
                    result = CalculateDiscount(books, discountby4);
                }
                else
                {
                    result = CalculateDiscountOther(dictionary, discountby2, discountby3, discountby4, discountby5);
                }
            }

            else if (books.Count == 5)
            {
                if (dictionary.Count == books.Count)
                {
                    result = CalculateDiscount(books, discountby5);
                }
                else
                {
                    result = CalculateDiscountOther(dictionary, discountby2, discountby3, discountby4, discountby5);
                }
            }

            return result;
        }

        private static Dictionary<Book, int> InsertDictionary(List<Book> books, List<string> booklist, Dictionary<Book, int> dictionary)
        {
            foreach (Book book in books)
            {
                if (dictionary.Count == 0)
                {
                    dictionary.Add(book, 1);
                }
                else
                {
                    var dictionarytemp = new Dictionary<Book, int>(dictionary);
                    foreach (Book dictionaryitem in dictionary.Keys)
                    {
                        int value = -1;
                        dictionarytemp.TryGetValue(book, out value);
                        if (dictionaryitem.Name == book.Name)
                        {
                            dictionarytemp[dictionaryitem] = dictionarytemp[dictionaryitem] + 1;
                        }
                        else if (value == 0 && (booklist.Find(x => x.Contains(book.Name)) == null))
                        {
                            dictionarytemp.Add(book, 1);
                            booklist.Add(book.Name);
                        }
                    }

                    dictionary = dictionarytemp;

                }
            }

            return dictionary;
        }

        private double CalculateDiscountOther( Dictionary<Book, int> dictionary, int discountby2, int discountby3, int discountby4, int discountby5)
        {
            double result = 0;

            while (dictionary.Count > 0)
            {
                if (dictionary.Count == 1)
                {
                    result = result + dictionary.First().Key.Price;
                    break;
                }
                else if (dictionary.Count == 2)
                {
                    var priceby2book = 0;
                    var dictionarytemp = new Dictionary<Book, int>(dictionary);
                    foreach (var item in dictionarytemp)
                    {
                        priceby2book = priceby2book + item.Key.Price;

                        if (item.Value == 1)
                        {
                            dictionary.Remove(item.Key);
                        }
                        else
                        {
                            dictionary[item.Key] = item.Value - 1;
                        }
                    }

                    priceby2book = priceby2book * (100 - discountby2) / 100 ;

                    result = result + priceby2book;
                }
                else if (dictionary.Count == 3)
                {
                    var priceby3book = 0;
                    var dictionarytemp = new Dictionary<Book, int>(dictionary);
                    foreach (var item in dictionarytemp)
                    {
                        priceby3book = priceby3book + item.Key.Price;

                        if (item.Value == 1)
                        {
                            dictionary.Remove(item.Key);
                        }
                        else
                        {
                            dictionary[item.Key] = item.Value - 1;
                        }
                    }

                    priceby3book = priceby3book * (100 - discountby3) / 100;

                    result = result + priceby3book;
                }
                else if (dictionary.Count == 4)
                {
                    var priceby4book = 0;
                    var dictionarytemp = new Dictionary<Book, int>(dictionary);
                    foreach (var item in dictionarytemp)
                    {
                        priceby4book = priceby4book + item.Key.Price;

                        if (item.Value == 1)
                        {
                            dictionary.Remove(item.Key);
                        }
                        else
                        {
                            dictionary[item.Key] = item.Value - 1;
                        }

                    }

                    priceby4book = priceby4book * (100 - discountby4) / 100 ;

                    result = result + priceby4book;
                }
                else if (dictionary.Count == 5)
                {
                    var priceby5book = 0;
                    var dictionarytemp = new Dictionary<Book, int>(dictionary);
                    foreach (var item in dictionarytemp)
                    {
                        priceby5book = priceby5book + item.Key.Price;

                        if (item.Value == 1)
                        {
                            dictionary.Remove(item.Key);
                        }
                        else
                        {
                            dictionary[item.Key] = item.Value - 1;
                        }
                    }

                    priceby5book = priceby5book * (100 - discountby5) / 100 ;

                    result = result + priceby5book;
                }
            }

            return result;
        }

        private static double CalculateDiscount(List<Book> books, int discount)
        {
            double result = 0;

            foreach (Book book in books)
            {
                result += (book.Price) *(100 - discount) / 100;
            }

            return result;
        }
    }
}