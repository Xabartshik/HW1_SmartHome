namespace SmartDevicesProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sHub = new SmartHub
            {
                Name = "Хаб",
                Id = 0
            };
            var actuator = new Actuator
            {
                Name = null,
                Id = 1
            };
            var sensor1 = new Sensor { Name = "Сенсор-1", Id = 2 };
            
            var sensor2 = new Sensor { Name = "Сенсор-2", Id = 3 };

            sensor1.Connect(sHub);
            sensor2.Connect(sHub);
            actuator.Connect(sHub);
            Console.WriteLine();

            sensor1.Record(42);
            sensor2.Record(63);
            actuator.Toggle();
            Console.WriteLine();

            Console.WriteLine(sensor1.GetStatus());
            Console.WriteLine(sensor2.GetStatus());
            Console.WriteLine(actuator.GetStatus());
            Console.WriteLine(sHub.GetStatus());
            Console.WriteLine();

            sensor1.Disconnect();
            sensor2.Disconnect();
            actuator.Disconnect();
            Console.WriteLine();

            Console.WriteLine(sHub.GetStatus());
            Console.WriteLine();
        }
    }
}
