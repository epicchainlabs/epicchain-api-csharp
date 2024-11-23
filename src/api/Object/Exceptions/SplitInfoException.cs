using System;

namespace EpicChain.API.v2.Object.Exceptions
{
    public class SplitInfoException : Exception
    {
        private readonly SplitInfo splitInfo;

        public SplitInfoException(SplitInfo si)
        {
            splitInfo = si;
        }

        public SplitInfo SplitInfo()
        {
            return splitInfo;
        }
    }
}
