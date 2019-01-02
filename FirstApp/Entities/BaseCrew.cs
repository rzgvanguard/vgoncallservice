using System;
using System.Collections.Generic;

namespace FirstApp.Entities
{
    public interface BaseCrew
    {
        String CrewId
        {
            get;
            set;
        }

        String CrewEmail
        {
            get;
            set;
        }

        String CrewPhoneNumber
        {
            get;
            set;
        }

        String CrewExtension
        {
            get;
            set;
        }

        String FirstName
        {
            get;
            set;
        }

        String LastName
        {
            get;
            set;
        }

        List<int> OnCallDays
        {
            get;
            set;
        }
    }
}
