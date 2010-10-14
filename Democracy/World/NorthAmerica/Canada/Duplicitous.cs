using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Democracy.Definitions;
using Democracy.Government;
using Democracy.Government.GeneralImp;

namespace Democracy.World.NorthAmerica.Canada
{
    public class Duplicitous : Politician, IPolitician 
    {
        private IRiding riding;

        public Duplicitous( string name, IRiding riding ) : base( name )
        {
            Riding = riding;
        }

        override public IRiding Riding
        {
            get { return riding; } 
            
            set
            {
                riding = value;
                ApprovalRating = CalculateApprovalRating();
            }
        }

        override public string GetSoundBite( Issue issue )
        {
            return DuplicitousConstitution.Responses[ issue ];
        }

        private double CalculateApprovalRating()
        {
            double rating = 0;

            foreach( KeyValuePair<Issue, double> issue in DuplicitousConstitution.IssueRatings )
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

        public static IDictionary<Issue, double> IssueRatings = new Dictionary<Issue, double>()
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
