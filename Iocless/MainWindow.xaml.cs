using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using Democracy.Government.GeneralImp;
using Democracy.World.NorthAmerica.Canada;

namespace Iocless
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private ICountry canada;

        public MainWindow()
        {
            InitializeComponent();

            Canada = CountryFactory.GetCanada();
            partiesCB.ItemsSource = Canada.Government.PoliticalParties;
            CallElection();
        }

        public ICountry Canada { get; set; }

        private void CallElection()
        {
            Canada.Government.CallElection();
            controllingPartyLbl.Content = Canada.Government.PartyInPower.Name;
        }

        private void OnCallElectionClick( object sender, RoutedEventArgs e )
        {
            CallElection();
        }

        private void OnQetQuote( object sender, RoutedEventArgs e )
        {

        }

        private void OnPartySelection( object sender, SelectionChangedEventArgs e )
        {

        }

        protected void OnPropertyChanged( string propertyName )
        {
            var handler = PropertyChanged;
            if( handler != null ) handler( this, new PropertyChangedEventArgs( propertyName ) );
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
