using Google.Protobuf;
using EpicChain;
using EpicChain.API.v2.Accounting;
using EpicChain.API.v2.Cryptography;
using EpicChain.API.v2.Refs;
using EpicChain.API.v2.Session;
using System;

namespace EpicChain.API.v2.Client
{
    public partial class Client
    {
        public Accounting.Decimal GetBalance(OwnerID owner, CallOptions options = null)
        {
            var account_client = new AccountingService.AccountingServiceClient(channel);
            var opts = DefaultCallOptions.ApplyCustomOptions(options);
            var req = new BalanceRequest
            {
                Body = new BalanceRequest.Types.Body
                {
                    OwnerId = owner,
                }
            };
            req.MetaHeader = opts.GetRequestMetaHeader();
            req.SignRequest(key);
            var resp = account_client.Balance(req);
            if (!resp.VerifyResponse())
                throw new FormatException("invalid balance response");
            return resp.Body.Balance;
        }

        public Accounting.Decimal GetSelfBalance()
        {
            var w = key.ToOwnerID();
            return GetBalance(w);
        }
    }
}
