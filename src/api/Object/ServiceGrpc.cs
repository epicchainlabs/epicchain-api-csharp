// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: object/service.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace EpicChainAPI.v2.Object {
  /// <summary>
  /// `ObjectService` provides API for manipulating objects. Object operations do
  /// not interact with sidechain and are only served by nodes in p2p style.
  /// </summary>
  public static partial class ObjectService
  {
    static readonly string __ServiceName = "EpicChain.fs.v2.object.ObjectService";

    static readonly grpc::Marshaller<global::EpicChainAPI.v2.Object.GetRequest> __Marshaller_neo_fs_v2_object_GetRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::EpicChainAPI.v2.Object.GetRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::EpicChainAPI.v2.Object.GetResponse> __Marshaller_neo_fs_v2_object_GetResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::EpicChainAPI.v2.Object.GetResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::EpicChainAPI.v2.Object.PutRequest> __Marshaller_neo_fs_v2_object_PutRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::EpicChainAPI.v2.Object.PutRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::EpicChainAPI.v2.Object.PutResponse> __Marshaller_neo_fs_v2_object_PutResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::EpicChainAPI.v2.Object.PutResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::EpicChainAPI.v2.Object.DeleteRequest> __Marshaller_neo_fs_v2_object_DeleteRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::EpicChainAPI.v2.Object.DeleteRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::EpicChainAPI.v2.Object.DeleteResponse> __Marshaller_neo_fs_v2_object_DeleteResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::EpicChainAPI.v2.Object.DeleteResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::EpicChainAPI.v2.Object.HeadRequest> __Marshaller_neo_fs_v2_object_HeadRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::EpicChainAPI.v2.Object.HeadRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::EpicChainAPI.v2.Object.HeadResponse> __Marshaller_neo_fs_v2_object_HeadResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::EpicChainAPI.v2.Object.HeadResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::EpicChainAPI.v2.Object.SearchRequest> __Marshaller_neo_fs_v2_object_SearchRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::EpicChainAPI.v2.Object.SearchRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::EpicChainAPI.v2.Object.SearchResponse> __Marshaller_neo_fs_v2_object_SearchResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::EpicChainAPI.v2.Object.SearchResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::EpicChainAPI.v2.Object.GetRangeRequest> __Marshaller_neo_fs_v2_object_GetRangeRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::EpicChainAPI.v2.Object.GetRangeRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::EpicChainAPI.v2.Object.GetRangeResponse> __Marshaller_neo_fs_v2_object_GetRangeResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::EpicChainAPI.v2.Object.GetRangeResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::EpicChainAPI.v2.Object.GetRangeHashRequest> __Marshaller_neo_fs_v2_object_GetRangeHashRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::EpicChainAPI.v2.Object.GetRangeHashRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::EpicChainAPI.v2.Object.GetRangeHashResponse> __Marshaller_neo_fs_v2_object_GetRangeHashResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::EpicChainAPI.v2.Object.GetRangeHashResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::EpicChainAPI.v2.Object.GetRequest, global::EpicChainAPI.v2.Object.GetResponse> __Method_Get = new grpc::Method<global::EpicChainAPI.v2.Object.GetRequest, global::EpicChainAPI.v2.Object.GetResponse>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "Get",
        __Marshaller_neo_fs_v2_object_GetRequest,
        __Marshaller_neo_fs_v2_object_GetResponse);

    static readonly grpc::Method<global::EpicChainAPI.v2.Object.PutRequest, global::EpicChainAPI.v2.Object.PutResponse> __Method_Put = new grpc::Method<global::EpicChainAPI.v2.Object.PutRequest, global::EpicChainAPI.v2.Object.PutResponse>(
        grpc::MethodType.ClientStreaming,
        __ServiceName,
        "Put",
        __Marshaller_neo_fs_v2_object_PutRequest,
        __Marshaller_neo_fs_v2_object_PutResponse);

    static readonly grpc::Method<global::EpicChainAPI.v2.Object.DeleteRequest, global::EpicChainAPI.v2.Object.DeleteResponse> __Method_Delete = new grpc::Method<global::EpicChainAPI.v2.Object.DeleteRequest, global::EpicChainAPI.v2.Object.DeleteResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Delete",
        __Marshaller_neo_fs_v2_object_DeleteRequest,
        __Marshaller_neo_fs_v2_object_DeleteResponse);

    static readonly grpc::Method<global::EpicChainAPI.v2.Object.HeadRequest, global::EpicChainAPI.v2.Object.HeadResponse> __Method_Head = new grpc::Method<global::EpicChainAPI.v2.Object.HeadRequest, global::EpicChainAPI.v2.Object.HeadResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Head",
        __Marshaller_neo_fs_v2_object_HeadRequest,
        __Marshaller_neo_fs_v2_object_HeadResponse);

    static readonly grpc::Method<global::EpicChainAPI.v2.Object.SearchRequest, global::EpicChainAPI.v2.Object.SearchResponse> __Method_Search = new grpc::Method<global::EpicChainAPI.v2.Object.SearchRequest, global::EpicChainAPI.v2.Object.SearchResponse>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "Search",
        __Marshaller_neo_fs_v2_object_SearchRequest,
        __Marshaller_neo_fs_v2_object_SearchResponse);

    static readonly grpc::Method<global::EpicChainAPI.v2.Object.GetRangeRequest, global::EpicChainAPI.v2.Object.GetRangeResponse> __Method_GetRange = new grpc::Method<global::EpicChainAPI.v2.Object.GetRangeRequest, global::EpicChainAPI.v2.Object.GetRangeResponse>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "GetRange",
        __Marshaller_neo_fs_v2_object_GetRangeRequest,
        __Marshaller_neo_fs_v2_object_GetRangeResponse);

    static readonly grpc::Method<global::EpicChainAPI.v2.Object.GetRangeHashRequest, global::EpicChainAPI.v2.Object.GetRangeHashResponse> __Method_GetRangeHash = new grpc::Method<global::EpicChainAPI.v2.Object.GetRangeHashRequest, global::EpicChainAPI.v2.Object.GetRangeHashResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetRangeHash",
        __Marshaller_neo_fs_v2_object_GetRangeHashRequest,
        __Marshaller_neo_fs_v2_object_GetRangeHashResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::EpicChainAPI.v2.Object.ServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ObjectService</summary>
    [grpc::BindServiceMethod(typeof(ObjectService), "BindService")]
    public abstract partial class ObjectServiceBase
    {
      /// <summary>
      /// Receive full object structure, including Headers and payload. Response uses
      /// gRPC stream. First response message carries object with requested address.
      /// Chunk messages are parts of the object's payload if it is needed. All
      /// messages, except the first one, carry payload chunks. Requested object can
      /// be restored by concatenation of object message payload and all chunks
      /// keeping receiving order.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="responseStream">Used for sending responses back to the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>A task indicating completion of the handler.</returns>
      public virtual global::System.Threading.Tasks.Task Get(global::EpicChainAPI.v2.Object.GetRequest request, grpc::IServerStreamWriter<global::EpicChainAPI.v2.Object.GetResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Put the object into container. Request uses gRPC stream. First message
      /// SHOULD be of PutHeader type. `ContainerID` and `OwnerID` of an object
      /// SHOULD be set. Session token SHOULD be obtained before `PUT` operation (see
      /// session package). Chunk messages are considered by server as a part of an
      /// object payload. All messages, except first one, SHOULD be payload chunks.
      /// Chunk messages SHOULD be sent in direct order of fragmentation.
      /// </summary>
      /// <param name="requestStream">Used for reading requests from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::EpicChainAPI.v2.Object.PutResponse> Put(grpc::IAsyncStreamReader<global::EpicChainAPI.v2.Object.PutRequest> requestStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Delete the object from a container. There is no immediate removal
      /// guarantee. Object will be marked for removal and deleted eventually.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::EpicChainAPI.v2.Object.DeleteResponse> Delete(global::EpicChainAPI.v2.Object.DeleteRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Returns the object Headers without data payload. By default full header is
      /// returned. If `main_only` request field is set, the short header with only
      /// the very minimal information would be returned instead.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::EpicChainAPI.v2.Object.HeadResponse> Head(global::EpicChainAPI.v2.Object.HeadRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Search objects in container. Search query allows to match by Object
      /// Header's filed values. Please see the corresponding NeoFS Technical
      /// Specification section for more details.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="responseStream">Used for sending responses back to the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>A task indicating completion of the handler.</returns>
      public virtual global::System.Threading.Tasks.Task Search(global::EpicChainAPI.v2.Object.SearchRequest request, grpc::IServerStreamWriter<global::EpicChainAPI.v2.Object.SearchResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Get byte range of data payload. Range is set as an (offset, length) tuple.
      /// Like in `Get` method, the response uses gRPC stream. Requested range can be
      /// restored by concatenation of all received payload chunks keeping receiving
      /// order.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="responseStream">Used for sending responses back to the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>A task indicating completion of the handler.</returns>
      public virtual global::System.Threading.Tasks.Task GetRange(global::EpicChainAPI.v2.Object.GetRangeRequest request, grpc::IServerStreamWriter<global::EpicChainAPI.v2.Object.GetRangeResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Returns homomorphic or regular hash of object's payload range after
      /// applying XOR operation with the provided `salt`. Ranges are set of (offset,
      /// length) tuples. Hashes order in response corresponds to ranges order in
      /// request. Note that hash is calculated for XORed data.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::EpicChainAPI.v2.Object.GetRangeHashResponse> GetRangeHash(global::EpicChainAPI.v2.Object.GetRangeHashRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for ObjectService</summary>
    public partial class ObjectServiceClient : grpc::ClientBase<ObjectServiceClient>
    {
      /// <summary>Creates a new client for ObjectService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public ObjectServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ObjectService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public ObjectServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected ObjectServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected ObjectServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Receive full object structure, including Headers and payload. Response uses
      /// gRPC stream. First response message carries object with requested address.
      /// Chunk messages are parts of the object's payload if it is needed. All
      /// messages, except the first one, carry payload chunks. Requested object can
      /// be restored by concatenation of object message payload and all chunks
      /// keeping receiving order.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncServerStreamingCall<global::EpicChainAPI.v2.Object.GetResponse> Get(global::EpicChainAPI.v2.Object.GetRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Get(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Receive full object structure, including Headers and payload. Response uses
      /// gRPC stream. First response message carries object with requested address.
      /// Chunk messages are parts of the object's payload if it is needed. All
      /// messages, except the first one, carry payload chunks. Requested object can
      /// be restored by concatenation of object message payload and all chunks
      /// keeping receiving order.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncServerStreamingCall<global::EpicChainAPI.v2.Object.GetResponse> Get(global::EpicChainAPI.v2.Object.GetRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_Get, null, options, request);
      }
      /// <summary>
      /// Put the object into container. Request uses gRPC stream. First message
      /// SHOULD be of PutHeader type. `ContainerID` and `OwnerID` of an object
      /// SHOULD be set. Session token SHOULD be obtained before `PUT` operation (see
      /// session package). Chunk messages are considered by server as a part of an
      /// object payload. All messages, except first one, SHOULD be payload chunks.
      /// Chunk messages SHOULD be sent in direct order of fragmentation.
      /// </summary>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncClientStreamingCall<global::EpicChainAPI.v2.Object.PutRequest, global::EpicChainAPI.v2.Object.PutResponse> Put(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Put(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Put the object into container. Request uses gRPC stream. First message
      /// SHOULD be of PutHeader type. `ContainerID` and `OwnerID` of an object
      /// SHOULD be set. Session token SHOULD be obtained before `PUT` operation (see
      /// session package). Chunk messages are considered by server as a part of an
      /// object payload. All messages, except first one, SHOULD be payload chunks.
      /// Chunk messages SHOULD be sent in direct order of fragmentation.
      /// </summary>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncClientStreamingCall<global::EpicChainAPI.v2.Object.PutRequest, global::EpicChainAPI.v2.Object.PutResponse> Put(grpc::CallOptions options)
      {
        return CallInvoker.AsyncClientStreamingCall(__Method_Put, null, options);
      }
      /// <summary>
      /// Delete the object from a container. There is no immediate removal
      /// guarantee. Object will be marked for removal and deleted eventually.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::EpicChainAPI.v2.Object.DeleteResponse Delete(global::EpicChainAPI.v2.Object.DeleteRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Delete(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Delete the object from a container. There is no immediate removal
      /// guarantee. Object will be marked for removal and deleted eventually.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::EpicChainAPI.v2.Object.DeleteResponse Delete(global::EpicChainAPI.v2.Object.DeleteRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Delete, null, options, request);
      }
      /// <summary>
      /// Delete the object from a container. There is no immediate removal
      /// guarantee. Object will be marked for removal and deleted eventually.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::EpicChainAPI.v2.Object.DeleteResponse> DeleteAsync(global::EpicChainAPI.v2.Object.DeleteRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Delete the object from a container. There is no immediate removal
      /// guarantee. Object will be marked for removal and deleted eventually.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::EpicChainAPI.v2.Object.DeleteResponse> DeleteAsync(global::EpicChainAPI.v2.Object.DeleteRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Delete, null, options, request);
      }
      /// <summary>
      /// Returns the object Headers without data payload. By default full header is
      /// returned. If `main_only` request field is set, the short header with only
      /// the very minimal information would be returned instead.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::EpicChainAPI.v2.Object.HeadResponse Head(global::EpicChainAPI.v2.Object.HeadRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Head(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the object Headers without data payload. By default full header is
      /// returned. If `main_only` request field is set, the short header with only
      /// the very minimal information would be returned instead.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::EpicChainAPI.v2.Object.HeadResponse Head(global::EpicChainAPI.v2.Object.HeadRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Head, null, options, request);
      }
      /// <summary>
      /// Returns the object Headers without data payload. By default full header is
      /// returned. If `main_only` request field is set, the short header with only
      /// the very minimal information would be returned instead.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::EpicChainAPI.v2.Object.HeadResponse> HeadAsync(global::EpicChainAPI.v2.Object.HeadRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return HeadAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the object Headers without data payload. By default full header is
      /// returned. If `main_only` request field is set, the short header with only
      /// the very minimal information would be returned instead.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::EpicChainAPI.v2.Object.HeadResponse> HeadAsync(global::EpicChainAPI.v2.Object.HeadRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Head, null, options, request);
      }
      /// <summary>
      /// Search objects in container. Search query allows to match by Object
      /// Header's filed values. Please see the corresponding NeoFS Technical
      /// Specification section for more details.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncServerStreamingCall<global::EpicChainAPI.v2.Object.SearchResponse> Search(global::EpicChainAPI.v2.Object.SearchRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Search(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Search objects in container. Search query allows to match by Object
      /// Header's filed values. Please see the corresponding NeoFS Technical
      /// Specification section for more details.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncServerStreamingCall<global::EpicChainAPI.v2.Object.SearchResponse> Search(global::EpicChainAPI.v2.Object.SearchRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_Search, null, options, request);
      }
      /// <summary>
      /// Get byte range of data payload. Range is set as an (offset, length) tuple.
      /// Like in `Get` method, the response uses gRPC stream. Requested range can be
      /// restored by concatenation of all received payload chunks keeping receiving
      /// order.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncServerStreamingCall<global::EpicChainAPI.v2.Object.GetRangeResponse> GetRange(global::EpicChainAPI.v2.Object.GetRangeRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetRange(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Get byte range of data payload. Range is set as an (offset, length) tuple.
      /// Like in `Get` method, the response uses gRPC stream. Requested range can be
      /// restored by concatenation of all received payload chunks keeping receiving
      /// order.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncServerStreamingCall<global::EpicChainAPI.v2.Object.GetRangeResponse> GetRange(global::EpicChainAPI.v2.Object.GetRangeRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_GetRange, null, options, request);
      }
      /// <summary>
      /// Returns homomorphic or regular hash of object's payload range after
      /// applying XOR operation with the provided `salt`. Ranges are set of (offset,
      /// length) tuples. Hashes order in response corresponds to ranges order in
      /// request. Note that hash is calculated for XORed data.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::EpicChainAPI.v2.Object.GetRangeHashResponse GetRangeHash(global::EpicChainAPI.v2.Object.GetRangeHashRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetRangeHash(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns homomorphic or regular hash of object's payload range after
      /// applying XOR operation with the provided `salt`. Ranges are set of (offset,
      /// length) tuples. Hashes order in response corresponds to ranges order in
      /// request. Note that hash is calculated for XORed data.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::EpicChainAPI.v2.Object.GetRangeHashResponse GetRangeHash(global::EpicChainAPI.v2.Object.GetRangeHashRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetRangeHash, null, options, request);
      }
      /// <summary>
      /// Returns homomorphic or regular hash of object's payload range after
      /// applying XOR operation with the provided `salt`. Ranges are set of (offset,
      /// length) tuples. Hashes order in response corresponds to ranges order in
      /// request. Note that hash is calculated for XORed data.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::EpicChainAPI.v2.Object.GetRangeHashResponse> GetRangeHashAsync(global::EpicChainAPI.v2.Object.GetRangeHashRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetRangeHashAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns homomorphic or regular hash of object's payload range after
      /// applying XOR operation with the provided `salt`. Ranges are set of (offset,
      /// length) tuples. Hashes order in response corresponds to ranges order in
      /// request. Note that hash is calculated for XORed data.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::EpicChainAPI.v2.Object.GetRangeHashResponse> GetRangeHashAsync(global::EpicChainAPI.v2.Object.GetRangeHashRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetRangeHash, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override ObjectServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ObjectServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(ObjectServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Get, serviceImpl.Get)
          .AddMethod(__Method_Put, serviceImpl.Put)
          .AddMethod(__Method_Delete, serviceImpl.Delete)
          .AddMethod(__Method_Head, serviceImpl.Head)
          .AddMethod(__Method_Search, serviceImpl.Search)
          .AddMethod(__Method_GetRange, serviceImpl.GetRange)
          .AddMethod(__Method_GetRangeHash, serviceImpl.GetRangeHash).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ObjectServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_Get, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::EpicChainAPI.v2.Object.GetRequest, global::EpicChainAPI.v2.Object.GetResponse>(serviceImpl.Get));
      serviceBinder.AddMethod(__Method_Put, serviceImpl == null ? null : new grpc::ClientStreamingServerMethod<global::EpicChainAPI.v2.Object.PutRequest, global::EpicChainAPI.v2.Object.PutResponse>(serviceImpl.Put));
      serviceBinder.AddMethod(__Method_Delete, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::EpicChainAPI.v2.Object.DeleteRequest, global::EpicChainAPI.v2.Object.DeleteResponse>(serviceImpl.Delete));
      serviceBinder.AddMethod(__Method_Head, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::EpicChainAPI.v2.Object.HeadRequest, global::EpicChainAPI.v2.Object.HeadResponse>(serviceImpl.Head));
      serviceBinder.AddMethod(__Method_Search, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::EpicChainAPI.v2.Object.SearchRequest, global::EpicChainAPI.v2.Object.SearchResponse>(serviceImpl.Search));
      serviceBinder.AddMethod(__Method_GetRange, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::EpicChainAPI.v2.Object.GetRangeRequest, global::EpicChainAPI.v2.Object.GetRangeResponse>(serviceImpl.GetRange));
      serviceBinder.AddMethod(__Method_GetRangeHash, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::EpicChainAPI.v2.Object.GetRangeHashRequest, global::EpicChainAPI.v2.Object.GetRangeHashResponse>(serviceImpl.GetRangeHash));
    }

  }
}
#endregion
