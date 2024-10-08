namespace DependencyInversionApp.WithDependencyInversion
{
    public interface IDevice
    {
        void TurnOn();
        void TurnOff();
    }

    public class Light : IDevice
    {
        public void TurnOn()
        {
            Console.WriteLine("Light is on.");
        }

        public void TurnOff()
        {
            Console.WriteLine("Light is off.");
        }
    }

    public class Switch
    {
        private IDevice _device;

        public Switch(IDevice device)
        {
            _device = device;
        }

        public void Operate(bool on)
        {
            if (on)
                _device.TurnOn();
            else
                _device.TurnOff();
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            IDevice light = new Light();
            Switch lightSwitch = new Switch(light);

            lightSwitch.Operate(true);  // Output: Light is on.
            lightSwitch.Operate(false); // Output: Light is off.
        }
    } 
}
