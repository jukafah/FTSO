using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Newtonsoft.Json.Linq;

namespace FTSO
{
    public class Candidate
    {
        private string candidateName;
        private string interviewedBy;
        
        
        public Candidate(string candidateName, string interviewedBy)
        {
            this.candidateName = candidateName;
            this.interviewedBy = interviewedBy;
        }

        private void LoadRoles()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();

            StreamReader roleStreamReader =
                new StreamReader(assembly.GetManifestResourceStream("FTSO.Resources.roles.json")
            );
            JObject roles = JObject.Parse(roleStreamReader.ReadToEnd());
            
            try
            {
                foreach (var role in roles)
                {
                    Console.WriteLine();
                    Console.WriteLine($"role key: {role.Key}");
                    Console.WriteLine($"Minimum Skill Level for role: {role.Value}");
                    Console.WriteLine();
                }
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Stop messing with the roles configuration!");
                throw;
            }
        }


        private void LoadSkills()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            
            // todo: perhaps these should be dictionaries?
            StreamReader skillStreamReader = new StreamReader(
                assembly.GetManifestResourceStream("FTSO.Resources.skills.json")
            );
            JObject skills = JObject.Parse(skillStreamReader.ReadToEnd());
           
            Dictionary<string, int> candidateSkills = new Dictionary<string, int>();
            
            try
            {
                foreach (var skill in skills)
                {
                    
//                    Console.Write("Enter a value for X (int): ");
//                    while (!int.TryParse(Console.ReadLine(), out x))
//                        Console.Write("The value must be of integer type, try again: ");
                    int skillValue;
                    
                    
                    do {
                        Console.Write($"{skill.Key}: ");
                    } while (!int.TryParse(Console.ReadLine(), out skillValue));
                    
//                    Console.Write($"{skill.Key}: ");
//                    while (!int.TryParse(Console.ReadLine(), out skillValue))
//                        Console.Write("Use a number you goof");
                    
//                    Console.Write($"{skill.Key}: ");
//                    string skillValue = Console.ReadLine();
//                    candidateSkills.Add(skill.Key,  Int16.Parse(skillValue));
                    
                    
//                    Console.WriteLine();
//                    Console.WriteLine($"Key: {skill.Key}");
//                    Console.WriteLine($"Skill Weight: {skill.Value}");
//                    Console.WriteLine();
                }
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Stop messing with the skill weight configuration!");
                throw;
            }
        }


        public void GiveFeedback()
        {
            
            LoadRoles();
            LoadSkills();

            // because it's not done
            throw new NotImplementedException("Finish the program!");
        }

        public void CalculateRole()
        {
            throw new NotImplementedException();
        }
        
        public void EnterSkills()
        {
            throw new NotImplementedException();
        }
    }
}