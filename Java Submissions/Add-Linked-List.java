// 2. Add Two Numbers
// You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order, and each of their nodes contains a single digit. Add the two numbers and return the sum as a linked list.
// You may assume the two numbers do not contain any leading zero, except the number 0 itself.

// Definition for singly-linked list.
class ListNode {
    int val;
    ListNode next;
    ListNode() {}
    ListNode(int val) { this.val = val; }
    ListNode(int val, ListNode next) { this.val = val; this.next = next; }
}

class Solution {
    int remainder = 0;
    int total = 0;
    int output = 0;
    public ListNode addTwoNumbers(ListNode l1, ListNode l2) {
        if (l1 == null && l2 == null && remainder == 0) return null;
        total = (l1 != null ? l1.val : 0) + (l2 != null ? l2.val : 0) + remainder;
        output = total % 10;
        remainder = total / 10;

        l1 = l1 == null ? null : l1.next;
        l2 = l2 == null ? null : l2.next;

        return new ListNode(output, addTwoNumbers(l1, l2));        
    }
}

public static void main(String[] args) {
    Solution solution = new Solution();
    ListNode l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
    ListNode l2 = new ListNode(5, new ListNode(6, new ListNode(4)));
    ListNode result = solution.addTwoNumbers(l1, l2);
    while (result != null) {
        System.out.print(result.val + " ");
        result = result.next;
    }
}