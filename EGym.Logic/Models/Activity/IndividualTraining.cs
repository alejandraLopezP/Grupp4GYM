﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGym.Logic.Models.Activity
{
    public class IndividualTraining : Activity
    {
        public IndividualTraining(DateTime startTime, DateTime bookningDate, int duration, int id) 
                : base(startTime, bookningDate, duration, id)
        {

        }

        public override string GetActivityType()
        {
            return "IndividualActivity";
        }
    }
}
