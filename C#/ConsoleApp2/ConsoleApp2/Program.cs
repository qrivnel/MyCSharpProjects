using System;

public class Personel
{
    public string AdSoyad;
    public int SicilNo;
    public double Maas;

    public Personel(string adSoyad, int sicilNo, double maas)
    {
        AdSoyad = adSoyad;
        SicilNo = sicilNo;
        Maas = maas;
    }
}

public class Node
{
    public Personel data;
    public Node next;

    public Node(Personel p)
    {
        data = p;
        next = null;
    }
}

public class LinkedList
{
    public Node head;

    public void PrintList()
    {
        Node temp = head;
        while (temp != null)
        {
            Console.WriteLine(temp.data.AdSoyad + " - " + temp.data.SicilNo + " - " + temp.data.Maas);
            temp = temp.next;
        }
    }

    public void Append(Personel p)
    {
        Node newNode = new Node(p);
        if (head == null)
        {
            head = newNode;
            return;
        }
        Node temp = head;
        while (temp.next != null)
        {
            temp = temp.next;
        }
        temp.next = newNode;
    }

    public Node SimpleSearch(int sicilNo)
    {
        Node temp = head;
        while (temp != null)
        {
            if (temp.data.SicilNo == sicilNo)
            {
                return temp;
            }
            temp = temp.next;
        }
        return null;
    }

    public Node SortedSearch(int sicilNo)
    {
        Node temp = head;
        while (temp != null && temp.data.SicilNo < sicilNo)
        {
            temp = temp.next;
        }
        if (temp != null && temp.data.SicilNo == sicilNo)
        {
            return temp;
        }
        return null;
    }

    public void Insert(Personel p)
    {
        Node newNode = new Node(p);
        if (head == null)
        {
            head = newNode;
            return;
        }
        if (p.SicilNo < head.data.SicilNo)
        {
            newNode.next = head;
            head = newNode;
            return;
        }
        Node temp = head;
        while (temp.next != null && temp.next.data.SicilNo < p.SicilNo)
        {
            temp = temp.next;
        }
        newNode.next = temp.next;
        temp.next = newNode;
    }

    public void SortedInsert(Personel p)
    {
        Node newNode = new Node(p);
        if (head == null || p.SicilNo < head.data.SicilNo)
        {
            newNode.next = head;
            head = newNode;
            return;
        }
        Node temp = head;
        while (temp.next != null && temp.next.data.SicilNo < p.SicilNo)
        {
            temp = temp.next;
        }
        newNode.next = temp.next;
        temp.next = newNode;
    }
}
