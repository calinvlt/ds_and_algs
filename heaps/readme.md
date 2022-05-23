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