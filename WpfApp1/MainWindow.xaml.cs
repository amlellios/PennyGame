using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    //penny images from pixabay free images
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool PlayersChoice;
        bool ComputerChoice;
        int PlayersScore;
        int ComputersScore;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Heads_Click(object sender, RoutedEventArgs e)
        {
            PlayersChoice = true;
            PlayerPennyHeads.Visibility = Visibility.Visible;


        }

        private void Tails_Click(object sender, RoutedEventArgs e)
        {
            PlayersChoice = false;
            PlayerPennyTails.Visibility = Visibility.Visible;
            
        }
        
        

        private void Play_Click(object sender, RoutedEventArgs e)
        {
          
            if (PlayersChoice=ComputerChoice)
            {
                ComputersScore++;
                PlayersScore--;
                
            }
            else
            {
                ComputersScore++;
                PlayersScore--;
            }

           
                    
        }
    }
   
}
