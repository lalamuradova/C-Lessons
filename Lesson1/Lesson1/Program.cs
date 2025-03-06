using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Task 1: Sade calculator proqrami
            //Description: Istifadeciden 2 reqem sorushsun, 3 - cude operasiyani sorushsun eger `topla` dirsa toplasin, `cix` dirsa cixsin, `bolme` dirsa bolsun, `vurma` bu isharedirse reqemleri bir birine vursun. neticeni sonda ekrana cap elesin.

            //Input: 20, 10, vurma
            //Output: 200


            //Console.Write("Enter number1: ");
            //int number1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter number2: ");
            //int number2 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter operation (+,-,*,/): ");
            //char operation = Convert.ToChar(Console.ReadLine());

            //if (operation == '+')
            //{
            //    Console.Write("Result: ");
            //    Console.WriteLine(number1 + number2);
            //}
            //else if (operation == '*')
            //{
            //    Console.Write("Result: ");
            //    Console.WriteLine(number1 * number2);
            //}
            //else if (operation == '-')
            //{
            //    Console.Write("Result: ");
            //    Console.WriteLine(number1 - number2);
            //}
            //else if (operation == '/')
            //{
            //    if (number2 != 0)
            //    {
            //        Console.Write("Result: ");
            //        Console.WriteLine(number1 / number2);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Second number is zero");
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("Wrong choice");
            //}

            // ------------------------------------------------------------------------------------
            //Task 2.İstifadəçidən aylıq gəlirini və xərclərini(məsələn, kirayə, ərzaq və nəqliyyat)
            //soruşun.Xərclərdən sonra qalan qalıqlarını hesablayın və göstərin.məsələn

            //# Input: gelir = 5000, kiraye = 1500, magaza = 1000, ictimai_neqiliyyat = 500
            //# Output: qaliq = 2000

            //Console.Write("Enter Salary: ");
            //float salary = float.Parse(Console.ReadLine());

            //Console.Write("Enter rental cost: ");
            //float rentCost = float.Parse(Console.ReadLine());


            //Console.Write("Enter public transportation cost: ");
            //float publicTransport = float.Parse(Console.ReadLine());


            //Console.Write("Enter store cost: ");
            //float store = float.Parse(Console.ReadLine());

            //Console.Write("Enter utility cost: ");
            //float utility = float.Parse(Console.ReadLine());

            //float total = rentCost + publicTransport + store + utility;
            //float balance = salary - total;
            //int manat = (int)balance;
            //int qepik=(int) ((balance- manat)*100);
            //Console.WriteLine(manat+" manat"+qepik+" qepik");


            //------------------------------------------------------------------------------------
            //Task 3. İstifadəçidən yaşını və növbəti doğum gününə neçə ay qaldığını soruşun.
            //Onların ad gününə qalan günlərin sayını hesablayın və göstərin
            //(sadəlik üçün ayı 30 gün qəbul edin).

            //# Input: yas = 25, nece_ay_qalib = 5
            //# Output: Ad gunune 150 gun qaldi


            //Console.Write("Enter Age: ");
            //int age = Int32.Parse(Console.ReadLine());

            //Console.Write("Enter months Left: ");
            //int monthsLeft = Int32.Parse(Console.ReadLine());

            //int result = monthsLeft * 30;
            //Console.WriteLine($"There are {result} days left until your birthday.");

            //------------------------------------------------------------------------------------
            //Task 4. Temperatur olcən proqram
            //Temperaturları Selsi və Fahrenheit arasında çevirən proqram yazın.
            //İstifadəçi çevrilmə istiqamətini seçməli və temperaturu daxil etməlidir.
            //Bundan sonra proqram çevrilmiş dəyəri göstərməlidir.

            //Hesablama qaydası:
            //Selsidən Fahrenheitə: (C × 9/5) + 32
            //Farenheitdən Selsiyə: (F - 32) × 5/9

            //# Input: C, 25°
            //# Output: 77°F

            //# Input: F, 77
            //# Output: 25°C

            //Console.Write("Choose Selsi(C) or Farnheit(F): ");
            //char choice = Convert.ToChar(Console.ReadLine());

            //Console.Write("Enter temperature: ");
            //int temp = Convert.ToInt32(Console.ReadLine());
            //int result;
            //if (choice == 'C')
            //{
            //    result = (temp * 9 / 5) + 32;
            //    Console.WriteLine(result+ "°F");
            //}
            //else if(choice == 'F')
            //{
            //    result = (temp - 32) * 5;
            //    Console.WriteLine(result + "°C");
            //}
            //else
            //{
            //    Console.WriteLine("Wrong input");
            //}


            //------------------------------------------------------------------------------------

            //Task 5. İstifadəçinin 1-dən 10-a qədər gizli nömrəni təxmin etməyə çalışdığı
            //proqram yaradın. Hər təxmindən sonra onların çox yüksək, çox aşağı və ya düzgün
            //olduğunu bildirin. İstifadəçi düzgün təxmin etdikdə oyun bitməlidir.

            //# Secret number: 7
            //# Input: 4, 9, 7
            //# Output: "Çox aşağı", "Çox yüksək", "Təbriklər qazandınız düzdü"

            Console.Write("Enter secret number: ");
            int secretNumber = Convert.ToInt32(Console.ReadLine());
            int number;
            while (true) {
              Console.Write("Enter number: ");
              number = Convert.ToInt32(Console.ReadLine());
                if (number == secretNumber)
                {
                    Console.WriteLine("Conratulations");
                    break;
                }
                else if (number < secretNumber)
                {
                    Console.WriteLine("Number is low");
                }
                else
                {
                    Console.WriteLine("Number is high");
                }
            }
          

        }
    }
}
