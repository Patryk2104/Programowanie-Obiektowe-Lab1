using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp {
    //klasa teacher dziedziczy po klasie person
    class Teacher :Person {
        protected string subject;


        public void set_subject(string n) {
            subject = n;
        }
        //polimorfizm
        public override string show() {
            return first_name + " " + last_name + ", lat " + age + " jest nauczycielem. Nauczany przedmiot: " + subject;
        }
    }
}
