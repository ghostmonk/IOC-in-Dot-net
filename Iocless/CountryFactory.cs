using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Democracy.Definitions;
using Democracy.Government;
using Democracy.Government.GeneralImp;
using Democracy.World.NorthAmerica.Canada;

namespace Iocless
{
    class CountryFactory
    {
        public static ICountry GetCanada()
        {
            ICountry canada = new Canada();
            IGovernment canadianGovernment = new CanadianGovernment( canada );
            canada.Government = canadianGovernment;

            IPoliticalParty greens = CreateGreenParty();
            IPoliticalParty liberals = CreateLiberalParty();
            IPoliticalParty conservatives = CreateConservativeParty();

            canadianGovernment.AddPoliticalParty( greens );
            canadianGovernment.AddPoliticalParty( liberals );
            canadianGovernment.AddPoliticalParty( conservatives );

            IDepartment healthMinistry = CreatePublicHealth();
            canadianGovernment.AddDepartment( healthMinistry );

            foreach( IPoliticalParty party in canadianGovernment.PoliticalParties )
            {
                party.Leader.Ministry = healthMinistry;
                canada.AddRiding( party.Leader.Riding );
            }

            return canada;
        }

        private static IPoliticalParty CreateGreenParty()
        {
            PartyConfig config = new PartyConfig
            {
                Name = "Greens",
                PartyType = PartyType.Green,
                RidingName = "City of Montreal",
                Population = 3000000,
                ImportantIssue = Issue.Taxes,
                PopulousBipartisanRating = -49,
                PopulousName = "Montreal",
                Leader = new PoliticianStats { Name = "Jesse Helms", Approval = 60 },
                LeftHandMan = new PoliticianStats { Name = "Fred Frum", Approval = 35 },
                RightHandMan = new PoliticianStats { Name = "Jersy Core", Approval = 40 },
            };

            return GetParty( config );
        }

        private static IPoliticalParty CreateConservativeParty()
        {
            PartyConfig config = new PartyConfig
            {
                Name = "Conservatives",
                PartyType = PartyType.Conservative,
                RidingName = "Calgary",
                Population = 1000000,
                ImportantIssue = Issue.Energy,
                PopulousBipartisanRating = 20,
                PopulousName = "District of Calgary",
                Leader = new PoliticianStats { Name = "Stephen Harper", Approval = 55 },
                LeftHandMan = new PoliticianStats { Name = "Kevin Jones", Approval = 35 },
                RightHandMan = new PoliticianStats { Name = "Whillem Jefferies", Approval = 22 },
            };

            return GetParty( config );
        }

        private static IPoliticalParty CreateLiberalParty()
        {
            PartyConfig config = new PartyConfig
            {
                Name = "Liberals",
                PartyType = PartyType.Liberal,
                RidingName = "Toronto",
                Population = 6000000,
                ImportantIssue = Issue.HealthCare,
                PopulousBipartisanRating = -20,
                PopulousName = "City of Toronto",
                Leader = new PoliticianStats { Name = "Michael Ignatieff", Approval = 32 },
                LeftHandMan = new PoliticianStats { Name = "Bob Sagat", Approval = 67 },
                RightHandMan = new PoliticianStats { Name = "John Secada", Approval = 10 },
            };

            return GetParty( config );
        }

        private static IDepartment CreatePublicHealth()
        {
            IDepartment healthWorks = new PublicHealthWorks();
            IBureaucrat inspector = new Inspector( "William Jones", healthWorks, ManagementStyle.Autocratic );
            IBureaucrat drone = new Drone( "Conway Jackson", healthWorks, ManagementStyle.Consultative );
            healthWorks.AddBureaucrat( inspector ).AddBureaucrat( drone );

            return healthWorks;
        }

        private static IPoliticalParty GetParty( PartyConfig config )
        {
            PoliticalParty party = new PoliticalParty( config.Name )
            {
                Type = config.PartyType
            };

            IPopulous populous = new Populous( config.PopulousName )
            {
                BipartisanRating = config.PopulousBipartisanRating
            };

            IRiding riding = new Riding( config.RidingName, populous )
            {
                Population = config.Population,
                MostImportantIssue = config.ImportantIssue
            };

            Politician leader = new Duplicitous( config.Leader.Name, riding )
            {
                ApprovalRating = config.Leader.Approval,
                Party = party
            };

            Politician rightHandMan = new Duplicitous( config.RightHandMan.Name, riding )
            {
                ApprovalRating = config.RightHandMan.Approval,
                Party = party
            };

            Politician leftHandMan = new Politician( config.LeftHandMan.Name )
            {
                ApprovalRating = config.LeftHandMan.Approval,
                Party = party,
                Riding = riding
            };

            riding.ElectedRepresentative = leader;

            party
                .AddPolitician( rightHandMan )
                .AddPolitician( leftHandMan )
                .Leader = leader;

            return party;
        }

        private class PartyConfig
        {
            public string Name;
            public string PopulousName;
            public double PopulousBipartisanRating;
            public string RidingName;
            public int Population;
            public Issue ImportantIssue;
            public PartyType PartyType;
            public PoliticianStats Leader;
            public PoliticianStats RightHandMan;
            public PoliticianStats LeftHandMan;
        }

        private class PoliticianStats
        {
            public string Name;
            public Double Approval;
        }
    }
}
