using System;
using System.Collections.Generic;
using System.Linq;
/* Assignment By: Jay Patel
 * Id: 991592044
*/
namespace A1JayPatel
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 1;
            bool shouldContinue = true;
            List<Player> myList = new List<Player>();
            BasketballPlayer player1 = new BasketballPlayer(count++,PlayerType.BasketballPlayer,"Jai","Indian Boys", 20, 50, 20);
            myList.Add(player1);
            BasketballPlayer player2 = new BasketballPlayer(count++, PlayerType.BasketballPlayer, "James", "Montreal Brunos", 30, 70, 30);
            myList.Add(player2);
            BasketballPlayer player3 = new BasketballPlayer(count++, PlayerType.BasketballPlayer, "Adam", "Ontario Crackers", 40, 30, 10);
            myList.Add(player3);
            BaseballPlayer player4 = new BaseballPlayer(count++, PlayerType.BaseballPlayer, "Harsh", "Texas trackers", 20, 30, 15);
            myList.Add(player4);
            BaseballPlayer player5 = new BaseballPlayer(count++, PlayerType.BaseballPlayer, "Jagjit", "Punjab de Munde", 50, 40, 25);
            myList.Add(player5);
            BaseballPlayer player6 = new BaseballPlayer(count++, PlayerType.BaseballPlayer, "Nikolas", "Brampton Batters", 70, 50, 30);
            myList.Add(player6);
            HockeyPlayer player7 = new HockeyPlayer(count++, PlayerType.HockeyPlayer, "Ricardo", "Toronto Maple Leafs", 30, 50, 34);
            myList.Add(player7);
            HockeyPlayer player8 = new HockeyPlayer(count++, PlayerType.HockeyPlayer, "Viktor Arvidsson", "Edmonton Oilers", 10, 20, 10);
            myList.Add(player8);
            HockeyPlayer player9 = new HockeyPlayer(count++, PlayerType.HockeyPlayer, "Corey Crawford", "Vancouver Canucks", 80, 150, 70);
            myList.Add(player9);

            mainMenu(count,myList);
            while (shouldContinue)
            //Reference for Exit menu: https://stackoverflow.com/questions/41795869/how-to-allow-the-user-to-choose-whether-the-continue-the-program-or-exit-it-c
            {
                var userIn = Console.ReadLine();
                if (int.TryParse(userIn, out int userInp))
                    userInp = int.Parse(userIn);
                switch (userInp)
                {
                    case 1:
                        addPlayer(count, myList);
                        break;
                    case 2:
                        editPlayer(count, myList);
                        break;
                    case 3:
                        deletePlayer(count, myList);
                        break;
                    case 4:
                        viewPlayer(count, myList);
                        break;
                    case 5:
                        searchPlayer(count, myList);
                        break;
                    case 6:
                        shouldContinue = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input. please try again.");
                        break;

                }
            }

            // to show main menu
            static void mainMenu(int count, List<Player> myList)
            {
                Console.WriteLine("\n\tAssignment 1 by Jay Patel\n\n");
                Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+");
                Console.WriteLine("\n\t1 - Add Player\n\t2 - Edit Player\n\t3 - Delete Player\n\t4 - View Players" +
                   "\n\t5 - Search Player\n\t6 - Exit");
                Console.Write("\nEnter your choice: ");

            }

            //To add Players
            static void addPlayer(int count, List<Player> myList) 
            {
                Console.Clear();
                Console.WriteLine("\nAdd New Player:\n\n\t1 - Add Hockey Player\n\t2 - Add Basketball Player\n\t" +
                    "3 - Add Baseball Player\n\t4 - Back To Main Menu\n");
                Console.Write("Enter your choice: ");
                var usrIn = Console.ReadLine();
                if (!int.TryParse(usrIn, out int usrInp))
                    Console.Write("");
                else
                    usrInp = int.Parse(usrIn);
                switch (usrInp)
                {
                    case 1:
                        addHockeyPlayer(count, myList);
                        break;
                    case 2:
                        addBasketballPlayer(count, myList);
                        break;
                    case 3:
                        addBaseballPlayer(count, myList);
                        break;
                    case 4:
                        Console.Clear();
                        mainMenu(count, myList);
                        break;
                    default:
                        Console.WriteLine("Invalid input. please try again.");
                        break;
                }
            }

            // to add hockey player
            static void addHockeyPlayer(int count, List<Player> myList)
            {
                Console.WriteLine("\nAdding Hockey Player\n");
                Console.Write("Enter Player Name: ");
                String plyname = Console.ReadLine();
                Console.Write("Enter team name: ");
                String teamName = Console.ReadLine();
                Console.Write("Enter games played: ");
                int gmplyed = int.Parse(Console.ReadLine());
                Console.Write("Enter assists: ");
                int ass = int.Parse(Console.ReadLine());
                Console.Write("Enter goals: ");
                int goals = int.Parse(Console.ReadLine());
                Console.WriteLine("\nNew Player Added.\n\nView All HockeyPlayers: \n\n");
                HockeyPlayer player = new HockeyPlayer(count++, PlayerType.HockeyPlayer, plyname, teamName, gmplyed, ass, goals);
                myList.Add(player);
                viewHockeyPlayer(count, myList);
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
                addPlayer(count, myList);
            }

            // to add basketball player
            static void addBasketballPlayer(int count, List<Player> myList)
            {
                Console.WriteLine("\nAdding Basketball Player\n");
                Console.Write("Enter Player Name: ");
                String plyname = Console.ReadLine();
                Console.Write("Enter team name: ");
                String teamName = Console.ReadLine();
                Console.Write("Enter games played: ");
                int gmplyed = int.Parse(Console.ReadLine());
                Console.Write("Enter Field Goals: ");
                int fGoals = int.Parse(Console.ReadLine());
                Console.Write("Enter 3-Pointers: ");
                int tpoint = int.Parse(Console.ReadLine());
                Console.WriteLine("\nNew Player Added.\n\nView All BasketballPlayers: \n\n");
                BasketballPlayer player = new BasketballPlayer(count++, PlayerType.BasketballPlayer, plyname, teamName, gmplyed, fGoals, tpoint);
                myList.Add(player);
                viewBasketballPlayer(count, myList);
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
                addPlayer(count, myList);
            }

            //to add baseball player
            static void addBaseballPlayer(int count, List<Player> myList)
            {
                Console.WriteLine("\nAdding Baseball Player\n");
                Console.Write("Enter Player Name: ");
                String plyname = Console.ReadLine();
                Console.Write("Enter team name: ");
                String teamName = Console.ReadLine();
                Console.Write("Enter games played: ");
                int gmplyed = int.Parse(Console.ReadLine());
                Console.Write("Enter Runs: ");
                int runs = int.Parse(Console.ReadLine());
                Console.Write("Enter HomeRuns: ");
                int hRuns = int.Parse(Console.ReadLine());
                Console.WriteLine("\nNew Player Added.\n\nView All BaseballPlayers: \n\n");
                BaseballPlayer player = new BaseballPlayer(count++, PlayerType.BaseballPlayer, plyname, teamName, gmplyed, runs, hRuns);
                myList.Add(player);
                viewBaseballPlayer(count, myList);
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
                addPlayer(count, myList);
            }

            //to edit players
            static void editPlayer(int count, List<Player> myList)
            {
                Console.Clear();
                Console.WriteLine("\nEdit New Player:\n\n\t1 - Edit Hockey Player\n\t2 - Edit Basketball Player\n\t" +"3 - Edit Baseball Player\n\t4 - Back To Main Menu\n");
                Console.Write("Enter your choice: ");
                var usrIn = Console.ReadLine();
                if (!int.TryParse(usrIn, out int usrInp))
                    Console.Write("");
                else
                    usrInp = int.Parse(usrIn);
                switch (usrInp)
                {
                    case 1:
                        editHockeyPlayer(count, myList);
                        break;
                    case 2:
                        editBasketballPlayer(count, myList);
                        break;
                    case 3:
                        editBaseballPlayer(count, myList);
                        break;
                    case 4:
                        Console.Clear();
                        mainMenu(count, myList);
                        break;
                    default:
                        Console.WriteLine("Invalid input. please try again.");
                        break;
                }
            }

            //to edit hockey player
            static void editHockeyPlayer(int count, List<Player> myList)
            {
                Console.WriteLine("\nView All HockeyPlayers:\n");
                viewHockeyPlayer(count, myList);
                Console.WriteLine("\nEditing Hockey Player\n");
                Console.Write("Enter ID of player you want to edit: ");
                int id = int.Parse(Console.ReadLine());
                int plyId = 0;
                foreach (Player plyr in myList)
                {
                    if (plyr.PlayerId == id)
                    {
                        break;
                    }
                    plyId += 1;
                }
                Console.Write("Enter Player Name: ");
                myList[plyId].PlayerName = Console.ReadLine();
                Console.Write("Enter team name: ");
                myList[plyId].TeamName = Console.ReadLine();
                Console.Write("Enter games played: ");
                myList[plyId].GamesPlayed = int.Parse(Console.ReadLine());
                Console.Write("Enter assists: ");
                ((HockeyPlayer)myList[plyId]).Assists = int.Parse(Console.ReadLine());
                Console.Write("Enter goals: ");
                ((HockeyPlayer)myList[plyId]).Goals = int.Parse(Console.ReadLine());
                Console.WriteLine($"\nPlayer with ID = {id} updated.\n");
                Console.WriteLine("View All HockeyPlayers:\n");
                viewHockeyPlayer(count, myList);
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
                editPlayer(count, myList);

            }

            // to edit basketball player
            static void editBasketballPlayer(int count, List<Player> myList)
            {
                Console.WriteLine("\nView All BasketballPlayers:\n");
                viewBasketballPlayer(count, myList);
                Console.WriteLine("\nEditing Basketball Player\n");
                Console.Write("Enter ID of player you want to edit: ");
                int id = int.Parse(Console.ReadLine());
                int plyId = 0;
                foreach (Player plyr in myList)
                {
                    if (plyr.PlayerId == id)
                    { 
                        break; 
                    }
                    plyId += 1;
                }
                Console.Write("Enter Player Name: ");
                myList[plyId].PlayerName = Console.ReadLine();
                Console.Write("Enter team name: ");
                myList[plyId].TeamName = Console.ReadLine();
                Console.Write("Enter games played: ");
                myList[plyId].GamesPlayed = int.Parse(Console.ReadLine());
                Console.Write("Enter Field Goals: ");
                ((BasketballPlayer)myList[plyId]).FieldGoals = int.Parse(Console.ReadLine());
                Console.Write("Enter 3-Pointers: ");
                ((BasketballPlayer)myList[plyId]).ThreePointers = int.Parse(Console.ReadLine());
                Console.WriteLine($"\nPlayer with ID = {id} updated.\n");
                Console.WriteLine("View All BasketballPlayers:\n");
                viewBasketballPlayer(count, myList);
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
                editPlayer(count, myList);

            }

            //to edit baseball player
            static void editBaseballPlayer(int count, List<Player> myList)
            {
                Console.WriteLine("\nView All BaseballPlayers:\n");
                viewBaseballPlayer(count, myList);
                Console.WriteLine("\nEditing Baseball Player\n");
                Console.Write("Enter ID of player you want to edit: ");
                int id = int.Parse(Console.ReadLine());
                int plyId = 0;
                foreach (Player plyr in myList)
                {
                    if (plyr.PlayerId == id)
                    { 
                        break; 
                    }
                    plyId += 1;
                }
                Console.Write("Enter Player Name: ");
                myList[plyId].PlayerName = Console.ReadLine();
                Console.Write("Enter team name: ");
                myList[plyId].TeamName = Console.ReadLine();
                Console.Write("Enter games played: ");
                myList[plyId].GamesPlayed = int.Parse(Console.ReadLine());
                Console.Write("Enter Runs: ");
                ((BaseballPlayer)myList[plyId]).Runs = int.Parse(Console.ReadLine());
                Console.Write("Enter HomeRuns: ");
                ((BaseballPlayer)myList[plyId]).HomeRuns = int.Parse(Console.ReadLine());
                Console.WriteLine($"\nPlayer with ID = {id} updated.\n");
                Console.WriteLine("View All BaseballPlayers:\n");
                viewBaseballPlayer(count, myList);
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
                editPlayer(count, myList);
            }

            //to delete players
            static void deletePlayer(int count, List<Player> myList)
            {
                Console.Clear();
                Console.WriteLine("\nDelete New Player:\n\n\t1 - Delete Hockey Player\n\t2 - Delete Basketball Player\n\t" + "3 - Delete Baseball Player\n\t4 - Back To Main Menu\n");
                Console.Write("Enter your choice: ");
                var usrIn = Console.ReadLine();
                if (!int.TryParse(usrIn, out int usrInp))
                    Console.Write("");
                else
                    usrInp = int.Parse(usrIn);
                switch (usrInp)
                {
                    case 1:
                        deleteHockeyPlayer(count, myList);
                        break;
                    case 2:
                        deleteBasketballPlayer(count, myList);
                        break;
                    case 3:
                        deleteBaseballPlayer(count, myList);
                        break;
                    case 4:
                        Console.Clear();
                        mainMenu(count, myList);
                        break;
                    default:
                        Console.WriteLine("Invalid input. please try again.");
                        break;
                }
            }

            //to delete hockey player
            static void deleteHockeyPlayer(int count, List<Player> myList)
            {
                Console.WriteLine("\nView All HockeyPlayers:\n");
                viewHockeyPlayer(count, myList);
                Console.WriteLine("\nDeleting Hockey Player\n");
                Console.Write("Enter ID of player you want to delete: ");
                int id = int.Parse(Console.ReadLine());
                foreach (Player plyr in myList)
                {
                    if (plyr.PlayerId == id)
                    {
                        var rem = myList.Single(plyr => plyr.PlayerId == id);
                        //Refrence: https://www.codegrepper.com/code-examples/dart/how+to+remove+specific+row+from+list+in+c%23
                        myList.Remove(rem);
                        break;
                    }

                }
                Console.WriteLine($"\nPlayer with ID = {id} deleted.\n");
                Console.WriteLine("View All HockeyPlayers:\n");
                viewHockeyPlayer(count, myList);
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
                deletePlayer(count, myList);
            }

            //to delete Basketball player
            static void deleteBasketballPlayer(int count, List<Player> myList)
            {
                Console.WriteLine("\nView All BasketballPlayers:\n");
                viewBasketballPlayer(count, myList);
                Console.WriteLine("\nDeleting Basketball Player\n");
                Console.Write("Enter ID of player you want to delete: ");
                int id = int.Parse(Console.ReadLine());
                foreach (Player plyr in myList)
                {
                    if (plyr.PlayerId == id)
                    {
                        var rem = myList.Single(plyr => plyr.PlayerId == id);
                        //Refrence: https://www.codegrepper.com/code-examples/dart/how+to+remove+specific+row+from+list+in+c%23
                        myList.Remove(rem);
                        break;
                    }

                }
                Console.WriteLine($"\nPlayer with ID = {id} deleted.\n");
                Console.WriteLine("View All BasketballPlayers:\n");
                viewBasketballPlayer(count, myList);
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
                deletePlayer(count, myList);
            }

            //to delete Baseball player
            static void deleteBaseballPlayer(int count, List<Player> myList)
            {
                Console.WriteLine("\nView All BaseballPlayers:\n");
                viewBaseballPlayer(count, myList);
                Console.WriteLine("\nDeleting Baseball Player\n");
                Console.Write("Enter ID of player you want to delete: ");
                int id = int.Parse(Console.ReadLine());
                foreach (Player plyr in myList)
                {
                    if (plyr.PlayerId == id)
                    {
                        var rem = myList.Single(plyr => plyr.PlayerId == id);
                        //Refrence: https://www.codegrepper.com/code-examples/dart/how+to+remove+specific+row+from+list+in+c%23
                        myList.Remove(rem);
                        break;
                    }

                }
                Console.WriteLine($"\nPlayer with ID = {id} deleted.\n");
                Console.WriteLine("View All BaseballPlayers:\n");
                viewBaseballPlayer(count, myList);
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
                deletePlayer(count, myList);
            }

            //to view all players
            static void viewPlayer(int count, List<Player> myList)
            {
                Console.Clear();
                Console.WriteLine("\nView All Players:\n\n");
                Console.WriteLine("Hockey Players:\n");
                viewHockeyPlayer(count,myList);
                Console.WriteLine("\nBasketball Players:\n");
                viewBasketballPlayer(count, myList);
                Console.WriteLine("\nBaseball Players:\n");
                viewBaseballPlayer(count, myList);
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
                mainMenu(count,myList);
            }

            //to view hockey player
            static void viewHockeyPlayer(int count, List<Player> myList)
            {
                Console.WriteLine($"{"Player Type",-20}{"Player Id",-14}{"Player Name",-20}{"Team Name",-20}{"Games Played",-16}{"Assists",-15}{"Goals"}{"Points",15}\n");
                foreach (Player plyr in myList)
                {
                    if (plyr is HockeyPlayer)
                    {
                        HockeyPlayer hplyr = plyr as HockeyPlayer;
                        Console.WriteLine(plyr.ToString() + $"{plyr.Points(),15}");
                    }

                }
            }

            //to view basketball player
            static void viewBasketballPlayer(int count, List<Player> myList)
            {
                Console.WriteLine($"{"Player Type",-20}{"Player Id",-14}{"Player Name",-20}{"Team Name",-20}{"Games Played",-16}{"Field Goals",-15}{"3-Pointers",-15}{"Points"}\n");
                foreach (Player plyr in myList)
                {
                    if (plyr is BasketballPlayer)
                    {
                        BasketballPlayer hplyr = plyr as BasketballPlayer;
                        Console.WriteLine(plyr.ToString() + $"{plyr.Points()}");
                    }
                }
            }

            //to view baseball player
            static void viewBaseballPlayer(int count, List<Player> myList)
            {
                Console.WriteLine($"{"Player Type",-20}{"Player Id",-14}{"Player Name",-20}{"Team Name",-20}{"Games Played",-16}{"Runs",-15}{"HomeRuns",-15}{"Points"}\n");
                foreach (Player plyr in myList)
                {
                    if (plyr is BaseballPlayer)
                    {
                        BaseballPlayer hplyr = plyr as BaseballPlayer;
                        Console.WriteLine(plyr.ToString() + $"{plyr.Points()}");
                    }
                }
            }

            //to search players by name
            static void searchPlayer(int count, List<Player> myList)
            {
                Console.Clear();
                Console.WriteLine("\nSearch Players by Name. Partial matches can fetch results.\n");
                Console.Write("Enter player name to search: ");
                string ser = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("\nView All Players:\n\n");
                Console.WriteLine("Hockey Players:\n");
                Console.WriteLine($"{"Player Type",-20}{"Player Id",-14}{"Player Name",-20}{"Team Name",-20}{"Games Played",-16}{"Assists",-15}{"Goals"}{"Points",15}\n\n");
                foreach (Player plyr in myList) {
                    if (plyr.TypeOfPlayer == PlayerType.HockeyPlayer)
                    {
                        bool isFound = plyr.PlayerName.Contains(ser, StringComparison.OrdinalIgnoreCase);
                        if (isFound)
                        {
                            Console.WriteLine(plyr + $"{plyr.Points()}\n");
                        }
                    }
                }
                Console.WriteLine("Basketball Players:\n");
                Console.WriteLine($"{"Player Type",-20}{"Player Id",-14}{"Player Name",-20}{"Team Name",-20}{"Games Played",-16}{"Field Goals",-15}{"3-Pointers",-15}{"Points"}\n\n");
                foreach (Player plyr in myList)
                {
                    if (plyr.TypeOfPlayer == PlayerType.BasketballPlayer)
                    {
                        bool isFound = plyr.PlayerName.Contains(ser, StringComparison.OrdinalIgnoreCase);
                        if (isFound)
                            {
                                Console.WriteLine(plyr + $"{plyr.Points()}\n");
                            }
                        }
                    }
                Console.WriteLine("Baseball Players:\n");
                Console.WriteLine($"{"Player Type",-20}{"Player Id",-14}{"Player Name",-20}{"Team Name",-20}{"Games Played",-16}{"Runs",-15}{"HomeRuns",-15}{"Points"}\n\n");
                foreach (Player plyr in myList)
                {
                    if (plyr.TypeOfPlayer == PlayerType.BaseballPlayer)
                    {
                        bool isFound = plyr.PlayerName.Contains(ser, StringComparison.OrdinalIgnoreCase);
                            if (isFound)
                            {
                                Console.WriteLine(plyr + $"{plyr.Points()}\n");
                            }
                        }
                    }
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
                mainMenu(count, myList);
            }
        }
    }
}