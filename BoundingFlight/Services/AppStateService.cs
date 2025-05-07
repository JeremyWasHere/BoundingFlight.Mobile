namespace BoundingFlight.Services
{
    public class AppStateService
    {
        public string? ApiKey
        {
            get { return "e6a3fe9ecac4441b8ead61db264e9848"; }
        }

        public readonly Dictionary<int, object> ObjectTunnel = new();

        public event Action? OnStateChange;

        public void NotifyStateChanged() => OnStateChange?.Invoke();
    }
}
