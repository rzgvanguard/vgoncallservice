using System;
using System.Collections.Generic;

namespace FirstApp.Entities
{
    public class BaseCrew
    {
        public String CrewId
        {
            get;
            set;
        }

        public String CrewEmail
        {
            get;
            set;
        }

        public String CrewPhoneNumber
        {
            get;
            set;
        }

        public String CrewExtension
        {
            get;
            set;
        }

        public String FirstName
        {
            get;
            set;
        }

        public String LastName
        {
            get;
            set;
        }

        public List<int> OnCallDays
        {
            get;
            set;
        }

        public BaseCrew()
        {
        }
    }
}
