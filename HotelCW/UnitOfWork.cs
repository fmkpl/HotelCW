using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelCW
{
    public class UnitOfWork : IDisposable
    {
        private MyDbContext db = new MyDbContext();

        private AdminRepository adminRepository;
        private RoomRepository roomRepository;
        private UserRepository userRepository;

        public AdminRepository Admins
        {
            get 
            {
                if (adminRepository == null) 
                {
                    adminRepository = new AdminRepository(db);
                }
                return adminRepository;
            }
        }

        public UserRepository Users
        {
            get
            {
                if (userRepository == null)
                {
                    userRepository = new UserRepository(db);
                }
                return userRepository;
            }
        }

        public RoomRepository Rooms
        {
            get
            {
                if (roomRepository == null)
                {
                    roomRepository = new RoomRepository(db);
                }
                return roomRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;


        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }


        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
