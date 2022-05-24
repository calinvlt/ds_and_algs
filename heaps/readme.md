# Heaps

**Priority queue** \- special queue on which the deletion and access are done from the front of the queue\, but the insertion leaves the queue in an ordered state\.

**Abstract data type** \- is a type that can be implemented using other more fundamental data types

A priority queue can be implemented using an ordered array with the following constraints:

* always delete from the end of the array -> O(1)
* when data is inserted, the array remains sorted -> O(n)

**Because insertions in an ordered array take O(n), heap is a better fundamental data type which can be used to implement a priority queue.**

**Heap** is a **binary tree** that maintains the following conditions:

* each node's value must be greater than the values of its descendants
* the tree is complete
    * if you read the tree level by level from left to right **each level has all the nodes**
        * **the last level is allowed to have empty nodes as long as there aren't any nodes to the right of the empty positions**

## **Properties**

* not worth searching through
* the root node will always have the max/min value -> great tool for implementing priority queues

## **Operations**

### Insertion

1. Insert the new node in the rightmost spot in the bottom level
2. Compare new node with its parent node
3. If the new node is greater than the parent node swap the nodes.
4. Continue until new node is lower than the parent node

Problem: finding the rightmost spot in the bottom level

### Deletion

We always delete the root

1. Move the last node where root was
2. Trickle the node down into it proper place
    * Swap the node with its smaller child
    * Continue until the node has no children larger then its value

<br>
<br>
