using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Numerics;
using System.Reflection.Metadata;
using System.Security.Claims;
using System.Security.Cryptography;
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
        #region question3
        //Q3: What are Multiple Type Parameters ?
        //  Multiple type parameters mean that a generic class or method uses more than one type parameter.
        //   Each parameter represents a different data type that will be specified when the class is used.

        //    Example: Pair<TKey, TValue>:
        //    public class Pair<TKey, TValue>
        //{
        //    public TKey Key { get; set; }
        //    public TValue Value { get; set; }

        //    public Pair(TKey key, TValue value)
        //    {
        //        Key = key;
        //        Value = value;
        //    }

        //    public TKey GetKey()
        //    {
        //        return Key;
        //    }

        //    public TValue GetValue()
        //    {
        //        return Value;
        //    }
        //}
        #endregion
        #region question4
        // Q4: What is a Generic Method?

        //A generic method is a method that uses type parameters(such as < T >)
        //so it can work with different data types without rewriting the method for each type.

        //  Example: Swap < T > Method
        // public static void Swap<T>(ref T a, ref T b)
        //   {
        //    T temp = a;
        //    a = b;
        //   b b = temp;
        //   }
        #endregion
        #region question5
        //Q5: Write a Generic Method FindMax<T> that Finds the Maximum Value:
        //        public static T FindMax<T>(T a, T b) where T : IComparable<T>
        //{
        //    if (a.CompareTo(b) > 0)
        //        return a;
        //    else
        //        return b;
        //}

        #endregion
        #region question6
        //Q6: What is a Generic Interface?

        //  A generic interface is an interface that uses type parameters(like<T>) so it can work with different data types.
        //  It defines methods that operate on a generic type, and the actual type is specified when a class implements the interface.
        //  This makes the interface reusable and type-safe.

        //Example: IRepository<T>:
        //        public interface IRepository<T>
        //{
        //    void Add(T item);
        //    T Get(int id);
        //}
        #endregion
        #region question7
        // What is the struct Constraint?
        //The struct constraint in generics is used to restrict the type parameter so that it must be a value type(a structure).

        //Example:

        //    public class ValueContainer<T> where T : struct
        //{
        //    public T Value;

        //    public ValueContainer(T value)
        //    {
        //        Value = value;
        //    }

        //    public T GetValue()
        //    {
        //        return Value;
        //    }
        //}
        #endregion
        #region question8
        //Q8: What is the class Constraint?
        //The class constraint in generics restricts the type parameter so that it must be a reference type.

        //Example:
        //    public class ReferenceContainer<T> where T : class
        //{
        //    public T Item;

        //    public ReferenceContainer(T item)
        //    {
        //        Item = item;
        //    }

        //    public T GetItem()
        //    {
        //        return Item;
        //    }
        //}
        #endregion
        #region question9
        // Q9: What is the new() Constraint?

        //The new() constraint in generics requires that the type parameter must have a public parameterless constructor

        //     example:
        //     public class Creator<T> where T : new()
        // {
        //     public T CreateObject()
        //     {
        //         return new T();
        //     }
        // }
        #endregion
        #region question10
        //Q10: What is the Interface Constraint?
        //The interface constraint in generics restricts the type parameter so that it must implement a specific interface.

        //Example:
        //    Suppose we have an interface IPrintable :
        //    public interface IPrintable
        //{
        //    void Print();
        //}

        //public class Printer<T> where T : IPrintable
        //{
        //    public void PrintItem(T item)
        //    {
        //        item.Print();  
        //    }
        //}
        #endregion
        #region question11
        //Q11: What is the Base Class Constraint?
        // The base class constraint in generics restricts the type parameter so that it must inherit from a specific base class.

        //Example:

        //    Suppose we have a base class Animal.

        //    public class Animal
        //{
        //    public void Eat()
        //    {
        //        Console.WriteLine("Animal is eating");
        //    }
        //}

        //public class Zoo<T> where T : Animal
        //{
        //    public void Feed(T animal)
        //    {
        //        animal.Eat();
        //    }
        //}
        #endregion

    }
    }
}
