using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic
{
    public class Patient : TreatmentPlan
    {
        public override int treatmentPlan { get => base.treatmentPlan; set => base.treatmentPlan = value; }
        public Patient(int deseaseCode) 
        {
            treatmentPlan = deseaseCode;
        }
        public void DocApoitment( ) 
        {
            if (treatmentPlan == 1)
            {
                Surgeon chiropractor = new Surgeon();
                chiropractor.medication(treatmentPlan);
            }
            if (treatmentPlan == 2)
            {
                Dentist teethDoctoir = new Dentist();
                teethDoctoir.medication(treatmentPlan);
            }
            if (treatmentPlan == 3)
            {
                Therapist soresDoctor = new Therapist();
                soresDoctor.medication(treatmentPlan);
            }


        }
    }
}
