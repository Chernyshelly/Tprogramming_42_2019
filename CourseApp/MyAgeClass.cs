﻿using System;
using System.Collections.Generic;

namespace CourseApp
{
    public class MyAgeClass
    {
        public static DateTime DateCompar(DateTime date1, DateTime date2)
        {
            if (date1.Ticks < date2.Ticks)
            {
                var res = new DateTime(date2.Ticks - date1.Ticks);
                return res;
            }
            else
            {
                long a = Math.Abs(date2.Ticks - date1.Ticks);
                if (a < 10000001)
                {
                    throw new AgeException("Автору 0 лет");
                }
            }

            throw new AgeException("Вы ещё не родились, ожидайте");
        }

        public static string MyAge()
        {
            Console.WriteLine("Введите год своего рождения:");
            int years = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите месяц своего рождения:");
            int months = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите день своего рождения:");
            int days = int.Parse(Console.ReadLine());
            DateTime result = DateCompar(new DateTime(years, months, days), DateTime.Now);
            return $"Вам {result.Year - 1} лет, {result.Month - 1} месяцев и {result.Day - 1} дня";
        }

        public static string MyAge(int y, int m, int d)
        {
            DateTime result = DateCompar(new DateTime(y, m, d), DateTime.Now);
            return $"Вам {result.Year - 1} лет, {result.Month - 1} месяцев и {result.Day - 1} дня";
        }

        public static string MyAge(DateTime date)
        {
            DateTime result = DateCompar(date, DateTime.Now);
            return $"Вам {result.Year - 1} лет, {result.Month - 1} месяцев и {result.Day - 1} дня";
        }
    }
}