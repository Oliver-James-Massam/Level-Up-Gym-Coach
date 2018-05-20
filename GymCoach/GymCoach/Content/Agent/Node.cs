using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GymCoach.Content.Agent
{
    public class Node<E>
    {
        //Node Contents
        private E element;
        private List<Node<E>> next;
        //private List<Node<E>> prev;

        //Constructor
        public Node(List<Node<E>> next, /*List<Node<E>> prev,*/  E element)
        {
            this.next = next;
            //this.prev = prev;
            this.element = element;
        }

        //Constructor
        public Node()
        {
            next = new List<Node<E>>(); ;
            element = default(E);
        }

        //Setting element of node
        public void setElement(E element)
        {
            this.element = element;
        }

        //Get Element of node
        public E getElement()
        {
            return this.element;
        }

        //Get list of next nodes
        public List<Node<E>> getNext()
        {
            return this.next;
        }

        //Getting node at an index
        public Node<E> getNodeAt(int index)
        {
            return next.ElementAt(index);
        }

        //Set list of next nodes
        public void setNext(List<Node<E>> next)
        {
            this.next = next;
        }

        //Adding a new Node to the next list
        public void addNext(Node<E> node)
        {
            this.next.Add(node);
        }

        ////Return nodes parent
        //public List<Node<E>> getPrev()
        //{
        //    return this.prev;
        //}

        ////Set Nodes Parent
        //public void setPrev(List<Node<E>> prev)
        //{
        //    this.prev = prev;
        //}
    }
}