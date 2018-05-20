using GymCoach.Content;
using GymCoach.Content.Agent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GymCoach
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Exercise testExercise = new Exercise(10);
            Node<Exercise> tempNode = new Node<Exercise>(null, null, testExercise);

            PriorityQueue<Node<Exercise>, int> testQ = new PriorityQueue<Node<Exercise>, int>();

             testExercise = new Exercise(10);
            testQ.enqueue(new Node<Exercise>( null, null, testExercise), 10);

             testExercise = new Exercise(9);
            testQ.enqueue(new Node<Exercise>(null, null, testExercise), 9);

             testExercise = new Exercise(8);
            testQ.enqueue(new Node<Exercise>(null, null, testExercise), 8);
            testExercise = new Exercise(10);
            testQ.enqueue(new Node<Exercise>(null, null, testExercise), 10);

            testExercise = new Exercise(7);
            testQ.enqueue(new Node<Exercise>(null, null, testExercise), 7);

             testExercise = new Exercise(6);
            testQ.enqueue(new Node<Exercise>(null, null, testExercise), 6);
            testExercise = new Exercise(10);
            testQ.enqueue(new Node<Exercise>(null, null, testExercise), 10);

            testExercise = new Exercise(5);
            testQ.enqueue(new Node<Exercise>(null, null, testExercise), 5);

            int limit = testQ.numElements();
            for (int i = 0; i < limit; i++)
            {
                testPara.InnerHtml += "Position " + i + ": Number = " + testQ.dequeue().getElement().getNumMuscles() + "\n";
            }

            List<Exercise> exercises = new List<Exercise>();
            exercises = TreeStructure.getLowerBody();
            limit = exercises.Count();
            for (int i = 0; i < limit; i++)
            {
                testPara.InnerHtml += "Position " + i + ": Name = " + exercises[i].getExerciseName() + " - g("+ exercises[i].getGN() + ") + h("+ exercises[i].getHN() + ")\n";
            }
        }
    }
}