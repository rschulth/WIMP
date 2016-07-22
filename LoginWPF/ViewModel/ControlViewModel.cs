using System.Collections.Generic;
using LoginWPF.json;
using LoginWPF.Model;
using LoginWPF.View;
using LoginWPF.ViewModel.Common;
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace LoginWPF.ViewModel
{
    class ControlViewModel
    {
        public User User { get; private set; }

        public Menu Menu { get; private set; }

        public Garden1 Garden1 { get; private set; }

        public ArrayofObjects ArrayofObjects { get; private set; }

        public ICommand RefreshCommand { get; private set; }

        public ICommand LogoffCommand { get; private set; }

        private ControlWindow controlWindow;

        public ControlViewModel(User user, Menu menu, ControlWindow thisWindows)
        {
            User = user;
            Menu = menu;
            controlWindow = thisWindows;
            RefreshCommand = new DelegateCommand<Menu>(o => RefreshMenu(), o => true);
            LogoffCommand = new DelegateCommand<User>(o => Logoff(), o => true);
            ReadJsonFile();
            RefreshMenu();
        }

        public  async void RefreshMenu()
        {
            Update update = await HttpGetMenuRequest();

            if (update.success.Equals("1"))
            {
                Menu.Points = update.points;
                Menu.Bar = update.bar;
                Menu.Level = update.level;
                Menu.LevelNr = update.levelnr;
            }
            else
            {
                Menu.Points = string.Empty;
                Menu.Bar = string.Empty;
                Menu.Level = string.Empty;
                Menu.LevelNr = string.Empty;
                
            }
                
              GetGarden1(); 

        }


        public async void Logoff() {
            
            controlWindow.Close();
            HttpGetLogoffRequest();
            Application.Current.MainWindow.Show();

        }

        public async void GetGarden1() {

            Ajax garden = await HttpGetGardenRequest();

            if (garden.status.Equals("ok"))
            {
             // Garden1.Deko = garden.deko;
             // Garden1.GardenNo = garden.gardenNo;
             int[] array =  GardenObjectsToArray.getArray(garden.garden);
                int i;
            }


        }


        private async Task<Update> HttpGetMenuRequest() {

            CookieCollection cc = ParseCookie.GetAllCookies(User.Cookie);
            string jsonstring;
            var baseAddress = new Uri("http://s" + User.Server + ".wurzelimperium.de");
            using (var handler = new HttpClientHandler { UseCookies = false })
            using (var client = new HttpClient(handler) { BaseAddress = baseAddress })
            {
                var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, "/ajax/menu-update.php");
                httpRequestMessage.Headers.Add("Cookie", cc[0].Name+"="+cc[0].Value +"; "+ cc[1].Name+"="+cc[1].Value);
                var response = await client.SendAsync(httpRequestMessage);
                response.EnsureSuccessStatusCode();
                jsonstring = await response.Content.ReadAsStringAsync();
            }
            Update update = J2O.GetT<Update>(jsonstring);
            return update;
        }


        private async Task<Ajax> HttpGetGardenRequest() {
            //ajax/ajax.php?do=changeGarden&garden=1&token=c856daa6a74edc28ebf5c3123ac75d7d
            CookieCollection cc = ParseCookie.GetAllCookies(User.Cookie);
            string jsonstring;
            var baseAddress = new Uri("http://s" + User.Server + ".wurzelimperium.de");
            using (var handler = new HttpClientHandler { UseCookies = false })
            using (var client = new HttpClient(handler) { BaseAddress = baseAddress })
            {
                var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, "/ajax/ajax.php?do=changeGarden&garden=1&" + cc[0].Value);
                httpRequestMessage.Headers.Add("Cookie", cc[0].Name + "=" + cc[0].Value + "; " + cc[1].Name + "=" + cc[1].Value);
                var response = await client.SendAsync(httpRequestMessage);
                response.EnsureSuccessStatusCode();
                jsonstring = await response.Content.ReadAsStringAsync();
            }

            Ajax ajax = J2O.GetT<Ajax>(jsonstring);
            return ajax;
        }


        private async void HttpGetLogoffRequest()
        {
            CookieCollection cc = ParseCookie.GetAllCookies(User.Cookie);
         
            var baseAddress = new Uri("http://www.wurzelimperium.de");
            using (var handler = new HttpClientHandler { UseCookies = false })
            using (var client = new HttpClient(handler) { BaseAddress = baseAddress })
            {
                var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, "/login.php?logout=1&lastServer=" + User.Server + "&unr="+cc[1].Value);
                httpRequestMessage.Headers.Add("Cookie", cc[0].Name + "=" + cc[0].Value + "; " + cc[1].Name + "=" + cc[1].Value);
                var response = await client.SendAsync(httpRequestMessage);
                response.EnsureSuccessStatusCode();
                
            }
        }

        private async void  ReadJsonFile()
        {

            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"json\Item.json");
            string[] files = File.ReadAllLines(path);
            string jsonstring = File.ReadAllText(path);
            if (!jsonstring.Equals(""))
            {

                ArrayofObjects = J2O.GetT<ArrayofObjects>(jsonstring);
                
            }
         
        }
    }
}
