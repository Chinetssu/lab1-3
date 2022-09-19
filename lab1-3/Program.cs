using System;

namespace ConsoleAppOnlyDigit
{
    public class Logic
    {
        public static string Clean(string exp)
        {
            string fixedExp = "";
            foreach (var el in exp)
            {
                if (el == '-'|| el == '+'|| (el >= '0' && el <= '9'))
                {
                    fixedExp += el;
                }
            }
            return fixedExp;
        }
        public static int Convert(string exp)
        {
            exp = Logic.Clean(exp);
            int res = 0;
            int num = 0;
            bool neg = false;
            foreach (char el in exp)
            {
                if (el.Equals('+'))
                {
                    res += num;
                    neg = false;
                    num = 0;
                }
                else
                {
                    if (el.Equals('-'))
                    {
                        res += num;
                        neg = true;
                        num = 0;
                    }
                    else
                    {
                        if (neg)
                        {
                            num = num * 10 - int.Parse(el.ToString());
                        }
                        else
                        {
                            num = num * 10 + int.Parse(el.ToString());
                        }
                    }
                }
            }
            res += num;
            return res;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите выражение:");
            string expression = Console.ReadLine();
            int result = Logic.Convert(expression);
            Console.Write("="+result);
        }
    }
}