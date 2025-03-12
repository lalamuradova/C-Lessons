using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            /*
            1) Aşağıdaki tapşırığı yerinə yetirin: 
               a) Key və value-su string tipində olan Dictionary yaradın.  
               b) İstifadəçidən 10 dəfə iki söz yazılması istənilsin:
                   b.1) Birinci söz ölkə adı.
                   b.2) İkinci söz paytaxt adı.
               c) Daha sonra istifadəçi ölkə adı yazaraq daxil edilən list-dən paytaxt adını almalıdır. 
               d) Əgər istifadəçi ölkə adı əvəzinə "all" sözü daxil edilərsə, dictionary-də olan bütün ölkə-paytaxlar print edilsin.
               e) Nəticəni aldıqdan sonra yeni paytaxt axtarışı edilsin yoxsa proqram bitsin deyə istifadəçidən soruşulmalıdır və cavaba müvafiq   əməliyyat baş verməlidir.

               Misal üçün:
               Proqram çalışarkən aşağıdakilər baş verməlidi:
               Əvvəl belə mesaj çıxır:
               "Hörmətli istifadəçi! Zəhmət olmasa ölkə adı qeyd edin."
               Daha sonra ölkə adını yazmaq istənilir.
               Daha sonra bu mesaj çıxır:
               "Hörmətli istifadəçi! Zəhmət olmasa ölkəyə aid paytaxt qeyd edin."
               Paytaxt adını yazmaq istənilir.
               Bütün bu proses 10 dəfə təkrarlanır və dictionary dolur. Daha sonra istifadəçidən bir ölkə adı yazmaq istənilir:
               "Hörmətli istifadəçi! Zəhmət olmasa paytaxtını tapmaq istədiyiniz ölkənin adını qeyd edin."
               İstifadəçi "Azərbaycan" yazarsa dictionary-də həmin key-ə görə search edib, ona uyğun value-nu, yəni "Bakı" sözünü qaytarıb, ekrana print     etmək       lazımdı.
               Əgər istifadəçi ölkə adı əvəzinə "all" sözü daxil edilərsə, dictionary-də olan bütün ölkə-paytaxlar print edilsin.
               Print etdikdən sonra soruşulur:
               "Yeni paytaxt axtarılsın? Y/N"
               İstifadəçi "Y" yazarsa yeni axtarış üçün ölkə adı istənilsin, "N" basarsa proqramdan çıxsın.                
          */
            //Dictionary<string,string> dict= new Dictionary<string,string>();
            //string world, capital;
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write($"{i + 1}\nHörmətli istifadəçi! Zəhmət olmasa ölkə adı qeyd edin: ");
            //    world=Console.ReadLine();
            //    Console.Write("Hörmətli istifadəçi! Zəhmət olmasa ölkəyə aid paytaxt qeyd edin: ");
            //    capital = Console.ReadLine();

            //    dict.Add(world, capital);
            //}

            //string search;
            //string choice;
            //bool isFind = false;
            //while (true)
            //{
            //    isFind = false;
            //    Console.Write("Hörmətli istifadəçi! Zəhmət olmasa paytaxtını tapmaq istədiyiniz ölkənin adını qeyd edin: ");
            //    search= Console.ReadLine();
            //    if (search.ToLower() == "all".ToLower())
            //    {
            //        foreach (KeyValuePair<string, string> d in dict)
            //        {
            //            Console.WriteLine($"{d.Key} - {d.Value}");
            //        }
            //    }
            //    else
            //    {
            //        foreach (KeyValuePair<string, string> d in dict)
            //        {
            //            if(d.Key.ToLower() == search.ToLower())
            //            {
            //                Console.WriteLine($"{d.Key} - {d.Value}");
            //                isFind = true;
            //                break;
            //            }
            //        }
            //        if (!isFind)
            //        {
            //            Console.WriteLine("Paytaxt tapılmadı...");
            //        }
            //    }

            //    Console.Write("Yeni paytaxt axtarılsın? Y/N: ");
            //    choice = Console.ReadLine();
            //    if (choice == "N")
            //    {
            //        break;
            //    }

            //}

            #endregion



            #region Task2
            /*
             2) Aşağıdaki tapşırığı yerinə yetirin:
               a) string tipli Queue list-i yaradın.
               b) İçini müxtəlif mesajlarla doldurun.
               c) Əgər məlumat 10 item-dən çox olarsa, növbədə (queue-list) ilk olan elementi boşaldıb, yerinə yeni məlumatı salın.
             */

            //Queue<string> queue = new Queue<string>();
            //int counter = 0;
            //string item;

            //while(true)
            //{
            //    counter++;
            //    Console.Write(counter+" Enter item: ");
            //    item=Console.ReadLine();
            //    if (counter == 10)
            //    {
            //        queue.Dequeue();
            //        queue.Enqueue(item);
            //        counter--;
            //        continue;
            //    }
            //    queue.Enqueue(item);
            //}



            #endregion


            #region Task3
            /*
              3) Aşağıdaki tapşırığı yerinə yetirin:
               a) int tipində List yaradın. 
               b) İstifadəçi 10 müxtəlif ədədlərlə listi doldursun.
               c) Daha sonra list-in son 5 elementi ilə ilk 5 elementinin yerlərini dəyişdirin.
             */


            //List<int> list = new List<int>();
            //int number;

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write("Ente number: ");
            //    number = Convert.ToInt32(Console.ReadLine());
            //    list.Add(number);
            //}
            //int temp;
            //int size = list.Count;
            //for (int i = 0; i < size / 2; i++)
            //{
            //    temp = list[i];
            //    list[i] = list[i + 5];
            //    list[i + 5] = temp;
            //}

            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.Write(list[i] + " , ");
            //}
            //Console.WriteLine();
            #endregion

            #region Task4
            /*  
            4) Aşağıdaki tapşırığı yerinə yetirin:
              a) int tipli elə bir kolleksiya yaradın ki, içində bütün item-lər unique olsun (təkrarlanma olmasın) və sort edilmiş vəziyyətdə olsun.
              b) Daha sonra içini müxtəlif ədədlərlə doldurun. (Console-dan)
              c) Nəticəni ekrana çap edin.
           */

            //SortedSet<int> set = new SortedSet<int>();
            //int number;
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write("Enter number: ");
            //    number = Convert.ToInt32(Console.ReadLine());
            //    set.Add(number);
            //}

            //foreach (int i in set)
            //{
            //    Console.Write(i + " , ");
            //}
            //Console.WriteLine();
            #endregion





        }
    }
}
