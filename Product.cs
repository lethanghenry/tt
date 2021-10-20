using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Product
    {
        public string name { get; set; }
        public int price { get; set; }
        public int quality { get; set; }
        public int categoryId { get; set; }
        public Category category { get; set; }
        public Product()
        { }

        public Product(string name,int price, int quality, int categoryId)
        {
            this.name = name;
            this.price = price;
            this.quality = quality;
            this.categoryId = categoryId;
        }

        public Product(string name, int price, int quality, int categoryId,Category category)
        {
            this.name = name;
            this.price = price;
            this.quality = quality;
            this.categoryId = categoryId;
            this.category = category;
        }

        public override string ToString()
        {
            return "\t" + this.name + "\t" + this.price + "\t" + this.quality + "\t" + this.categoryId;
        }
       
       

    }
}
