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
    /// Interaction logic for AddMusicRecord.xaml
    /// </summary>
    public partial class AddMusicRecord : Window
    {
        UnitOfWork AddMusicRecordd = new UnitOfWork();
        public AddMusicRecord()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            AddMusicRecordd.MusicRecordRepo.Insert(new MusicRecord()
            {
                Name = this.nameTB.Text,
                Age = Convert.ToInt32(this.AgeTB.Text),
                Price = this.PriceTB.Text,
                GroupId = Convert.ToInt32(this.GroupTB.Text),

            });
            AddMusicRecordd.Save();
            this.Close();
        }
    }
}
