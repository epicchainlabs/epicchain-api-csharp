using EpicChain.API.v2.Session;
using Google.Protobuf;

namespace EpicChain.API.v2.Session
{
    public interface IResponseMeta
    {
        ResponseMetaHeader MetaHeader { get; set; }
    }

    public interface IResponse : IResponseMeta
    {
        ResponseVerificationHeader VerifyHeader { get; set; }
        IMessage GetBody();
    }
}