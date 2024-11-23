using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using EpicChain;
using EpicChain.API.v2.Refs;
using System.Security.Cryptography;
using Google.Protobuf;
using EpicChain.SmartContract;
using EpicChain.Wallets;
using EpicChain.Cryptography;

namespace EpicChain.API.v2.Cryptography
{
    public static class KeyExtension
    {
        public static string ToAddress(this ECDsa key)
        {
            return key.PublicKey().PublicKeyToAddress();
        }

        public static OwnerID ToOwnerID(this ECDsa key)
        {
            return key.PublicKey().PublicKeyToOwnerID();
        }

        public static string OwnerIDToAddress(this OwnerID owner)
        {
            return Base58.Encode(owner.Value.ToByteArray());
        }

        public static OwnerID AddressToOwnerID(this string address)
        {
            var bytes = Base58.Decode(address);
            return new OwnerID
            {
                Value = ByteString.CopyFrom(bytes),
            };
        }

        public static string PublicKeyToAddress(this byte[] public_key)
        {
            EpicChain.Cryptography.ECC.ECCurve curve = EpicChain.Cryptography.ECC.ECCurve.Secp256r1;
            var public_key_point = EpicChain.Cryptography.ECC.ECPoint.DecodePoint(public_key, curve);
            var contract = Contract.CreateSignatureContract(public_key_point);
            return contract.ScriptHash.ToAddress();
        }

        public static OwnerID PublicKeyToOwnerID(this byte[] public_key)
        {
            var bytes = Base58.Decode(public_key.PublicKeyToAddress());
            return new OwnerID
            {
                Value = ByteString.CopyFrom(bytes),
            };
        }

        // encode point
        public static byte[] PublicKey(this ECDsa key)
        {
            var param = key.ExportParameters(false);
            var pubkey = new byte[33];
            var pos = 33 - param.Q.X.Length;

            param.Q.X.CopyTo(pubkey, pos);
            if (new BigInteger(param.Q.Y.Reverse().Concat(new byte[] { 0x00 }).ToArray()).IsEven)
            {
                pubkey[0] = 0x2;
            }
            else
            {
                pubkey[0] = 0x3;
            }

            return pubkey;
        }



        public static ECDsa LoadPrivateKey(this byte[] private_key)
        {
            var kp = new KeyPair(private_key);
            var public_key = kp.PublicKey.EncodePoint(false)[1..];
            var key = ECDsa.Create(new ECParameters
            {
                Curve = ECCurve.NamedCurves.nistP256,
                D = private_key,
                Q = new ECPoint
                {
                    X = public_key[..32],
                    Y = public_key[32..]
                }
            });
            return key;
        }

        public static ECDsa LoadWif(this string wif)
        {
            var private_key = Wallet.GetPrivateKeyFromWIF(wif);
            return LoadPrivateKey(private_key);
        }

        private static byte[] DecodePublicKey(this byte[] public_key)
        {
            return EpicChain.Cryptography.ECC.ECPoint.DecodePoint(public_key, EpicChain.Cryptography.ECC.ECCurve.Secp256r1).EncodePoint(false)[1..];
        }

        public static ECDsa LoadPublicKey(this byte[] public_key)
        {
            var public_key_full = public_key.DecodePublicKey();
            var key = ECDsa.Create(new ECParameters
            {
                Curve = ECCurve.NamedCurves.nistP256,
                Q = new ECPoint
                {
                    X = public_key_full[..32],
                    Y = public_key_full[32..]
                }
            });
            return key;
        }
    }
}
