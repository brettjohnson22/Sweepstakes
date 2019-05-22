using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;

namespace Sweepstakes
{
    public class Sweepstakes
    {
        //member variables (HAS A)
        private Dictionary<double, Contestant> contestantList;
        public string name;

        //constructor (SPAWNER)
        public Sweepstakes(string name)
        {
            this.name = name;
            contestantList = new Dictionary<double, Contestant>();
        }

        //member methods (CAN DO)
        public void RegisterContestant(Contestant contestant)
        {
            contestant.registration = contestantList.Count;
            contestantList.Add(contestant.registration, contestant);
        }
        public string PickWinner()
        {
            string winner = "";
            Random rand = new Random();
            double winningNumber = rand.Next(contestantList.Count);
            foreach(KeyValuePair<double, Contestant> contestant in contestantList)
            {
                if (winningNumber == contestant.Key)
                {
                    contestant.Value.won = true;
                    winner = contestant.Value.Name;
                }
            }
            return winner;
        }
        void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine($"Info on Contestant #{contestant.registration}:\nName: {contestant.Name}\nEmail: {contestant.Email}");
        }
        public void Notify(string winner)
        {
            foreach(KeyValuePair<double, Contestant> contestant in contestantList)
            {
                contestant.Value.Update(winner);
            }
        }
        public void EmailWinner(Contestant contestant)
        {
            MimeMessage message = new MimeMessage();
            message.From.Add(new MailboxAddress("Sweepstakes Manager", "manager@sweepstakescompany.com"));
            message.To.Add(new MailboxAddress(contestant.Name, contestant.Email));
            message.Subject = "Congratulations, you won!";
            message.Body = new TextPart("plain")
            {
                Text = @"Hello, contestant! You won the sweepstakes!"
            };
            using (SmtpClient client = new SmtpClient())
            {
                client.ServerCertificateValidationCallback = (s, c, h, e) => true;
                client.Connect("smtp.sweepstakescompany.com", 587, false);
                client.Authenticate("manager", "password");
                client.Send(message);
                client.Disconnect(true);
            }
        }
    }
}
