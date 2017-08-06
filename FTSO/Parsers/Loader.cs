using System.IO;
using System.Reflection;
using Newtonsoft.Json.Linq;

namespace FTSO.Parsers
{
    public class Loader
    {
        private Assembly assembly;
        private StreamReader streamReader;
        
        public Loader()
        {
            assembly = Assembly.GetExecutingAssembly();
        }
        
        
        

//        public JObject LoadRoles()
//        {
////            Assembly assembly = Assembly.GetExecutingAssembly();
//
////            StreamReader roleStreamReader =
////                new StreamReader(assembly.GetManifestResourceStream("FTSO.Resources.roles.json")
////                );
////            return JObject.Parse(roleStreamReader.ReadToEnd());
//        }
    }
}