#pragma warning disable
using System;
using System.IO;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Web;

using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;

internal class Node
{
    internal int key;
    internal int val;
    internal Node next;
    internal Node(int key, int val)
    {
        this.key = key;
        this.val = val;
    }
}

internal class LinkedListO
{
    internal Node head;

    internal bool AddNode(Node node)
    {
        if (head == null)
        {
            head = node;
            return true;
        }
        if (head.key == node.key)
        {
            head.val = node.val;
            return false;
        }
        Node cn = head;
        while (cn.next != null)
        {
            if (cn.key == node.key)
            {
                cn.val = node.val;
                return false;
            }
            cn = cn.next;
        }
        cn.next = node;
        return true;
    }

    internal bool Remove(int key)
    {
        if (head == null)
            return false;
        if (head.key == key)
        {
            head = head.next;
            return head == null;
        }
        Node cn = head;
        while (cn.next != null)
        {
            if (cn.next.key == key)
            {
                cn.next = cn.next.next;
                return head == null;
            }
            cn = cn.next;
        }
        return head == null;
    }

    internal int GetNode(int key)
    {
        Node cn = head;
        while (cn != null)
        {
            if (cn.key == key)
                return cn.val;
            cn = cn.next;
        }
        throw new NullReferenceException();
    }
}



internal class HashTable
{
    private float loadFactor;
    private LinkedListO[] linkedListsArr;
    private int count;
    internal HashTable(int capacity, float loadFactor = 0.75f)
    {
        linkedListsArr = new LinkedListO[capacity];
        count = 0;
        for (int i = 0; i < linkedListsArr.Length; i++)
            linkedListsArr[i] = new LinkedListO();
        this.loadFactor = loadFactor;
    }

    private float getCurLoadFactor()
    {
        return (float)((float)count / (float)linkedListsArr.Length);
    }

    internal void put(int key, int value)
    {
        int newIndx = getHashedIndx(key);
        if (linkedListsArr[newIndx].AddNode(new Node(key, value)))
            count++;
        while (getCurLoadFactor() >= loadFactor)
            ReHash();
    }

    private void ReHash()
    {
        count = 0;
        LinkedListO[] newlinkedListsArr = new LinkedListO[linkedListsArr.Length * 2];
        for (int i = 0; i < newlinkedListsArr.Length; i++)
            newlinkedListsArr[i] = new LinkedListO();
        for (int i = 0; i < linkedListsArr.Length; i++)
        {
            Node cn = linkedListsArr[i].head;
            while (cn != null)
            {
                Node newNode = new Node(cn.key, cn.val);
                int newIndx = newNode.key % newlinkedListsArr.Length;
                if (newlinkedListsArr[newIndx].AddNode(newNode))
                    count++;
                cn = cn.next;
            }
        }
        linkedListsArr = newlinkedListsArr;
    }

    internal int get(int key)
    {
        int newIndx = getHashedIndx(key);
        return linkedListsArr[newIndx].GetNode(key);
    }

    internal void delete(int key)
    {
        int newIndx = getHashedIndx(key);
        if (linkedListsArr[newIndx].Remove(key))
            count--;
    }

    private int getHashedIndx(int key)
    {
        return key % linkedListsArr.Length;
    }

}

internal class Solution
{
    internal static void Main()
    {
        HashTable hashtable = new HashTable(5);
        for (int i = 0; i < 3; i++)
            hashtable.put(i, i);
        for (int i = 0; i < 3; i++)
            Console.WriteLine(hashtable.get(i));
        for (int i = 0; i < 3; i++)
            hashtable.delete(i);

    }
}