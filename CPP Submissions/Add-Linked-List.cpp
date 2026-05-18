// 2. Add Two Numbers
// You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order, and each of their nodes contains a single digit. Add the two numbers and return the sum as a linked list.
// You may assume the two numbers do not contain any leading zero, except the number 0 itself.

#include <iostream>
using namespace std;

// Definition for singly-linked list.
struct ListNode {
    int val;
    ListNode *next;
    ListNode() : val(0), next(nullptr) {}
    ListNode(int x) : val(x), next(nullptr) {}
    ListNode(int x, ListNode *next) : val(x), next(next) {}
};

class Solution {
public:
    ListNode* addTwoNumbers(ListNode* l1, ListNode* l2, int remainder = 0) {
        if (l1 == NULL && l2 == NULL && remainder == 0) return NULL;
        int total = (l1 ? l1 -> val : 0) + (l2 ? l2 -> val : 0) + remainder;
        int output = total % 10;
        remainder = total / 10;

        return new ListNode(output, addTwoNumbers(l1 ? l1 -> next : NULL, l2 ? l2 -> next : NULL, remainder));
    }
};