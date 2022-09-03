using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoUygulaması
{
    public class PersonInfo
    {
        public static List<Person> person = new List<Person>();

        public PersonInfo()
        {
            person.Add(new Person(1, "Musa Kibar"));
            person.Add(new Person(2, "Ali Nurkoyuncu"));
            person.Add(new Person(3, "Alperen Şener"));
            person.Add(new Person(4, "Mehmet Mutlu"));
        }
    }
}
