using EventEase.Models;

namespace EventEase.Services
{
    public class EventService
    {
        public List<Event> GetEvents() => new()
        {
            new Event { Id = 1, Name = "Tech Summit", Date = new DateTime(2025, 3, 10), Location = "Vancouver" },
            new Event { Id = 2, Name = "Marketing Expo", Date = new DateTime(2025, 3, 20), Location = "Victoria" }
        };
    }
}