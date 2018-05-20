using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GymCoach.Content.Agent
{
    public class PriorityQueue<N, Fn>
    {
        private NodePriority nextNode;
        private LinkedList<NodePriority> priorityNodes;
        public struct NodePriority
        {
            public N node;
            public int fnValue;

            public NodePriority(N node, int fnValue)
            {
                this.node = node;
                this.fnValue = fnValue;
            }
        }

        //Constructor
        public PriorityQueue()
        {
            priorityNodes = new LinkedList<NodePriority>();
        }

        //Constructor
        public PriorityQueue(N node, int fnValue)
        {
            nextNode.node = node;
            nextNode.fnValue = fnValue;
            priorityNodes = new LinkedList<NodePriority>();
            priorityNodes.AddLast(nextNode);
        }

        //insert a new node into priority queue
        public void enqueue(N node, int fnValue)
        {
            //Check if list is empty
            if (priorityNodes.Count < 1)
            {
                System.Diagnostics.Debug.WriteLine("Add " + fnValue);
                priorityNodes.AddFirst(new NodePriority(node, fnValue));
            }
            else
            {
                int index = 0;
                foreach (NodePriority i in priorityNodes)
                {
                    System.Diagnostics.Debug.WriteLine("For " + i.fnValue);
                    if (i.fnValue > fnValue)
                    {
                        //insert new node in place of another and push others back
                        priorityNodes.AddBefore(priorityNodes.Find(i), new NodePriority(node, fnValue));
                        System.Diagnostics.Debug.WriteLine("Replace: " + i.fnValue);
                        return;
                    }
                    index++;
                }
                //reached end of list meaning that the node provided is prioritised least
                priorityNodes.AddLast(new NodePriority(node, fnValue));
            }

        }

        //Return and remove the 1st element in the priority queue
        public N dequeue()
        {
            N tempNode = priorityNodes.First().node;
            priorityNodes.RemoveFirst();
            return tempNode;
        }

        //return number of elements in the queue
        public int numElements()
        {
            return priorityNodes.Count();
        }

        //returns the 1st node in the queue
        public N peek()
        {
            return priorityNodes.First().node;
        }
    }
}