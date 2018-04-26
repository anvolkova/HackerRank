 /*
Detect a cycle in a linked list. Note that the head pointer may be 'null' if the list is empty.

A Node is defined as: 
    class Node {
        int data;
        Node next;
    }
*/

bool hasCycle(Node head) {
    if(head == null || head.next == null){
        return false;
    }
    Node fast = head.next;
    Node slow = head;
    while(fast != slow){
        if(fast.next == null || fast.next.next == null){
            return false;
        }
        else{
            fast = fast.next.next;
            slow = slow.next;
        }
    }
    return true;

}
