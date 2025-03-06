using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  Grade Calculator
            //Task: Grade Calculator(switch case ile yazilacaq)
            //You are tasked with creating a program that takes an array of student grades and calculates the corresponding letter grades for each student. The grading scale is as follows:
            //A: 90 - 100
            //B: 80 - 89
            //C: 70 - 79
            //D: 60 - 69
            //F: Below

            //Console.Write("Enter grade: ");
            //int grade=Convert.ToInt32(Console.ReadLine());

            //switch (grade)
            //{
            //    case int n when (n >= 90 && n <= 100):
            //        Console.WriteLine("A");
            //        break;
            //    case int n when (n >= 80 && n <= 89):
            //        Console.WriteLine("B");
            //        break;
            //    case int n when (n >= 70 && n <= 79):
            //        Console.WriteLine("C");
            //        break;
            //    case int n when (n >= 60 && n <= 69):
            //        Console.WriteLine("D");
            //        break;
            //    default:
            //        Console.WriteLine("F");
            //        break;
            //}

            #endregion


            int[] arr = { 4, 5, 2, 1, 5, 2, 5, 3, 5, 6, 2, 1, 6, 2, 6, 2, 5, 3, 2, 7, 4, 6, 4, 5, 6, 2, 5, 6, 3, 7, 3, 7 };
            #region Task2
            //1) Yuxaridaki arrayda 5 reqeminin nece defe tekrarlandigini tapin
            //int count = 0;
            //foreach (var number in arr)
            //{
            //    if (number == 5)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine($"Count: {count}");
            #endregion

            #region Task3
            //2) Yuxaridaki arraydaki butun reqemlerin cemini tapin
            //int total = 0;
            //foreach (var number in arr)
            //{
            //    total += number;
            //}
            //Console.WriteLine($"Total: {total}");
            #endregion

            #region Task4
            //3) arraydaki en boyuk reqemi tapin ve nece defe tekrarlandigini gosterin
            //int max = arr[0];
            //foreach (int i in arr)
            //{
            //    if (max < i)
            //    {
            //        max = i;
            //    }
            //}
            //Console.WriteLine($"Max: {max}");
            //int count = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] == max)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine($"Count: {count}");
            #endregion

            #region Task5
            //4)arraydaki ilk 3 e bolunende qaliqda 2 alinan reqemi ve hemin reqemin arraydaki indexini tapin
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] % 3 == 2)
            //    {
            //        Console.WriteLine($"Number: {arr[i]}, Index: {i}");
            //        break;
            //    }
            //}
            #endregion

            #region Task6
            //5)arraydaki en boyuk reqemin ilk indexini tapin
            //int max = arr[0];
            //foreach (int i in arr)
            //{
            //    if (max < i)
            //    {
            //        max = i;
            //    }
            //}

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] == max)
            //    {
            //        Console.WriteLine($"Max: {max}, Index: {i}");
            //        break;
            //    }
            //}
            #endregion

            #region Task7
            //6)4 reqeminin arrayin hansi indexlerinde oldugunu gosterin
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] == 4)
            //    {
            //        Console.WriteLine($"Index: {i}");
            //    }
            //}
            #endregion

            #region Task8
            //7)5 reqeminin arraydaki en boyuk ve en kicik indexlerini tapin
            //int max_index = -1, min_index = arr.Length;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] == 5)
            //    {
            //        if (max_index < i)
            //        {
            //            max_index = i;
            //        }
            //        if (min_index > i)
            //        {
            //            min_index = i;
            //        }
            //    }
            //}
            //if (max_index == -1 || min_index==arr.Length)
            //{
            //    Console.WriteLine("Number not found");
            //}
            //else
            //{
            //    Console.WriteLine($"Minimum index: {min_index}, Max index: {max_index}");
            //}
            #endregion






        }
    }
}
