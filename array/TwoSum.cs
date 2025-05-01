public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dicNum = new Dictionary<int,int>();
        var result = new int[2];
        for(int i=0;i<nums.Length;i++)
        {
            var rem = target - nums[i];
            if(dicNum.ContainsKey(rem))
            {
                result[0] = dicNum[rem];
                result[1] = i;
                return result;
            }

            if(!dicNum.ContainsKey(nums[i]))
            {
                dicNum.Add(nums[i],i);
            }
        }

        return result;
    }
}

/*
Example 1:

Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
Example 2:

Input: nums = [3,2,4], target = 6
Output: [1,2]
Example 3:

Input: nums = [3,3], target = 6
Output: [0,1]
*/
