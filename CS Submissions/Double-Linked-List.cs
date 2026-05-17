// 2816. Double a Number Represented as a Linked List
// You are given the head of a linked list representing a non-negative integer. 
// The most significant digit is at the head of the list, and each node contains a single digit. 
// Double the integer and return the head of the resulting linked list.  


var solution = new Solution();
var result = solution.DoubleIt(new ListNode(1, new ListNode(2, new ListNode(3))));
while (result != null) {
    Console.Write(result.val);
    result = result.next;
}
public class Solution {
    public ListNode DoubleIt(ListNode head, int remainder = 0) {
        if (head.val * 2 > 9) {
            head = new ListNode(0, head);
        }
        for (ListNode node = head; node != null; node = node.next) {
            node.val = (node.val * 2) % 10;
            if (node.next != null && node.next.val * 2 > 9) {
                node.val++;
            }
        }
        return head;
    }
}


// Definition for singly-linked list.
public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
}
