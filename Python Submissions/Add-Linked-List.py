# 2. Add Two Numbers
# You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order, and each of their nodes contains a single digit. Add the two numbers and return the sum as a linked list.
# You may assume the two numbers do not contain any leading zero, except the number 0 itself.

# Definition for singly-linked list.
class ListNode(object):
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next


class Solution(object):
    def addTwoNumbers(self, l1, l2):
        total = l1.val + l2.val
        output = total % 10
        remainder = total // 10
        answer = ListNode(output)

        if any((l1.next, l2.next, remainder)):
            l1 = l1.next if l1.next else ListNode(0)
            l2 = l2.next if l2.next else ListNode(0)
            l1.val += remainder
            answer.next = self.addTwoNumbers(l1, l2)

        return answer
        
solution = Solution()
result = solution.addTwoNumbers(ListNode(2, ListNode(4, ListNode(3))), ListNode(5, ListNode(6, ListNode(4))))
while result:
    print(result.val) # 7, 0, 8
    result = result.next
