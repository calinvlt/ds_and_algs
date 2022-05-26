# Trie

Main use case is autocomplete.
Some data structure must contain all the words in a dictionary

1. unordered array the search will be O(n)
2. hash table would not work because the key will be the entire word so prefixed won't work
3. ordered array the search will be O(log n)
4. trie ds search is O(k) k = number of characters in the word

**Trie - a kind of tree ideal for text-based features like autocomplete**

## Implementation

Each node contains a hash table where keys are English characters and the values are other nodes
<br>
``` C#
class TrieNode {
    private readonly Dictionary<string, TrieNode> _children;
    public TrieNode(Dictionary<string, TrieNode> children) {
        _children = children;
    }
}

class Trie {
    private readonly TrieNode _root;
    public Trie() {
        _root = new TrieNode();
    }
}
```

\* indicate the end of a word, otherwise we won't know when a word ends

<br>
<br>
