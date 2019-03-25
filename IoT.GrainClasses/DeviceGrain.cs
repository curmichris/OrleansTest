using System;
using System.Threading.Tasks;
using IoT.GrainInterfaces;
using Orleans;

namespace IoT.GrainClasses
{
    /// <summary>
    /// Grain implementation class Grain1.
    /// </summary>
    public class DeviceGrain : Grain, IDeviceGrain
    {
        private double lastValue;
        public override Task OnActivateAsync()
        {
            var id = this.GetPrimaryKeyLong();
            Console.WriteLine("Activated {0}", id);

            return base.OnActivateAsync();
        }

        public Task SetTemperature(double value)
        {
            if (lastValue < 100 && value > 100)
            {
                Console.WriteLine("High Temperature recorded {0}", value);
            }

            lastValue = value;
            return TaskDone.Done;
        }
    }
}
