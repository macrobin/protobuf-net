
// Option: data-contract serialization ([DataContract]/[DataMember]) enabled
    
//------------------------------------------------------------------------------
// 
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// 
//------------------------------------------------------------------------------

// Generated from: BasicMessage.proto
namespace BasicProtoDemo
{
    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BasicMessage")]
    [global::System.Runtime.Serialization.DataContract(Name=@"BasicMessage")]
    
    public partial class BasicMessage : global::ProtoBuf.IExtensible
    {
      public BasicMessage() {}
      
    private int _id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.Runtime.Serialization.DataMember(Name=@"id", Order = 1, IsRequired = true)]
    
    public int Id
    {
      get { return _id; }
      set { _id = value; }
    }
    private string _name;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.Runtime.Serialization.DataMember(Name=@"name", Order = 2, IsRequired = true)]
    
    public string Name
    {
      get { return _name; }
      set { _name = value; }
    }
      private global::ProtoBuf.IExtension extensionObject;
      global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }
  
    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BasicOperationResponse")]
    [global::System.Runtime.Serialization.DataContract(Name=@"BasicOperationResponse")]
    
    public partial class BasicOperationResponse : global::ProtoBuf.IExtensible
    {
      public BasicOperationResponse() {}
      
    private BasicProtoDemo.BasicMessage _result;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.Runtime.Serialization.DataMember(Name=@"result", Order = 1, IsRequired = true)]
    
    public BasicProtoDemo.BasicMessage Result
    {
      get { return _result; }
      set { _result = value; }
    }
      private global::ProtoBuf.IExtension extensionObject;
      global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }
  
    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BasicOperationRequest")]
    [global::System.Runtime.Serialization.DataContract(Name=@"BasicOperationRequest")]
    
    public partial class BasicOperationRequest : global::ProtoBuf.IExtensible
    {
      public BasicOperationRequest() {}
      
      private global::ProtoBuf.IExtension extensionObject;
      global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }
  
    [global::System.ServiceModel.ServiceContract(Name = @"BasicService")]
    public interface IBasicService
    {
      
        [global::System.ServiceModel.OperationContract(Name = @"BasicOperation")]
        [global::ProtoBuf.ServiceModel.ProtoBehavior]
    BasicProtoDemo.BasicOperationResponse BasicOperation(BasicProtoDemo.BasicOperationRequest request);
    
        [global::System.ServiceModel.OperationContract(AsyncPattern = true, Name = @"BasicOperation")]
        global::System.IAsyncResult BeginBasicOperation(BasicProtoDemo.BasicOperationRequest request, global::System.AsyncCallback callback, object state);
    BasicProtoDemo.BasicOperationResponse EndBasicOperation(global::System.IAsyncResult ar);
    
    }
    
    
    public partial class BasicOperationCompletedEventArgs : global::System.ComponentModel.AsyncCompletedEventArgs
    {
        private object[] results;

        public BasicOperationCompletedEventArgs(object[] results, global::System.Exception exception, bool cancelled, object userState)
            : base(exception, cancelled, userState) 
        {
            this.results = results;
        }
        
        public BasicProtoDemo.BasicOperationResponse Result
        {
            get { 
                base.RaiseExceptionIfNecessary();
                return (BasicProtoDemo.BasicOperationResponse)(this.results[0]); 
            }
        }
    }
  
    
    [global::System.Diagnostics.DebuggerStepThroughAttribute()]
    public partial class BasicServiceClient : global::System.ServiceModel.ClientBase<IBasicService>, IBasicService
    {

        public BasicServiceClient()
        {}
        public BasicServiceClient(string endpointConfigurationName) 
            : base(endpointConfigurationName) 
        {}
        public BasicServiceClient(string endpointConfigurationName, string remoteAddress) 
            : base(endpointConfigurationName, remoteAddress)
        {}
        public BasicServiceClient(string endpointConfigurationName, global::System.ServiceModel.EndpointAddress remoteAddress)
            : base(endpointConfigurationName, remoteAddress)
        {}
        public BasicServiceClient(global::System.ServiceModel.Channels.Binding binding, global::System.ServiceModel.EndpointAddress remoteAddress)
            : base(binding, remoteAddress)
        {}

        
        private BeginOperationDelegate onBeginBasicOperationDelegate;
        private EndOperationDelegate onEndBasicOperationDelegate;
        private global::System.Threading.SendOrPostCallback onBasicOperationCompletedDelegate;

        public event global::System.EventHandler<BasicOperationCompletedEventArgs> BasicOperationCompleted;

        public BasicProtoDemo.BasicOperationResponse BasicOperation(BasicProtoDemo.BasicOperationRequest request)
        {
            return base.Channel.BasicOperation(request);
        }

        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public global::System.IAsyncResult BeginBasicOperation(BasicProtoDemo.BasicOperationRequest request, global::System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginBasicOperation(request, callback, asyncState);
        }

        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public BasicProtoDemo.BasicOperationResponse EndBasicOperation(global::System.IAsyncResult result)
        {
            return base.Channel.EndBasicOperation(result);
        }

        private global::System.IAsyncResult OnBeginBasicOperation(object[] inValues, global::System.AsyncCallback callback, object asyncState)
        {
            BasicProtoDemo.BasicOperationRequest request = ((BasicProtoDemo.BasicOperationRequest)(inValues[0]));
            return this.BeginBasicOperation(request, callback, asyncState);
        }

        private object[] OnEndBasicOperation(global::System.IAsyncResult result)
        {
            BasicProtoDemo.BasicOperationResponse retVal = this.EndBasicOperation(result);
            return new object[] {
                retVal};
        }

        private void OnBasicOperationCompleted(object state)
        {
            if ((this.BasicOperationCompleted != null))
            {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.BasicOperationCompleted(this, new BasicOperationCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }

        public void BasicOperationAsync(BasicProtoDemo.BasicOperationRequest request)
        {
            this.BasicOperationAsync(request, null);
        }

        public void BasicOperationAsync(BasicProtoDemo.BasicOperationRequest request, object userState)
        {
            if ((this.onBeginBasicOperationDelegate == null))
            {
                this.onBeginBasicOperationDelegate = new BeginOperationDelegate(this.OnBeginBasicOperation);
            }
            if ((this.onEndBasicOperationDelegate == null))
            {
                this.onEndBasicOperationDelegate = new EndOperationDelegate(this.OnEndBasicOperation);
            }
            if ((this.onBasicOperationCompletedDelegate == null))
            {
                this.onBasicOperationCompletedDelegate = new global::System.Threading.SendOrPostCallback(this.OnBasicOperationCompleted);
            }
            base.InvokeAsync(this.onBeginBasicOperationDelegate, new object[] {
                    request}, this.onEndBasicOperationDelegate, this.onBasicOperationCompletedDelegate, userState);
        }
    
    }  
  
}
