using InterfaceHierarchy;
using TransportsHierarchy;
using TransportsHierarchy.AirTransport;
using TransportsHierarchy.GroundTransport;
using TransportsHierarchy.WaterTransport;

namespace ClientClass
{
    public class Client
    {
        private Transport transport;
        private Transport CreateTransport()
        {
            Console.WriteLine("Choose an hierarchy of your transport(Ground,Water,Air)");
            string hierarchy = Console.ReadLine();

            Console.WriteLine("Choose a transport, thats included in your hierarchy:");
            string transportOption = Console.ReadLine();


            transport = hierarchy switch
            {
                "Ground" => transportOption switch
                {
                    "Automobile" => new Automobile(),
                    "Railroad" => new Railroad(),
                    "Horse-drawn" => new HorseDrawn(),
                    _ => throw new Exception("Invalid transport option for Ground hierarchy.")
                },
                "Water" => transportOption switch
                {
                    "Boat" => new Boat(),
                    "Tanker" => new Tanker(),
                    "Motorship" => new Motorship(),
                    _ => throw new Exception("Invalid transport option for Water hierarchy.")
                },
                "Air" => transportOption switch
                {
                    "Airplane" => new Airplane(),
                    "Helicopter" => new Helicopter(),
                    "Airship" => new Airship(),
                    _ => throw new Exception("Invalid transport option for Air hierarchy.")
                },
                _ => throw new Exception("There is no such hierarchy option.")
            };

            return transport;

        }

        private void Routing()
        {
            if (transport is IGround ground)
                ground.BuildGroundRoute();
            else if (transport is IAir air)
                air.BuildAirRoute();
            else if (transport is IWater water)
                water.BuildWaterRoute();

            transport.Move();
        }

        public void Begin()
        {
            CreateTransport();
            Routing();
        }
    }
}
