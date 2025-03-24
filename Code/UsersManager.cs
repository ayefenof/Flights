using Notifications.Data;

namespace Notifications
{
    public class UsersManager : IUsersManager
    {
       private readonly Dictionary<int, UserData> _users = new (); //in real system will use kind of orm to real db, can use concurrent dictionary if we want to enable few clients on the same user  
        static int _counter = 0;
        Mutex _mutex= new Mutex();

        public bool AddOrUpdateUser(UserData user)
        {
            _users[user.Id] = user; 
            return true;
        }

        public bool AddUser(UserData user)
        {
            _mutex.WaitOne();
            _counter++;
            _users.Add(_counter, user);
            _mutex.ReleaseMutex();
            return true;
        }

        public bool DeleteUser(int id)
        {
            if(_users.ContainsKey(id))
            {
                _users.Remove(id);
            }
            return true;
        }

        public bool UpdateUser(UserData user)
        {
            if (_users.ContainsKey(user.Id))
            {
                _users[user.Id] = user;
                return true;
            }
            return false;
        }

        public bool UpdatePrice(int flightId, int price)
        {
            throw new NotImplementedException();
        }
    }
}
