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
        private const string SkillWeight = "skillWeight";
        private const string MinimumSkill = "minimumSkill";
        
        public static void Main(string[] args)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            
            StreamReader skillStreamReader = new StreamReader(
                assembly.GetManifestResourceStream("FTSO.Resources.skills.json")
            );
            JObject skills = JObject.Parse(skillStreamReader.ReadToEnd());

            StreamReader roleStreamReader =
                new StreamReader(assembly.GetManifestResourceStream("FTSO.Resources.roles.json")
            );
            JObject roles = JObject.Parse(roleStreamReader.ReadToEnd());
           
            
            Console.WriteLine("Candidate Name");

           


//            Console.WriteLine("Candidate Name");
//            string nameOfCandidate = Console.ReadLine();
//            
//            Console.WriteLine("Interviewers");
//            List<String> interviewers = Console.ReadLine().Split(',').ToList();
//            
//            Console.WriteLine();
//            Console.WriteLine($"The candidate was: {nameOfCandidate}");
//            Console.WriteLine();
//            Console.WriteLine($"And was interviewed by: {interviewers}");


            try
            {
                foreach (var skill in skills)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Key: {skill.Key}");
//                Console.WriteLine($"Skill Weight: {(int)skill.Value.SelectToken("weight")}");
                    Console.WriteLine($"Skill Weight: {(int) skill.Value.SelectToken(SkillWeight)}");
                    Console.WriteLine();
                }
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("poopfish");
                throw;
            }


            foreach (var role in roles)
            {
                Console.WriteLine();
                Console.WriteLine($"role key: {role.Key}");
                Console.WriteLine($"Minimum Skill Level for role: {(int)role.Value.SelectToken(MinimumSkill)}");
                Console.WriteLine();
            }

//            Console.WriteLine("Candidate Name:");
//            string input = Console.ReadLine();
//            
//            Console.Write($"Yout typed {input}");
//            Console.WriteLine();
//            Console.WriteLine();
        }
    }
}