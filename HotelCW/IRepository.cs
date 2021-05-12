using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelCW
{
    interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        void Create(T item);
        void Update(T item);
        void Delete(int id);
    }

    public class AdminRepository : IRepository<Admin>
    {
        private MyDbContext db;

        public AdminRepository(MyDbContext context) 
        {
            this.db = context;
        }

        public IEnumerable<Admin> GetAll()
        {
            return db.Admins;
        }

        public Admin Get(int id)
        {
            return db.Admins.Find(id);
        }

        public void Create(Admin admin)
        {
            db.Admins.Add(admin);
        }

        public void Update(Admin admin)
        {
            db.Entry(admin).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Admin admin = db.Admins.Find(id);
            if (admin != null)
                db.Admins.Remove(admin);
        }
    }


    public class RoomRepository : IRepository<Room>
    {
        private MyDbContext db;

        public RoomRepository(MyDbContext context)
        {
            this.db = context;
        }

        public IEnumerable<Room> GetAll()
        {
            return db.Rooms;
        }

        public Room Get(int id)
        {
            return db.Rooms.Find(id);
        }

        public void Create(Room room)
        {
            db.Rooms.Add(room);
        }

        public void Update(Room room)
        {
            db.Entry(room).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Room room = db.Rooms.Find(id);
            if (room != null)
                db.Rooms.Remove(room);
        }
    }


    public class UserRepository : IRepository<User>
    {
        private MyDbContext db;

        public UserRepository(MyDbContext context)
        {
            this.db = context;
        }

        public IEnumerable<User> GetAll()
        {
            return db.Users;
        }

        public User Get(int id)
        {
            return db.Users.Find(id);
        }

        public void Create(User user)
        {
            db.Users.Add(user);
        }

        public void Update(User user)
        {
            db.Entry(user).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            User user = db.Users.Find(id);
            if (user != null)
                db.Users.Remove(user);
        }
    }
}
