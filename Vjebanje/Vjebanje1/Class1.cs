using System;
using System.Collections.Generic;
using System.Text;

namespace Vjebanje1
{
    public class Dog
    {
        int age;
        string breed;
        string name;

        public string Bark()
        {
            return "Woof!";
        }

        //seteri- moraju biti public i tipa void su jer ne vracaju nista nego postavljas na odredenu vrijednost

        public void SetAge(int age)
        {
            this.age = age;
        }
        //geteri- javni tip je onog sto moras vratit
        public int GetAge()
        {
            return this.age;
        }

        

    }
}
