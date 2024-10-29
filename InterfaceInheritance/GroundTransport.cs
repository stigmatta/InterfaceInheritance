using InterfaceHierarchy;

namespace TransportsHierarchy
{
    namespace GroundTransport
    {
        public class Automobile : Transport, IGround
        {
            private static readonly string name = "Automobile";
            public override string Name => name;

            private static readonly string action = "Moving";
            public override string Action => action;

            public void BuildGroundRoute()
            {
                Console.WriteLine("Ground route for {0} has been built",Name);
            }

        }


        public class Railroad : Transport, IGround
        {
            private static readonly string name = "Railroad";
            public override string Name => name;
            private static readonly string action = "Moving";
            public override string Action => action;

            public void BuildGroundRoute()
            {
                Console.WriteLine("Ground route for {0} has been built",Name);
            }

        }

        public class HorseDrawn : Transport, IGround
        {
            private static readonly string name = "Horse-drawn";
            public override string Name => name;

            private static readonly string action = "Moving";
            public override string Action => action;

            public void BuildGroundRoute()
            {
                Console.WriteLine("Ground route for {0} has been built",Name);
            }

        }
    }

}
