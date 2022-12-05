using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShopSalon.AppData
{
    public class Clients
    {
        public string name { get; set; }
        public string adress { get; set; }
        public int phone { get; set; }

        public Clients(string _name, string _adress, int _phone)
        {
            this.name = _name;
            this.adress = _adress;
            this.phone = _phone;
        }
    }
}
