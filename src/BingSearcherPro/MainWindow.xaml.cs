using System.Collections.Generic;
using BingSearcherPro.Models;

namespace BingSearcherPro
{
    public partial class MainWindow
    {
        public List<Account> AccountList { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Browser.Navigate("http://www.bing.com");
        }
    }
}
