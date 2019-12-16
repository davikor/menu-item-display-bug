using System.Collections.Generic;

namespace PrismUpdateTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            NewMenu.ItemsSource = new List<MenuItemViewModel>
            {
                new MenuItemViewModel("Shouldn't"),
                new MenuItemViewModel("have"),
                new MenuItemViewModel("the MenuItem container"),
                new MenuItemViewModel("twice")
            };
        }
    }
}
