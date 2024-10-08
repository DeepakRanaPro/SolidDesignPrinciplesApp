namespace DependencyInversionApp.WithoutDependencyInversion
{
    public class Light
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
        private Light _light;

        public Switch(Light light)
        {
            _light = light;
        }

        public void Operate(bool on)
        {
            if (on)
                _light.TurnOn();
            else
                _light.TurnOff();
        }
    }
}
