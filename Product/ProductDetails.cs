using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    public enum ProductCatagory { Mobile, Dell }
    class ProductDetails
    {
        
        public int Pid { get; set; }
        public string Pname { get; set; }
       

        public ProductCatagory ProductCatagorys;
        public List<Brand> b = new List<Brand>();


    }
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

    }

}
