// LeetCode problem 205: Isomorphic Strings
// https://leetcode.com/problems/isomorphic-strings/

public class Program205
{
	public static void Test()
	{
		Program205 p = new();

		//false test
		string s = "foo";
		string t = "bar";
		Console.WriteLine($"Are the strings isomorphic? Should be FALSE: [{p.IsIsomorphic(s, t)}] \n\r");

		//true test
		s = "egg";
		t = "add";
		Console.WriteLine($"Are the strings isomorphic? Should be TRUE:  [{p.IsIsomorphic(s, t)}] \n\r");
	}

	public bool IsIsomorphic(string s, string t)
	{
		if (s.Length != t.Length) return false;

		Dictionary<char, char> map = new();
		char c = 'a';

		for (int i = 0; i < s.Length; i++)
		{
			if (map.ContainsKey(s[i]) && map.TryGetValue(s[i], out c))
			{
				if (!c.Equals(t[i])) return false;
			}
			else if (!map.ContainsValue(t[i]))
			{
				map.Add(s[i], t[i]);
			}
			else return false;

			Console.WriteLine($"map.Key(s[i]) = [{s[i]}] | map.GetValue(s[i]) = [{map.GetValueOrDefault(s[i])}] (...OR...) KEY (s[i]) = [{s[i]}] | VALUE (t[i]) = [{t[i]}] \n\r");
		}
		return true;
	}
}