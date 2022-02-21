using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp {
    //klasa student dziedziczy po klasie person
    class Student:Person {
        protected string class_name;


        public void set_class_name(string n) {
            class_name = n;
        }
        //polimorfizm
        public override string show() {
           return first_name + " " + last_name + ", lat " + age + " jest uczniem. Klasa: " + class_name;
        }
    }
}
