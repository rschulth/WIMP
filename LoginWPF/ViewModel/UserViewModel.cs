using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using LoginWPF.json;
using LoginWPF.Model;
using LoginWPF.View;
using LoginWPF.ViewModel.Common;

namespace LoginWPF.ViewModel
{
    class UserViewModel
    {

        public User User { get;  private set; }
        public ICommand LoginCommand{ get; private set; }
        public bool HasChanged { get; set; }

        public UserViewModel(User u)
        {
            u.Username = "HDIChris1";
            u.Password = "11111111";
            u.Server = 43;
            User = u;
            User.PropertyChanged += (s, e) => HasChanged = true;
            LoginCommand =  new DelegateCommand<User>(o => Sending(), o => true);

        }


        public async void Sending()
        {
            User.NewRandom();
            String url = "http://www.wurzelimperium.de/dispatch.php?r="+User.GetRandom();
            String payload = "do=login&server=server"+User.Server+"&user="+User.Username+"&pass="+User.Password;
            String json= HttpPostRequest(url, payload);

            Dispatch dispatch = J2O.GetT<Dispatch>(json);
            User.Answer = dispatch.status;
            if (dispatch.status.Equals("ok") && dispatch.url!= null)
            {
                string loginData = "&embed=&ref=&retid=";
                String urld = dispatch.url;
                urld.Trim(new Char[] {(char)92}); // minus \
                User.Cookie = await HttpGetRequest(urld+loginData);
                Application.Current.MainWindow.Hide();  //todo (Hide?)
                ControlWindow cw = new ControlWindow(User);
                cw.Show();

            } 
        }

        private string HttpPostRequest(string url, string postParameters) {
            ServicePointManager.Expect100Continue = false;
            ASCIIEncoding encoding = new ASCIIEncoding();

            byte[] data = encoding.GetBytes(postParameters);

            HttpWebRequest req =
              (HttpWebRequest)WebRequest.Create(url);
            req.Method = "POST";
            req.ContentType = "application/x-www-form-urlencoded; charset=UTF-8";
            req.UserAgent = "Mozilla/5.0 (Windows NT 6.3; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/37.0.2062.124 Safari/537.36";
            req.Accept = "text/javascript, text/html, application/xml, text/xml, */*";
            req.ContentLength = data.Length;

            Stream newStream = req.GetRequestStream();
            // Send the data.
            newStream.Write(data, 0, data.Length);
            newStream.Close();

            HttpWebResponse rep = (HttpWebResponse)req.GetResponse();

            Stream responseStream = rep.GetResponseStream();

            StreamReader myStreamReader = new StreamReader(responseStream, Encoding.Default);

            string pageContent = myStreamReader.ReadToEnd();

            myStreamReader.Close();
            responseStream.Close();
            rep.Close();

            return pageContent;
        }


        private async Task<CookieContainer> HttpGetRequest(string url)
        {
            CookieContainer cookies = new CookieContainer();
            HttpClientHandler handler = new HttpClientHandler();
            handler.CookieContainer = cookies;
            HttpClient client = new HttpClient(handler);
            var request = new HttpRequestMessage(HttpMethod.Get, url);
            HttpResponseMessage response = await client.SendAsync(request);
            return cookies;
        }

    }
}
