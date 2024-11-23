// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: netmap/service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EpicChain.API.v2.Netmap {

  /// <summary>Holder for reflection information generated from netmap/service.proto</summary>
  public static partial class ServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for netmap/service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRuZXRtYXAvc2VydmljZS5wcm90bxIQbmVvLmZzLnYyLm5ldG1hcBoSbmV0",
            "bWFwL3R5cGVzLnByb3RvGhByZWZzL3R5cGVzLnByb3RvGhNzZXNzaW9uL3R5",
            "cGVzLnByb3RvItkBChRMb2NhbE5vZGVJbmZvUmVxdWVzdBI5CgRib2R5GAEg",
            "ASgLMisubmVvLmZzLnYyLm5ldG1hcC5Mb2NhbE5vZGVJbmZvUmVxdWVzdC5C",
            "b2R5EjkKC21ldGFfaGVhZGVyGAIgASgLMiQubmVvLmZzLnYyLnNlc3Npb24u",
            "UmVxdWVzdE1ldGFIZWFkZXISQwoNdmVyaWZ5X2hlYWRlchgDIAEoCzIsLm5l",
            "by5mcy52Mi5zZXNzaW9uLlJlcXVlc3RWZXJpZmljYXRpb25IZWFkZXIaBgoE",
            "Qm9keSK2AgoVTG9jYWxOb2RlSW5mb1Jlc3BvbnNlEjoKBGJvZHkYASABKAsy",
            "LC5uZW8uZnMudjIubmV0bWFwLkxvY2FsTm9kZUluZm9SZXNwb25zZS5Cb2R5",
            "EjoKC21ldGFfaGVhZGVyGAIgASgLMiUubmVvLmZzLnYyLnNlc3Npb24uUmVz",
            "cG9uc2VNZXRhSGVhZGVyEkQKDXZlcmlmeV9oZWFkZXIYAyABKAsyLS5uZW8u",
            "ZnMudjIuc2Vzc2lvbi5SZXNwb25zZVZlcmlmaWNhdGlvbkhlYWRlchpfCgRC",
            "b2R5EigKB3ZlcnNpb24YASABKAsyFy5uZW8uZnMudjIucmVmcy5WZXJzaW9u",
            "Ei0KCW5vZGVfaW5mbxgCIAEoCzIaLm5lby5mcy52Mi5uZXRtYXAuTm9kZUlu",
            "Zm8ycQoNTmV0bWFwU2VydmljZRJgCg1Mb2NhbE5vZGVJbmZvEiYubmVvLmZz",
            "LnYyLm5ldG1hcC5Mb2NhbE5vZGVJbmZvUmVxdWVzdBonLm5lby5mcy52Mi5u",
            "ZXRtYXAuTG9jYWxOb2RlSW5mb1Jlc3BvbnNlQk9aN2dpdGh1Yi5jb20vbnNw",
            "Y2MtZGV2L25lb2ZzLWFwaS1nby92Mi9uZXRtYXAvZ3JwYztuZXRtYXCqAhNO",
            "ZW9GUy5BUEkudjIuTmV0bWFwYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EpicChain.API.v2.Netmap.TypesReflection.Descriptor, global::EpicChain.API.v2.Refs.TypesReflection.Descriptor, global::EpicChain.API.v2.Session.TypesReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EpicChain.API.v2.Netmap.LocalNodeInfoRequest), global::EpicChain.API.v2.Netmap.LocalNodeInfoRequest.Parser, new[]{ "Body", "MetaHeader", "VerifyHeader" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::EpicChain.API.v2.Netmap.LocalNodeInfoRequest.Types.Body), global::EpicChain.API.v2.Netmap.LocalNodeInfoRequest.Types.Body.Parser, null, null, null, null, null)}),
            new pbr::GeneratedClrTypeInfo(typeof(global::EpicChain.API.v2.Netmap.LocalNodeInfoResponse), global::EpicChain.API.v2.Netmap.LocalNodeInfoResponse.Parser, new[]{ "Body", "MetaHeader", "VerifyHeader" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::EpicChain.API.v2.Netmap.LocalNodeInfoResponse.Types.Body), global::EpicChain.API.v2.Netmap.LocalNodeInfoResponse.Types.Body.Parser, new[]{ "Version", "NodeInfo" }, null, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Get NodeInfo structure from the particular node directly
  /// </summary>
  public sealed partial class LocalNodeInfoRequest : pb::IMessage<LocalNodeInfoRequest> {
    private static readonly pb::MessageParser<LocalNodeInfoRequest> _parser = new pb::MessageParser<LocalNodeInfoRequest>(() => new LocalNodeInfoRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<LocalNodeInfoRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EpicChain.API.v2.Netmap.ServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LocalNodeInfoRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LocalNodeInfoRequest(LocalNodeInfoRequest other) : this() {
      body_ = other.body_ != null ? other.body_.Clone() : null;
      metaHeader_ = other.metaHeader_ != null ? other.metaHeader_.Clone() : null;
      verifyHeader_ = other.verifyHeader_ != null ? other.verifyHeader_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LocalNodeInfoRequest Clone() {
      return new LocalNodeInfoRequest(this);
    }

    /// <summary>Field number for the "body" field.</summary>
    public const int BodyFieldNumber = 1;
    private global::EpicChain.API.v2.Netmap.LocalNodeInfoRequest.Types.Body body_;
    /// <summary>
    /// Body of the LocalNodeInfo request message
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::EpicChain.API.v2.Netmap.LocalNodeInfoRequest.Types.Body Body {
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
      return Equals(other as LocalNodeInfoRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(LocalNodeInfoRequest other) {
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
    public void MergeFrom(LocalNodeInfoRequest other) {
      if (other == null) {
        return;
      }
      if (other.body_ != null) {
        if (body_ == null) {
          Body = new global::EpicChain.API.v2.Netmap.LocalNodeInfoRequest.Types.Body();
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
              Body = new global::EpicChain.API.v2.Netmap.LocalNodeInfoRequest.Types.Body();
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
    /// <summary>Container for nested types declared in the LocalNodeInfoRequest message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// LocalNodeInfo request body is empty.
      /// </summary>
      public sealed partial class Body : pb::IMessage<Body> {
        private static readonly pb::MessageParser<Body> _parser = new pb::MessageParser<Body>(() => new Body());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<Body> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::EpicChain.API.v2.Netmap.LocalNodeInfoRequest.Descriptor.NestedTypes[0]; }
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
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Body Clone() {
          return new Body(this);
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
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
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
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
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
            }
          }
        }

      }

    }
    #endregion

  }

  /// <summary>
  /// Local Node Info, including API Version in use
  /// </summary>
  public sealed partial class LocalNodeInfoResponse : pb::IMessage<LocalNodeInfoResponse> {
    private static readonly pb::MessageParser<LocalNodeInfoResponse> _parser = new pb::MessageParser<LocalNodeInfoResponse>(() => new LocalNodeInfoResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<LocalNodeInfoResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EpicChain.API.v2.Netmap.ServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LocalNodeInfoResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LocalNodeInfoResponse(LocalNodeInfoResponse other) : this() {
      body_ = other.body_ != null ? other.body_.Clone() : null;
      metaHeader_ = other.metaHeader_ != null ? other.metaHeader_.Clone() : null;
      verifyHeader_ = other.verifyHeader_ != null ? other.verifyHeader_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LocalNodeInfoResponse Clone() {
      return new LocalNodeInfoResponse(this);
    }

    /// <summary>Field number for the "body" field.</summary>
    public const int BodyFieldNumber = 1;
    private global::EpicChain.API.v2.Netmap.LocalNodeInfoResponse.Types.Body body_;
    /// <summary>
    /// Body of the balance response message.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::EpicChain.API.v2.Netmap.LocalNodeInfoResponse.Types.Body Body {
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
    /// message transport and does not affect response execution.
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
      return Equals(other as LocalNodeInfoResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(LocalNodeInfoResponse other) {
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
    public void MergeFrom(LocalNodeInfoResponse other) {
      if (other == null) {
        return;
      }
      if (other.body_ != null) {
        if (body_ == null) {
          Body = new global::EpicChain.API.v2.Netmap.LocalNodeInfoResponse.Types.Body();
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
              Body = new global::EpicChain.API.v2.Netmap.LocalNodeInfoResponse.Types.Body();
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
    /// <summary>Container for nested types declared in the LocalNodeInfoResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Local Node Info, including API Version in use.
      /// </summary>
      public sealed partial class Body : pb::IMessage<Body> {
        private static readonly pb::MessageParser<Body> _parser = new pb::MessageParser<Body>(() => new Body());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<Body> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::EpicChain.API.v2.Netmap.LocalNodeInfoResponse.Descriptor.NestedTypes[0]; }
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
          version_ = other.version_ != null ? other.version_.Clone() : null;
          nodeInfo_ = other.nodeInfo_ != null ? other.nodeInfo_.Clone() : null;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Body Clone() {
          return new Body(this);
        }

        /// <summary>Field number for the "version" field.</summary>
        public const int VersionFieldNumber = 1;
        private global::EpicChain.API.v2.Refs.Version version_;
        /// <summary>
        /// Latest EpicChain API version in use
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::EpicChain.API.v2.Refs.Version Version {
          get { return version_; }
          set {
            version_ = value;
          }
        }

        /// <summary>Field number for the "node_info" field.</summary>
        public const int NodeInfoFieldNumber = 2;
        private global::EpicChain.API.v2.Netmap.NodeInfo nodeInfo_;
        /// <summary>
        /// NodeInfo structure with recent information from node itself
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::EpicChain.API.v2.Netmap.NodeInfo NodeInfo {
          get { return nodeInfo_; }
          set {
            nodeInfo_ = value;
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
          if (!object.Equals(Version, other.Version)) return false;
          if (!object.Equals(NodeInfo, other.NodeInfo)) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (version_ != null) hash ^= Version.GetHashCode();
          if (nodeInfo_ != null) hash ^= NodeInfo.GetHashCode();
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
          if (version_ != null) {
            output.WriteRawTag(10);
            output.WriteMessage(Version);
          }
          if (nodeInfo_ != null) {
            output.WriteRawTag(18);
            output.WriteMessage(NodeInfo);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (version_ != null) {
            size += 1 + pb::CodedOutputStream.ComputeMessageSize(Version);
          }
          if (nodeInfo_ != null) {
            size += 1 + pb::CodedOutputStream.ComputeMessageSize(NodeInfo);
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
          if (other.version_ != null) {
            if (version_ == null) {
              Version = new global::EpicChain.API.v2.Refs.Version();
            }
            Version.MergeFrom(other.Version);
          }
          if (other.nodeInfo_ != null) {
            if (nodeInfo_ == null) {
              NodeInfo = new global::EpicChain.API.v2.Netmap.NodeInfo();
            }
            NodeInfo.MergeFrom(other.NodeInfo);
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
                if (version_ == null) {
                  Version = new global::EpicChain.API.v2.Refs.Version();
                }
                input.ReadMessage(Version);
                break;
              }
              case 18: {
                if (nodeInfo_ == null) {
                  NodeInfo = new global::EpicChain.API.v2.Netmap.NodeInfo();
                }
                input.ReadMessage(NodeInfo);
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
