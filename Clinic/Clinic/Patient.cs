using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic
{
    public class Patient 
    {
        public TreatmentPlan Plan { get; set; }
        public Patient(int deseaseCode) 
        {
            Plan =new TreatmentPlan(deseaseCode);
        }
        public void DocApoitment( ) 
        {
            if (Plan.TreatmentPlanForDoc == 1)
            {
                Surgeon chiropractor = new Surgeon();
                chiropractor.Medication(Plan.TreatmentPlanForDoc);
            }
            if (Plan.TreatmentPlanForDoc == 2)
            {
                Dentist teethDoctoir = new Dentist();
                teethDoctoir.Medication(Plan.TreatmentPlanForDoc);
            }
            if (Plan.TreatmentPlanForDoc == 3)
            {
                Therapist soresDoctor = new Therapist();
                soresDoctor.Medication(Plan.TreatmentPlanForDoc);
            }


        }
    }
}
