using System;

class GitPrograms{
  class Prgram{
    static int Palindrome(int num){
      int sum=0, rem, temp;
      temp=num;
      while(num>0){
        rem = num % 10;
        sum = rem * 10 + sum;
        num = sum / 10;
      }
      if(temp==num)
        Console.WriteLine("Is Palindrome");
      else
        Console.WriteLine("Is not Palindrome");
    }
  }
}
