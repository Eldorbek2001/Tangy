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
        public string status { get; set; }

        public IEnumerable<Demo_ProductProp> ProductProperties { get; set; }
        public void toggleStatus()
        {
            isActive = !isActive;
            if (isActive)
            {
                this.status = "Active";
            }
            else
            {
                this.status = "Inactive";
            }
        }
    }

}
