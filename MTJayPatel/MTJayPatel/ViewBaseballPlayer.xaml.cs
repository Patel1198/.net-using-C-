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
    /// Interaction logic for ViewBaseballPlayer.xaml
    /// </summary>
    public partial class ViewBaseballPlayer : Window
    {
        private List<BaseballPlayer> baseBallPlayers;
        public ViewBaseballPlayer()
        {
            InitializeComponent();
            Closing += Window_Closing;
            baseBallPlayers = new List<BaseballPlayer>()
            {
                new BaseballPlayer(0, PlayerType.BaseballPlayer, "Mike Trout", "Angels", 400, 380, 250),
                new BaseballPlayer(1, PlayerType.BaseballPlayer, "Christian Yelich", "Brewers", 490, 420, 340),
                new BaseballPlayer(2, PlayerType.BaseballPlayer, "Cody Bellinger", "Dodgers", 680, 550, 470),
                new BaseballPlayer(3, PlayerType.BaseballPlayer, "Alex Bregman", "Astros", 850, 820, 680),
                new BaseballPlayer(4, PlayerType.BaseballPlayer, "Gerrit Cole", "Yankees", 120, 180, 160)
        };
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
                RefreshListBox();
            }

         private void RefreshListBox()
            {
                var playerNames = from basePlayer in baseBallPlayers
                             select basePlayer.PlayerName;
            lstBaseballPlayers.ItemsSource = playerNames;
        }

        private void lstBaseballPlayers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            int index = lstBaseballPlayers.SelectedIndex;
            var selectedPlayer = (from player in baseBallPlayers
                                  where player.PlayerId == index
                                  select player).FirstOrDefault();
            if (selectedPlayer != null)
            {
                txtPlayerId.Text = Convert.ToString(selectedPlayer.PlayerId);
                txtPlayerName.Text = selectedPlayer.PlayerName;
                txtTeamName.Text = selectedPlayer.TeamName;
                txtGamesPlayed.Text = Convert.ToString(selectedPlayer.GamesPlayed);
                txtRuns.Text = Convert.ToString(selectedPlayer.Runs);
                txtHomeRuns.Text = Convert.ToString(selectedPlayer.HomeRuns);
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
            else if (string.IsNullOrEmpty(txtRuns.Text) || txtRuns.Text.All(Char.IsLetter))
            {
                MessageBox.Show("Runs Should not be empty or should not contain letters", "Validation", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else if (string.IsNullOrEmpty(txtHomeRuns.Text) || txtHomeRuns.Text.All(Char.IsLetter))
            {
                MessageBox.Show("HomeRuns Should not be empty or should not contain letters", "Validation", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                BaseballPlayer baseballPlayer = new BaseballPlayer(baseBallPlayers.Count, PlayerType.BaseballPlayer, txtPlayerName.Text, txtTeamName.Text, int.Parse(txtGamesPlayed.Text), int.Parse(txtRuns.Text), int.Parse(txtHomeRuns.Text));
                baseBallPlayers.Add(baseballPlayer);
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
            else if (string.IsNullOrEmpty(txtRuns.Text) || txtRuns.Text.All(Char.IsLetter))
            {
                MessageBox.Show("Runs Should not be empty or should not contain letters", "Validation", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else if (string.IsNullOrEmpty(txtHomeRuns.Text) || txtHomeRuns.Text.All(Char.IsLetter))
            {
                MessageBox.Show("HomeRuns Should not be empty or should not contain letters", "Validation", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {

                int index = lstBaseballPlayers.SelectedIndex;
                if (MessageBox.Show($"Are You sure, You Want to Update {txtPlayerName.Text}'s Data ?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {

                    BaseballPlayer baseballPlayer = baseBallPlayers[index];
                    baseballPlayer.PlayerName = txtPlayerName.Text;
                    baseballPlayer.TeamName = txtTeamName.Text;
                    baseballPlayer.GamesPlayed = int.Parse(txtGamesPlayed.Text);
                    baseballPlayer.Runs = int.Parse(txtRuns.Text);
                    baseballPlayer.HomeRuns = int.Parse(txtHomeRuns.Text);
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
            int index = lstBaseballPlayers.SelectedIndex;
            if (MessageBox.Show($"Are You sure, You Want to Delete {txtPlayerName.Text}'s data ?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                baseBallPlayers.RemoveAt(index);
                for (int i = 0; i < baseBallPlayers.Count; i++)
                    baseBallPlayers[i].PlayerId = i;
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
                MessageBox.Show("BaseballPlayer Window is Successfully Closed.", "Confirmation", MessageBoxButton.OK, MessageBoxImage.Information);
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
