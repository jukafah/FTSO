using System;

namespace FTSO.Controller
{
    public class Feedback
    {
        private String candidateName;
        private String interviewedBy;
        
        public Feedback()
        {          
            bool flag0 = true; 

            do
            {
                Console.Write("Candidate Name: ");
                string name = Console.ReadLine();

                if (!String.IsNullOrEmpty(name))
                {
                    // maybe re-execute same method?
                    candidateName = name;
                    flag0 = false;
                }
                else
                {
                    // false logic
                    Console.WriteLine("Please enter a name.");
                }
            } while (flag0);

            bool flag1 = true;

            do
            {
                Console.Write("Interviewed By: ");
                string interviewer = Console.ReadLine();

                if (!String.IsNullOrEmpty(interviewer))
                {
                    interviewedBy = interviewer;
                    flag1 = false;
                }
                else
                {
                    // false logic
                    Console.WriteLine("Please enter an interviewer.");
                }
            } while (flag1);

        }

        public void Generate()
        {
            throw new NotImplementedException();
        } 

        public void Enter()
        {
            throw new NotImplementedException();
        }
    }
}