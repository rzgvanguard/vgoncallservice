using System;
using System.Collections.Generic;

namespace FirstApp.Entities
{
    public class CrewData : BaseCrew
    {
        public String CrewManagerId
        {
            get;
            set;
        }
        public String CrewPMId
        {
            get;
            set;
        }
        public string CrewId { get; set; }
        public string CrewEmail { get; set; }
        public string CrewPhoneNumber { get; set; }
        public string CrewExtension { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<int> OnCallDays { get; set; }

        public CrewData()
        {
        }
    }
}
