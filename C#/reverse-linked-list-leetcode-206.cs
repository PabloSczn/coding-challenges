/*
*    Link: https://leetcode.com/problems/reverse-linked-list/
*
*    Given the head of a singly linked list, reverse the list, and return the reversed list.
*
*    Example 1:
*    Input: head = [1,2,3,4,5]
*    Output: [5,4,3,2,1]
*
*    Example 2:
*    Input: head = [1,2]
*    Output: [2,1]
*
*/

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode ReverseList(ListNode head) {
        ListNode prev = null;
        ListNode current = head;
        ListNode next = null;

        while(current != null){
            next = current.next;
            current.next = prev;
            prev = current;
            current = next;
        }

        return prev;
    }

    public void PrintList(ListNode head){
        ListNode temp = head;
        Console.Write('[');
        while(temp != null){
            Console.Write(temp.val + ", ");
            temp = temp.next;
        }
        Console.Write(']');
    }
}