using TransportsHierarchy;

namespace InterfaceHierarchy
{
    public interface IGround 
    {
        void BuildGroundRoute();
    }

    public interface IWater
    {
        void BuildWaterRoute();
    }

    public interface IAir
    {
        void BuildAirRoute();
    }
}
