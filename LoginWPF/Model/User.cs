using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CSharp.RuntimeBinder;

namespace LoginWPF.Model
{
    public class User : INotifyPropertyChanged
    {


        private string username;
        private string password;
        private int server;
        private string answer;
        private int random;
        private CookieContainer _cookie;


        public CookieContainer Cookie
        {
            get { return _cookie; }
            set { _cookie = value; }
        }

       public int Server {
            get { return server; }
            set {
                server  = value;
                FirePropertyChanged("Server");
            }
        }
       public string Username {
            get { return username; }
            set {
                username = value;
                FirePropertyChanged("Username");
            }
        }
       public string Password {
            get { return password; }
            set {
                password = value;
                FirePropertyChanged("Password");
            }
        }
        public string Answer {
            get { return answer; }
            set {
                answer = value;
                FirePropertyChanged("Answer");
            }
        }
        public void NewRandom() {
             
                Random rnd = new Random();
                random = rnd.Next(999999999);
               
        }
        public int GetRandom() {

            return random;
        }

        private void FirePropertyChanged(string propertyName) {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };
    }


}
