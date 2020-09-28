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

namespace WechatRobot
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DMSkinWindow_Loaded(object sender, RoutedEventArgs e)
        {
            //Naviga = true;

            //MainPage.IsChecked = true;
            //ChangeView_Click(MainPage, e);
        }

        private void DMSkinWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
