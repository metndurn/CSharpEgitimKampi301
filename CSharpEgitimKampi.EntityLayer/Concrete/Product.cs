using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi.EntityLayer.Concrete
{
	public class Product
	{
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductStock { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductDescription { get; set; }
        public int CategortId { get; set; }//her urunun bır kategorısı olacaktır ve bıre cok iliski kurulacaktır
        public virtual Category Category { get; set; }//bıre cok iliski kurulacaktırve buradan kategorı tablosunun haberı olmalı
        public List<Order> Orders { get; set; }
    }
}
