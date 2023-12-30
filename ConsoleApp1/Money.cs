using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson

{
    public class Money
        {
            private const string _currency = "usd";
            private int _integerPart;
            private int _coinPart;
            public string Currency { get; }
            public int IntegerPart
            {
                get
                {
                    return _integerPart;
                }
                set
                {
                    if (value > 0)
                    {
                        _integerPart = value;
                    }
                }
            }
            public int CoinPart
            {
                get
                {
                    return _coinPart;
                }
                set
                {
                    if (value > 0 && value < 100)
                    {
                        _coinPart = value;
                    }
                }
            }
            public void ShowMoney()
            {
                Console.WriteLine($"You have {_integerPart},{_coinPart} {_currency}");
            }

        }
        public class Product
        {
            public string? ProductName { get; set; }
            public Money? ProductPrice { get; set; }
            public void ShowProductAndPrice()
            {
                Console.WriteLine($"Name product:{ProductName}\nProduct price: {ProductPrice.IntegerPart},{ProductPrice.CoinPart} {ProductPrice.Currency}");
            }
        public Money DiscountProduct(int discountInteger, int discountCion)
        {
            ProductPrice.IntegerPart = discountInteger;
            ProductPrice.CoinPart -= discountCion;
            
            return ProductPrice;
        }
    }        

    }

