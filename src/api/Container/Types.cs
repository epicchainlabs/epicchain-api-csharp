// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: container/types.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NeoFS.API.v2.Container {

  /// <summary>Holder for reflection information generated from container/types.proto</summary>
  public static partial class TypesReflection {

    #region Descriptor
    /// <summary>File descriptor for container/types.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TypesReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVjb250YWluZXIvdHlwZXMucHJvdG8SE25lby5mcy52Mi5jb250YWluZXIa",
            "Em5ldG1hcC90eXBlcy5wcm90bxoQcmVmcy90eXBlcy5wcm90byLyAgoJQ29u",
            "dGFpbmVyEjEKB3ZlcnNpb24YASABKAsyFy5uZW8uZnMudjIucmVmcy5WZXJz",
            "aW9uUgd2ZXJzaW9uEjIKCG93bmVyX2lkGAIgASgLMhcubmVvLmZzLnYyLnJl",
            "ZnMuT3duZXJJRFIHb3duZXJJRBIUCgVub25jZRgDIAEoDFIFbm9uY2USGwoJ",
            "YmFzaWNfYWNsGAQgASgNUghiYXNpY0FDTBJICgphdHRyaWJ1dGVzGAUgAygL",
            "MigubmVvLmZzLnYyLmNvbnRhaW5lci5Db250YWluZXIuQXR0cmlidXRlUgph",
            "dHRyaWJ1dGVzEkwKEHBsYWNlbWVudF9wb2xpY3kYBiABKAsyIS5uZW8uZnMu",
            "djIubmV0bWFwLlBsYWNlbWVudFBvbGljeVIPcGxhY2VtZW50UG9saWN5GjMK",
            "CUF0dHJpYnV0ZRIQCgNrZXkYASABKAlSA2tleRIUCgV2YWx1ZRgCIAEoCVIF",
            "dmFsdWVCWFo9Z2l0aHViLmNvbS9uc3BjYy1kZXYvbmVvZnMtYXBpLWdvL3Yy",
            "L2NvbnRhaW5lci9ncnBjO2NvbnRhaW5lcqoCFk5lb0ZTLkFQSS52Mi5Db250",
            "YWluZXJiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::NeoFS.API.v2.Netmap.TypesReflection.Descriptor, global::NeoFS.API.v2.Refs.TypesReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NeoFS.API.v2.Container.Container), global::NeoFS.API.v2.Container.Container.Parser, new[]{ "Version", "OwnerId", "Nonce", "BasicAcl", "Attributes", "PlacementPolicy" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::NeoFS.API.v2.Container.Container.Types.Attribute), global::NeoFS.API.v2.Container.Container.Types.Attribute.Parser, new[]{ "Key", "Value" }, null, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container is a structure that defines object placement behaviour. Objects can
  /// be stored only within containers. They define placement rule, attributes and
  /// access control information. ID of the container is a 32 byte long SHA256 hash
  /// of stable-marshalled container message.
  /// </summary>
  public sealed partial class Container : pb::IMessage<Container> {
    private static readonly pb::MessageParser<Container> _parser = new pb::MessageParser<Container>(() => new Container());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Container> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NeoFS.API.v2.Container.TypesReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Container() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Container(Container other) : this() {
      version_ = other.version_ != null ? other.version_.Clone() : null;
      ownerId_ = other.ownerId_ != null ? other.ownerId_.Clone() : null;
      nonce_ = other.nonce_;
      basicAcl_ = other.basicAcl_;
      attributes_ = other.attributes_.Clone();
      placementPolicy_ = other.placementPolicy_ != null ? other.placementPolicy_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Container Clone() {
      return new Container(this);
    }

    /// <summary>Field number for the "version" field.</summary>
    public const int VersionFieldNumber = 1;
    private global::NeoFS.API.v2.Refs.Version version_;
    /// <summary>
    /// Container format version. Effectively the version of API library used to
    /// create container.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::NeoFS.API.v2.Refs.Version Version {
      get { return version_; }
      set {
        version_ = value;
      }
    }

    /// <summary>Field number for the "owner_id" field.</summary>
    public const int OwnerIdFieldNumber = 2;
    private global::NeoFS.API.v2.Refs.OwnerID ownerId_;
    /// <summary>
    /// Identifier of the container owner
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::NeoFS.API.v2.Refs.OwnerID OwnerId {
      get { return ownerId_; }
      set {
        ownerId_ = value;
      }
    }

    /// <summary>Field number for the "nonce" field.</summary>
    public const int NonceFieldNumber = 3;
    private pb::ByteString nonce_ = pb::ByteString.Empty;
    /// <summary>
    /// Nonce is a 16 byte UUIDv4, used to avoid collisions of `ContainerID`s
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString Nonce {
      get { return nonce_; }
      set {
        nonce_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "basic_acl" field.</summary>
    public const int BasicAclFieldNumber = 4;
    private uint basicAcl_;
    /// <summary>
    /// `BasicACL` contains access control rules for owner, system, others groups
    /// and permission bits for `BearerToken` and `Extended ACL`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint BasicAcl {
      get { return basicAcl_; }
      set {
        basicAcl_ = value;
      }
    }

    /// <summary>Field number for the "attributes" field.</summary>
    public const int AttributesFieldNumber = 5;
    private static readonly pb::FieldCodec<global::NeoFS.API.v2.Container.Container.Types.Attribute> _repeated_attributes_codec
        = pb::FieldCodec.ForMessage(42, global::NeoFS.API.v2.Container.Container.Types.Attribute.Parser);
    private readonly pbc::RepeatedField<global::NeoFS.API.v2.Container.Container.Types.Attribute> attributes_ = new pbc::RepeatedField<global::NeoFS.API.v2.Container.Container.Types.Attribute>();
    /// <summary>
    /// Attributes represent immutable container's meta data
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::NeoFS.API.v2.Container.Container.Types.Attribute> Attributes {
      get { return attributes_; }
    }

    /// <summary>Field number for the "placement_policy" field.</summary>
    public const int PlacementPolicyFieldNumber = 6;
    private global::NeoFS.API.v2.Netmap.PlacementPolicy placementPolicy_;
    /// <summary>
    /// Placement policy for the object inside the container
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::NeoFS.API.v2.Netmap.PlacementPolicy PlacementPolicy {
      get { return placementPolicy_; }
      set {
        placementPolicy_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Container);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Container other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Version, other.Version)) return false;
      if (!object.Equals(OwnerId, other.OwnerId)) return false;
      if (Nonce != other.Nonce) return false;
      if (BasicAcl != other.BasicAcl) return false;
      if(!attributes_.Equals(other.attributes_)) return false;
      if (!object.Equals(PlacementPolicy, other.PlacementPolicy)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (version_ != null) hash ^= Version.GetHashCode();
      if (ownerId_ != null) hash ^= OwnerId.GetHashCode();
      if (Nonce.Length != 0) hash ^= Nonce.GetHashCode();
      if (BasicAcl != 0) hash ^= BasicAcl.GetHashCode();
      hash ^= attributes_.GetHashCode();
      if (placementPolicy_ != null) hash ^= PlacementPolicy.GetHashCode();
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
      if (ownerId_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(OwnerId);
      }
      if (Nonce.Length != 0) {
        output.WriteRawTag(26);
        output.WriteBytes(Nonce);
      }
      if (BasicAcl != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(BasicAcl);
      }
      attributes_.WriteTo(output, _repeated_attributes_codec);
      if (placementPolicy_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(PlacementPolicy);
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
      if (ownerId_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(OwnerId);
      }
      if (Nonce.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Nonce);
      }
      if (BasicAcl != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BasicAcl);
      }
      size += attributes_.CalculateSize(_repeated_attributes_codec);
      if (placementPolicy_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PlacementPolicy);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Container other) {
      if (other == null) {
        return;
      }
      if (other.version_ != null) {
        if (version_ == null) {
          Version = new global::NeoFS.API.v2.Refs.Version();
        }
        Version.MergeFrom(other.Version);
      }
      if (other.ownerId_ != null) {
        if (ownerId_ == null) {
          OwnerId = new global::NeoFS.API.v2.Refs.OwnerID();
        }
        OwnerId.MergeFrom(other.OwnerId);
      }
      if (other.Nonce.Length != 0) {
        Nonce = other.Nonce;
      }
      if (other.BasicAcl != 0) {
        BasicAcl = other.BasicAcl;
      }
      attributes_.Add(other.attributes_);
      if (other.placementPolicy_ != null) {
        if (placementPolicy_ == null) {
          PlacementPolicy = new global::NeoFS.API.v2.Netmap.PlacementPolicy();
        }
        PlacementPolicy.MergeFrom(other.PlacementPolicy);
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
              Version = new global::NeoFS.API.v2.Refs.Version();
            }
            input.ReadMessage(Version);
            break;
          }
          case 18: {
            if (ownerId_ == null) {
              OwnerId = new global::NeoFS.API.v2.Refs.OwnerID();
            }
            input.ReadMessage(OwnerId);
            break;
          }
          case 26: {
            Nonce = input.ReadBytes();
            break;
          }
          case 32: {
            BasicAcl = input.ReadUInt32();
            break;
          }
          case 42: {
            attributes_.AddEntriesFrom(input, _repeated_attributes_codec);
            break;
          }
          case 50: {
            if (placementPolicy_ == null) {
              PlacementPolicy = new global::NeoFS.API.v2.Netmap.PlacementPolicy();
            }
            input.ReadMessage(PlacementPolicy);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the Container message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// `Attribute` is a user-defined Key-Value metadata pair attached to the
      /// container. Container attributes are immutable. They are set at container
      /// creation and can never be added or updated.
      ///
      /// Key name must be a container-unique valid UTF-8 string. Value can't be
      /// empty. Containers with duplicated attribute names or attributes with empty
      /// values will be considered invalid.
      ///
      /// There are some "well-known" attributes affecting system behaviour:
      ///
      /// * __NEOFS__SUBNET \
      ///   String ID of container's storage subnet. Container can be attached to
      ///   only one subnet.
      ///
      /// And some well-known attributes used by applications only:
      ///
      /// * Name \
      ///   Human-friendly name
      /// * Timestamp \
      ///   User-defined local time of container creation in Unix Timestamp format
      /// </summary>
      public sealed partial class Attribute : pb::IMessage<Attribute> {
        private static readonly pb::MessageParser<Attribute> _parser = new pb::MessageParser<Attribute>(() => new Attribute());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<Attribute> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::NeoFS.API.v2.Container.Container.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Attribute() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Attribute(Attribute other) : this() {
          key_ = other.key_;
          value_ = other.value_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Attribute Clone() {
          return new Attribute(this);
        }

        /// <summary>Field number for the "key" field.</summary>
        public const int KeyFieldNumber = 1;
        private string key_ = "";
        /// <summary>
        /// Attribute name key
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string Key {
          get { return key_; }
          set {
            key_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "value" field.</summary>
        public const int ValueFieldNumber = 2;
        private string value_ = "";
        /// <summary>
        /// Attribute value
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string Value {
          get { return value_; }
          set {
            value_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as Attribute);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(Attribute other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (Key != other.Key) return false;
          if (Value != other.Value) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (Key.Length != 0) hash ^= Key.GetHashCode();
          if (Value.Length != 0) hash ^= Value.GetHashCode();
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
          if (Key.Length != 0) {
            output.WriteRawTag(10);
            output.WriteString(Key);
          }
          if (Value.Length != 0) {
            output.WriteRawTag(18);
            output.WriteString(Value);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (Key.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Key);
          }
          if (Value.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Value);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(Attribute other) {
          if (other == null) {
            return;
          }
          if (other.Key.Length != 0) {
            Key = other.Key;
          }
          if (other.Value.Length != 0) {
            Value = other.Value;
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
                Key = input.ReadString();
                break;
              }
              case 18: {
                Value = input.ReadString();
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
