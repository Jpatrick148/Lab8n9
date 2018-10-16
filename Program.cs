using System;
using System.Collections.Generic;

namespace Lab_8n9
{
    class Program
    {
        static void Main(string[] args)
        {
            

            List<StudentInfo> info = new List<StudentInfo>();

            StudentInfo s = new StudentInfo("Katie", "Grand Rapids","Indian");
            info.Add(s);
            StudentInfo s1 = new StudentInfo("Andrew","Grand Haven","Chicken Wings");
            info.Add(s1);
            StudentInfo s2 = new StudentInfo("Chuck","Ripon","Almonds");
            info.Add(s2);
            StudentInfo s3 = new StudentInfo("Jonathan","Alger","Tres Leche");
            info.Add(s3);
            StudentInfo s4 = new StudentInfo("Tommy","Raleigh","Buttered Toast");
            info.Add(s4);
            StudentInfo s5 = new StudentInfo("Jeremy","Milwaukee","Peanut Butter");
            info.Add(s5);
            StudentInfo s6 = new StudentInfo("Joseph","Grand Rapids","Burritos");
            info.Add(s6);
            StudentInfo s7 = new StudentInfo("Justin","Wyoming","BURGER");
            info.Add(s7);
            StudentInfo s8 = new StudentInfo("Sean","Grand Rapids","BBQ");
            info.Add(s8);
            StudentInfo s9 = new StudentInfo("Kelsey","Grand Rapids","Grits");
            info.Add(s9);

            int sNumber;
            int totalIndex = info.Count;
            bool indexCheck;

            do
            {                               
                Console.WriteLine("Hello! Which student would you like to learn about? (Enter a number 0-{0}.)",
                    totalIndex);
                string userIndex = Console.ReadLine();
                indexCheck = int.TryParse(userIndex, out sNumber);
                if (!indexCheck)
                {
                    Console.WriteLine("Please enter a number between 0 and {0}", totalIndex);
                }
                else if (sNumber > totalIndex)
                {
                    indexCheck = false;
                    Console.WriteLine("Please enter a number between 0 and {0}", totalIndex);
                }
                
            } while (!indexCheck);

            Console.WriteLine(sNumber);

            info.GetFirstName();

         
            Console.ReadLine();

        }

    }

    public class StudentInfo
    {
        public StudentInfo(string firstName, string location,string favFood)
        {
            FirstName = firstName;           
            Location = location;
            FavFood = favFood;
        }
        public string FirstName { set; get; }
        public string Location { set; get; }
        public string FavFood { set; get; }

        public void SetFirstName(string name)
        {
            this.FirstName = name;
        }

        public string GetFirstName()
        {
            return this.FirstName;
        }


    }


}
