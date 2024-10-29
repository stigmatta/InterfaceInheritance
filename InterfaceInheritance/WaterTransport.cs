using InterfaceHierarchy;

namespace TransportsHierarchy
{
    namespace WaterTransport
    {
        public class Tanker : Transport, IWater
        {
            private static readonly string name = "Tanker";
            public override string Name => name;

            private static readonly string action = "Swimming";
            public override string Action => action;

            public void BuildWaterRoute()
            {
                Console.WriteLine("Water route for {0} has been built", Name);
            }

        }

        public class Boat : Transport, IWater
        {
            private static readonly string name = "Boat";
            public override string Name => name;
            private static readonly string action = "Swimming";
            public override string Action => action;

            public void BuildWaterRoute()
            {
                Console.WriteLine("Water route for {0} has been built", Name);
            }

        }

        public class Motorship : Transport, IWater
        {
            private static readonly string name = "Motorship";
            public override string Name => name;
            private static readonly string action = "Swimming";
            public override string Action => action;

            public void BuildWaterRoute()
            {
                Console.WriteLine("Water route for {0} has been built", Name);
            }

        }

    }

}
