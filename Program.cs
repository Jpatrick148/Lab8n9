using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Lab_8n9
{
    class Program
    {
        static void Main(string[] args)
        {
            

            List<Student> info = new List<Student>();

            Student s = new Student("Katie", "Grand Rapids","Indian");
            info.Add(s); 
            Student s1 = new Student("Andrew","Grand Haven","Chicken Wings");
            info.Add(s1); 
            Student s2 = new Student("Chuck","Ripon","Almonds");
            info.Add(s2);
            Student s3 = new Student("Jonathan","Alger","Tres Leche");
            info.Add(s3);
            Student s4 = new Student("Tommy","Raleigh","Buttered Toast");
            info.Add(s4);
            Student s5 = new Student("Jeremy","Milwaukee","Peanut Butter");
            info.Add(s5);
            Student s6 = new Student("Joseph","Grand Rapids","Burritos");
            info.Add(s6);
            Student s7 = new Student("Justin","Wyoming","BURGER");
            info.Add(s7);
            Student s8 = new Student("Sean","Grand Rapids","BBQ");
            info.Add(s8);
            Student s9 = new Student("Kelsey","Grand Rapids","Grits");
            info.Add(s9);

            int sNumber;
            int totalIndex = info.Count-1;
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

            //for (int i = 0; i < info.Count; i++)
            //{
            //    Student a = info[i];
            //    Console.WriteLine(i + " " +a.GetName());

            //}

            Student picked = info[sNumber];

            Console.WriteLine(picked.GetName());

            Console.WriteLine("What would you like to know?");
            Console.WriteLine("1) Home Town");
            Console.WriteLine("2) Favorite Food");
            string fh = Console.ReadLine();

            if (fh == "1")
            {
                Console.WriteLine(picked.GetName() + " Home Town is " + picked.GetFood());
            }
            else if (fh == "2")
            {
                Console.WriteLine(picked.GetName() + " Favorite food is " + picked.GetHomeTown());
            }
            


            //Console.WriteLine(picked.GetFood());
            //Console.WriteLine(picked.GetHomeTown());

            
            
            Console.ReadLine();

        }

    }

    //public class StudentInfo
    //{
      

    //    public StudentInfo(string firstName, string location,string favFood)
    //    {
    //        FirstName = firstName;           
    //        Location = location;
    //        FavFood = favFood;
    //    }
    //    public string FirstName { set; get; }
    //    public string Location { set; get; }
    //    public string FavFood { set; get; }

    //    public void SetFirstName(string name)
    //    {
    //        this.FirstName = name;
    //    }

    //    public string GetFirstName()
    //    {
    //        return this.FirstName;
    //    }

        




    //}


}
