using System;
class Node
{
	public int data;
	public Node next;
    public Node(int d){
        data=d;
        next=null;
    }
		
}
class Solution {

	public static  Node insert(Node head,int data)
	{
      if(head == null)
      {
          return new Node(data);
      }
      else if(head.next == null)
      {
          head.next = new Node(data);
      }
      else
      {
          insert(head.next, data);
      }
      
      return head;
    }

	public static void display(Node head)