using Notifications.Data;

namespace Notifications
{
    public interface IUsersManager
    {
        public bool AddOrUpdateUser(UserData user);

        public bool AddUser(UserData user);
        public bool UpdateUser(UserData user);
        public bool DeleteUser(int id);
    }
}
