using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPatternExample
{
    public interface IChatMediator
    {
        void SendMessage(string msg, User user);
        void RegisterUser(User user);
    }
    public class User
    {
        internal IChatMediator Mediator;
        protected string Name;
        public User(string name)
        {
            this.Name = name;
        }
        public void Send(string msg)
        {
            Console.WriteLine(this.Name + " Sending Message: " + msg);
            Mediator.SendMessage(msg, this);
        }
        public void Receive(string msg)
        {
            Console.WriteLine(this.Name + " Received Message: " + msg);
        }
    }
   
    public class ChatMediator : IChatMediator
    {
        private List<User> users = new List<User>();
        public void RegisterUser(User user)
        {
            users.Add(user);
            user.Mediator = this;
        }

        public void SendMessage(string message, User user)
        {
            foreach (User u in users)
            {
                if (u != user)
                {
                    u.Receive(message);
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            IChatMediator chatMediator = new ChatMediator();
            User user1 = new User("Ali");
            User user2 = new User("Ahmed");

            chatMediator.RegisterUser(user1);
            chatMediator.RegisterUser(user2);

            user1.Send("Hello Ahmed");
            user2.Send("Hi Ali");

        }
    }
}
