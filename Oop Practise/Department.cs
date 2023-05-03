using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Practise
{
    public class Department:IInterface
    {

        public string Dept;
        public Department()
        {
            Dept = "N/A";
        }
        public string SetDept { set { Dept = value; } }
        public string GetDept { get { return Dept; } }
        public virtual void Find()
        {
            Console.WriteLine("Department Class Function");
        }

        public virtual int Compute(int x, int y)
        {
            return (x + y);
        }

        private void PrivateFnction()
        {

        }
    }
}
