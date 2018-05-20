using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GymCoach.Content.Agent
{
    public static class AStarSearch
    {
        private static PriorityQueue<Node<Exercise>, int> openList;
        private static PriorityQueue<Node<Exercise>, int> closedList;
        private static Node<Exercise> tree;

        public static void searchTree()
        {
            if(tree == null)
            {
                buildTree();
            }
        }

        public static int calcHeuristic(int gn, int hn)
        {
            int fn = gn + hn;
            return fn;
        }

        //build the tree to search
        public static void buildTree()
        {
            List<Exercise> exercises = TreeStructure.getExercises();
            List<Node<Exercise>> nextNodes = new List<Node<Exercise>>();

            //Full body
            tree = new Node<Exercise>(new List<Node<Exercise>>(), exercises[(int)EnumGroupLocation.FullBody]);
            tree.addNext(new Node<Exercise>(new List<Node<Exercise>>(), exercises[(int)EnumGroupLocation.UpperBody]));
            tree.addNext(new Node<Exercise>(new List<Node<Exercise>>(), exercises[(int)EnumGroupLocation.LowerBody]));
            nextNodes = tree.getNext();

            //Upper body
            Node<Exercise> upperBody = nextNodes[0];
            upperBody.addNext(new Node<Exercise>(new List<Node<Exercise>>(), exercises[(int)EnumGroupLocation.Push]));
            upperBody.addNext(new Node<Exercise>(new List<Node<Exercise>>(), exercises[(int)EnumGroupLocation.Pull]));

            //Lower body
            Node<Exercise> lowerBody = nextNodes[1];
            lowerBody.addNext(new Node<Exercise>(new List<Node<Exercise>>(), exercises[(int)EnumGroupLocation.UpperLeg]));
            lowerBody.addNext(new Node<Exercise>(new List<Node<Exercise>>(), exercises[(int)EnumGroupLocation.LowerLeg]));

            //Equipment and Exercises
            Node<Exercise> barbell = new Node<Exercise>();
            Node<Exercise> dumbbell = new Node<Exercise>();
            Node<Exercise> body = new Node<Exercise>();
            Node<Exercise> machine = new Node<Exercise>();

            List<List<Exercise>> equipExercises = TreeStructure.getBarbell();
            Node<Exercise> tempNode;
            List<Exercise> tempExercises = new List<Exercise>();

            //Push
            nextNodes = upperBody.getNext();
            Node<Exercise> push = nextNodes[0];
            //Barbell
            tempExercises = equipExercises[0];
            foreach (Exercise i in tempExercises)
            {
                tempNode = new Node<Exercise>(new List<Node<Exercise>>(), i);
                barbell.addNext(tempNode);
            }
            //Dumbbell
            foreach (Exercise i in tempExercises)
            {
                tempNode = new Node<Exercise>(new List<Node<Exercise>>(), i);
                dumbbell.addNext(tempNode);
            }
            //Body
            foreach (Exercise i in tempExercises)
            {
                tempNode = new Node<Exercise>(new List<Node<Exercise>>(), i);
                body.addNext(tempNode);
            }
            //Machine
            foreach (Exercise i in tempExercises)
            {
                tempNode = new Node<Exercise>(new List<Node<Exercise>>(), i);
                machine.addNext(tempNode);
            }
            push.addNext(barbell);
            push.addNext(dumbbell);
            push.addNext(body);
            push.addNext(machine);

            //Pull
            Node<Exercise> pull = nextNodes[1];
            //Barbell
            tempExercises = equipExercises[1];
            foreach (Exercise i in tempExercises)
            {
                tempNode = new Node<Exercise>(new List<Node<Exercise>>(), i);
                barbell.addNext(tempNode);
            }
            //Dumbbell
            foreach (Exercise i in tempExercises)
            {
                tempNode = new Node<Exercise>(new List<Node<Exercise>>(), i);
                dumbbell.addNext(tempNode);
            }
            //Body
            foreach (Exercise i in tempExercises)
            {
                tempNode = new Node<Exercise>(new List<Node<Exercise>>(), i);
                body.addNext(tempNode);
            }
            //Machine
            foreach (Exercise i in tempExercises)
            {
                tempNode = new Node<Exercise>(new List<Node<Exercise>>(), i);
                machine.addNext(tempNode);
            }
            pull.addNext(barbell);
            pull.addNext(dumbbell);
            pull.addNext(body);
            pull.addNext(machine);

            //Upper leg
            nextNodes = lowerBody.getNext();
            Node<Exercise> upperLeg = nextNodes[0];
            //Barbell
            tempExercises = equipExercises[1];
            foreach (Exercise i in tempExercises)
            {
                tempNode = new Node<Exercise>(new List<Node<Exercise>>(), i);
                barbell.addNext(tempNode);
            }
            //Dumbbell
            foreach (Exercise i in tempExercises)
            {
                tempNode = new Node<Exercise>(new List<Node<Exercise>>(), i);
                dumbbell.addNext(tempNode);
            }
            //Body
            foreach (Exercise i in tempExercises)
            {
                tempNode = new Node<Exercise>(new List<Node<Exercise>>(), i);
                body.addNext(tempNode);
            }
            //Machine
            foreach (Exercise i in tempExercises)
            {
                tempNode = new Node<Exercise>(new List<Node<Exercise>>(), i);
                machine.addNext(tempNode);
            }
            upperLeg.addNext(barbell);
            upperLeg.addNext(dumbbell);
            upperLeg.addNext(body);
            upperLeg.addNext(machine);

            //Lower leg
            Node<Exercise> lowerLeg = nextNodes[1];
            //Barbell
            tempExercises = equipExercises[1];
            foreach (Exercise i in tempExercises)
            {
                tempNode = new Node<Exercise>(new List<Node<Exercise>>(), i);
                barbell.addNext(tempNode);
            }
            //Dumbbell
            foreach (Exercise i in tempExercises)
            {
                tempNode = new Node<Exercise>(new List<Node<Exercise>>(), i);
                dumbbell.addNext(tempNode);
            }
            //Body
            foreach (Exercise i in tempExercises)
            {
                tempNode = new Node<Exercise>(new List<Node<Exercise>>(), i);
                body.addNext(tempNode);
            }
            //Machine
            foreach (Exercise i in tempExercises)
            {
                tempNode = new Node<Exercise>(new List<Node<Exercise>>(), i);
                machine.addNext(tempNode);
            }
            lowerLeg.addNext(barbell);
            lowerLeg.addNext(dumbbell);
            lowerLeg.addNext(body);
            lowerLeg.addNext(machine);
        }

        public static void setOpenList(PriorityQueue<Node<Exercise>, int> openlist)
        {
            openList = openlist;
        }

        public static PriorityQueue<Node<Exercise>, int> getOpenList()
        {
            return openList;
        }
    }
}