namespace SmartDevicesProject
{
    public class SmartHub : Device
    {
        public int DevicesCount { get; set; }
        public override string GetStatus()
        {
            return $"Hub {Name}: {DevicesCount} device(s) connected";
        }
        public void AddDevice()
        {
            DevicesCount++;
        }
        public void RemoveDevice()
        {
            if (DevicesCount >= 1)
            {
                DevicesCount--;
            }
        }
    }
}