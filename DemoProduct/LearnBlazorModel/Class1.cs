using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProduct.LearnBlazorModel
{
    public class Class1
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double price { get; set; }
        public bool isActive { get; set; } 


        public List<Demo_ProductProp> ProductProperties { get; set; }
        public string getStatus()
        {
   
            if (isActive)
            {
                return "Active";
            }
            else
            {
                return "Inactive";
            }
        }
    }

}
