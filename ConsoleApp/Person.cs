using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp {
    class Person {
        //skladowe protected są dostepne dla klasy w której się znajdują oraz dla klas dziedziczących
        protected string first_name;
        protected string last_name;
        protected int age;

        //skladowe public są dostępne dla wszystkich klas
        public void set_first_name(string n) {
            first_name = n;
        }

        public void set_last_name(string n) {
            last_name = n;
        }

        public void set_age(int x) {
            age = x;
        }

        public virtual string show() {
            return null;
        }
    }
}
