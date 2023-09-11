using data_access;
using data_access.Entities;
using data_access.Interfaces;
using data_access.Repositories;
using Microsoft.EntityFrameworkCore;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _02_wpf_client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        private void AllBought_Selected(object sender, RoutedEventArgs e)
        {
            tableView.ItemsSource = unitOfWork.BoughtRepo.Get(includeProperties:"Seller,Buyer").Select(x => new
            {
                x.Id,
                x.Price,
                Seller = x.Seller.Name,
                Buyer = x.Buyer.Name
            }) ;
        }

        private void AllBuyer_Selected(object sender, RoutedEventArgs e)
        {
            tableView.ItemsSource = unitOfWork.BuyerRepo.Get().Select(x => new
            {
                x.Id,
                x.Name,
               x.Surname,
               x.PhoneNumber,
               x.Email,

            });
        }

        private void AllGroup_Selected(object sender, RoutedEventArgs e)
        {
            tableView.ItemsSource = unitOfWork.GroupRepo.Get().Select(x => new
            {
                x.Id,
                x.Name,
                x.Age,
                x.NumberOfPeople
            });
        }

        private void AllMusicalRecord_Selected(object sender, RoutedEventArgs e)
        {
            tableView.ItemsSource = unitOfWork.MusicRecordRepo.Get(includeProperties: "Group").Select(x => new
            {
                x.Id,
                x.Name,
                x.Age,
                x.Price,
             Group = x.Group
               
            });
        }

        private void AllOrder_Selected(object sender, RoutedEventArgs e)
        {
            tableView.ItemsSource = unitOfWork.OrderRepo.Get(includeProperties: "Buyer").Select(x => new
            {
                x.Id,
                x.Sum,
                x.IsBought,
              Buyer =  x.Buyer,
               

            });
        }

        private void AllSeller_Selected(object sender, RoutedEventArgs e)
        {
            tableView.ItemsSource = unitOfWork.SellerRepo.Get().Select(x => new
            {
                x.Id,
              x.Name,
              x.Surname,
              x.Email,
              x.Phonenumber

            });
            
        }

        private void AllTrack_Selected(object sender, RoutedEventArgs e)
        {
            tableView.ItemsSource = unitOfWork.TrackRepo.Get(includeProperties: "MusicalRecord,Group,Ganre").Select(x => new
            {
                x.Id,
                x.Name,
                x.Longth,
                x.NumberOfAuditions,
                MusicalRecord =  x.MusicRecords,
                Group = x.Group,
                Ganre = x.Genre



            });
        }

        private void AllGenre_Selected(object sender, RoutedEventArgs e)
        {
            tableView.ItemsSource = unitOfWork.GenreRepo.Get(includeProperties: "MusicalRecord,Group,Ganre").Select(x => new
            {
                x.Id,
                x.Name,
          
            });
        }

        private void AddBought_Selected(object sender, RoutedEventArgs e)
        {
            AddBought addBought = new AddBought();
            addBought.ShowDialog();

        }

        private void AddBuyer_Selected(object sender, RoutedEventArgs e)
        {
            AddBuyer addBuyer = new AddBuyer();
            addBuyer.ShowDialog();
        }

        private void AddGenre_Selected(object sender, RoutedEventArgs e)
        {
            AddGenre addGenre = new AddGenre();
            addGenre.ShowDialog();
        }

        private void AddGroup_Selected(object sender, RoutedEventArgs e)
        {
            AddGroup addGroup = new AddGroup();
            addGroup.ShowDialog();
        }

        private void AddMusicRecord_Selected(object sender, RoutedEventArgs e)
        {
            AddMusicRecord addMusicRecord = new AddMusicRecord();
            addMusicRecord.ShowDialog();
        }

        private void AddOrder_Selected(object sender, RoutedEventArgs e)
        {
            AddOrder addOrder = new AddOrder();
            addOrder.ShowDialog();

        }

        private void AddSeller_Selected(object sender, RoutedEventArgs e)
        {
            AddSeller addSeller = new AddSeller();
            addSeller.ShowDialog();

        }

        private void AddTrack_Selected(object sender, RoutedEventArgs e)
        {
            AddTreck addTreck = new AddTreck();
            addTreck.ShowDialog();

        }
    }
}
