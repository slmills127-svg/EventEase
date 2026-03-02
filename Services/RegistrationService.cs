using EventEase.Models;

namespace EventEase.Services
{
    public class RegistrationService
    {
        private readonly List<Registration> registrations = new();

        public void AddRegistration(Registration reg)
        {
            registrations.Add(reg);
        }

        public IEnumerable<Registration> GetRegistrationsForEvent(int eventId)
        {
            return registrations.Where(r => r.EventId == eventId);
        }

        public bool IsUserRegistered(string email, int eventId)
        {
            return registrations.Any(r => r.Email == email && r.EventId == eventId);
        }
    }
}