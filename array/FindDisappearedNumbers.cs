public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {
        int[] visitedNumber = new int[nums.Length+1];
        IList<int> result = new List<int>();
        
        for(int i=0;i<nums.Length;i++)
        {
            visitedNumber[nums[i]] = 1;
        }

        for(int j=1;j<visitedNumber.Length;j++)
        {
            if(visitedNumber[j]==0)
            {
                result.Add(j);
            }
        }

        return result;
    }
}

/*
Given an array nums of n integers where nums[i] is in the range [1, n], return an array of all the integers in the range [1, n] that do not appear in nums.

Example 1:

Input: nums = [4,3,2,7,8,2,3,1]
Output: [5,6]
Example 2:

Input: nums = [1,1]
Output: [2]
*/
