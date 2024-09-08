/*
*    Link: https://leetcode.com/problems/4sum/
*
*    Prompt:
*    Given an array nums of n integers, return an array of all the unique quadruplets [nums[a], nums[b], nums[c], nums[d]] such that:
*        0 <= a, b, c, d < n
*        a, b, c, and d are distinct.
*        nums[a] + nums[b] + nums[c] + nums[d] == target
*
*    You may return the answer in any order.
*
*        
*    Example 1:
*    Input: nums = [1,0,-1,0,-2,2], target = 0
*    Output: [[-2,-1,1,2],[-2,0,0,2],[-1,0,0,1]]
*
*    Example 2:
*    Input: nums = [2,2,2,2,2], target = 8
*    Output: [[2,2,2,2]]
*
*/

public class Solution {
    public IList<IList<int>> FourSum(int[] nums, int target) {
        var result = new List<IList<int>>();
        int n = nums.Length;
        
        if (n < 4) return result;  // if there are less than 4 numbers
        
        // First sort the array
        Array.Sort(nums);  
        
        // Traverse the array using two loops and two pointers
        for (int i = 0; i < n - 3; i++)
        {
            // Skip duplicates for the first number
            if (i > 0 && nums[i] == nums[i - 1]) continue;  
            
            for (int j = i + 1; j < n - 2; j++)
            {
                // Skip duplicates for the second number
                if (j > i + 1 && nums[j] == nums[j - 1]) continue;  
                
                // Two-pointer approach
                int left = j + 1;
                int right = n - 1;
                
                while (left < right)
                {
                    long sum = (long)nums[i] + nums[j] + nums[left] + nums[right];
                    
                    if (sum == target)
                    {
                        result.Add(new List<int> { nums[i], nums[j], nums[left], nums[right] });
                        
                        // Skip duplicates for the third and fourth numbers
                        while (left < right && nums[left] == nums[left + 1]) left++;
                        while (left < right && nums[right] == nums[right - 1]) right--;
                        
                        // Move pointers after finding a valid quadruplet
                        left++;
                        right--;
                    }
                    else if (sum < target)
                    {
                        // Increase the sum
                        left++;  
                    }
                    else
                    {
                        // Decrease the sum
                        right--;  
                    }
                }
            }
        }
        
        return result;
    }
}