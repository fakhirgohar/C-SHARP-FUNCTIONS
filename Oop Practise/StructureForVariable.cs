using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Practise
{
    public struct StructureForVariable
    {
        public StructureForVariable(int a)//Parameterless Constuructor
        {

        }

        public static Nullable<int> RollNo = default(Nullable<int>);
        public static Nullable<float> Marks = default(Nullable<float>);

        public static dynamic Age = nameof(Age);
        public static dynamic Floor = nameof(Floor);
    }
}
