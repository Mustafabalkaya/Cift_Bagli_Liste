# Java Double Linked List Example

This example shows how to create and use a simple double linked list in the Java programming language.

## `DoubleLinkedList` Sınıfı

The double class provides the basic structure of the linked list. This class contains basic operations such as adding and removing list elements and printing the list.


```java
public class DoubleLinkedList<T> {
    private static class Node<T> {
        T data;
        Node<T> prev;
        Node<T> next;

        Node(T data) {
            this.data = data;

        }
    }

    private Node<T> head;
    private Node<T> tail;
    private int size = 0;

    public void add(T element) {
        // Eleman ekleme işlemleri burada gerçekleştirilir.
        // ...
    }

    public void remove(T element) {
        // Eleman çıkarma işlemleri burada gerçekleştirilir.
        // ...
    }

    public void printList() {
        // Liste yazdırma işlemleri burada gerçekleştirilir.
        // ...
    }
}
