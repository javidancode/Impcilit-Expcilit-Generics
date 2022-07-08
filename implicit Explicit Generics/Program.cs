using System;

namespace implicit_Explicit_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Dersde yazdiglarimizin Praktikasi

            //Manat manat = new Manat(1000);
            //Dollar dollar = manat;
            //Console.WriteLine(dollar.Usd);


            //StringList list = new StringList();
            //list.Add("Cavidan");
            //list.GetAll();


            //BookList booklist = new BookList();

            //Book book1 = new Book
            //{
            //    Name = "mavi qatarin sirri",
            //    Author = "Sherlock Holmes"
            //};

            //booklist.Add(book1);
            //booklist.GetAll();

            //EmpLoyee<string> emp1 = new EmpLoyee<string>();

            //EmpLoyee<int> emp2 = new EmpLoyee<int>();

            //EmpLoyee<Test> emp3 = new EmpLoyee<Test>();

            //EmpLoyee<Person, Common> employee = new EmpLoyee<Person, Common>();


            //Employee employee = new Employee(17, "Cavidan");
            //Student student = new Student(18, "Eli");

            //Console.WriteLine(employee > student);
        }
    }

    /*public class EmpLoyee<T,U>*/ /*where T : class*/
    //where T : struct
    //where T : Common
    //where T : ITest
    //where T:new ()
    //where T:U
    //{

    //}

    //public class Person:Common
    //{

    //}

    //public abstract class Common
    //{

    //}

    //public class Test : ITest
    //{

    //}

    //public class ITest
    //{

    //}


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
    //    public string Name  { get; set; }
    //    public int Age { get; set; }

    //    public Employee(int age, string name)
    //    {
    //        Name = name;
    //        Age = age;
    //    }


    //    public static bool operator > (Employee employee , Student student)
    //    {
    //        return employee.Age > student.Age;
    //    }

    //    public static bool operator <(Employee employee, Student student)
    //    {
    //        return employee.Age < student.Age;
    //    }



    //}












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
    //        return new Dollar(manat.Azn / 1.7);
    //    }
    //}

    //public class StringList
    //{
    //    private string[] arr;
    //    public StringList()
    //    {
    //        arr = new string[0];
    //    }


    //    public void Add(string str)
    //    {
    //        Array.Resize(ref arr, arr.Length + 1);
    //        arr[arr.Length - 1] = str;
    //    }

    //    public void GetAll()
    //    {
    //        foreach (var item in arr)
    //        {
    //            Console.WriteLine(item);
    //        }
    //    }
    //}

    //public class BookList
    //{
    //    private Book[] arr;
    //    public BookList()
    //    {
    //        arr = new Book[0];
    //    }


    //    public void Add(Book book)
    //    {
    //        Array.Resize(ref arr, arr.Length + 1);
    //        arr[arr.Length - 1] = book;
    //    }

    //    public void GetAll()
    //    {
    //        foreach (var item in arr)
    //        {
    //            Console.WriteLine(item.Name + " - " + item.Author);
    //        }
    //    }
    //}

    //public class Book
    //{
    //    public string Name { get; set; }
    //    public string Author { get; set; }
    //}

    #endregion Dersde yazdiglarimizin Praktikasi
}
