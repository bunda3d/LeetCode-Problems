// Merge Two Sorted Lists
// https://leetcode.com/problems/merge-two-sorted-lists

public class Program21
{
	public static void Test()
	{
		Console.WriteLine($"{instructions}");

		// test1 list1 = { 1, 2, 4 };
		ListNode l1 = new(1);
		l1.next = new(2);
		l1.next.next = new(4);
		// test1 list2 = { 1, 3, 4 };
		ListNode l2 = new(1);
		l2.next = new(3);
		l2.next.next = new(4);
		Console.WriteLine($"For inputs " +
			$"l1: [" +
			$"{l1.val}, " +
			$"{l1.next.val}, " +
			$"{l1.next.next.val}" +
			$"] " +
			$"and " +
			$"l2: [" +
			$"{l2.val}, " +
			$"{l2.next.val}, " +
			$"{l2.next.next.val}" +
			$"] \n\r");
		// test1 result should be: { 1, 1, 2, 3, 4, 4 }
		var res = MergeTwoLists(l1, l2);
		Console.WriteLine(
			$"Output = [" +
			$"{res.val}, " +
			$"{res.next.val}, " +
			$"{res.next.next.val}, " +
			$"{res.next.next.next.val}, " +
			$"{res.next.next.next.next.val}, " +
			$"{res.next.next.next.next.next.val}" +
			$"] \n\r");

		// test2 list3 = { };
		ListNode? l3 = new();
		// test2 list4 = { 0 };
		ListNode l4 = new(0);
		Console.WriteLine($"For inputs " +
			$"l1: [" +
			$"{l3.val}" +
			$"] " +
			$"and " +
			$"l2: [" +
			$"{l4.val}" +
			$"] \n\r");
		// test2 result should be: { 0 }
		res = MergeTwoLists(l3, l4);
		Console.WriteLine(
			$"Output = [" +
			$"{res.val}" +
			$"] \n\r");
	}

	public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
	{
		if (list1 == null) return list2;
		if (list2 == null) return list1;

		ListNode mergedList = new();
		ListNode current = mergedList;

		// this method sorts the merged list -> traverse both lists, compare current nodes
		while (list1 != null && list2 != null)
		{
			// if l1 is less, 'current' list = current l1 element, & advance l1 to its next element
			if (list1.val < list2.val)
			{
				current.next = list1;
				list1 = list1.next;
			}
			// if l2 is less, 'current' list = current l2 element, & advance l2 to its next element
			else
			{
				current.next = list2;
				list2 = list2.next;
			}
			// add latest value to list "current"
			current = current.next;
		}

		// add remaining nodes of non-empty list to new list
		current.next = (list1 != null) ? list1 : list2;

		return mergedList.next;
	}

	private const string instructions = "INSTRUCTIONS: \r\n" +
		"You are given the heads of two sorted linked lists list1 and list2.\r\n\r\n" +
		"Merge the two lists into one sorted list. The list should be made by splicing together the nodes of the first two lists.\r\n\r\n" +
		"Return the head of the merged linked list.\r\n\r\n" +
		"WARNING: \r\n" +
		"This problem has a weird homerolled 'singly linked list' object ('ListNode') instead of using an existing C# type, like 'LinkedList'\r\n\r\n";
}

public class ListNode
{
	public int val;
	public ListNode? next;

	public ListNode(int val = 0, ListNode? next = null)
	{
		this.val = val;
		this.next = next;
	}
}