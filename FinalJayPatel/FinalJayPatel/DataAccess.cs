using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalJayPatel
{
    class DataAccess
    {
        double gameTax = 0.0; // tax of 13%
        double tPriBfTax = 0.0; //total price before tax
        double netTotal = 0.0; // net total with tax and discount
        public void purchaseGamesFromDatabase()
        {
            using (var context = new GameShoppingDBEntities())
            {
                Console.Write("\nEnter your name: ");
                string customerName = Console.ReadLine();
                var customer = (from c in context.Customers
                                where c.Name.Contains(customerName)
                                select c).ToList();
                var custom = (from c in context.Customers
                              where c.Name.Contains(customerName)
                              select c).FirstOrDefault();
                if (customer.Count == 0)
                {
                    Console.WriteLine("\nHello, You are new customer in our database.\nnew Customer Record created successfuly in the database.\n");
                    Customer customer1 = new Customer();
                    customer1.Name = customerName;
                    context.Customers.Add(customer1);
                    context.SaveChanges();
                }
                else
                {
                    Console.WriteLine("Welcome Back!!!\n");
                }
                gameTable();
            /*Reference: https://docs.microsoft.com/en-us/dotnet/visual-basic/language-reference/statements/goto-statement 
              for Label to jump back to id again.
             */
            gameID:
                Console.Write("\nEnter Game ID you want to buy: ");
                int gameID = 0;
                gameID = int.Parse(Console.ReadLine());
                if (!(gameID > 0 && gameID < 6))
                {
                    Console.WriteLine("Wrong Game ID. Please try again later.");
                    goto gameID;
                }

                Game findGame = context.Games.Find(gameID);
                Console.Write("\nEnter quantity you want to buy: ");
                int quantityToBuy = int.Parse(Console.ReadLine());
                if (findGame.Stock < quantityToBuy)
                {
                    Console.WriteLine("Sorry Sir/Madam, We do not have quantity you want to buy.");
                }
                else
                {
                    var orderingCust = (from c in context.Customers
                                        where c.Name.Contains(customerName)
                                        select c).FirstOrDefault();
                    tPriBfTax = findGame.Price * quantityToBuy;
                    DateTime orderedDate = DateTime.Now;
                    findGame.Stock = findGame.Stock - quantityToBuy;
                    Order ordered = new Order();
                    if (quantityToBuy >= 5)
                    {
                        ordered.Discount = (tPriBfTax * 10) / 100;
                        gameTax = (tPriBfTax * 13) / 100;
                        netTotal = tPriBfTax - ordered.Discount + gameTax;
                    }
                    else
                    {

                        ordered.Discount = 0.0;
                        gameTax = (tPriBfTax * 13) / 100;
                        netTotal = tPriBfTax - ordered.Discount + gameTax;
                    }

                    ordered.CustomerId = custom.CustomerId;
                    ordered.GameId = findGame.GameId;
                    ordered.Quantity = quantityToBuy;
                    ordered.Date = orderedDate;
                    context.Orders.Add(ordered);
                    context.SaveChanges();

                    Console.Write("\nThanks.Your order has been successfully placed.");
                    Console.WriteLine("\nA summary of the transaction: ");
                    ConsoleTable table = new ConsoleTable("OrderId", "PurchasedDate", "Customer's Name", "Name of Game", "Price of Game", "Quantity", "Total Price(before Tax)", "Discount(10%)", "Tax(13%)", "NetTotal");
                    table.AddRow(ordered.OrderId, ordered.Date, ordered.Customer.Name, ordered.Game.Name, ordered.Game.Price.ToString("C"), ordered.Quantity, tPriBfTax, ordered.Discount.ToString("C"), gameTax.ToString("C"), netTotal.ToString("C"));
                    table.Write(Format.MarkDown);
                }

            }
        }


        public void gameTable()
        {
            using (var context = new GameShoppingDBEntities())
            {

                var gamesData = (from g in context.Games
                                 select g).ToList();
                ConsoleTable table = new ConsoleTable("Game Id", "Game Name", "Price(in Dollars)", "In Stock");
                foreach (var i in gamesData)
                {
                    table.AddRow(i.GameId, i.Name, i.Price.ToString("C"), i.Stock);
                }
                table.Write(Format.MarkDown);
            }
        }

        public void customerTable()
        {
            using (var context = new GameShoppingDBEntities())
            {
                var customers = context.Customers.ToList();
                ConsoleTable table = new ConsoleTable("Customer Id", "Customer Name");
                foreach (var i in customers)
                {
                    table.AddRow(i.CustomerId, i.Name);
                }
                table.Write(Format.MarkDown);
            }
        }

        public void ViewCustomerTransactionHistory()
        {
            using (var context = new GameShoppingDBEntities())
            {
                customerTable();
                Console.Write("\nEnter your Customer ID: ");
                int custID = int.Parse(Console.ReadLine());
                var gCustomer = (from c in context.Customers
                                 where c.CustomerId == custID
                                 select c).FirstOrDefault();

                if (gCustomer == null)
                {
                    Console.WriteLine($"Sorry Sir/Madam, You may have entered wrong customer ID.\nPlease try agian.");
                }
                else
                {
                    var orders = (from o in context.Orders
                                  where o.CustomerId == custID
                                  select o).ToList();

                    if (orders.Count > 0)
                    {

                        ConsoleTable table = new ConsoleTable("OrderId", "PurchasedDate", "Customer's Name", "Name of Game", "Price of Game", "Quantity", "Discount(10%)", "Tax(13%)", "NetTotal");
                        foreach (var i in orders)
                        {
                            tPriBfTax = (i.Game.Price) * (i.Quantity);
                            gameTax = ((tPriBfTax * 13) / 100);
                            netTotal = (tPriBfTax + gameTax - i.Discount);

                            table.AddRow(i.OrderId, i.Date, i.Customer.Name, i.Game.Name, i.Game.Price.ToString("C"), i.Quantity, i.Discount.ToString("C"), gameTax.ToString("C"), netTotal.ToString("C"));
                        }
                        table.Write(Format.MarkDown);
                    }
                    else
                    {
                        Console.WriteLine($"Sorry Sir/Madam, {gCustomer.Name} didn't bought anything from our store.");
                    }
                }
            }
        }
        public void viewAllTransactions()
        {
            using (var context = new GameShoppingDBEntities())
            {

                var orders = (from o in context.Orders select o).ToList();
                if (orders.Count == 0)
                {
                    Console.WriteLine("\nSorry Sir/Madam, We donot have any entry in order database.So, try again later.\n");
                }
                else
                {
                    ConsoleTable table = new ConsoleTable("OrderId", "PurchasedDate", "Customer's Name", "Name of Game", "Price of Game", "Quantity", "Discount(10%)", "Tax(13%)", "NetTotal");

                    foreach (var i in orders)
                    {
                        tPriBfTax = (i.Game.Price) * (i.Quantity);
                        gameTax = ((tPriBfTax * 13) / 100);
                        netTotal = (tPriBfTax + gameTax - i.Discount);
                        table.AddRow(i.OrderId, i.Date, i.Customer.Name, i.Game.Name, i.Game.Price.ToString("C"), i.Quantity, i.Discount.ToString("C"), gameTax.ToString("C"), netTotal.ToString("C"));
                    }
                    table.Write(Format.MarkDown);
                }
            }
        }
    }
}
