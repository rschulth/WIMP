using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using LoginWPF.Model;
using LoginWPF.ViewModel;

namespace LoginWPF.View
{
    /// <summary>
    /// Interaktionslogik für ControlWindow.xaml
    /// </summary>
    public partial class ControlWindow : Window
    {
        public ControlWindow(User user) {
            InitializeComponent();
            this.DataContext = new ControlViewModel(user, new LoginWPF.Model.Menu(), this);


        }
    }
}
