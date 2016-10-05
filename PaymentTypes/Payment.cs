using System;

namespace ConsoleApplication
{

    public class Payment
    {
        public decimal Amount{get;set;}

        public virtual string MakePayment() 
        {
            //TODO hit the payment processing API
            //this needs to be generic since the actual payment API will override this

            return $"You paid ${this.Amount} in cash";
        }
        public string SendConfirmation(string email)
        {
          return "You purchased several nice items";
        }
        public string SendConfirmation(string email, bool digitalDownload)
        {
          return "check your email for the downloadable book";
        }
    }
}