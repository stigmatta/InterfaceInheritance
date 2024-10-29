using InterfaceHierarchy;

namespace TransportsHierarchy
{
    namespace AirTransport
    {
        public class Airplane: Transport, IAir
        {
            private static readonly string name = "Airplane";
            private static readonly string action = "Flying";
            public override string Action => action;

            public override string Name => name;


            public void BuildAirRoute()
            {
                Console.WriteLine("Air route for {0} has been built", Name);
            }
        }

        public class Helicopter : Transport, IAir
        {
            private static readonly string name = "Helicopter";
            public override string Name => name;
            private static readonly string action = "Flying";
            public override string Action => action;
            public void BuildAirRoute()
            {
                Console.WriteLine("Air route for {0} has been built", Name);
            }

        }

        public class Airship : Transport, IAir
        {
            private static readonly string name = "Airship";
            public override string Name => name;

            private static readonly string action = "Flying";
            public override string Action => action;
            public void BuildAirRoute()
            {
                Console.WriteLine("Air route for {0} has been built", Name);
            }

        }
    }

}
