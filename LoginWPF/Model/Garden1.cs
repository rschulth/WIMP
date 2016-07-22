using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginWPF.Model
{
    class Garden1 : INotifyPropertyChanged
    {

        private int deko;
        private int gardenNo;
        private Plant plant;


        public int Deko {
            get { return deko; }
            set {
                deko = value;
                FirePropertyChanged("Deko");
            }
        }

        public int GardenNo {
            get { return gardenNo; }
            set {
                gardenNo = value;
                FirePropertyChanged("GardenNo");
            }
        }


        public Plant Plant {
            get { return plant; }
            set {
                plant = value;
                FirePropertyChanged("Plant");
            }
        }



        private void FirePropertyChanged(string propertyName) {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };
    }
}
