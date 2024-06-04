using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Program
    {
        static void Main()
        { }
         class CreditCard
        {
            private string cardNumber;
            private string cardholderName;
            private string cvc;
            private DateTime expirationDate;

            public CreditCard(string cardNumber, string cardholderName, string cvc, DateTime expirationDate)
            {
                if (!IsValidCardNumber(cardNumber))
                {
                    throw new ArgumentException("Wrong number of the card");
                }

                if (string.IsNullOrWhiteSpace(cardholderName))
                {
                    throw new ArgumentException("FIO of holder can't be empty");
                }

                if (cvc.Length != 3)
                {
                    throw new ArgumentException("Wrong CVC code");
                }
                this.cardNumber = cardNumber;
                this.cardholderName = cardholderName;
                this.cvc = cvc;
                this.expirationDate = expirationDate;
            }
            private bool IsValidCardNumber(string cardNumber)
            {
                return true;
            }
        }
    }
           
        }
    


