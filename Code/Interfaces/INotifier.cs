using Notifications.Data;

namespace Notifications
{
    public interface INotifier
    {
        public void RaiseFlightNotification(Flight flight);
    }
}
