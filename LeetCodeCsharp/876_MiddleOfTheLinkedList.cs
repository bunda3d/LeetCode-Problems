// 876. Middle of the Linked List
// https://leetcode.com/problems/middle-of-the-linked-list

public class Program876
{
	public static void Test()
	{
		Program876 p = new();

		Console.WriteLine($"{instructions}");

		// test1 list = { 1,2,3,4,5 };
		ListNode head = new(1);
		head.next = new(2);
		head.next.next = new(3);
		head.next.next.next = new(4);
		head.next.next.next.next = new(5);
		Console.WriteLine(
			$"TEST1........................... \n\r" +
			$"For input ListNode 'head':	[" +
			$"{head.val}, " +
			$"{head.next.val}, " +
			$"{head.next.next.val}, " +
			$"{head.next.next.next.val}, " +
			$"{head.next.next.next.next.val}" +
			$"] \r");
		// test1 result should be: { 3, 4, 5 }, with result.val = [3]
		var res = p.MiddleNode(head);
		Console.WriteLine(
			$"The middle node is:		      [" +
			$"{res.val}" +
			$"] \r");
		Console.WriteLine(
			$"Correct answer (result.val):	      [3]" +
			$"\n\r");

		// test2 list = { 1,2,3,4,5 };
		head = new(1);
		head.next = new(2);
		head.next.next = new(3);
		head.next.next.next = new(4);
		head.next.next.next.next = new(5);
		head.next.next.next.next.next = new(6);
		Console.WriteLine(
			$"TEST2........................... \n\r" +
			$"For input ListNode 'head':	[" +
			$"{head.val}, " +
			$"{head.next.val}, " +
			$"{head.next.next.val}, " +
			$"{head.next.next.next.val}, " +
			$"{head.next.next.next.next.val}, " +
			$"{head.next.next.next.next.next.val}" +
			$"] \r");
		// test2 result should be: { 4, 5, 6 }, with result.val = [4]
		res = p.MiddleNode(head);
		Console.WriteLine(
			$"The middle node is:			 [" +
			$"{res.val}" +
			$"] \r");
		Console.WriteLine(
			$"Correct answer (result.val):		 [4]" +
			$"\n\r\n\r");

		Console.WriteLine($"{explainer}");
	}

	//paste this method in leetcode:
	public ListNode MiddleNode(ListNode head)
	{
		ListNode slow = head;
		ListNode fast = head;
		while (fast != null && fast.next != null)
		{
			slow = slow.next;
			fast = fast.next.next;
		}
		return slow;
	}

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

	private const string instructions = "INSTRUCTIONS: \r\n" +
		"Given the head of a singly linked list, return the middle node of the linked list.\r\n\r\n" +
		"If there are two middle nodes, return the second middle node.\r\n\r\n";

	private const string explainer = "EXPLANATION: \r\n" +
		"The solution uses two pointers, one moving at twice the speed of the other.\r\n" +
		"When the faster pointer reaches the end of the list,\r\n" +
		"the slower pointer will be at the middle node of the list. \r\n" +
		"Return the slower pointer. \r\n\r\n";
}