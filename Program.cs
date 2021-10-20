using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Collections;

namespace ConsoleApplication1
{
    class Program
    {
   
        static Product findProduct (List<Product> listProduct, string nameProduct)
        {
            foreach (Product p in listProduct)
            {
                if (p.name == nameProduct)
                {
                    return p;
                }
                

            }
            return new Product();
        }

        static List<Product> findCategoryId(List<Product> listProduct, int categoryId)
        {
            List<Product> licategory=new List<Product>();
            foreach (Product p in listProduct)
            {
                if (p.categoryId == categoryId)
                {
                    licategory.Add(p);
                   
                }


            }
            return licategory;
        }
        static List<Product> findPrice(List<Product> listProduct, int price)
        {
            List<Product> listfindPrice = new List<Product>();
            foreach (Product p in listProduct)
            {
                if (p.price < price)
                {
                    listfindPrice.Add(p);

                }


            }
            return listfindPrice;
        }
        static List<Product> sortByPrice(List<Product> listProduct)
        {
            int n = listProduct.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (listProduct[j].price < listProduct[j + 1].price)
                    {
                        Product a = new Product();
                        a = listProduct[j];
                        listProduct[j] = listProduct[j + 1];
                        listProduct[j + 1] = a;
                    }
                }
            }
            return listProduct;
        }

        static List<Product> sortByName(List<Product> listProduct)
        {
            int n = listProduct.Count;
            for (int i = 0; i < n -1 ; i++)
            {
                
                for (int j = i + 1; j > 0; j--)
                {
                   
                        if (listProduct[j - 1].name.Length >listProduct[j].name.Length)
                        {
                            Product a = new Product();
                            a = listProduct[j - 1];
                            listProduct[j - 1] = listProduct[j];
                            listProduct[j] = a;
                        }
                   
                   
                }
                

               
            }
            return listProduct;
        }

        static string getCategory(int getCategoryId)
        {
            List<Category> listCategory = new List<Category>();
            foreach(Category c in listCategory)
            {
                if (c.id == getCategoryId)
                    return c.name;
            }
            return null;
        }
        // săp
        static List<Category> sortByNameCatefory(List<Category> listCategory)
        {
            int n = listCategory.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (String.Compare(getCategory(listCategory[j - 1].categoryId), getCategory(listCategory[j].categoryId)) > 0)
                    {
                        Category a = new Category();
                        a = listCategory[j - 1];
                        listCategory[j - 1] = listCategory[j];
                        listCategory[j] = a;
                    }
                }

            }
            return listCategory;
        }


        static List<Product> sortByNameCateforyinListProduct(List<Product> listProduct)
        {
            int n = listProduct.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (String.Compare(listProduct[j - 1].category.name, listProduct[j].category.name) > 0)
                    {
                        Product a = new Product();
                        a = listProduct[j - 1];
                        listProduct[j - 1] = listProduct[j];
                        listProduct[j] = a;
                    }
                }

            }
            return listProduct;
        }

        //bai 13
      /*  static List<Product> sortByCategoryName(List<Product> listP,List<Category> listC)
        {
            List<Category> list5 = sortByNameCatefory(listC);
            List<Product> listfinal = new List<Product>();
           foreach(Product p in listP)
           {
               for(int i=0;i<list5.Count;i++)
               {
                   if(list5[i].id==p.categoryId)
                   {
                       listfinal.Add(p);
                   }
               }
               
           }
          
            
                return listfinal;
        }
       * */
      //bai15
        static int MinByPrice(List<Product> listProduct)
        {
            int min=listProduct[0].price ;
            foreach(Product p in listProduct)
            {
               
                if (p.price < min)
                {
                    min = p.price;
                }
                
            }

            return min;  
        }
           //bai16
        static List<Product> MaxByPrice(List<Product> listProduct)
        {
            /*
            int max=listProduct[0].price ;
            foreach(Product p in listProduct)
            {
               
                if (p.price > max)
                {
                    max = p.price;
                }
                
            }
             * */
            List<Product> listmax = new List<Product>();
            
            int max=listProduct[0].price;
            listmax.Add(listProduct[0]);
            for (int i = 1; i < listProduct.Count;i++ )
            {
                if(listProduct[i].price>max)
                {
                    max = listProduct[i].price;
                    listmax.Clear();
                    listmax.Add(listProduct[i]);
                }
                if(listProduct[i].price==max)
                {
                    listmax.Add(listProduct[i]);
                }

            }

                return listmax;  
        }

        //bài 21
      // cách 1
        static double tinh(double salary,double rate)
        {
            if (rate==1)
            {
                return salary;
            }
     
            return tinh(salary,rate-1)+tinh(salary,rate-1)*0.1;
            
        }
        
        //cách 2
        static double calSalary(double salary, double rate)
        {
            double tong = 0;
            for(int i=1;i<=rate;i++)
            {
                if(i==1)
                {
                    tong = salary;
                   
                }
                if(i>1)
                {
                    tong = tong + tong * 0.1;
                }
               
            }
            return tong;
        }
        //bài 22
        static int calMonth(double money, double rate)
        {
            double m = money;
            int month = 0;
            while(m<=2*money)
            {
                m = m + m * rate/100;
                month++;
            }
            return month;
          
        }
        static double allmonth(double money,double rate,int month)
        {
            if (month == 0)
                return money;
            return allmonth(money,rate,month-1)+allmonth(money,rate,month)*rate/100;
        }
        static int calMonth5(double money, double rate)
        {
            double tonglai = 0;
            int month=1;
            for (int i = month; i < 1000;i++ )
            {
                tonglai = allmonth(money, rate, month);
                if(tonglai>=2*money)
                {
                    break;
                }
                month++;

            }



            return month;
        }



        /*
        static double calMonth2(double money, double rate)
        {
            if (2 == 1 + rate/100)
                return 1;
            return Math.Log(2,(1 + rate/100));
        }

        static double calMonth3(double money,double rate)
        {
            if (2*money == money +(money* rate / 100))
                return Math.Log(2,(1+rate));

            return calMonth3(((money + money * rate)*(1+rate)), rate);
        


        }
         * */

        static void Main(string[] args)
        {
            
            
            

            List<Category> listCategory=new List<Category>();
            Category category1 = new Category(1, "Computer");
            Category category2 = new Category(2, "Memory");
            Category category3 = new Category(3, "Card");
            Category category4 = new Category(4, "Acsesory");
            
            listCategory.Add(category1);
            listCategory.Add(category2);
            listCategory.Add(category3);
            listCategory.Add(category4);


            List<Product> listProduct = new List<Product>();
            Product product1 = new Product("CPU", 750, 10, 1,category1);
            Product product2 = new Product("RAM", 50, 2, 2,category2);
            Product product3 = new Product("HDD", 70, 1, 2,category2);
            Product product4 = new Product("Main", 400, 3, 1,category1);
            Product product5 = new Product("Keyboard", 30, 8, 4,category4);
            Product product6 = new Product("Mouse", 25, 50, 4,category4);
            Product product7 = new Product("VGA", 60, 35, 3,category3);
            Product product8 = new Product("Monitor", 120, 28, 2,category2);
            Product product9 = new Product("Case", 120, 28,5,new Category(5,"thang"));

            listProduct.Add(product1);
            listProduct.Add(product2);
            listProduct.Add(product3);
            listProduct.Add(product4);
            listProduct.Add(product5);
            listProduct.Add(product6);
            listProduct.Add(product7);
            listProduct.Add(product8);
            listProduct.Add(product9);
            
      
            Console.WriteLine("Danh sách products");
            foreach(Product p in listProduct)
            {              
                Console.WriteLine(p);
            }

            Console.WriteLine("Danh sách categorys");
            foreach (Category p in listCategory)
            {
                Console.WriteLine(p);
            }
            

            // nhập tên nameProduct để in ra product có name
           
                        Console.WriteLine("Nhập tên Product");
                        string nameProduct = Console.ReadLine();



          Console.WriteLine(findProduct(listProduct, nameProduct));

            //nhập categoryID

             Console.WriteLine("Nhập tên categoryId");
             int cate = int.Parse(Console.ReadLine());
             List<Product> list = findCategoryId(listProduct, cate);
             
            foreach(Product p in list)
            {
                Console.WriteLine(p);
            }

            //nhập price
            Console.WriteLine("Nhập tên price");
            int price = int.Parse(Console.ReadLine());
            List<Product> list2 = findPrice(listProduct, price);
            foreach(Product p in list2)
            {
                Console.WriteLine(p);
            }


            //sắp xếp
            // theo price
            Console.WriteLine("danh sách sau khi sắp xếp theo price");
            List<Product> list3 = sortByPrice(listProduct);
            foreach(Product p in list3)
            {
                Console.WriteLine(p);
            }


            //theo name
            Console.WriteLine("danh sách sau khi sắp xếp theo name");
            List<Product> list4 = sortByName(listProduct);
            foreach (Product p in list4)
            {
                Console.WriteLine(p);
            }

            //catetogy theo name
            
            Console.WriteLine("sắp xếp name trong category");

           
         
            List<Category> list6 = sortByNameCatefory(listCategory);
            foreach(Category c in list6)
            {
                Console.WriteLine(c);
            }



            //bài 13
            
            Console.WriteLine("sắp xêp theo category name");
            List<Product> list5 = sortByNameCateforyinListProduct(listProduct);
            foreach (Product p in list5)
            {
              
               Console.WriteLine(p);
              
            }
            //bài 14
            Console.WriteLine("danh sach ca Product à Category");
            foreach(Product p in listProduct)
            {
                Console.Write(p);
                Console.Write("\t");
             
                Console.Write(p.category.name);
                Console.WriteLine();
            

            }

            //bài 15

            int min=MinByPrice(listProduct);
            Console.WriteLine(" product có price min");
            foreach(Product p in listProduct)
            {
                if(p.price==min)
                {
                    Console.WriteLine(p);
                }
            }
            //bài 16
            /*
            int max = MaxByPrice(listProduct);
            Console.WriteLine("Product có price max");
            foreach(Product p in listProduct)
            {
                if(p.price==max)
                {
                    Console.WriteLine(p);
                }
            }
             * */
            //bài 17
            Console.WriteLine("Giá Trị Max");
            List<Product> listmaxout = MaxByPrice(listProduct);
            foreach(Product p in listmaxout)
            {
                Console.WriteLine(p);
            }

            // bài 21
            Console.WriteLine("in ra câu 17");
            Console.WriteLine(tinh(1000,5 ));
            Console.WriteLine(calSalary(1000, 5));
            // bài 22
            Console.WriteLine("So thang can tiet kiem");
        //    Console.WriteLine(calMonth2(100, 5));

            Console.WriteLine(calMonth(100, 5));
            Console.WriteLine("So thang can tiet kiem cách đệ quy");
        
            Console.WriteLine(calMonth5(100, 10));
            
                Console.ReadKey();
          



        }
   
    }
       
}
