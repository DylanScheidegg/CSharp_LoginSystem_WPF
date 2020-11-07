//using OpenQA.Selenium.Chrome;
using System.Windows;
//using System.IO;
//using Microsoft.Win32;
using System;
using System.Windows.Threading;
//using System.Net;

namespace WPF_TikTokCopyLink
{
    /// <summary>
    /// Interaction logic for Main.xaml
    /// </summary>
    /// https://www.youtube.com/watch?v=QkT8fgoFz3g
    /// 

    public partial class Main : Window
    {
        //https://www.youtube.com/watch?v=bz-CdFkElK4

        string[] proxies;
        int count;
        int inter;
        bool started;
        DispatcherTimer dt = new DispatcherTimer();

        public Main()
        {
            InitializeComponent();

            //inter = 1/4;
            inter = 10;
            dt.Interval = TimeSpan.FromSeconds(inter);
            dt.Tick += dtTicker;
            started = false;

        }

        private void dtTicker(object sender, EventArgs e)
        {
            lbProxUsing.Content = proxies[count];

            lbCount.Content = Convert.ToString(count);
            count++;
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            /*
            if (started == false)
            {
                var chromeOptions = new ChromeOptions();
                chromeOptions.AddArguments("headless");

                //string vidURL = "https://www.tiktok.com/@" + etUsername.Text + "/video/" + etVideoID.Text + "?lang=en";
                string vidURL = "https://www.google.com/";

                using (var driver = new ChromeDriver(chromeOptions)) {
                    driver.Navigate().GoToUrl(vidURL);
                    
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(vidURL);
                    request.Method = "GET";
                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    using (var reader = new StreamReader(stream))
                    {
                        HttpStatusCode statusCode = ((HttpWebResponse)response).StatusCode;
                        string contents = reader.ReadToEnd();
                        MessageBox.Show(statusCode.ToString());
                    }

                }
                dt.Start();
            } else
            {
                dt.Stop();
                started = false;
            }

                //WinInetInterop.SetConnectionProxy(proxies[count]);
        */    
    }

        private void Load_Click(object sender, RoutedEventArgs e)
        {
            /*
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.DefaultExt = ".txt";
            openFile.Filter = "TXT Files (*.txt)|*.txt";

            if (openFile.ShowDialog() == true)
            {
                // Opens file
                string strFilePath = openFile.FileName;
                MessageBox.Show(strFilePath, "File Path Choosen For Proxies");

                // Reads File
                StreamReader stream = new StreamReader(strFilePath);
                string fileData = stream.ReadToEnd();

                // Displaying Results
                string data = fileData.ToString();

                // Put into Global Array
                proxies = data.Split('\n');

                string lstrList = "";
                foreach (string i in proxies)
                {
                    //MessageBox.Show(i, "hi");
                    lstrList += i + '\n';
                }
                tbProxyList.Text = lstrList;

                // Close Reader
                stream.Close();

            }
            */
        }
        
    }
   
}
