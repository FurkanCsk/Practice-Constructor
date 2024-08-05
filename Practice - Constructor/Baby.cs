using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice___Constructor
{
    public class Baby
    {
        public string _name;
        public string _surname;
        public DateTime _birthday;

        public Baby()    // Default Constructor without parameters
        {
            CryingBaby();
        }

        public Baby(string Name, string SurName)  // Constructor with two parameters
        {
            _name = Name;
            _surname = SurName;
            CryingBaby();
        }

        public void CryingBaby()  // A method for display the crying message
        {
            Console.WriteLine("INGAAAAA!!!");
            _birthday = DateTime.Now;
        }

        public void BabyInfoDisplay() // A method for display baby informations
        {
            Console.WriteLine($"Name : {_name}, Surname : {_surname}, Birthday : {_birthday}");
        }

    }
}
