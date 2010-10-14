using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Democracy.Definitions;

namespace Democracy.Government.GeneralImp
{
    public class Politician : Entity, IPolitician
    {
        public Politician( string name ) : base( name ) {}

        public virtual IRiding Riding { get; set; }

        public virtual IPoliticalParty Party { get; set; }

        public virtual IDepartment Ministry { get; set; }

        public virtual double ApprovalRating { get; set; }

        public virtual bool HasPortfolio
        {
            get { return Ministry != null; }
        }

        public virtual double AdjustApprovalRating( double adjustment )
        {
            ApprovalRating += adjustment;
            return ApprovalRating;
        }

        public virtual string GetSoundBite( Issue issue )
        {
            return "I am a douche bag.";
        }
    }
}
