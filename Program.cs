
using System;


public class Program
{
    public static void Main(string[] args)
    {
      Write1ThroughN_While(-1);
      Write1ThroughN_While(5);
      Write1ThroughN_While(0);
      //...
      Write1ThroughN_For(-1);
      Write1ThroughN_For(5);
      Write1ThroughN_For(0);
      //...
      WriteNThrough1_While(-1);
      WriteNThrough1_While(5);
      WriteNThrough1_While(0);
      //...
      WriteNThrough1_For(-1);
      WriteNThrough1_For(5);
      WriteNThrough1_For(0);
      //...
      WriteEvensThrough100();
      //...
      FindSum(5);
      FindSum(1);
      FindSum(-3);
      FindSum(100);
      //...
      FindSumOfEvenNumbers(10);
      FindSumOfEvenNumbers(-5);
      FindSumOfEvenNumbers(2);
      FindSumOfEvenNumbers(0);
      FindSumOfEvenNumbers(1);
      FindSumOfEvenNumbers(25);
      FindSumOfEvenNumbers(-25);
      //...
      FindSumOfOddNumbers(10);
      FindSumOfOddNumbers(-5);
      FindSumOfOddNumbers(1);
      FindSumOfOddNumbers(2);
      FindSumOfOddNumbers(25);
      FindSumOfOddNumbers(-25);
      //...
      OutputRightTriangle(4);
      OutputRightTriangle(6);
      OutputRightTriangle(-4);
      OutputRightTriangle(-6);
      OutputRightTriangle(0);
    }
    public static void Write1ThroughN_While(int n){
        int x = 0;
        if(n<=0)
        Console.WriteLine(n +" is out of range.");
        else{
            while(x<n){
                x++;
                Console.Write(x + " ");
            }
            Console.Write("\n");
        }
    }
    public static void Write1ThroughN_For(int n){
        if(n<=0)
        Console.WriteLine(n +" is out of range.");
        else{
            for(int x = 1; x <= n;x++){
                Console.Write(x + " ");
            }
            Console.Write("\n");
        }
    }
    public static void WriteNThrough1_While(int n){
        int x = n;
        if(n<=0)
        Console.WriteLine(n +" is out of range.");
        else{
            while(x>0){
                Console.Write(x + " ");
                x--;
            }
            Console.Write("\n");
        }
    }
    public static void WriteNThrough1_For(int n){
        if(n<=0)
        Console.WriteLine(n +" is out of range.");
        else{
            for(int x = n; x > 0;x--){
                Console.Write(x + " ");
            }
            Console.Write("\n");
        }
    }
    public static void WriteEvensThrough100(){
        for(int x = 2; x <= 100;x+=2)
        Console.Write(x + " ");
        Console.Write("\n");
    }
    public static void FindSum(int n){
        int x = n;
        if(x > 0){
        while(x > 0){
            x--;
            n+=x;
        }
        }
        else{
        while(x < -2){
            x++;
            n+=x;
        }
        }
        Console.WriteLine(n);
    }
    public static void FindSumOfEvenNumbers(int n){
        if(n>0){
        if(n%2==1)
        n--;
        for(int x = n - 2;x > 0;x-=2)
        n+=x;
        }
        else{
        if(Math.Abs(n)%2==1)
        n++;
        for(int x = n + 2;x < -1;x+=2)
        n+=x;
        }
        Console.WriteLine(n);
    }
    public static void FindSumOfOddNumbers(int n){
        if(n>0){
        if(n%2==0)
        n--;
        for(int x = n - 2;x > 0;x-=2)
        n+=x;
        }
        else{
        if(Math.Abs(n)%2==0)
        n++;
        for(int x = n + 2;x < -1;x+=2)
        n+=x;
        }
        Console.WriteLine(n);
    }
    public static void OutputRightTriangle(int n){
        string trongle = "";
        if(n>0){
        for(int x = 0;x < n;x++){
        trongle += "*";
        Console.WriteLine(trongle);
        }
        }
        else if(n<0){
        n = Math.Abs(n);
        for(int x = 0;x < n;x++)
        trongle +="*";
        for(int x = n;x > 0;x--){
        Console.WriteLine(trongle);
        trongle = trongle.Substring(0,trongle.Length-1);
        }
        }
        else
        Console.WriteLine("0 is out of range.");
       /* string boo = "******";
        boo = boo.Substring(0,boo.Length-1);
         Console.WriteLine(boo); */
    }
}
