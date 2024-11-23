using EpicChain.API.v2.Refs;

namespace EpicChain.API.v2.Session
{
    public partial class RequestMetaHeader
    {
        public static RequestMetaHeader Default
        {
            get
            {
                var meta = new RequestMetaHeader()
                {
                    Version = Version.SDKVersion(),
                    Epoch = 0,
                    Ttl = 2,
                };
                return meta;
            }
        }
    }
}