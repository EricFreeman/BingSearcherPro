using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using BingSearcherPro.Models;

namespace BingSearcherPro
{
    public partial class MainWindow : INotifyPropertyChanged
    {
        private List<Account> _accountList;

        public List<Account> AccountList
        {
            get { return _accountList; }
            set
            {
                _accountList = value;
                OnPropertyChanged();
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            Browser.Navigate("http://www.bing.com");

            AccountList = new List<Account>();
            AccountList.Add(new Account {UserName = "Bob", Password = "123"});
            Accounts.ItemsSource = AccountList;
        }

        #region Notify Property Changed

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
