using EpicChainAPI.v2.Netmap;

namespace EpicChainAPI.v2.UnitTests.TestNetmap
{
    public static class Helper
    {
        public static Node GenerateTestNode(int index, params (string, string)[] attrs)
        {
            var ni = new NodeInfo();
            foreach (var item in attrs)
            {
                ni.Attributes.Add(new NodeInfo.Types.Attribute
                {
                    Key = item.Item1,
                    Value = item.Item2,
                });
            }
            return new Node(index, ni);
        }
    }
}