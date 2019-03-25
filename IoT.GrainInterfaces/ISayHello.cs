using System.Threading.Tasks;
using Orleans;

namespace IoT.GrainInterfaces
{
    public interface ISayHello : IGrainWithIntegerKey
    {
        Task<string> SayHelloMessage();
    }
}
