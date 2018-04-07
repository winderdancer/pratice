// https://leetcode.com/problems/palindrome-number/description/
public class Solution {
 public bool IsPalindrome(int x) {
  if (x < 0) {
   return false;
  }


  int length = 0;
  int tempx = x;

  while (tempx > 0) {
   tempx = tempx / 10;
   length++;
  }
  //Console.WriteLine("length= "+ length);

  while (x > 10) {
   int digit = x % 10;
   //Console.WriteLine("digit= " + digit);
   int compareDigit = x / (int) Math.Pow(10, (length - 1));
   //Console.WriteLine("compareDigit= " + compareDigit);
   if (digit != compareDigit) {
    return false;
   }

   x = (x - compareDigit * (int)(Math.Pow(10, (length - 1)))) / 10;
   length = length - 2;
   //Console.WriteLine("x= " + x);
  }

  if (length > 1 && x != 0) {
   return false;
  } else {
   return true;
  }
 }
}
