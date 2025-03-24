using Notifications.Data;

namespace Notifications
{
    public class FlightEventArgs :EventArgs
    {
        public Flight FlightData { get; set; }
    }

    public interface IPriceUpdater
    {
        public bool UpdatePrice(int flightId, int price);

        public event EventHandler<FlightEventArgs> FlightChanged;

    }
}
