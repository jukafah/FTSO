using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json.Linq;

namespace FTSO
{
    internal class Program
    {


        public static void Main(string[] args)
        {
            Console.Write("Candidate Name: ");
            string candidateName = Console.ReadLine();
            
            Console.Write("Interviewed By: ");
            string interviewedBy = Console.ReadLine();

            
            Candidate candidate = new Candidate(candidateName, interviewedBy);

          
            // commands off candidate?
            candidate.GiveFeedback();
        }
    }
}