using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Practise
{
    public class Student : Department
    {

        protected internal int test;
        public static int st;
        public int RollNo;
        public string Name;
        public decimal Marks;
        public string Gender;
        public string Address;
        public Student()
        {
            //Console.WriteLine("Constructor is Called");
            RollNo = 0;
            Name = "Empty";
            Marks = 0;
            Gender = "Empty";
            Address = "Empty";
        }
        public override void Find()
        {
            Console.WriteLine("Student Class Function");
        }
        public void SetStudent(int rn, string name = "Default Name", decimal marks = 0, string gender = "Default Gender", string address = "Default Address")
        {
            RollNo = rn;
            Name = name;
            Marks = marks;
            Gender = gender;
            Address = address;
        }
        public void print()
        {
            Console.WriteLine("Print Function Called");
            Console.WriteLine(RollNo);
            Console.WriteLine(Name);
            Console.WriteLine(Marks);
            Console.WriteLine(Gender);
            Console.WriteLine(Address);
        }

        public override int Compute(int x, int y)
        {
            return base.Compute(x, y) * 5;
        }

        private void PrivateFunction()
        {

        }
    }
}
