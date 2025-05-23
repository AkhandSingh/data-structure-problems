public class Solution {
    public int ThirdMax(int[] nums) {
        long firstMax = long.MinValue;
        long secondMax = long.MinValue;
        long thirdMax = long.MinValue;

        for(int i=0;i<nums.Length;i++)
        {
            if(firstMax == nums[i] || secondMax ==  nums[i] || thirdMax == nums[i])
            {
                continue;
            }

            if(firstMax <nums[i])
            {
                thirdMax = secondMax;
                secondMax = firstMax;
                firstMax = nums[i];                
            }
            else if(secondMax < nums[i])
            {
                thirdMax = secondMax;
                secondMax = nums[i];
            }
            else if(thirdMax < nums[i])
            {
                thirdMax = nums[i];
            }
        }

        return thirdMax == long.MinValue? (int)firstMax : (int)thirdMax;
    }
}

/*Example 1:

Input: nums = [3,2,1]
Output: 1
Explanation:
The first distinct maximum is 3.
The second distinct maximum is 2.
The third distinct maximum is 1.
Example 2:

Input: nums = [1,2]
Output: 2
Explanation:
The first distinct maximum is 2.
The second distinct maximum is 1.
The third distinct maximum does not exist, so the maximum (2) is returned instead.
Example 3:

Input: nums = [2,2,3,1]
Output: 1
Explanation:
The first distinct maximum is 3.
The second distinct maximum is 2 (both 2's are counted together since they have the same value).
The third distinct maximum is 1.
*/
