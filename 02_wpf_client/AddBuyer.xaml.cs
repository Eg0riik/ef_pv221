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
    /// Interaction logic for AddBuyer.xaml
    /// </summary>
    public partial class AddBuyer : Window
    {
        UnitOfWork AddBuyerr = new UnitOfWork();
        public AddBuyer()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
             AddBuyerr.BuyerRepo.Insert(new Buyer()
            {
                 Name = this.name.Text,
                 Surname = this.Surname.Text,
                 PhoneNumber= this.PhoneNumber.Text,
                 Email= this.Email.Text,
             });
            AddBuyerr.Save();
            this.Close();
        }
    }
}
