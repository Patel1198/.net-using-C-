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
using System.Windows.Shapes;

namespace MTJayPatel
{
    /// <summary>
    /// Interaction logic for ViewHockeyPlayer.xaml
    /// </summary>
    public partial class ViewHockeyPlayer : Window
    {
        private List<HockeyPlayer> hockeyPlayers;
        public ViewHockeyPlayer()
        {
            InitializeComponent();
            Closing += Window_Closing;

            hockeyPlayers = new List<HockeyPlayer>()
            {
                new HockeyPlayer(0, PlayerType.HockeyPlayer, "Ricardo", "Toronto Maple Leafs", 30, 50, 34),
                new HockeyPlayer(1, PlayerType.HockeyPlayer, "Viktor Arvidsson", "Edmonton Oilers", 10, 20, 10),
                new HockeyPlayer(2, PlayerType.HockeyPlayer, "Corey Crawford", "Vancouver Canucks", 80, 150, 70),
                new HockeyPlayer(3, PlayerType.HockeyPlayer, "Wayne Gretzky", "Edmonton Oilers", 150, 220, 180),
                new HockeyPlayer(4, PlayerType.HockeyPlayer, "Jaromir Jagr", "Washington Capitals", 170, 250, 220)
        };
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            RefreshListBox();
        }

        private void RefreshListBox()
        {
            var playerNames = from hckPlayer in hockeyPlayers
                              select hckPlayer.PlayerName;
            lstHockeyPlayers.ItemsSource = playerNames;
        }
        private void lstHockeyPlayers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = lstHockeyPlayers.SelectedIndex;
            var selectedPlayer = (from player in hockeyPlayers
                                 where player.PlayerId == index
                                 select player).FirstOrDefault();
            if(selectedPlayer != null)
            { 
            txtPlayerId.Text = Convert.ToString(selectedPlayer.PlayerId);
            txtPlayerName.Text = selectedPlayer.PlayerName;
            txtTeamName.Text = selectedPlayer.TeamName;
            txtGamesPlayed.Text = Convert.ToString(selectedPlayer.GamesPlayed);
            txtGoals.Text = Convert.ToString(selectedPlayer.Goals);
            txtAssists.Text = Convert.ToString(selectedPlayer.Assists);
            txtPoints.Text = Convert.ToString(selectedPlayer.Points());
            }
        }


        private void btnAddPlayer_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPlayerName.Text) || txtPlayerName.Text.All(Char.IsDigit))
            {
                MessageBox.Show("PlayerName Should not be empty or should not contain number", "Validation", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else if (string.IsNullOrEmpty(txtTeamName.Text) || txtTeamName.Text.All(Char.IsDigit))
            {
                 MessageBox.Show("Team Name Should not be empty or should not contain number", "Validation", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else if (string.IsNullOrEmpty(txtGamesPlayed.Text) || txtGamesPlayed.Text.All(Char.IsLetter))
            {
                 MessageBox.Show("Games Played Should not be empty or should not contain letters", "Validation", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else if (string.IsNullOrEmpty(txtGoals.Text) || txtGoals.Text.All(Char.IsLetter))
            {
                 MessageBox.Show("Goals Should not be empty or should not contain letters", "Validation", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else if (string.IsNullOrEmpty(txtAssists.Text) || txtAssists.Text.All(Char.IsLetter))
            {
                 MessageBox.Show("Assists Should not be empty or should not contain letters", "Validation", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {                 
                 HockeyPlayer hockeyPlayer = new HockeyPlayer(hockeyPlayers.Count, PlayerType.HockeyPlayer, txtPlayerName.Text, txtTeamName.Text, int.Parse(txtGamesPlayed.Text), int.Parse(txtAssists.Text), int.Parse(txtGoals.Text));
                    hockeyPlayers.Add(hockeyPlayer);          
            }
                RefreshListBox();
            
        }

        private void btnUpdatePlayer_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPlayerName.Text) || txtPlayerName.Text.All(Char.IsDigit))
            {
                MessageBox.Show("PlayerName Should not be empty or should not contain number", "Validation", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else if (string.IsNullOrEmpty(txtTeamName.Text) || txtTeamName.Text.All(Char.IsDigit))
            {
                MessageBox.Show("Team Name Should not be empty or should not contain number", "Validation", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else if (string.IsNullOrEmpty(txtGamesPlayed.Text) || txtGamesPlayed.Text.All(Char.IsLetter))
            {
                MessageBox.Show("Games Played Should not be empty or should not contain letters", "Validation", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else if (string.IsNullOrEmpty(txtGoals.Text) || txtGoals.Text.All(Char.IsLetter))
            {
                MessageBox.Show("Goals Should not be empty or should not contain letters", "Validation", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else if (string.IsNullOrEmpty(txtAssists.Text) || txtAssists.Text.All(Char.IsLetter))
            {
                MessageBox.Show("Assists Should not be empty or should not contain letters", "Validation", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                int index = lstHockeyPlayers.SelectedIndex;
                if (MessageBox.Show($"Are You sure, You Want to Update {txtPlayerName.Text}'s Data ?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {

                    HockeyPlayer hockeyplayer = hockeyPlayers[index];
                    hockeyplayer.PlayerName = txtPlayerName.Text;
                    hockeyplayer.TeamName = txtTeamName.Text;
                    hockeyplayer.GamesPlayed = int.Parse(txtGamesPlayed.Text);
                    hockeyplayer.Goals = int.Parse(txtGoals.Text);
                    hockeyplayer.Assists = int.Parse(txtAssists.Text);
                    RefreshListBox();
                }
                else
                {
                    MessageBox.Show($"{txtPlayerName.Text} is not updated from the list", "Confirmation", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
        }

        private void btnDeletePlayer_Click(object sender, RoutedEventArgs e)
        {
            int index = lstHockeyPlayers.SelectedIndex;
            if (MessageBox.Show($"Are You sure, You Want to Delete {txtPlayerName.Text}'s data ?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                hockeyPlayers.RemoveAt(index);
                for (int i = 0; i < hockeyPlayers.Count; i++)
                    hockeyPlayers[i].PlayerId = i;
            }
            else
            {
                MessageBox.Show($"{txtPlayerName.Text} is not deleted from the list", "Confirmation", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            RefreshListBox();
        }

        
        private void Window_Closing(object sender, CancelEventArgs cancelEventArgs)
        {

            if (MessageBox.Show(this, "Are you sure you want to Close this window?", "Confirm", MessageBoxButton.YesNo, MessageBoxImage.Question) != MessageBoxResult.Yes)
            {
                cancelEventArgs.Cancel = true;
            }
            else 
            {
                MessageBox.Show("HockeyPlayer Window is Successfully Closed.", "Confirmation", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void btnQuit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnHelp_Click(object sender, RoutedEventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }
    }
   
}
