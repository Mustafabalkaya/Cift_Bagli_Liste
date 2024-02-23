# Java Double Linked List Example

Bu örnek, Java programlama dilinde basit bir double linked list'in nasıl oluşturulacağını ve kullanılacağını göstermektedir.

## `DoubleLinkedList` Sınıfı

`DoubleLinkedList` sınıfı, double linked list'in temel yapısını sağlar. Bu sınıf, liste elemanlarını eklemek, çıkarmak ve listeyi yazdırmak gibi temel işlemleri içerir.

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
