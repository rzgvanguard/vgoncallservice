using System;
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
        public CrewData()
        {
        }
    }
}
