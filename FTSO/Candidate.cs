using System;

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