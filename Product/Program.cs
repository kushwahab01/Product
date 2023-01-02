using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ProductDetails> p = new List<ProductDetails>()
            {
                new ProductDetails
                {
                    Pid=101,
                    Pname="Mobile",
                    
                    ProductCatagorys=ProductCatagory.Mobile,
                    b=
                    {
                        new Brand{ Id=11, Name="Samsung", Price=1000},
                        new Brand{ Id=12, Name="Nokia", Price=2000},
                        new Brand{ Id=13, Name="iphone", Price=2510},
                        new Brand{ Id=14, Name="Oppo", Price=1522},
                        new Brand{ Id=15, Name="Vivo", Price=1133},
                        new Brand{ Id=16, Name="Android", Price=2050},
                    }

                },
                new ProductDetails
                {
                    Pid=102,
                    Pname="Dell",
                    ProductCatagorys=ProductCatagory.Dell,
                    b=
                    {
                        new Brand{ Id=17, Name="NoteBooks", Price=1546},
                        new Brand{ Id=18, Name="Desktops", Price=4000},
                        new Brand{ Id=19, Name="Gamer", Price=2121},
                        new Brand{ Id=20, Name="Accessories", Price=2133},
                        new Brand{ Id=21, Name="Monitors",  Price=1000},
                    }
                }

            };
            foreach (ProductDetails item in p)
            {
                Console.WriteLine($"Product Id Is : {item.Pid} Product Name is : {item.Pname}");
                foreach (Brand i in item.b)
                {
                    if(i.Price>1000 && i.Price<2000)
                    {
                        Console.WriteLine("\t" +"Name of Product is : "+ i.Name+" & "+"Price Of Product is : "+i.Price);
                    }
                    
                }
            }

            Console.WriteLine(".........Dell Products..............................");
            foreach (ProductDetails item in p)
            {
                Console.WriteLine($"Product Id Is : {item.Pid} Product Name is : {item.Pname} Product Catagory is : {item.ProductCatagorys}");
                foreach (Brand i in item.b )
                {
                    Console.WriteLine("\t"+i.Id+" "+"Product Name is : "+ i.Name+" & "+"Price of product is : "+i.Price);

                }
            }


            Console.WriteLine(".........Single Product Using Id........................");
            foreach (ProductDetails item in p)
            {
                Console.WriteLine($"Product Id Is : {item.Pid} Product Name is : {item.Pname}");
                foreach (Brand i in item.b)
                {
                    if (i.Id==15)
                    {
                        Console.WriteLine("\t" + "Name of Product is : " + i.Name + " & " + "Price Of Product is : " + i.Price);
                    }

                }
            }
        }
    }
}
