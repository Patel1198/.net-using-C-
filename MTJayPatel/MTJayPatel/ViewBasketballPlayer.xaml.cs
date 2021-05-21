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
    /// Interaction logic for ViewBasketballPlayer.xaml
    /// </summary>
    public partial class ViewBasketballPlayer : Window
    {
        private List<BasketballPlayer> basketBallPlayers;
        public ViewBasketballPlayer()
        {
            InitializeComponent();
            Closing += Window_Closing;
            basketBallPlayers = new List<BasketballPlayer>()
            {
                new BasketballPlayer(0, PlayerType.BasketballPlayer, "Michael Jordan", "Washington Wizards", 300, 280, 150),
                new BasketballPlayer(1, PlayerType.BasketballPlayer, "LeBron James", "Los Angeles Lakers", 290, 220, 140),
                new BasketballPlayer(2, PlayerType.BasketballPlayer, "Kareem Abdul-Jabbar", "Milwaukee Bucks", 280, 250, 170),
                new BasketballPlayer(3, PlayerType.BasketballPlayer, "Bill Russell", "Boston Celtics", 150, 120, 80),
                new BasketballPlayer(4, PlayerType.BasketballPlayer, "Tim Duncan", "San Antonio Spurs", 170, 150, 120)
        };
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            RefreshListBox();
        }  

         private void RefreshListBox()
            {

                var playerNames = from baskPlayer in basketBallPlayers
                              select baskPlayer.PlayerName;
            lstBasketballPlayers.ItemsSource = playerNames;

        }

        private void lstBasketballPlayers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = lstBasketballPlayers.SelectedIndex;
            var selectedPlayer = (from player in basketBallPlayers
                                  where player.PlayerId == index
                                  select player).FirstOrDefault();
            if (selectedPlayer != null)
            {
                txtPlayerId.Text = Convert.ToString(selectedPlayer.PlayerId);
                txtPlayerName.Text = selectedPlayer.PlayerName;
                txtTeamName.Text = selectedPlayer.TeamName;
                txtGamesPlayed.Text = Convert.ToString(selectedPlayer.GamesPlayed);
                txtFieldGoals.Text = Convert.ToString(selectedPlayer.FieldGoals);
                txtThreePointers.Text = Convert.ToString(selectedPlayer.ThreePointers);
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
            else if (string.IsNullOrEmpty(txtFieldGoals.Text) || txtFieldGoals.Text.All(Char.IsLetter))
            {
                MessageBox.Show("Field Goals Should not be empty or should not contain letters", "Validation", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else if (string.IsNullOrEmpty(txtThreePointers.Text) || txtThreePointers.Text.All(Char.IsLetter))
            {
                MessageBox.Show("Three Pointers Should not be empty or should not contain letters", "Validation", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                BasketballPlayer basketballPlayer = new BasketballPlayer(basketBallPlayers.Count, PlayerType.BasketballPlayer, txtPlayerName.Text, txtTeamName.Text, int.Parse(txtGamesPlayed.Text), int.Parse(txtFieldGoals.Text), int.Parse(txtThreePointers.Text));
                basketBallPlayers.Add(basketballPlayer);
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
            else if (string.IsNullOrEmpty(txtFieldGoals.Text) || txtFieldGoals.Text.All(Char.IsLetter))
            {
                MessageBox.Show("Field Goals Should not be empty or should not contain letters", "Validation", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else if (string.IsNullOrEmpty(txtThreePointers.Text) || txtThreePointers.Text.All(Char.IsLetter))
            {
                MessageBox.Show("Three Pointers Should not be empty or should not contain letters", "Validation", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                int index = lstBasketballPlayers.SelectedIndex;
                if (MessageBox.Show($"Are You sure, You Want to Update {txtPlayerName.Text}'s Data ?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {

                    BasketballPlayer basketballplayer = basketBallPlayers[index];
                    basketballplayer.PlayerName = txtPlayerName.Text;
                    basketballplayer.TeamName = txtTeamName.Text;
                    basketballplayer.GamesPlayed = int.Parse(txtGamesPlayed.Text);
                    basketballplayer.FieldGoals = int.Parse(txtFieldGoals.Text);
                    basketballplayer.ThreePointers = int.Parse(txtThreePointers.Text);
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
            int index = lstBasketballPlayers.SelectedIndex;
            if (MessageBox.Show($"Are You sure, You Want to Delete {txtPlayerName.Text}'s data ?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                basketBallPlayers.RemoveAt(index);
                for (int i = 0; i < basketBallPlayers.Count; i++)
                    basketBallPlayers[i].PlayerId = i;
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
                MessageBox.Show("Basketball Window is Successfully Closed.", "Confirmation", MessageBoxButton.OK, MessageBoxImage.Information);
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
