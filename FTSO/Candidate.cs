using System;
using System.IO;
using System.Reflection;
using Newtonsoft.Json.Linq;

namespace FTSO
{
    public class Candidate
    {
        private const string SkillWeight = "skillWeight";
        private const string MinimumSkill = "minimumSkill";
        
        private string candidateName;
        private string interviewedBy;
        
        public Candidate(string candidateName, string interviewedBy)
        {
            this.candidateName = candidateName;
            this.interviewedBy = interviewedBy;
        }


        public void GiveFeedback()
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
           
            
            
            try
            {
                foreach (var skill in skills)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Key: {skill.Key}");
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
        }
    }
}