using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GymCoach.Content.Agent
{
    //The weighting of using a piece of equipment
    //Lower number of items/objects used is better
    //Machine is stabilised and doesnt require as much engagement from user
    public enum EnumHEquipment
    {
        Barbell = 1,
        Dumbbell = 2,
        Kettlebell = 2,
        Machine = 2
    }
}