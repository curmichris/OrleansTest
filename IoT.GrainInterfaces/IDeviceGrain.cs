using System.Threading.Tasks;
using Orleans;

namespace IoT.GrainInterfaces
{
    /// <summary>
    /// Grain interface IGrain1
    /// </summary>
    public interface IDeviceGrain : IGrainWithGuidKey
    {
        Task SetTemperature(double value);
    }
}
