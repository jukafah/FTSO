using System;
using System.IO;
using System.Reflection;
using Newtonsoft.Json.Linq;

namespace FTSO.Model
{
    public class Roles
    {
        private readonly JObject roles;
        
        private Roles()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();

            Stream roleStream = assembly.GetManifestResourceStream("FTSO.Resources.roles.json");
            if (roleStream == null)
                throw new NullReferenceException("Could not find roles.json");

            StreamReader roleStreamReader = new StreamReader(roleStream);
            roles = JObject.Parse(roleStreamReader.ReadToEnd());
        }

        public JObject Get()
        {
            return roles;
        }

        public void Enter()
        {
            throw new NotImplementedException();
        }
        
    }
}