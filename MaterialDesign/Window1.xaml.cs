using MaterialDesignExtensions.Model;
using MaterialDesignThemes.Wpf;
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

namespace MaterialDesign
{
    /// <summary>
    /// Window1.xaml 的交互逻辑
    /// </summary>
    public partial class Window1 : MaterialDesignExtensions.Controls.MaterialWindow
    {
        public Window1()
        {
            InitializeComponent();
            InitSideNavMenu();
        }

        private void InitSideNavMenu()
        {
            List<INavigationItem> navigationItems = new List<INavigationItem>()
            {
                new SubheaderNavigationItem() { Subheader = "传感器" },
                new FirstLevelNavigationItem() { Label = "ATU-S506", Icon = PackIconKind.Instagram, IsSelected = true },
                //new DividerNavigationItem(),
                //new SubheaderNavigationItem() { Subheader = "Media" },
                //new FirstLevelNavigationItem() { Label = "Images", Icon = PackIconKind.Image },
                //new SecondLevelNavigationItem() { Label = "Camera", Icon = PackIconKind.Camera },
                //new FirstLevelNavigationItem() { Label = "Music", Icon = PackIconKind.Music },
                //new FirstLevelNavigationItem() { Label = "Videos", Icon = PackIconKind.Video }
            };

            sideNav.Items = navigationItems;
        }

        private void NavigationItemSelected(object sender, MaterialDesignExtensions.Controls.NavigationItemSelectedEventArgs args)
        {
            if (appBar != null)
            {
                appBar.IsNavigationDrawerOpen = false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 鼠标事件处理，左键按住移动时使得窗体可拖拽
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Max(object sender, RoutedEventArgs e)
        {
            //WindowState = WindowState.Maximized;
            WindowState = (WindowState == WindowState.Maximized ? WindowState.Normal : WindowState.Maximized);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Min(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void appBar_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            WindowState = (WindowState == WindowState.Maximized ? WindowState.Normal : WindowState.Maximized);
        }
    }
}
