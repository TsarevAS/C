/* lab5
Служащий, персона, рабочий, инженер
employee, person, worker, engineer

Иерархия классов (свойства):
		person (age, gender)
		^
		|
		employee (firm, salary)
		^
		|
worker(speciality)		engineer(university)

*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApplication3
{
    //--------класс персона-------------
    class Person
    {
        public string gender;
        protected int age;
        public Person()
        {
            this.gender = "M";
            this.age = 33;
        }
        public Person(string gender, int age)
        {
            this.gender = gender;
            this.age = age;
        }
        public virtual string get()
        {
            return String.Format("Person : Gender - {0}, Age - {1}", this.gender, this.age);
        }
    }
    //--------класс Служащий-------------
    class employee : Person
    {
        protected string firm;
        protected float salary;
        public employee()
        {
            this.salary = 50000;
            this.firm = "BAIKAL";
        }
        public override string get()
        {
            return String.Format("Person : Gender - {0}, Age - {1} firm - {2}, salary - {3}", this.gender, this.age, this.firm, this.salary);
        }
    }
    //----------класс рабочий-------------------
    class worker : employee
    {
        protected string speciality;
        public worker()

        {
            this.speciality = "electricity";
        }
        public override string get()
        {
            return String.Format("worker : Gender - {0}, Age - {1} firm - {2}, speciality - {3}", this.gender, this.age, this.firm, this.speciality);
        }
    }
    //-----класс инженер--------------
    class engineer : employee
    {
        protected string university;
        public engineer()

        {
            this.university = "MGPU";
        }
        public override string get()
        {
            return String.Format("engineer : Gender - {0}, Age - {1} firm - {2}, university - {3}", this.gender, this.age, this.firm, this.university);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Person B = new Person();
            Person C = new employee();
            Person D = new worker();
            Person E = new engineer();
            Console.WriteLine(B.get());
            Console.WriteLine(C.get());
            Console.WriteLine(D.get());
            Console.WriteLine(E.get());
        }
    }
}