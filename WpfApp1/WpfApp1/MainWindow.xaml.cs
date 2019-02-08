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

namespace WpfApp1
{
    public class BoundObject
    {
        public string MyProperty { get; set; }
        public void MyMethod()
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
            
            browser.Address = "file:///C:/HTML/youtubesampleIfarameAPI.html";


            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            browser.GetMainFrame().EvaluateScriptAsync(@"alert('test')");

            
            // After your ChromiumWebBrowser has been created you can register the object, if you wait too long an exception will be thrown 
            // saying the browser is already initialized and it's too late.
            //browser = new ChromiumWebBrowser();

             //Standard object rego
            
            //browser.RegisterAsyncJsObject("bound", new AsyncBoundObject(), BindingOptions.DefaultBinder); //Use the default binder to serialize values into complex objects
            //browser.RegisterAsyncJsObject("bound", new AsyncBoundObject(), new BindingOptions { CamelCaseJavascriptNames = false, Binder = new MyCustomBinder() }); //No camelcase of names and specify a default binder

        }


        
    }
}

