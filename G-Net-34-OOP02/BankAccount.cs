using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_34_OOP02
{
    internal class BankAccount
    {
        #region Part 01
        #region Question 01 
        #region A
        //public string Owner;
        //public decimal Balance; this not good because it can be changed by anyone and can not validate the value 
        //public void Withdraw(decimal amount)
        //{
        //    Balance -= amount;
        //}
        #endregion
        #region B
        // private string owner{ get; set; }
        // private decimal balance { get; set; }
        //public double Balance
        //{
        //    get { return balance; }
        //    set
        //    {
        //        if (value < 0)
        //            Console.WriteLine("الرصيد لا يمكن أن يكون سالبًا");
        //        else
        //            balance = value;
        //    }
        //}
        #endregion
        #region C
        //It's a bad habit because I can't control the data.
        //I can add or modify an illogical value, such as changing the balance to negative, but I cannot add a verification.
        //Developing the code in the future will be very difficult because it will require modification everywhere you use it.
        #endregion
        #endregion
        #endregion
    }
}
