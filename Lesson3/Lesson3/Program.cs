using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Creating a Simple Shopping List Application in C#
            //Task: Creating a Simple Shopping List Application in C#

            //Sizə C# dilində əsas alış-veriş siyahısı proqramı yaratmaq tapşırılıb. Tətbiq istifadəçilərə alış-veriş siyahısına elementlər əlavə etmək, əşyaların siyahısını göstərmək və müəyyən bir elementin əlavə edilib-edilməməsi haqqında məlumat vermək imkanı verməlidir. 

            //Use switch case and arraylist )))

            object item1 = new
            {
                name = "Banana",
                price = 2.5,
                quantity = 10,
                category = "Fruits"
            };

            object item2 = new
            {
                name = "Potatoes",
                price = 1.3,
                quantity = 22,
                category = "Vegetables"
            };

            object item3 = new
            {
                name = "Pasta",
                price = 3.4,
                quantity = 17,
                category = "Grains"
            };

            object item4 = new
            {
                name = "Lemon",
                price = 1.10,
                quantity = 35,
                category = "Fruits"
            };

            ArrayList productList = new ArrayList();
            productList.Add(item1);
            productList.Add(item2);
            productList.Add(item3);
            productList.Add(item4);
            string productName;
            bool isFind;
            while (true)
            {
                isFind = false;
                Console.Write("1. Add product \n2. Display list \n3. Check product \n4. Exit \nSelect an option: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter product name: ");
                        productName= Console.ReadLine();
                        foreach (var item in productList)
                        {
                            dynamic product = item;
                            if (product.name.ToLower() == productName.ToLower())
                            {
                                isFind= true;
                                Console.WriteLine("This product name already exist!!!");
                                break;
                            }
                        }
                        if (!isFind)
                        {
                            Console.Write("Enter price: ");
                            float price=Convert.ToSingle(Console.ReadLine());

                            Console.Write("Enter quantity: ");
                            int quantity = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Enter category: ");
                            string category = Console.ReadLine();

                            object item = new
                            {
                                name = productName,
                                price = price,
                                quantity = quantity,
                                category = category
                            };
                            productList.Add(item);
                            Console.WriteLine("Product succesfully added.");
                        }
                        break;
                    case 2:
                        foreach (var item in productList)
                        {
                            dynamic product = item;
                            Console.WriteLine("____________________________________________________________________________");
                            Console.WriteLine($"Product name: {product.name} \nPrice: {product.price} \nQuantity: {product.quantity} \nCategory:{product.category}");
                        }
                        Console.WriteLine("____________________________________________________________________________");
                        break;
                    case 3:
                        Console.Write("Enter product name: ");
                        productName = Console.ReadLine();
                        foreach (var item in productList)
                        {
                            dynamic product = item;
                            if (product.name.ToLower() == productName.ToLower())
                            {
                                Console.WriteLine($"\nProduct name: {product.name} \nPrice: {product.price} \nQuantity: {product.quantity} \nCategory:{product.category}\n");
                                isFind= true;
                                break;
                            }
                        }

                        if (!isFind)
                        {
                            Console.WriteLine("Product not found!!!");
                        }

                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Wrong choice...");
                        break;
                }

                if (choice == 4)
                {
                    break;
                }
            }
            #endregion
        }
    }
}
