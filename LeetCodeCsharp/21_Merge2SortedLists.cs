// Merge Two Sorted Lists
// https://leetcode.com/problems/merge-two-sorted-lists

public class Program21
{
	public static void Test()
	{
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

		// traverse both lists, compare their current nodes
		while (list1 != null && list2 != null)
		{
			if (list1.val < list2.val)
			{
				current.next = list1;
				list1 = list1.next;
			}
			else
			{
				current.next = list2;
				list2 = list2.next;
			}
			current = current.next;
		}

		// add remaining nodes of non-empty list to new list
		current.next = (list1 != null) ? list1 : list2;

		return mergedList.next;
	}
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