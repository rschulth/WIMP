using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginWPF.Model
{
    public class Menu : INotifyPropertyChanged
    {

        private string bar;
        private string points;
        private string level;
        private string levelNr;
       

        public string Bar {
            get { return bar; }
            set {
                bar = value;
                FirePropertyChanged("Bar");
            }
        }

        public string Points {
            get { return points; }
            set {
                points = value;
                FirePropertyChanged("Points");
            }
        }


        public string Level {
            get { return level; }
            set
            {
                level = WebUtility.HtmlDecode(value);
                FirePropertyChanged("Level");
            }
        }

        public string LevelNr {
            get { return levelNr; }
            set {
                levelNr = value;
                FirePropertyChanged("LevelNr");
            }
        }

        private void FirePropertyChanged(string propertyName) {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };
    }
}
