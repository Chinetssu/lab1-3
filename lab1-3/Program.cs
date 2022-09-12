using System;

namespace ConsoleAppOnlyDigit
{
    public class Logic
    {
        public static int Convert(string exp)
        {
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