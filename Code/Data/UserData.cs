namespace Notifications.Data
{
    public class UserData
    {
        private INotifier _notifier;
        public UserData(IPriceUpdater priceUpdater, INotifier notifier, int id, string name)//need to fill all fields
        {
            Id = id;
            Name = name;
            priceUpdater.FlightChanged += OnFlightCahanged;
            _notifier = notifier;
        }

        private void OnFlightCahanged(object? sender, FlightEventArgs e)
        {
            if (IsFlightRelevant(e.FlightData))
            {
                _notifier.RaiseFlightNotification(e.FlightData);
            }
        }

        public int Id { get; set; }
        public string Name { get; set; }

        // some constraints examples
        int maxPrice { get; set; }

        DateTime StartTime { get; set; } = DateTime.MinValue;
        DateTime EndTime { get; set; } = DateTime.MaxValue;

        public bool IsFlightRelevant(Flight flight)
        {
            if (flight.Price <= maxPrice && flight.FlightTime >= StartTime && flight.FlightTime <= EndTime
                ) // Add all other constraints checks, depends on the specs
                return true;
            return false;
        }



    }
}
