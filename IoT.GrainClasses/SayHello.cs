using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IoT.GrainInterfaces;
using Orleans;

namespace IoT.GrainClasses
{
    public class SayHello : Grain, GrainInterfaces.ISayHello
    {
        public Task<string> SayHelloMessage()
        {
            return Task.FromResult("Hello!");
        }
    }
}
