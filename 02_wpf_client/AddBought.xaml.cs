using data_access.Entities;
using data_access.Repositories;
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

namespace _02_wpf_client
{
    /// <summary>
    /// Interaction logic for AddBought.xaml
    /// </summary>
    public partial class AddBought : Window
    {
        UnitOfWork AddBoughtt = new UnitOfWork();
        public AddBought()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            AddBoughtt.BoughtRepo.Insert(new Bought()
            {
                Price = Convert.ToInt32(this.PriceTB.Text),
                SallerId = Convert.ToInt32( SellerTB.Text),
                   BuyerId = Convert.ToInt32(BuyerTB.Text)

            }) ;
            AddBoughtt.Save();
            this.Close();
        }
    }
}
