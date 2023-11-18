using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppPub3.Models;

namespace WpfAppPub3.ViewModels
{
    public class ShowHistroyModels:BaseViewModels
    {
        private ObservableCollection<Beer> purchaseHistory;

        public ObservableCollection<Beer> PurchaseHistory
        {
            get { return purchaseHistory; }
            set { purchaseHistory = value; OnPropertyChanged(); }
        }

        public ShowHistroyModels()
        {
            PurchaseHistory = new ObservableCollection<Beer>();
        }

        public double CalculateTotal()
        {
            return PurchaseHistory.Sum(beer => beer.Total);
        }
    }
}
