using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch19studio
{
    public class MenuItem
    {
        public string NameOfItem { get; set; }
        public string Description;
        public string Category;
        public double Price;
        public DateTime CreationDate = DateTime.Today;

        public MenuItem(string name, string desc, string category, double price)
        {
            NameOfItem = name;
            Description = desc;
            Category = category;
            Price = price;
        }


    }
}
