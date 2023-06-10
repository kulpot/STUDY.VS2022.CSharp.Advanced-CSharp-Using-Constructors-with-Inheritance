using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DealingWithConstructors;

//ref link:https://www.youtube.com/watch?v=rgnLN9M5d2k&list=PLhq7kqloVlM9iFmPZpQMgFjL6LytLv1Md&index=4&t=4s
//

namespace DealingWithConstructors
{
    class Program
    {
        // Using Constructor with Inheritance
        static void Main(string[] args)
        {
            List<Person> emps = new List<Person>();
            /*
            emps.Add(new Employee());
            emps.Add(new Student());

            Person p = new Employee();
            Employee e = p as Employee;
            if(e != null)
            {
                e.
            }
            */

            Student s = new Student("SBot");
            //s.Name = "SBot";
            s.Age = 1;
            s.GradeLevel = 9;

            Employee e = new Employee("Ebot");
            //e.Name = "Ebot";
            e.Age = 2;
            e.ID = "343434sdf34sd";

            emps.Add(s);
            emps.Add(e);

            foreach(Person p in emps)
            {
                if(p is Student)
                {
                    Student temp = p as Student;
                    Console.WriteLine(temp.GradeLevel);
                }
                else if(p is Employee)
                {
                    Employee temp = p as Employee;
                    Console.WriteLine(temp.ID);
                }
            }
        }
    }
}