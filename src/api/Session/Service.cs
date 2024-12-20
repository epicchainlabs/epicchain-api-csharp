// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: session/service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EpicChain.API.v2.Session {

  /// <summary>Holder for reflection information generated from session/service.proto</summary>
  public static partial class ServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for session/service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVzZXNzaW9uL3NlcnZpY2UucHJvdG8SEW5lby5mcy52Mi5zZXNzaW9uGhBy",
            "ZWZzL3R5cGVzLnByb3RvGhNzZXNzaW9uL3R5cGVzLnByb3RvIosCCg1DcmVh",
            "dGVSZXF1ZXN0EjMKBGJvZHkYASABKAsyJS5uZW8uZnMudjIuc2Vzc2lvbi5D",
            "cmVhdGVSZXF1ZXN0LkJvZHkSOQoLbWV0YV9oZWFkZXIYAiABKAsyJC5uZW8u",
            "ZnMudjIuc2Vzc2lvbi5SZXF1ZXN0TWV0YUhlYWRlchJDCg12ZXJpZnlfaGVh",
            "ZGVyGAMgASgLMiwubmVvLmZzLnYyLnNlc3Npb24uUmVxdWVzdFZlcmlmaWNh",
            "dGlvbkhlYWRlchpFCgRCb2R5EikKCG93bmVyX2lkGAEgASgLMhcubmVvLmZz",
            "LnYyLnJlZnMuT3duZXJJRBISCgpleHBpcmF0aW9uGAIgASgEIvEBCg5DcmVh",
            "dGVSZXNwb25zZRI0CgRib2R5GAEgASgLMiYubmVvLmZzLnYyLnNlc3Npb24u",
            "Q3JlYXRlUmVzcG9uc2UuQm9keRI6CgttZXRhX2hlYWRlchgCIAEoCzIlLm5l",
            "by5mcy52Mi5zZXNzaW9uLlJlc3BvbnNlTWV0YUhlYWRlchJECg12ZXJpZnlf",
            "aGVhZGVyGAMgASgLMi0ubmVvLmZzLnYyLnNlc3Npb24uUmVzcG9uc2VWZXJp",
            "ZmljYXRpb25IZWFkZXIaJwoEQm9keRIKCgJpZBgBIAEoDBITCgtzZXNzaW9u",
            "X2tleRgCIAEoDDJfCg5TZXNzaW9uU2VydmljZRJNCgZDcmVhdGUSIC5uZW8u",
            "ZnMudjIuc2Vzc2lvbi5DcmVhdGVSZXF1ZXN0GiEubmVvLmZzLnYyLnNlc3Np",
            "b24uQ3JlYXRlUmVzcG9uc2VCUlo5Z2l0aHViLmNvbS9uc3BjYy1kZXYvbmVv",
            "ZnMtYXBpLWdvL3YyL3Nlc3Npb24vZ3JwYztzZXNzaW9uqgIUTmVvRlMuQVBJ",
            "LnYyLlNlc3Npb25iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EpicChain.API.v2.Refs.TypesReflection.Descriptor, global::EpicChain.API.v2.Session.TypesReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EpicChain.API.v2.Session.CreateRequest), global::EpicChain.API.v2.Session.CreateRequest.Parser, new[]{ "Body", "MetaHeader", "VerifyHeader" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::EpicChain.API.v2.Session.CreateRequest.Types.Body), global::EpicChain.API.v2.Session.CreateRequest.Types.Body.Parser, new[]{ "OwnerId", "Expiration" }, null, null, null, null)}),
            new pbr::GeneratedClrTypeInfo(typeof(global::EpicChain.API.v2.Session.CreateResponse), global::EpicChain.API.v2.Session.CreateResponse.Parser, new[]{ "Body", "MetaHeader", "VerifyHeader" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::EpicChain.API.v2.Session.CreateResponse.Types.Body), global::EpicChain.API.v2.Session.CreateResponse.Types.Body.Parser, new[]{ "Id", "SessionKey" }, null, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Information necessary for opening a session.
  /// </summary>
  public sealed partial class CreateRequest : pb::IMessage<CreateRequest> {
    private static readonly pb::MessageParser<CreateRequest> _parser = new pb::MessageParser<CreateRequest>(() => new CreateRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CreateRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EpicChain.API.v2.Session.ServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CreateRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CreateRequest(CreateRequest other) : this() {
      body_ = other.body_ != null ? other.body_.Clone() : null;
      metaHeader_ = other.metaHeader_ != null ? other.metaHeader_.Clone() : null;
      verifyHeader_ = other.verifyHeader_ != null ? other.verifyHeader_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CreateRequest Clone() {
      return new CreateRequest(this);
    }

    /// <summary>Field number for the "body" field.</summary>
    public const int BodyFieldNumber = 1;
    private global::EpicChain.API.v2.Session.CreateRequest.Types.Body body_;
    /// <summary>
    /// Body of create session token request message.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::EpicChain.API.v2.Session.CreateRequest.Types.Body Body {
      get { return body_; }
      set {
        body_ = value;
      }
    }

    /// <summary>Field number for the "meta_header" field.</summary>
    public const int MetaHeaderFieldNumber = 2;
    private global::EpicChain.API.v2.Session.RequestMetaHeader metaHeader_;
    /// <summary>
    /// Carries request meta information. Header data is used only to regulate
    /// message transport and does not affect request execution.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::EpicChain.API.v2.Session.RequestMetaHeader MetaHeader {
      get { return metaHeader_; }
      set {
        metaHeader_ = value;
      }
    }

    /// <summary>Field number for the "verify_header" field.</summary>
    public const int VerifyHeaderFieldNumber = 3;
    private global::EpicChain.API.v2.Session.RequestVerificationHeader verifyHeader_;
    /// <summary>
    /// Carries request verification information. This header is used to
    /// authenticate the nodes of the message route and check the correctness of
    /// transmission.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::EpicChain.API.v2.Session.RequestVerificationHeader VerifyHeader {
      get { return verifyHeader_; }
      set {
        verifyHeader_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CreateRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CreateRequest other) {
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
    public void MergeFrom(CreateRequest other) {
      if (other == null) {
        return;
      }
      if (other.body_ != null) {
        if (body_ == null) {
          Body = new global::EpicChain.API.v2.Session.CreateRequest.Types.Body();
        }
        Body.MergeFrom(other.Body);
      }
      if (other.metaHeader_ != null) {
        if (metaHeader_ == null) {
          MetaHeader = new global::EpicChain.API.v2.Session.RequestMetaHeader();
        }
        MetaHeader.MergeFrom(other.MetaHeader);
      }
      if (other.verifyHeader_ != null) {
        if (verifyHeader_ == null) {
          VerifyHeader = new global::EpicChain.API.v2.Session.RequestVerificationHeader();
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
              Body = new global::EpicChain.API.v2.Session.CreateRequest.Types.Body();
            }
            input.ReadMessage(Body);
            break;
          }
          case 18: {
            if (metaHeader_ == null) {
              MetaHeader = new global::EpicChain.API.v2.Session.RequestMetaHeader();
            }
            input.ReadMessage(MetaHeader);
            break;
          }
          case 26: {
            if (verifyHeader_ == null) {
              VerifyHeader = new global::EpicChain.API.v2.Session.RequestVerificationHeader();
            }
            input.ReadMessage(VerifyHeader);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the CreateRequest message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Session creation request body
      /// </summary>
      public sealed partial class Body : pb::IMessage<Body> {
        private static readonly pb::MessageParser<Body> _parser = new pb::MessageParser<Body>(() => new Body());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<Body> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::EpicChain.API.v2.Session.CreateRequest.Descriptor.NestedTypes[0]; }
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
          expiration_ = other.expiration_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Body Clone() {
          return new Body(this);
        }

        /// <summary>Field number for the "owner_id" field.</summary>
        public const int OwnerIdFieldNumber = 1;
        private global::EpicChain.API.v2.Refs.OwnerID ownerId_;
        /// <summary>
        /// Session initiating user's or node's key derived `OwnerID`
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::EpicChain.API.v2.Refs.OwnerID OwnerId {
          get { return ownerId_; }
          set {
            ownerId_ = value;
          }
        }

        /// <summary>Field number for the "expiration" field.</summary>
        public const int ExpirationFieldNumber = 2;
        private ulong expiration_;
        /// <summary>
        /// Session expiration `Epoch`
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public ulong Expiration {
          get { return expiration_; }
          set {
            expiration_ = value;
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
          if (Expiration != other.Expiration) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (ownerId_ != null) hash ^= OwnerId.GetHashCode();
          if (Expiration != 0UL) hash ^= Expiration.GetHashCode();
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
          if (Expiration != 0UL) {
            output.WriteRawTag(16);
            output.WriteUInt64(Expiration);
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
          if (Expiration != 0UL) {
            size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Expiration);
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
              OwnerId = new global::EpicChain.API.v2.Refs.OwnerID();
            }
            OwnerId.MergeFrom(other.OwnerId);
          }
          if (other.Expiration != 0UL) {
            Expiration = other.Expiration;
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
                  OwnerId = new global::EpicChain.API.v2.Refs.OwnerID();
                }
                input.ReadMessage(OwnerId);
                break;
              }
              case 16: {
                Expiration = input.ReadUInt64();
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
  /// Information about the opened session.
  /// </summary>
  public sealed partial class CreateResponse : pb::IMessage<CreateResponse> {
    private static readonly pb::MessageParser<CreateResponse> _parser = new pb::MessageParser<CreateResponse>(() => new CreateResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CreateResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EpicChain.API.v2.Session.ServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CreateResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CreateResponse(CreateResponse other) : this() {
      body_ = other.body_ != null ? other.body_.Clone() : null;
      metaHeader_ = other.metaHeader_ != null ? other.metaHeader_.Clone() : null;
      verifyHeader_ = other.verifyHeader_ != null ? other.verifyHeader_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CreateResponse Clone() {
      return new CreateResponse(this);
    }

    /// <summary>Field number for the "body" field.</summary>
    public const int BodyFieldNumber = 1;
    private global::EpicChain.API.v2.Session.CreateResponse.Types.Body body_;
    /// <summary>
    /// Body of create session token response message.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::EpicChain.API.v2.Session.CreateResponse.Types.Body Body {
      get { return body_; }
      set {
        body_ = value;
      }
    }

    /// <summary>Field number for the "meta_header" field.</summary>
    public const int MetaHeaderFieldNumber = 2;
    private global::EpicChain.API.v2.Session.ResponseMetaHeader metaHeader_;
    /// <summary>
    /// Carries response meta information. Header data is used only to regulate
    /// message transport and does not affect request execution.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::EpicChain.API.v2.Session.ResponseMetaHeader MetaHeader {
      get { return metaHeader_; }
      set {
        metaHeader_ = value;
      }
    }

    /// <summary>Field number for the "verify_header" field.</summary>
    public const int VerifyHeaderFieldNumber = 3;
    private global::EpicChain.API.v2.Session.ResponseVerificationHeader verifyHeader_;
    /// <summary>
    /// Carries response verification information. This header is used to
    /// authenticate the nodes of the message route and check the correctness of
    /// transmission.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::EpicChain.API.v2.Session.ResponseVerificationHeader VerifyHeader {
      get { return verifyHeader_; }
      set {
        verifyHeader_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CreateResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CreateResponse other) {
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
    public void MergeFrom(CreateResponse other) {
      if (other == null) {
        return;
      }
      if (other.body_ != null) {
        if (body_ == null) {
          Body = new global::EpicChain.API.v2.Session.CreateResponse.Types.Body();
        }
        Body.MergeFrom(other.Body);
      }
      if (other.metaHeader_ != null) {
        if (metaHeader_ == null) {
          MetaHeader = new global::EpicChain.API.v2.Session.ResponseMetaHeader();
        }
        MetaHeader.MergeFrom(other.MetaHeader);
      }
      if (other.verifyHeader_ != null) {
        if (verifyHeader_ == null) {
          VerifyHeader = new global::EpicChain.API.v2.Session.ResponseVerificationHeader();
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
              Body = new global::EpicChain.API.v2.Session.CreateResponse.Types.Body();
            }
            input.ReadMessage(Body);
            break;
          }
          case 18: {
            if (metaHeader_ == null) {
              MetaHeader = new global::EpicChain.API.v2.Session.ResponseMetaHeader();
            }
            input.ReadMessage(MetaHeader);
            break;
          }
          case 26: {
            if (verifyHeader_ == null) {
              VerifyHeader = new global::EpicChain.API.v2.Session.ResponseVerificationHeader();
            }
            input.ReadMessage(VerifyHeader);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the CreateResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Session creation response body
      /// </summary>
      public sealed partial class Body : pb::IMessage<Body> {
        private static readonly pb::MessageParser<Body> _parser = new pb::MessageParser<Body>(() => new Body());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<Body> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::EpicChain.API.v2.Session.CreateResponse.Descriptor.NestedTypes[0]; }
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
          id_ = other.id_;
          sessionKey_ = other.sessionKey_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Body Clone() {
          return new Body(this);
        }

        /// <summary>Field number for the "id" field.</summary>
        public const int IdFieldNumber = 1;
        private pb::ByteString id_ = pb::ByteString.Empty;
        /// <summary>
        /// Identifier of a newly created session
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pb::ByteString Id {
          get { return id_; }
          set {
            id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "session_key" field.</summary>
        public const int SessionKeyFieldNumber = 2;
        private pb::ByteString sessionKey_ = pb::ByteString.Empty;
        /// <summary>
        /// Public key used for session
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pb::ByteString SessionKey {
          get { return sessionKey_; }
          set {
            sessionKey_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
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
          if (Id != other.Id) return false;
          if (SessionKey != other.SessionKey) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (Id.Length != 0) hash ^= Id.GetHashCode();
          if (SessionKey.Length != 0) hash ^= SessionKey.GetHashCode();
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
          if (Id.Length != 0) {
            output.WriteRawTag(10);
            output.WriteBytes(Id);
          }
          if (SessionKey.Length != 0) {
            output.WriteRawTag(18);
            output.WriteBytes(SessionKey);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (Id.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeBytesSize(Id);
          }
          if (SessionKey.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeBytesSize(SessionKey);
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
          if (other.Id.Length != 0) {
            Id = other.Id;
          }
          if (other.SessionKey.Length != 0) {
            SessionKey = other.SessionKey;
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
                Id = input.ReadBytes();
                break;
              }
              case 18: {
                SessionKey = input.ReadBytes();
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
