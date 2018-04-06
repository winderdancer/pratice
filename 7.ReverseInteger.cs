//https://leetcode.com/problems/reverse-integer/description/

using System;

public class Test {
 public static int Reverse(int x) {

  int sum = 0;
  bool isNegative = x < 0;
  if (isNegative) {
   x = -x;
  }


  while (x > 0) {
   int digit = x % 10;
   x = x / 10;

   /*
   try
   {
   sum = checked(sum * 10 + digit); 
   }
   catch (Exception error)
   {
     return 0;
   }
   */

   int originalSum = sum;
   sum = sum * 10 + digit;
   if (originalSum != (sum - digit) / 10) {
    return 0;
   }

  }

  if (isNegative) {
   sum = -sum;
  }

  return sum;
 }

 public static void Main() {

  Console.WriteLine(Reverse(234));
 }
}
