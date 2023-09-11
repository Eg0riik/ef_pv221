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
    /// Interaction logic for AddSeller.xaml
    /// </summary>
    public partial class AddSeller : Window
    {
        UnitOfWork AddSellerr = new UnitOfWork();
        public AddSeller()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            AddSellerr.SellerRepo.Insert(new Seller()
            {
                Name = this.nameTB.Text,
                Surname = this.SurnameTB.Text,
                    Email = this.EmailTB.Text,
               Phonenumber = this.PhoneNumberTB.Text,

            });
            AddSellerr.Save();
            this.Close();
        }
    }
}
