using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseArithmetic_ChangeOfBase
{
    public class StackUsingLinkedList
    {
        public Node<int> Head;
        /*  public int top
          {
              get { return top; }
              private set {
                  if(Head==null)
                  { top = -1; }
                  else
                  { top = value; }
              }

          }
          */
        public int top { get; set; }
        public int Nodecount { get; set; }


        public void Push(int data)
        {
            if (Nodecount == 0)
            {
                Head = new Node<int>(data);
                top = Head.Data;
                Nodecount++;
                return; ;
            }
            var temp = new Node<int>(data);
            temp.Next = Head;
            Head = temp;
            top = Head.Data;
            Nodecount++;
        }
        public void Pop()
        {
            var temp = Head;
            Head = temp.Next;
            if (Head != null)
                top = Head.Data;
        }
        public void Print()
        {
            var prtemp = Head;
            StringBuilder sb = new StringBuilder();
            while (true)
            {
                if (prtemp == null)
                {
                    break;
                }
                sb.Append("|" + prtemp.Data + "|");
                var temp = prtemp;
                prtemp = temp.Next;
            }
            Console.WriteLine(sb.ToString());
        }
    }



    public class Node<T>
    {
        public Node<T> Next { get; set; }

        public T Data { get; set; }

        public Node(T data)
        {
            Data = data;
        }
    }
}

