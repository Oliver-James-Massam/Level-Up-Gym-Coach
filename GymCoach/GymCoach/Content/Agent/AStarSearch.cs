using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GymCoach.Content.Agent
{
    public class AStarSearch
    {
        private PriorityQueue<Node<Exercise>, int> openList;
        private PriorityQueue<Node<Exercise>, int> closedList;
        private Node<Exercise> tree;

        public AStarSearch()
        {
            this.tree = null;
        }

        public void searchTree()
        {
            if(tree == null)
            {
                buildTree();
            }
        }

        public int calcHeuristic(int gn, int hn)
        {
            int fn = gn + hn;
            return fn;
        }

        public void buildTree()
        {
            //Exercise exercise = TreeStructure.getBarbell();
        }

        public void setOpenList(PriorityQueue<Node<Exercise>, int> openList)
        {
            this.openList = openList;
        }

        public PriorityQueue<Node<Exercise>, int> getOpenList()
        {
            return this.openList;
        }
    }
}