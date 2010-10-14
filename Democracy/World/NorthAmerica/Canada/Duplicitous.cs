using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Democracy.Definitions;
using Democracy.Government;

namespace Democracy.World.NorthAmerica.Canada
{
    public class Duplicitous : IPolitician 
    {
        private IRiding riding;

        public Duplicitous( string name, IRiding riding )
        {
            Name = name;
            Riding = riding;
        }
        
        public string Name { get; private set; }

        public float ApprovalRating { get; private set; }

        public IPoliticalParty Party { get; set; }

        public IDepartment Ministry { get; set; }

        public bool HasPortfolio
        {
            get
            {
                return Ministry != null;
            }
        }

        public IRiding Riding
        {
            get { return riding; } 
            
            set
            {
                riding = value;
                ApprovalRating = CalculateApprovalRating();
            }
        }

        public float AdjustApprovalRating( float adjustment )
        {
            ApprovalRating += adjustment;
            return ApprovalRating;
        }

        public string GetSoundBite( Issue issue )
        {
            return DuplicitousConstitution.Responses[ issue ];
        }

        private float CalculateApprovalRating()
        {
            float rating = 0;

            foreach( KeyValuePair<Issue, float> issue in DuplicitousConstitution.IssueRatings )
            {
                 rating += riding.Populous.RateStanceOnIssue( issue.Key, issue.Value, 0 );
            }

            return rating / DuplicitousConstitution.IssueRatings.Count;
        }
    }

    class DuplicitousConstitution
    {
        public static IDictionary<Issue, string> Responses = new Dictionary<Issue, string>()
        {
            { Issue.Transportation, "Duplicitous response on Transportation" },
            { Issue.Abortion, "Duplicitous response on Abortion" },
            { Issue.Employment, "Duplicitous response on Employment" },
            { Issue.Energy, "Duplicitous response on Energy" },
            { Issue.HealthCare, "Duplicitous response on HealthCare" },
            { Issue.Taxes, "Duplicitous response on Taxes" }
        };

        public static IDictionary<Issue, float> IssueRatings = new Dictionary<Issue, float>()
        {
            { Issue.Transportation, 40 },
            { Issue.Abortion, -50 },
            { Issue.Employment, -80 },
            { Issue.Energy, -90 },
            { Issue.HealthCare, 10 },
            { Issue.Taxes, -95 }
        };
    }
}
