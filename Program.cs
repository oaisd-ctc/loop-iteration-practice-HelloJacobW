
using System;


public class Program
{
    public static void Main(string[] args)
    {
       string boo = "******";
       Console.WriteLine(boo);
       boo = boo.Substring(0,boo.Length-1);
       Console.WriteLine(boo);
    }
}
