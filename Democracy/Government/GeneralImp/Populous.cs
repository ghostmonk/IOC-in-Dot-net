using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Democracy.Definitions;

namespace Democracy.Government.GeneralImp
{
    public class Populous : Entity, IPopulous
    {
        private Dictionary<Issue, double> issues;

        public Populous( string name ) : base( name )
        {
            issues = new Dictionary<Issue, double>();
        }

        public double BipartisanRating { get; set; }

        public void AddImportantIssue( Issue issue, double importance )
        {
            issues[ issue ] = importance;
        }

        public double RateStanceOnIssue( Issue issue, double polarity, double modifier )
        {
            return new Random().Next();
        }
    }
}
