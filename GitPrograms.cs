using System;

class GitPrograms{
  public abstact class Prgram{
    public abstract void Reverse();
    static void Palindrome(int num){
      int sum=0, rem, temp;
      temp=num;
      while(num>0){
        rem = num % 10;
        sum = sum * 10 + rem;
        num = sum / 10;
      }
      if(temp==num)
        Console.WriteLine("Is Palindrome");
      else
        Console.WriteLine("Is not Palindrome");
    }
    
    static void Armstrong(int num){
      int car=0, rem, temp;
      temp=num;
      while(num>0){
        rem = num % 10;
        car = car + (rem * rem * rem);
        num = num / 10;
      }
      if(temp==num)
        Console.WriteLine("Is Armstrong");
      else
        Console.WriteLine("Is not Armstrong");
    }
    
    public class StringReverse : Program{
      public override void Reverse(){
        string str = Console.ReadLine();
        string result = "";
        for(int i = str.Length-1; i>=0; i--)
          result += str[i];
        Console.WriteLine("result");
      }
    }
    
    public static void Main(){
      Palindrome(121);
      Armstrong(153);
    } 
  }
}

