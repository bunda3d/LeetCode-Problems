// Reverse Linked List
// https://leetcode.com/problems/reverse-linked-list/

using static System.Net.Mime.MediaTypeNames;

public class Program206
{
	public static void Test()
	{
		Program206 p = new();

		Console.WriteLine($"{instructions}");

		// test1 list1 = { 1,2,3,4,5 };
		ListNode head = new(1);
		head.next = new(2);
		head.next.next = new(3);
		head.next.next.next = new(4);
		head.next.next.next.next = new(5);
		Console.WriteLine(
			$"For input ListNode 'head':	[" +
			$"{head.val}, " +
			$"{head.next.val}, " +
			$"{head.next.next.val}, " +
			$"{head.next.next.next.val}, " +
			$"{head.next.next.next.next.val}" +
			$"] \n\r");
		// test1 result should be: { 5, 4, 3, 2, 1 }
		var res = p.ReverseList(head);
		Console.WriteLine(
			$"Output for ReversedList(head):	[" +
			$"{res.val}, " +
			$"{res.next.val}, " +
			$"{res.next.next.val}, " +
			$"{res.next.next.next.val}, " +
			$"{res.next.next.next.next.val}" +
			$"] \r");
		Console.WriteLine(
			$"... Correct answer:		[5, 4, 3, 2, 1]" +
			$"\n\r");
	}

	public ListNode ReverseList(ListNode head)
	{
		ListNode prev = null;
		Console.WriteLine($"ListNode prev=null => prev={prev?.val} \n\r");

		while (head != null)
		{
			ListNode next = head.next;
			Console.WriteLine($"ListNode next=head.next => next={next?.val}");
			head.next = prev;
			Console.WriteLine($"head.next=prev => head.next={head.next?.val}");
			prev = head;
			Console.WriteLine($"prev=head => prev={prev?.val}");
			head = next;
			Console.WriteLine($"head=next => head={head?.val} \n");
		}
		return prev;
	}

	private const string instructions = "INSTRUCTIONS: \r\n" +
		"Given the head of a singly linked list, reverse the list, and return the reversed list.\r\n\r\n";

	public class ListNode
	{
		public int val;
		public ListNode next;

		public ListNode(int val = 0, ListNode next = null)
		{
			this.val = val;
			this.next = next;
		}
	}
}

// what to paste into leetcode
/*

	public ListNode ReverseList(ListNode head)
	{
		ListNode prev = null;

		while (head != null)
		{
			ListNode next = head.next;
			head.next = prev;
			prev = head;
			head = next;
		}
		return prev;
	}

*/