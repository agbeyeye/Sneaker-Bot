using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillyBot.Models
{
    public class Model
    {
        public List<Store> Stores { get; set; }
        public List<Profile> Profiles {get;set;}
        public List<Task> Tasks { get; set; }
        public List<Proxy> Proxies { get; set; }
    }

    public class Profile
    {
        //Billing information
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string code { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string cardType { get; set; }
        public string cardNumber { get; set; }
        public string month { get; set; }
        public string year { get; set; }
        public string cvc { get; set; }

        //Shipping Information
        public string shipping_firstName { get; set; }
        public string shipping_lastName { get; set; }
        public string shipping_address { get; set; }
        public string shipping_code { get; set; }
        public string shipping_city { get; set; }
        public string shipping_state { get; set; }

       

    }

    public class Proxy
    {
        public string proxy_address { get; set; }
    }

    public class Store
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Task
    {
        public string id { get; set; }
        public string product { get; set; }
        public string productId { get; set; }
        public string url { get; set; }
        public int quantity { get; set; }
        public string size { get; set; }
        public string proxy { get; set; }
        public Store store { get; set; }
        public Profile profile { get; set; }
    }
}
