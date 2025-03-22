using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ConsoleApp7
{
    using System;



    class Student
    {
        public String name;
        public int rollno;
        public String course;
        public int age;


        public Student(String name, int rollno, String course, int age)
        {

            this.name = name;
            this.rollno = rollno;
            this.course = course;
            this.age = age;

        }


        public void ShowDetail()
        {
            Console.WriteLine("name is = " + this.name);
            Console.WriteLine("Roll-Number is =" + this.rollno);
            Console.WriteLine("Course =  " + this.course);
            Console.WriteLine(" Age is  = " + this.age);
        }


    }


    class main
    {
        public static void Main()
        {

            Student s1 = new Student("Ankit", 1, "btech", 22);
            Student s2 = new Student("Aditya", 2, "btech", 22);

            s1.ShowDetail();
            s2.ShowDetail();


        }
    }
}
    