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
        #region Question 03 
        #region A

        //this[int index] The class can be used as if it were an array or a list. The elements within the class can be accessed using indexes, making it more flexible and easier to use.
        //The `this[int index]` pointer is used to access and modify the elements of an array `names`. The pointer specifies a method for accessing values ​​within the array by providing `get` (to retrieve the value) and `set` (to assign the value).
        #endregion
        #region B
        // register[10] = "Ali" It will attempt to assign the value "Ali" to index 10 in the names array.
        // However, the array only contains 5 elements (from index 0 to 4), therefore an IndexOutOfRangeException will occur because index 10 is outside the range of the array.
        // You can add a validation within the `set` property to ensure that the index is within the range of the array. For example:
        //public string this[int index]
        //{
        //    get { return names[index]; }
        //    set
        //    {
        //        if (index >= 0 && index < names.Length)
        //        {
        //            names[index] = value;
        //        }
        //        else
        //        {
        //            Console.WriteLine("الفهرس خارج النطاق!");
        //        }
        //    }
        //}
        #endregion
        #region C
        // yes This is useful when you need to work with different types of data or index formats within the same class. For example, if you have a class containing multi-category data, you can use multiple pointers to access that data.
        //public class StudentRegister
        //{
        //    private string[] names = new string[5];
        //    private int[] ages = new int[5];

        //    public string this[int index]
        //    {
        //        get { return names[index]; }
        //        set { names[index] = value; }
        //    }

        //    public int this[string name]
        //    {
        //        get
        //        {
        //            int index = Array.IndexOf(names, name);
        //            return (index > 0) ? ages[index] : 0; 
        //        }
        //        set
        //        {
        //            int index = Array.IndexOf(names, name);
        //            if (index >= 0)
        //            {
        //                ages[index] = value;
        //            }
        //        }
        //    }
        //}
        #endregion
        #endregion
        #endregion
    }
}
