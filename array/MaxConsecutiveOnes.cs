public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int max = 0;
        int count = 0;

        for(int i=0;i<nums.Length;i++)
        {
            if(nums[i]==0)
            {
                max = Math.Max(max, count);
                count = 0;
                continue;
            }

            if(nums[i] == 1)
            {
                count++;
            }
        }
        
        max = Math.Max(max, count);
        return max;
    }
}

/*
Example 1:

Input: nums = [1,1,0,1,1,1]
Output: 3
Explanation: The first two digits or the last three digits are consecutive 1s. The maximum number of consecutive 1s is 3.
Example 2:

Input: nums = [1,0,1,1,0,1]
Output: 2
*/
