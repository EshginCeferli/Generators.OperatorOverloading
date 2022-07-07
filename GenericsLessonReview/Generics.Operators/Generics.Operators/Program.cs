using System;

namespace Implicit.Explicit
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Implicit,Explicit
            //Manat manat = new Manat(340);
            //Dollar dollar = manat;
            //Console.WriteLine(dollar.Usd);

            //int a = 123;
            //Console.WriteLine(a.ToString());
            //string b = "123";
            //Console.WriteLine(int.Parse(b));
            #endregion
            #region Generics
            //StringList stringList = new StringList();
            //stringList.Add("Eshgin");
            //stringList.Add("Ceferli");
            //stringList.GetData();


            //BookList bookList = new BookList();


            //Book book1 = new Book()

            //{
            //    Name = "Xemse",
            //    Author = "Nizami"
            //}; 

            //Book book2 = new Book()
            //{
            //    Name = "Xemse",
            //    Author = "Nizami"
            //}; 

            //Book book3 = new Book()
            //{
            //    Name = "Xemse",
            //    Author = "Nizami"
            //};

            //bookList.Add(book1);
            //bookList.Add(book2);
            //bookList.Add(book3);
            //bookList.GetData();

            //DataList<Book> dataList = new DataList<Book>();
            //dataList.Add(new Book { Author = "Nizami" });
            //dataList.Add(new Book { Name = "Xemse" });

            //dataList.GetData();

            //DataList<int> dataList = new DataList<int>();
            //DataList<string> dataList1 = new DataList<string>();
            //DataList<Person> dataList2 = new DataList<Person>();

            //Employee<Person, Common> employee = new Employee<Person, Common>();
            #endregion
            #region Operator Overloading
            //Student student = new Student(20, "Eshgin");
            //Employee employee = new Employee(30, "Sadiq");
            //Console.WriteLine(employee > student);
            #endregion



        }
    }
    #region Implicit,Explicit
    //public class Dollar
    //{
    //    public double Usd { get; set; }
    //    public Dollar(double usd)
    //    {
    //        Usd = usd;
    //    }
    //}
    //public class Manat
    //{
    //    public double Azn { get; set; }
    //    public Manat(double azn)
    //    {
    //        Azn = azn;
    //    }

    //    public static implicit operator Dollar(Manat manat)
    //    {
    //        return new Dollar(manat.Azn / 1.70);
    //    }
    //}
    #endregion
    #region Generics
    //public class StringList
    //{
    //    private string[] arr;
    //    public StringList()
    //    {
    //        arr = new string[0];
    //    }
    //    public void Add(string data
    //    {
    //        Array.Resize(ref arr, arr.Length + 1);
    //        arr[arr.Length - 1] = data;
    //    }
    //    public void GetData()
    //    {
    //        foreach(var item in arr)
    //        Console.WriteLine(item );
    //    }
    //}

    //public class Employee <T,U> where T:U
    //{

    //}

    //public class DataList <T> where T : Common
    //{
    //    private T[] arr;
    //    public DataList()
    //    {
    //        arr = new T[0];
    //    }
    //    public void Add(T data)
    //    {
    //        Array.Resize(ref arr, arr.Length + 1);
    //        arr[arr.Length - 1] = data;
    //    }
    //    public void GetData()
    //    {
    //        foreach (var item in arr)
    //            Console.WriteLine(item);
    //    }
    //}
    //public class Book
    //{
    //    public string Name { get; set; }
    //    public string Author { get; set; }
    //}

    //public class Person : Common
    //{

    //}
    //public class Common
    //{

    //}
    #endregion
    #region Operator Overloading
    //public class Student
    //{
    //    public string Name { get; set; }
    //    public int Age { get; set; }
    //    public Student(int age, string name)
    //    {
    //        Name = name;
    //        Age = age;

    //    }
    //}
    //public class Employee
    //{
    //    public string Name { get; set; }
    //    public int Age { get; set; }
    //    public Employee(int age, string name)
    //    {
    //        Name = name;
    //        Age = age;
    //    }
    //    public static bool operator >(Employee employee, Student student)
    //    {
    //        return employee.Age > student.Age;
    //    }
    //    public static bool operator <(Employee employee, Student student)
    //    {
    //        return employee.Age > student.Age;
    //    }

    //}
    #endregion


}
