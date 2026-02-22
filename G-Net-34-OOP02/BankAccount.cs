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
        #region Question 02
        //Field is a variable that is declared directly in a class or struct. It can be public, private, protected, internal, or protected internal. It can be of any type, including primitive types, reference types, and value types. Fields are used to store data that is associated with an object or class.
        //Property is a member that provides a flexible mechanism to read, write, or compute the value of a private field. Properties can be used as if they are public data members, but they are actually special methods called accessors. The get accessor returns the property value, and the set accessor assigns a new value to the property. Properties can also include validation logic in the set accessor to ensure that the value being assigned is valid.
        // yes Can a property contain logic
        // public string name;  // Field
        // public string Name { get; set; } // Auto-implemented property
        //private int width;
        //private int height;

        //// خاصية لقراءة المساحة (وهي قيمة محسوبة)
        //public int Area
        //{
        //    get
        //    {
        //        return width * height; // المساحة هي الطول × العرض
        //    }
        //}
        #endregion
        #endregion
    }
}
