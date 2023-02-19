using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic
{
    public class TreatmentPlan 
    {
        public  int TreatmentPlanForDoc { get; set; } = 0;
        public TreatmentPlan(int initTreatmentPlan) { TreatmentPlanForDoc = initTreatmentPlan;  }

    }
}
