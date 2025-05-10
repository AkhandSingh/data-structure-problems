public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        for(int i=0;i<nums1.Length;i++)
        {
            var number = nums1[i];
            bool isFound =  false;
            bool isNextNumFound = false;
            for(int j = 0;j<nums2.Length;j++)
            {
                if(number == nums2[j])
                {
                   isFound = true;
                   
                }

                if(isFound && number <nums2[j])
                {
                    nums1[i] = nums2[j];
                    isNextNumFound = true;
                    break;
                }
            }
            
            if(!isNextNumFound)
            {
                nums1[i] = -1;
            }
        }

        return nums1;
    }
}

/*Example 1:

Input: nums1 = [4,1,2], nums2 = [1,3,4,2]
Output: [-1,3,-1]
Explanation: The next greater element for each value of nums1 is as follows:
- 4 is underlined in nums2 = [1,3,4,2]. There is no next greater element, so the answer is -1.
- 1 is underlined in nums2 = [1,3,4,2]. The next greater element is 3.
- 2 is underlined in nums2 = [1,3,4,2]. There is no next greater element, so the answer is -1.
Example 2:

Input: nums1 = [2,4], nums2 = [1,2,3,4]
Output: [3,-1]
Explanation: The next greater element for each value of nums1 is as follows:
- 2 is underlined in nums2 = [1,2,3,4]. The next greater element is 3.
- 4 is underlined in nums2 = [1,2,3,4]. There is no next greater element, so the answer is -1.*/
 
