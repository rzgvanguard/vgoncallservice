using System;
using System.Collections.Generic;
using FirstApp.Entities;

namespace FirstApp.Services
{
    public static class CrewDataService
    {
        public static List<BaseCrew> GetCrewData() {
            List<BaseCrew> retList = new List<BaseCrew>();

            Manager m1 = new Manager
            {
                CrewId = "89201",
                CrewEmail = "mcavallo@vanguard.com",
                CrewExtension = "55545",
                CrewPhoneNumber = "4435680439",
                FirstName = "Michael",
                LastName = "Cavallo",
                ProductList = new List<ProductData>
                {
                    new ProductData { ProductName = "Balances and Holdings",
                        ProductOwner = "Theresa Young",
                        TechnicalOwner = "Michael Cavallo" },
                    new ProductData { ProductName = "Address",
                        ProductOwner = "Theresa Young",
                        TechnicalOwner = "Michael Cavallo" },
                    new ProductData { ProductName = "Portfolio Watch",
                        ProductOwner = "Theresa Young",
                        TechnicalOwner = "Michael Cavallo" }
                }
            };

            ProjectManager pm1 = new ProjectManager
            {
                CrewEmail = "Jae@vanguard.com",
                FirstName = "Jae",
                LastName = "Lee",
                CrewExtension = "99341",
                CrewPhoneNumber = "22049385550",
                ManagerId = m1.CrewId,
                CrewId = "10592"
            };

            CrewData c1 = new CrewData();
            CrewData c2 = new CrewData();
            CrewData c3 = new CrewData();
            CrewData c4 = new CrewData();
            CrewData c5 = new CrewData();
            CrewData c6 = new CrewData();
            CrewData c7 = new CrewData();
            CrewData c8 = new CrewData();
            CrewData c9 = new CrewData();
            CrewData c10 = new CrewData();

            retList.Add(c1);
            retList.Add(c2);
            retList.Add(c3);
            retList.Add(c4);
            retList.Add(c5);
            retList.Add(c6);
            retList.Add(c7);
            retList.Add(c8);
            retList.Add(c9);
            retList.Add(c10);
            // retList.Add(m1);
            // retList.Add(pm1);

            c1.FirstName = "Yumi";
            c1.LastName = "Yu";
            c1.CrewExtension = "83942";
            c1.CrewManagerId = m1.CrewId;
            c1.CrewPMId = pm1.CrewId;
            c1.CrewEmail = "yumi_yu@vanguard.com";
            c1.CrewPhoneNumber = "2839482127";
            c1.CrewId = "12345";

            c2.FirstName = "Alex";
            c2.LastName = "Jones";
            c2.CrewExtension = "77483";
            c2.CrewManagerId = m1.CrewId;
            c2.CrewPMId = pm1.CrewId;
            c2.CrewEmail = "alex_jones@vanguard.com";
            c2.CrewPhoneNumber = "1039459304";
            c2.CrewId = "23456";

            c3.FirstName = "Jack";
            c3.LastName = "Son";
            c3.CrewExtension = "88293";
            c3.CrewManagerId = m1.CrewId;
            c3.CrewPMId = pm1.CrewId;
            c3.CrewEmail = "jack_son@vanguard.com";
            c3.CrewPhoneNumber = "3049587302";
            c3.CrewId = "34567";

            c4.FirstName = "Lauren";
            c4.LastName = "Haggle";
            c4.CrewExtension = "11039";
            c4.CrewManagerId = m1.CrewId;
            c4.CrewPMId = pm1.CrewId;
            c4.CrewEmail = "lauren_haggle@vanguard.com";
            c4.CrewPhoneNumber = "1043998930";
            c4.CrewId = "45678";

            c5.FirstName = "Arthor";
            c5.LastName = "Ash";
            c6.CrewExtension = "20394";
            c5.CrewManagerId = m1.CrewId;
            c5.CrewPMId = pm1.CrewId;
            c5.CrewEmail = "arthor_ash@vanguard.com";
            c5.CrewPhoneNumber = "1034931098";
            c5.CrewId = "77458";

            c6.FirstName = "Thor";
            c6.LastName = "Ragnorok";
            c7.CrewExtension = "920387";
            c6.CrewManagerId = m1.CrewId;
            c6.CrewPMId = pm1.CrewId;
            c6.CrewEmail = "thor_ragnorok@vanguard.com";
            c6.CrewPhoneNumber = "7069854730";
            c6.CrewId = "92034";

            c7.FirstName = "Peter";
            c7.LastName = "Parker";
            c7.CrewExtension = "77869";
            c7.CrewManagerId = m1.CrewId;
            c7.CrewPMId = pm1.CrewId;
            c7.CrewEmail = "peter_parker@vanguard.com";
            c7.CrewPhoneNumber = "9074520980";
            c7.CrewId = "11830";

            c8.FirstName = "Brandon";
            c8.LastName = "Bjergson";
            c8.CrewExtension = "20394";
            c8.CrewManagerId = m1.CrewId;
            c8.CrewPMId = pm1.CrewId;
            c8.CrewEmail = "brandon_bjergson@vanguard.com";
            c8.CrewPhoneNumber = "6098753200";
            c8.CrewId = "75982";

            c9.FirstName = "Zack";
            c9.LastName = "Johnson";
            c9.CrewExtension = "90125";
            c9.CrewManagerId = m1.CrewId;
            c9.CrewPMId = pm1.CrewId;
            c9.CrewEmail = "zack_johnson@vanguard.com";
            c9.CrewPhoneNumber = "30234534908";
            c9.CrewId = "22309";

            c10.FirstName = "Akiko";
            c10.LastName = "Yokosama";
            c10.CrewExtension = "50184";
            c10.CrewManagerId = m1.CrewId;
            c10.CrewPMId = pm1.CrewId;
            c10.CrewEmail = "akiko_yokosama@vanguard.com";
            c10.CrewPhoneNumber = "3027784747";
            c10.CrewId = "88930";

            return retList;
        }
    }
}
