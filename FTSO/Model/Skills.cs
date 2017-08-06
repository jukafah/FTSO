using System;
using System.IO;
using System.Reflection;
using Newtonsoft.Json.Linq;

namespace FTSO.Model
{
    public class Skills
    {
        private readonly JObject skills;
        private JObject candidateSkills;
        
        private Skills()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();

            Stream roleStream = assembly.GetManifestResourceStream("FTSO.Resources.skills.json");
            if (roleStream == null)
                throw new NullReferenceException("Could not find skills.json");

            StreamReader roleStreamReader = new StreamReader(roleStream);
            skills = JObject.Parse(roleStreamReader.ReadToEnd());
        }

        public JObject Get()
        {
            return skills;
        }

        public void Enter()
        {
            throw new NotImplementedException();
        }
        
    }
}