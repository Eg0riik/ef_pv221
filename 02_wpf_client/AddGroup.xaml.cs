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
    /// Interaction logic for AddGroup.xaml
    /// </summary>
    public partial class AddGroup : Window
    {
        UnitOfWork AddGroupp = new UnitOfWork();
        public AddGroup()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            AddGroupp.GroupRepo.Insert(new Group()
            {
                Name = this.nameTB.Text,
                Age = Convert.ToInt32(this.AgeTB.Text),
                NumberOfPeople = Convert.ToInt32(this.NumberOfPeopleTB.Text),
            });
                AddGroupp.Save();
                this.Close();
        }
    }
}
