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
using System.Windows.Navigation;
using System.Windows.Shapes;
using CefSharp.Wpf;
using CefSharp;
using CefSharp.Structs;
using System.Diagnostics;
using static WpfApp1.BoundObject;
using System.IO;

namespace WpfApp1
{
    public class BoundObject
    {
        public string MyProperty { get; set; }
        public void a()
        {
            // Do something really cool here.
            MessageBox.Show("Something to do!");
        }
                
    }
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        ChromiumWebBrowser browser;
        public MainWindow thiswindow;
        public MainWindow()
        {
            InitializeComponent();


            CefSharpSettings.LegacyJavascriptBindingEnabled = true;
            browser = new ChromiumWebBrowser();

            
            browser.RegisterAsyncJsObject("bound", new BoundObject());


            MAIN.Children.Add(browser);
            thiswindow = this;
            //browser.MenuHandler = new ContextMenuHandler();
            //browser.RequestHandler = new RequestHandler();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
         //   browser.Address = "file:///C:/HTML/youtubesampleIfarameAPI.html";

            VlcControl1.vlcPlayer.MediaPlayer.VlcLibDirectory =new DirectoryInfo(@"c:\Program Files\VideoLAN\VLC\");
            VlcControl1.vlcPlayer.MediaPlayer.EndInit();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            browser.GetMainFrame().EvaluateScriptAsync(@"alert('test')");
          //  VlcControl1.vlcPlayer.MediaPlayer.Play(@"https://r5---sn-gvnuxaxjvh-aome.googlevideo.com/videoplayback?key=yt6&ip=77.51.1.96&fvip=4&ipbits=0&ei=AYZkXMqMBZO4yQWkirmIBw&id=o-AEdaYtSaiuuVAtNuuWS6S7lJ3RFlbfibGu2w39BvxQNL&mm=31%2C29&mn=sn-gvnuxaxjvh-aome%2Csn-n8v7kn76&dur=0.000&gir=yes&lmt=1467907874541427&clen=577017&mt=1550091665&mv=m&ms=au%2Crdu&source=youtube&mime=video%2Fwebm&itag=43&expire=1550113377&sparams=clen%2Cdur%2Cei%2Cgir%2Cid%2Cinitcwndbps%2Cip%2Cipbits%2Citag%2Clmt%2Cmime%2Cmm%2Cmn%2Cms%2Cmv%2Cnh%2Cpl%2Cratebypass%2Crequiressl%2Csource%2Cexpire&nh=%2CIgpwcjA0LnN2bzAzKgkxMjcuMC4wLjE&c=WEB&initcwndbps=1133750&ratebypass=yes&signature=4A21F561E48AC296583EC54D2E25E21E8C90DDEC.3379B6FEBA2CB7A2B799F269946C0B8442F7EEF3&requiressl=yes&pl=21");

            VlcControl1.vlcPlayer.MediaPlayer.Play(@"https://r3---sn-gvnuxaxjvh-aome.googlevideo.com/videoplayback?txp=4532432&mm=31,29&mn=sn-gvnuxaxjvh-aome,sn-n8v7znze&ip=77.51.1.96&key=yt6&id=o-ANEl4q_0rsKMIa56fs_SPKHQin_9PfsoVChDdXiQqO7m&signature=8781E9BD91B4CFD39F3DF1DBE77C4C30A5C529EE.46F41412CA666B3F3D18F3818823242038B19A06&ipbits=0&ms=au,rdu&mt=1550088635&mv=m&pl=21&fvip=13&lmt=1549341608408328&c=WEB&source=youtube&ratebypass=yes&initcwndbps=1097500&nh=,IgpwcjAyLnN2bzAzKgkxMjcuMC4wLjE&itag=22&mime=video/mp4&expire=1550110316&requiressl=yes&sparams=dur,ei,id,initcwndbps,ip,ipbits,itag,lmt,mime,mm,mn,ms,mv,nh,pl,ratebypass,requiressl,source,expire&dur=2165.121&ei=DHpkXJKhHNDR7QSl8LmICA&fallback_host=");

            
            // After your ChromiumWebBrowser has been created you can register the object, if you wait too long an exception will be thrown 
            // saying the browser is already initialized and it's too late.
            //browser = new ChromiumWebBrowser();

             //Standard object rego
            
            //browser.RegisterAsyncJsObject("bound", new AsyncBoundObject(), BindingOptions.DefaultBinder); //Use the default binder to serialize values into complex objects
            //browser.RegisterAsyncJsObject("bound", new AsyncBoundObject(), new BindingOptions { CamelCaseJavascriptNames = false, Binder = new MyCustomBinder() }); //No camelcase of names and specify a default binder

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            Uri U = new Uri(@"https://r3---sn-gvnuxaxjvh-aome.googlevideo.com/videoplayback?txp=4532432&mm=31,29&mn=sn-gvnuxaxjvh-aome,sn-n8v7znze&ip=77.51.1.96&key=yt6&id=o-ANEl4q_0rsKMIa56fs_SPKHQin_9PfsoVChDdXiQqO7m&signature=8781E9BD91B4CFD39F3DF1DBE77C4C30A5C529EE.46F41412CA666B3F3D18F3818823242038B19A06&ipbits=0&ms=au,rdu&mt=1550088635&mv=m&pl=21&fvip=13&lmt=1549341608408328&c=WEB&source=youtube&ratebypass=yes&initcwndbps=1097500&nh=,IgpwcjAyLnN2bzAzKgkxMjcuMC4wLjE&itag=22&mime=video/mp4&expire=1550110316&requiressl=yes&sparams=dur,ei,id,initcwndbps,ip,ipbits,itag,lmt,mime,mm,mn,ms,mv,nh,pl,ratebypass,requiressl,source,expire&dur=2165.121&ei=DHpkXJKhHNDR7QSl8LmICA&fallback_host=", UriKind.Absolute);
            MDE.Source = U;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MDE.Play();
        }
    }
}

