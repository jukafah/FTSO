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
    }
}