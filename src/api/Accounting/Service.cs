// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: accounting/service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EpicChainAPI.v2.Accounting {

  /// <summary>Holder for reflection information generated from accounting/service.proto</summary>
  public static partial class ServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for accounting/service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhhY2NvdW50aW5nL3NlcnZpY2UucHJvdG8SFG5lby5mcy52Mi5hY2NvdW50",
            "aW5nGhZhY2NvdW50aW5nL3R5cGVzLnByb3RvGhByZWZzL3R5cGVzLnByb3Rv",
            "GhNzZXNzaW9uL3R5cGVzLnByb3RvIvwBCg5CYWxhbmNlUmVxdWVzdBI3CgRi",
            "b2R5GAEgASgLMikubmVvLmZzLnYyLmFjY291bnRpbmcuQmFsYW5jZVJlcXVl",
            "c3QuQm9keRI5CgttZXRhX2hlYWRlchgCIAEoCzIkLm5lby5mcy52Mi5zZXNz",
            "aW9uLlJlcXVlc3RNZXRhSGVhZGVyEkMKDXZlcmlmeV9oZWFkZXIYAyABKAsy",
            "LC5uZW8uZnMudjIuc2Vzc2lvbi5SZXF1ZXN0VmVyaWZpY2F0aW9uSGVhZGVy",
            "GjEKBEJvZHkSKQoIb3duZXJfaWQYASABKAsyFy5uZW8uZnMudjIucmVmcy5P",
            "d25lcklEIoUCCg9CYWxhbmNlUmVzcG9uc2USOAoEYm9keRgBIAEoCzIqLm5l",
            "by5mcy52Mi5hY2NvdW50aW5nLkJhbGFuY2VSZXNwb25zZS5Cb2R5EjoKC21l",
            "dGFfaGVhZGVyGAIgASgLMiUubmVvLmZzLnYyLnNlc3Npb24uUmVzcG9uc2VN",
            "ZXRhSGVhZGVyEkQKDXZlcmlmeV9oZWFkZXIYAyABKAsyLS5uZW8uZnMudjIu",
            "c2Vzc2lvbi5SZXNwb25zZVZlcmlmaWNhdGlvbkhlYWRlcho2CgRCb2R5Ei4K",
            "B2JhbGFuY2UYASABKAsyHS5uZW8uZnMudjIuYWNjb3VudGluZy5EZWNpbWFs",
            "MmsKEUFjY291bnRpbmdTZXJ2aWNlElYKB0JhbGFuY2USJC5uZW8uZnMudjIu",
            "YWNjb3VudGluZy5CYWxhbmNlUmVxdWVzdBolLm5lby5mcy52Mi5hY2NvdW50",
            "aW5nLkJhbGFuY2VSZXNwb25zZUJbWj9naXRodWIuY29tL25zcGNjLWRldi9u",
            "ZW9mcy1hcGktZ28vdjIvYWNjb3VudGluZy9ncnBjO2FjY291bnRpbmeqAhdO",
            "ZW9GUy5BUEkudjIuQWNjb3VudGluZ2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EpicChainAPI.v2.Accounting.TypesReflection.Descriptor, global::EpicChainAPI.v2.Refs.TypesReflection.Descriptor, global::EpicChainAPI.v2.Session.TypesReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EpicChainAPI.v2.Accounting.BalanceRequest), global::EpicChainAPI.v2.Accounting.BalanceRequest.Parser, new[]{ "Body", "MetaHeader", "VerifyHeader" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::EpicChainAPI.v2.Accounting.BalanceRequest.Types.Body), global::EpicChainAPI.v2.Accounting.BalanceRequest.Types.Body.Parser, new[]{ "OwnerId" }, null, null, null, null)}),
            new pbr::GeneratedClrTypeInfo(typeof(global::EpicChainAPI.v2.Accounting.BalanceResponse), global::EpicChainAPI.v2.Accounting.BalanceResponse.Parser, new[]{ "Body", "MetaHeader", "VerifyHeader" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::EpicChainAPI.v2.Accounting.BalanceResponse.Types.Body), global::EpicChainAPI.v2.Accounting.BalanceResponse.Types.Body.Parser, new[]{ "Balance" }, null, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// BalanceRequest message
  /// </summary>
  public sealed partial class BalanceRequest : pb::IMessage<BalanceRequest> {
    private static readonly pb::MessageParser<BalanceRequest> _parser = new pb::MessageParser<BalanceRequest>(() => new BalanceRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BalanceRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EpicChainAPI.v2.Accounting.ServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BalanceRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BalanceRequest(BalanceRequest other) : this() {
      body_ = other.body_ != null ? other.body_.Clone() : null;
      metaHeader_ = other.metaHeader_ != null ? other.metaHeader_.Clone() : null;
      verifyHeader_ = other.verifyHeader_ != null ? other.verifyHeader_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BalanceRequest Clone() {
      return new BalanceRequest(this);
    }

    /// <summary>Field number for the "body" field.</summary>
    public const int BodyFieldNumber = 1;
    private global::EpicChainAPI.v2.Accounting.BalanceRequest.Types.Body body_;
    /// <summary>
    /// Body of the balance request message.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::EpicChainAPI.v2.Accounting.BalanceRequest.Types.Body Body {
      get { return body_; }
      set {
        body_ = value;
      }
    }

    /// <summary>Field number for the "meta_header" field.</summary>
    public const int MetaHeaderFieldNumber = 2;
    private global::EpicChainAPI.v2.Session.RequestMetaHeader metaHeader_;
    /// <summary>
    /// Carries request meta information. Header data is used only to regulate
    /// message transport and does not affect request execution.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::EpicChainAPI.v2.Session.RequestMetaHeader MetaHeader {
      get { return metaHeader_; }
      set {
        metaHeader_ = value;
      }
    }

    /// <summary>Field number for the "verify_header" field.</summary>
    public const int VerifyHeaderFieldNumber = 3;
    private global::EpicChainAPI.v2.Session.RequestVerificationHeader verifyHeader_;
    /// <summary>
    /// Carries request verification information. This header is used to
    /// authenticate the nodes of the message route and check the correctness of
    /// transmission.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::EpicChainAPI.v2.Session.RequestVerificationHeader VerifyHeader {
      get { return verifyHeader_; }
      set {
        verifyHeader_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as BalanceRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(BalanceRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Body, other.Body)) return false;
      if (!object.Equals(MetaHeader, other.MetaHeader)) return false;
      if (!object.Equals(VerifyHeader, other.VerifyHeader)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (body_ != null) hash ^= Body.GetHashCode();
      if (metaHeader_ != null) hash ^= MetaHeader.GetHashCode();
      if (verifyHeader_ != null) hash ^= VerifyHeader.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (body_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Body);
      }
      if (metaHeader_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(MetaHeader);
      }
      if (verifyHeader_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(VerifyHeader);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (body_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Body);
      }
      if (metaHeader_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MetaHeader);
      }
      if (verifyHeader_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(VerifyHeader);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(BalanceRequest other) {
      if (other == null) {
        return;
      }
      if (other.body_ != null) {
        if (body_ == null) {
          Body = new global::EpicChainAPI.v2.Accounting.BalanceRequest.Types.Body();
        }
        Body.MergeFrom(other.Body);
      }
      if (other.metaHeader_ != null) {
        if (metaHeader_ == null) {
          MetaHeader = new global::EpicChainAPI.v2.Session.RequestMetaHeader();
        }
        MetaHeader.MergeFrom(other.MetaHeader);
      }
      if (other.verifyHeader_ != null) {
        if (verifyHeader_ == null) {
          VerifyHeader = new global::EpicChainAPI.v2.Session.RequestVerificationHeader();
        }
        VerifyHeader.MergeFrom(other.VerifyHeader);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (body_ == null) {
              Body = new global::EpicChainAPI.v2.Accounting.BalanceRequest.Types.Body();
            }
            input.ReadMessage(Body);
            break;
          }
          case 18: {
            if (metaHeader_ == null) {
              MetaHeader = new global::EpicChainAPI.v2.Session.RequestMetaHeader();
            }
            input.ReadMessage(MetaHeader);
            break;
          }
          case 26: {
            if (verifyHeader_ == null) {
              VerifyHeader = new global::EpicChainAPI.v2.Session.RequestVerificationHeader();
            }
            input.ReadMessage(VerifyHeader);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the BalanceRequest message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// To indicate the account for which the balance is requested, it's identifier
      /// is used. It can be any existing account in NeoFS sidechain `Balance` smart
      /// contract. If omitted, client implementation MUST set it to the request's
      /// signer `OwnerID`.
      /// </summary>
      public sealed partial class Body : pb::IMessage<Body> {
        private static readonly pb::MessageParser<Body> _parser = new pb::MessageParser<Body>(() => new Body());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<Body> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::EpicChainAPI.v2.Accounting.BalanceRequest.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Body() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Body(Body other) : this() {
          ownerId_ = other.ownerId_ != null ? other.ownerId_.Clone() : null;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Body Clone() {
          return new Body(this);
        }

        /// <summary>Field number for the "owner_id" field.</summary>
        public const int OwnerIdFieldNumber = 1;
        private global::EpicChainAPI.v2.Refs.OwnerID ownerId_;
        /// <summary>
        /// Valid user identifier in `OwnerID` format for which the balance is
        /// requested. Required field.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::EpicChainAPI.v2.Refs.OwnerID OwnerId {
          get { return ownerId_; }
          set {
            ownerId_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as Body);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(Body other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (!object.Equals(OwnerId, other.OwnerId)) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (ownerId_ != null) hash ^= OwnerId.GetHashCode();
          if (_unknownFields != null) {
            hash ^= _unknownFields.GetHashCode();
          }
          return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString() {
          return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output) {
          if (ownerId_ != null) {
            output.WriteRawTag(10);
            output.WriteMessage(OwnerId);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (ownerId_ != null) {
            size += 1 + pb::CodedOutputStream.ComputeMessageSize(OwnerId);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(Body other) {
          if (other == null) {
            return;
          }
          if (other.ownerId_ != null) {
            if (ownerId_ == null) {
              OwnerId = new global::EpicChainAPI.v2.Refs.OwnerID();
            }
            OwnerId.MergeFrom(other.OwnerId);
          }
          _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(pb::CodedInputStream input) {
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
                break;
              case 10: {
                if (ownerId_ == null) {
                  OwnerId = new global::EpicChainAPI.v2.Refs.OwnerID();
                }
                input.ReadMessage(OwnerId);
                break;
              }
            }
          }
        }

      }

    }
    #endregion

  }

  /// <summary>
  /// BalanceResponse message
  /// </summary>
  public sealed partial class BalanceResponse : pb::IMessage<BalanceResponse> {
    private static readonly pb::MessageParser<BalanceResponse> _parser = new pb::MessageParser<BalanceResponse>(() => new BalanceResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BalanceResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EpicChainAPI.v2.Accounting.ServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BalanceResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BalanceResponse(BalanceResponse other) : this() {
      body_ = other.body_ != null ? other.body_.Clone() : null;
      metaHeader_ = other.metaHeader_ != null ? other.metaHeader_.Clone() : null;
      verifyHeader_ = other.verifyHeader_ != null ? other.verifyHeader_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BalanceResponse Clone() {
      return new BalanceResponse(this);
    }

    /// <summary>Field number for the "body" field.</summary>
    public const int BodyFieldNumber = 1;
    private global::EpicChainAPI.v2.Accounting.BalanceResponse.Types.Body body_;
    /// <summary>
    /// Body of the balance response message.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::EpicChainAPI.v2.Accounting.BalanceResponse.Types.Body Body {
      get { return body_; }
      set {
        body_ = value;
      }
    }

    /// <summary>Field number for the "meta_header" field.</summary>
    public const int MetaHeaderFieldNumber = 2;
    private global::EpicChainAPI.v2.Session.ResponseMetaHeader metaHeader_;
    /// <summary>
    /// Carries response meta information. Header data is used only to regulate
    /// message transport and does not affect request execution.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::EpicChainAPI.v2.Session.ResponseMetaHeader MetaHeader {
      get { return metaHeader_; }
      set {
        metaHeader_ = value;
      }
    }

    /// <summary>Field number for the "verify_header" field.</summary>
    public const int VerifyHeaderFieldNumber = 3;
    private global::EpicChainAPI.v2.Session.ResponseVerificationHeader verifyHeader_;
    /// <summary>
    /// Carries response verification information. This header is used to
    /// authenticate the nodes of the message route and check the correctness of
    /// transmission.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::EpicChainAPI.v2.Session.ResponseVerificationHeader VerifyHeader {
      get { return verifyHeader_; }
      set {
        verifyHeader_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as BalanceResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(BalanceResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Body, other.Body)) return false;
      if (!object.Equals(MetaHeader, other.MetaHeader)) return false;
      if (!object.Equals(VerifyHeader, other.VerifyHeader)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (body_ != null) hash ^= Body.GetHashCode();
      if (metaHeader_ != null) hash ^= MetaHeader.GetHashCode();
      if (verifyHeader_ != null) hash ^= VerifyHeader.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (body_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Body);
      }
      if (metaHeader_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(MetaHeader);
      }
      if (verifyHeader_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(VerifyHeader);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (body_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Body);
      }
      if (metaHeader_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MetaHeader);
      }
      if (verifyHeader_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(VerifyHeader);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(BalanceResponse other) {
      if (other == null) {
        return;
      }
      if (other.body_ != null) {
        if (body_ == null) {
          Body = new global::EpicChainAPI.v2.Accounting.BalanceResponse.Types.Body();
        }
        Body.MergeFrom(other.Body);
      }
      if (other.metaHeader_ != null) {
        if (metaHeader_ == null) {
          MetaHeader = new global::EpicChainAPI.v2.Session.ResponseMetaHeader();
        }
        MetaHeader.MergeFrom(other.MetaHeader);
      }
      if (other.verifyHeader_ != null) {
        if (verifyHeader_ == null) {
          VerifyHeader = new global::EpicChainAPI.v2.Session.ResponseVerificationHeader();
        }
        VerifyHeader.MergeFrom(other.VerifyHeader);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (body_ == null) {
              Body = new global::EpicChainAPI.v2.Accounting.BalanceResponse.Types.Body();
            }
            input.ReadMessage(Body);
            break;
          }
          case 18: {
            if (metaHeader_ == null) {
              MetaHeader = new global::EpicChainAPI.v2.Session.ResponseMetaHeader();
            }
            input.ReadMessage(MetaHeader);
            break;
          }
          case 26: {
            if (verifyHeader_ == null) {
              VerifyHeader = new global::EpicChainAPI.v2.Session.ResponseVerificationHeader();
            }
            input.ReadMessage(VerifyHeader);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the BalanceResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// The amount of funds in GAS token for the `OwnerID`'s account requested.
      /// Balance is `Decimal` format to avoid precision issues with rounding.
      /// </summary>
      public sealed partial class Body : pb::IMessage<Body> {
        private static readonly pb::MessageParser<Body> _parser = new pb::MessageParser<Body>(() => new Body());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<Body> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::EpicChainAPI.v2.Accounting.BalanceResponse.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Body() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Body(Body other) : this() {
          balance_ = other.balance_ != null ? other.balance_.Clone() : null;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Body Clone() {
          return new Body(this);
        }

        /// <summary>Field number for the "balance" field.</summary>
        public const int BalanceFieldNumber = 1;
        private global::EpicChainAPI.v2.Accounting.Decimal balance_;
        /// <summary>
        /// Amount of funds in GAS token for the requested account.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::EpicChainAPI.v2.Accounting.Decimal Balance {
          get { return balance_; }
          set {
            balance_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as Body);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(Body other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (!object.Equals(Balance, other.Balance)) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (balance_ != null) hash ^= Balance.GetHashCode();
          if (_unknownFields != null) {
            hash ^= _unknownFields.GetHashCode();
          }
          return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString() {
          return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output) {
          if (balance_ != null) {
            output.WriteRawTag(10);
            output.WriteMessage(Balance);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (balance_ != null) {
            size += 1 + pb::CodedOutputStream.ComputeMessageSize(Balance);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(Body other) {
          if (other == null) {
            return;
          }
          if (other.balance_ != null) {
            if (balance_ == null) {
              Balance = new global::EpicChainAPI.v2.Accounting.Decimal();
            }
            Balance.MergeFrom(other.Balance);
          }
          _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(pb::CodedInputStream input) {
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
                break;
              case 10: {
                if (balance_ == null) {
                  Balance = new global::EpicChainAPI.v2.Accounting.Decimal();
                }
                input.ReadMessage(Balance);
                break;
              }
            }
          }
        }

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
