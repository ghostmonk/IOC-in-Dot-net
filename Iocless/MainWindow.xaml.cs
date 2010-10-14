using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Democracy.Definitions;
using Democracy.Government;
using Democracy.World.NorthAmerica.Canada;

namespace Iocless
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ICountry canada;
        
        public MainWindow()
        {
            InitializeComponent();

            canada = new Canada();
            IPoliticalParty conservatives = new Conservatives();
            IPopulous montrealPopulous = new MontrealPopulous();
            IDepartment healthWorks = new PublicHealthWorks();

            IRiding montreal = new Montreal( montrealPopulous );
            IPolitician harper = new Duplicitous( "Steven Harper", montreal );
            IGovernment canadianGovernment = new CanadianGovernment( canada );

            IBureaucrat inspector = new Inspector( "William Jones", healthWorks, ManagementStyle.Autocratic );
            IBureaucrat drone = new Drone( "Conway Jackson", healthWorks, ManagementStyle.Consultative );

            montreal.ElectedRepresentative = harper;
            montreal.MostImportantIssue = Issue.Taxes;
            
            conservatives.Leader = harper;
            harper.Ministry = healthWorks;
            harper.Party = conservatives;
            harper.AdjustApprovalRating( 50 );

            healthWorks.AddBureaucrat( inspector ).AddBureaucrat( drone );
            
            canada.Government = canadianGovernment;
            canada.AddRiding( montreal );

            canadianGovernment.AddPoliticalParty( conservatives );
            canadianGovernment.AddDepartment( healthWorks );
        }

        private void OnCallElectionClick( object sender, RoutedEventArgs e )
        {
            canada.Government.CallElection();
            controllingPartyLbl.Content = canada.Government.PartyInPower.Name;
        }

        private void OnQetQuote( object sender, RoutedEventArgs e )
        {

        }

        private void OnPartySelection( object sender, SelectionChangedEventArgs e )
        {

        }
    }
}
