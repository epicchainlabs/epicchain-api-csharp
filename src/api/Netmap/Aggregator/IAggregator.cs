
namespace EpicChain.API.v2.Netmap.Aggregator
{
    public interface IAggregator
    {
        void Add(double w);
        double Compute();
        void Clear();
    }
}
