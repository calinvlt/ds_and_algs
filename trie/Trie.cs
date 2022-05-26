namespace Tries;

public class TrieNode {
  private Dictionary<char, TrieNode> _children;
  public Dictionary<char, TrieNode> Children => _children;

  public TrieNode()
  {
    _children = new Dictionary<char, TrieNode>();
  }  
}

public class Trie {

  private readonly TrieNode _root;
  public Trie()
  {
    _root = new TrieNode();
  }

  public void Add(string word) {
    var chars = word.ToCharArray();
    var current = _root;
    
    for(int i=0; i<chars.Length; i++) {
      if (current.Children.ContainsKey(chars[i])) {
        current = current.Children[chars[i]];        
      } else { 
        var newNode = new TrieNode();
        current.Children.Add(chars[i], newNode);

        current = newNode;
      }
    }

    current.Children.Add('*', null);
  }

  public TrieNode Search(string word) {
    var chars = word.ToCharArray();
    var current = _root;

    for(int i=0; i<chars.Length; i++) {
      if (current.Children.ContainsKey(chars[i])) {
        current = current.Children[chars[i]];
      } else {
        return null;
      }
    }
    return current;
  }

  public void CollectAllWords(TrieNode node, string word, List<string> words) {
    if (node == null) node = _root;

    foreach (var item in node.Children)
    {
      if (item.Key == '*') {
        words.Add(word);
        }
      else {
        var word1 = word + item.Key;
        CollectAllWords(item.Value, word1, words);
      }
    }
  }
}