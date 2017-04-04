using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


// “空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=234238 上有介绍

namespace 且行且烹饪
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class StoryPage : Page
    {
        public StoryPage()
        {
            this.InitializeComponent();

            //连接数据库
            //SQLiteConnection db = CreatSQLiteConnection();
 
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            //To Do
            //this.Frame.Navigate(typeof());
        }

        private void Forward_Click(object sender, RoutedEventArgs e)
        {
            //To Do
            //this.Frame.Navigate(typeof());
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }
    }
}
