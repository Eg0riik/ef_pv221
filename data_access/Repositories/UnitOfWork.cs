using data_acces;
using data_access.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_access.Repositories
{
    public interface IUoW
    {
        Repository<Bought> BoughtRepo { get; }
        Repository<Buyer> BuyerRepo { get; }
        Repository<Genre> GenreRepo { get; }
        Repository<Group> GroupRepo { get; }

        Repository<MusicRecord> MusicRecordRepo { get; }
        Repository<Order> OrderRepo { get; }
        Repository<Seller> SellerRepo { get; }
        Repository<Track> TrackRepo { get; }
        void Save();
    }
    public class UnitOfWork : IUoW, IDisposable
    {
        private static MusicalShop context = new MusicalShop();
        private Repository<Bought> boughtRepo;
        private Repository<Buyer> buyerRepo;
        private Repository<Genre> genreRepo;
        private Repository<Group> groupRepo;
        private Repository<MusicRecord> musicRecordRepo;
        private Repository<Order> orderRepo;
        private Repository<Seller> sellerRepo;
        private Repository<Track> trackRepo;
    

        public Repository<Bought> BoughtRepo
        {
            get
            {
                if (this.boughtRepo == null)
                {
                    this.boughtRepo = new Repository<Bought>(context);
                }
                return boughtRepo;
            }
        }

        public Repository<Buyer> BuyerRepo
        {
            get
            {

                if (this.buyerRepo == null)
                {
                    this.buyerRepo = new Repository<Buyer>(context);
                }
                return buyerRepo;
            }
        }

        public Repository<Genre> GenreRepo
        {
            get
            {

                if (this.genreRepo == null)
                {
                    this.genreRepo = new Repository<Genre>(context);
                }
                return genreRepo;
            }
        }
        public Repository<Group> GroupRepo
        {
            get
            {

                if (this.groupRepo == null)
                {
                    this.groupRepo = new Repository<Group>(context);
                }
                return groupRepo;
            }
        }

        public Repository<MusicRecord> MusicRecordRepo
        {
            get
            {

                if (this.musicRecordRepo == null)
                {
                    this.musicRecordRepo = new Repository<MusicRecord>(context);
                }
                return musicRecordRepo;
            }
        }
        public Repository<Order> OrderRepo
        {
            get
            {

                if (this.orderRepo == null)
                {
                    this.orderRepo = new Repository<Order>(context);
                }
                return orderRepo;
            }
        }
        public Repository<Seller> SellerRepo
        {
            get
            {

                if (this.sellerRepo == null)
                {
                    this.sellerRepo = new Repository<Seller>(context);
                }
                return sellerRepo;
            }
        }
        public Repository<Track> TrackRepo
        {
            get
            {

                if (this.trackRepo == null)
                {
                    this.trackRepo = new Repository<Track>(context);
                }
                return trackRepo;
            }
        }
        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
