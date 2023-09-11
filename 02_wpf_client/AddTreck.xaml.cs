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
    /// Interaction logic for AddTreck.xaml
    /// </summary>
    public partial class AddTreck : Window
    {
        UnitOfWork AddTreckk = new UnitOfWork();
        public AddTreck()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            AddTreckk.TrackRepo.Insert(new Track()
            {
                Name = this.name.Text,
                Longth = this.LengthTB.Text,
                NumberOfAuditions =Convert.ToInt32( this.LengthTB.Text),
                MusicalRecordId = Convert.ToInt32(this.MusicalRecordIdTB.Text),
                GroupId = Convert.ToInt32(this.GroupIdTB.Text),
                 GanreId = Convert.ToInt32(this.GanreIdTb.Text),
            });
            AddTreckk.Save();
            this.Close();
        }
    }
}
