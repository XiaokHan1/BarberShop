using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShopSalon
{
    public class User
    {
        public string name { get; set; }
        public string dataOfBirth { get; set; }
        public string age { get; set; }
        public string gender { get; set; }

        public User(string _name, string _dataOfBirth, string _age, string _gender)
        {
            name = _name;
            dataOfBirth = _dataOfBirth;
            age = _age;
            gender = _gender;
        }
    }
}
