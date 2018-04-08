https://leetcode.com/problems/non-decreasing-array/description/

using System;

public class Test {
 public static bool CheckPossibility(int[] nums) {

  if (nums == null || nums.Length < 3) {
   return true;
  }

  int changeOnce = 0;

  for (int i = 0; i < nums.Length - 1; i++) {
   // compare nums[i] with nums[i+1]
   // If nums[i] is same or smaller, go to the next one
   // If nums[i] is bigger than nums[i+1], set
   if (nums[i] > nums[i + 1]) {
    changeOnce++;
    // We have two changing ways
    // Decrease nums[i] to the same as nums[i+1], however, make sure this one is still 
    // larger the previous one
    // If option 1 does not work, increase nums[i+1] to nums[i]
    // option 1 is preferred as we can get the most possible smaller number

    // Try option 1
    int changingValue = nums[i + 1];

    if (i > 0 && changingValue < nums[i - 1]) {
     nums[i + 1] = nums[i];
    }


    if (changeOnce == 2) {
     return false;
    }
   }
  }

  return true;

 }

 public static void Main() {
  int[] weekDays = {
   4,
   2,
   3
  };
  //string[] weekDays = [];
  Console.WriteLine(CheckPossibility(weekDays));
 }
}
