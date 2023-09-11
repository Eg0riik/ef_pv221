using data_access.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace data_acces
{
    public class MusicalShop : DbContext
    {
        public MusicalShop() :base(){ }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            //modelBuilder.Entity<MusicalShop>().HasData(new[]
            //{

            //    //new Bought() { Id = 1,  },


            //});
            modelBuilder.Entity<MusicalShop>().HasData(new[]
            {
            
                new Buyer() { Id = 1, Name = "Josh",Surname ="Bender ",PhoneNumber = "+380123899"},
                new Buyer() { Id = 2, Name = "Tomas",Surname ="Shelbi",PhoneNumber = "+380809722"},

            });

            modelBuilder.Entity<MusicalShop>().HasData(new[]
           {

                new Genre() { Id = 1, Name = "Hip hop"},
                new Genre() { Id = 2, Name = "Rock"},
                 new Genre() { Id = 3, Name = "Rep"},

            });

            modelBuilder.Entity<MusicalShop>().HasData(new[]
           {

                new Group() { Id = 1, Name = "TopGroup",Age = 12, NumberOfPeople = 5},
                new Group() { Id = 2, Name = "RockGroup",Age =11, NumberOfPeople = 8},
                 new Group() { Id = 3, Name = "RepGroup",Age= 7,NumberOfPeople = 4},
            });
            modelBuilder.Entity<MusicalShop>().HasData(new[]
          {

                new MusicRecord() { Id = 1, Name = "TopMusic2023",Age = 1,  Price = "100$",GroupId = 1},
                new MusicRecord() { Id = 2, Name = "TopRock2011",Age = 12, Price = "1020$",GroupId = 2},
                 new MusicRecord() { Id = 3, Name = "GoodRep2021",Age =2,Price = "100$",GroupId = 3 },
            });
            modelBuilder.Entity<MusicalShop>().HasData(new[]
        {

                new Order() { Id = 1,Sum = "100$",IsBought = false,BuyerId = 1},
                new Order() { Id = 2,Sum = "201$",IsBought = true, BuyerId = 1},
                new Order() { Id = 3,Sum = "1000$",IsBought = false, BuyerId = 2},
            });
            modelBuilder.Entity<MusicalShop>().HasData(new[]
   {

                new Seller() { Id = 1,Name = "Tolik",Surname="Nikityk",Email="lalalal@gmail.com",Phonenumber="+380128566"},
                new Seller() { Id = 2,Name = "Vlad",Surname = "Rom",Email="romdjeka@gmail.com",Phonenumber= "+380121216"},
                new Seller() { Id = 3,Name = "Rick",Surname = "Adik",Email="Adidas007@gmail.com",Phonenumber="+48102900"},
            });
            modelBuilder.Entity<MusicalShop>().HasData(new[]
   {

                new Track() { Id = 1,Name = "LAlala",Longth ="3:00",NumberOfAuditions = 159992,MusicalRecordId = 1,GroupId =1,GanreId = 1},
                new Track() { Id = 2,Name = "Vlad",Longth ="2:40",NumberOfAuditions = 812323,MusicalRecordId = 2,GroupId =2,GanreId = 2},
                new Track() { Id = 3,Name = "Rick",Longth = "1:40", NumberOfAuditions = 15922, MusicalRecordId = 3, GroupId = 3, GanreId = 3},
            });
        }   
        //Entiti frem pideednanui
            public DbSet<Bought> Boughts { get; set; }
            public DbSet<Buyer> Buyers { get; set; }
            public DbSet<Genre> Ganres { get; set; }
            public DbSet<Group> Groups { get; set; }
            public DbSet<MusicRecord> MusicRecords { get; set; }
            public DbSet<Order> Orders { get; set; }
            public DbSet<Seller> Sellers { get; set; }
            public DbSet<Track> Tracks { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conn = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MusicalShop;Integrated Security=True;Connect Timeout=30;";
            optionsBuilder.UseSqlServer(conn);
        }
    }
}


 
      