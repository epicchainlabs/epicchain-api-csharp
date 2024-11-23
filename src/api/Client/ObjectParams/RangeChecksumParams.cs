using EpicChainAPI.v2.Object;
using EpicChainAPI.v2.Refs;
using System.Collections.Generic;

namespace EpicChainAPI.v2.Client.ObjectParams
{
    public class RangeChecksumParams
    {
        public Address Address;
        public bool Raw;
        public List<Range> Ranges;
        public ChecksumType Type;
        public byte[] Salt;
    }
}
