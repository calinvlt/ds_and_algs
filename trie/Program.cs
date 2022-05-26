using Tries;

var trie = new Trie();
trie.Add("tes");
trie.Add("tet");
trie.Add("tea");

System.Console.WriteLine(trie.Search("te"));
System.Console.WriteLine(trie.Search("testtt"));
var list = new List<string>();
trie.CollectAllWords(null, "", list);

list.ForEach(l => System.Console.WriteLine(l + " "));