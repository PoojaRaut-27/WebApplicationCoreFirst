using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationCoreFirst.Data;

namespace WebApplicationCoreFirst.ExtensionClass
{
    public static class ExtMethods
    {
        public static void ResultMyDB(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudResult>().HasData
                    (
                        new StudResult
                        {
                            RollNo = 1,
                            StudName = "Tejas",
                            BoardName = "Pune Univercity",
                            M1 = 45,
                            M2 = 56,
                            M3 = 78,
                            TotalMarks = 179,
                            Status = "Pass"
                ,
                            Greeting = "Congratulation"

                        },
                        new StudResult
                        {
                            RollNo = 2,
                            StudName = "Jay",
                            BoardName = "Pune Univercity",
                            M1 = 78,
                            M2 = 89,
                            M3 = 56,
                            TotalMarks = 223,
                            Status = "Pass"
                ,
                            Greeting = "Congratulation"

                        },
             new StudResult
             {
                 RollNo = 3,
                 StudName = "Mira",
                 BoardName = "Pune University",
                 M1 = 40,
                 M2 = 45,
                 M3 = 43,
                 TotalMarks = 128,
                 Status = "Pass"
                ,
                 Greeting = "Congratulation"

             },
              new StudResult
              {
                  RollNo = 4,
                  StudName = "rAMESH",
                  BoardName = "Pune Univercity",
                  M1 = 23,
                  M2 = 34,
                  M3 = 35,
                  TotalMarks = 91,
                  Status = "Fail"
                ,
                  Greeting = "Better Luck next"

              }
           );


        }
       // StudResult[] GetResult = new StudResult[]
       

    }
}
