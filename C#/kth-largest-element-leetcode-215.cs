/*
*    Link: https://leetcode.com/problems/kth-largest-element-in-an-array/
*
*    Given an integer array nums and an integer k, return the kth largest element in the array.
*    Note that it is the kth largest element in the sorted order, not the kth distinct element.
*    Can you solve it without sorting?
*
*    Example 1:
*    Input: nums = [3,2,1,5,6,4], k = 2
*    Output: 5
*
*    Example 2:
*    Input: nums = [3,2,3,1,2,4,5,5,6], k = 4
*    Output: 4
*
*/
public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        SortedSet<(int Value, int Index)> heap = new SortedSet<(int, int)> ();
        int n = nums.Length;

        for (int i = 0; i < n; i++) {
            if (heap.Count < k) {
                heap.Add((nums[i], i));
            } 
            else if (nums[i] > heap.Min.Value) {
                heap.Remove(heap.Min);
                heap.Add((nums[i], i));
            }
        }

        // The Kth largest element is the minimum element in the heap now
        return heap.Min.Value;
    }
}