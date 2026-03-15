using System.ComponentModel;
using System.Numerics;
using System.Reflection.Metadata;
using System.Security.Claims;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AdvancedC_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
        #region question1
        //1 What is a Generic Class?
        //A generic class is a class that is defined with a type parameter instead of a specific data type.
        //This means the class can work with different data types while keeping the same code.

        //  2 Why Do We Use Generics ?
        //1.Code Reusability:
        // The same class works with many data types.
        //No need to write separate classes for int, string, double, etc.

        // 2.Type Safety
        //Generics ensure that the correct data type is used.
        // Errors are caught at compile time, not runtime.

        //3.No Casting Required
        //Without generics(using object) you must cast the value.

        // 4.Better Performance
        //Avoids boxing and unboxing when working with value types like int, double, etc.

        #endregion
        #region question2
        //Q2: Write a generic class Container<T> with Add and Get methods:
        //    public class Container<T>
        //{
        //    private T item;

        //    public void Add(T value)
        //    {
        //        item = value;
        //    }

        //    public T Get()
        //    {
        //        return item;
        //    }
        //}
        #endregion
    }
    }
}
