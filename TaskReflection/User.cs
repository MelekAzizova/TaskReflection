using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskReflection
{
    internal class User
    {
        private int id;

        private string name;
        private static int age = 26;


        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }



        static void ChangeAge(int age)
        {
            age = age;

        }


    }
}
