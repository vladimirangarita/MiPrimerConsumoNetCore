//------------------------------------------------------------------------------
// <generado automáticamente>
//     Este código fue generado por una herramienta.
//     //
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </generado automáticamente>
//------------------------------------------------------------------------------

namespace ServiceMedicamento
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MedicamentoCLS", Namespace="http://schemas.datacontract.org/2004/07/ServiciosMedicamentos.Clases")]
    public partial class MedicamentoCLS : object
    {
        
        private int IidMedicamentoField;
        
        private string NombreField;
        
        private string ConcentracionField;
        
        private int IidFormaFarmaceuticaField;
        
        private string NombreFormaFarmaceuticaField;
        
        private decimal PrecioField;
        
        private int StockField;
        
        private string PresentacionField;
        
        private int BHabilitadoField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IidMedicamento
        {
            get
            {
                return this.IidMedicamentoField;
            }
            set
            {
                this.IidMedicamentoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre
        {
            get
            {
                return this.NombreField;
            }
            set
            {
                this.NombreField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public string Concentracion
        {
            get
            {
                return this.ConcentracionField;
            }
            set
            {
                this.ConcentracionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public int IidFormaFarmaceutica
        {
            get
            {
                return this.IidFormaFarmaceuticaField;
            }
            set
            {
                this.IidFormaFarmaceuticaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=4)]
        public string NombreFormaFarmaceutica
        {
            get
            {
                return this.NombreFormaFarmaceuticaField;
            }
            set
            {
                this.NombreFormaFarmaceuticaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=5)]
        public decimal Precio
        {
            get
            {
                return this.PrecioField;
            }
            set
            {
                this.PrecioField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=6)]
        public int Stock
        {
            get
            {
                return this.StockField;
            }
            set
            {
                this.StockField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=7)]
        public string Presentacion
        {
            get
            {
                return this.PresentacionField;
            }
            set
            {
                this.PresentacionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=8)]
        public int BHabilitado
        {
            get
            {
                return this.BHabilitadoField;
            }
            set
            {
                this.BHabilitadoField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FormaFarmaceuticaCLS", Namespace="http://schemas.datacontract.org/2004/07/ServiciosMedicamentos.Clases")]
    public partial class FormaFarmaceuticaCLS : object
    {
        
        private int IidFormaFarmaceuticaField;
        
        private string NombreFormaFarmaceuticaField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IidFormaFarmaceutica
        {
            get
            {
                return this.IidFormaFarmaceuticaField;
            }
            set
            {
                this.IidFormaFarmaceuticaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NombreFormaFarmaceutica
        {
            get
            {
                return this.NombreFormaFarmaceuticaField;
            }
            set
            {
                this.NombreFormaFarmaceuticaField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceMedicamento.IMedicamentos")]
    public interface IMedicamentos
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedicamentos/ListarMedicamentos", ReplyAction="http://tempuri.org/IMedicamentos/ListarMedicamentosResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceMedicamento.MedicamentoCLS>> ListarMedicamentosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedicamentos/ListaFormaFarmaceutica", ReplyAction="http://tempuri.org/IMedicamentos/ListaFormaFarmaceuticaResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceMedicamento.FormaFarmaceuticaCLS>> ListaFormaFarmaceuticaAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedicamentos/RecuperarMedicamento", ReplyAction="http://tempuri.org/IMedicamentos/RecuperarMedicamentoResponse")]
        System.Threading.Tasks.Task<ServiceMedicamento.MedicamentoCLS> RecuperarMedicamentoAsync(int iidMedicamento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedicamentos/RegistraryActualizarMedicamento", ReplyAction="http://tempuri.org/IMedicamentos/RegistraryActualizarMedicamentoResponse")]
        System.Threading.Tasks.Task<int> RegistraryActualizarMedicamentoAsync(ServiceMedicamento.MedicamentoCLS oMedicamentoCLS);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedicamentos/EliminarMedicamento", ReplyAction="http://tempuri.org/IMedicamentos/EliminarMedicamentoResponse")]
        System.Threading.Tasks.Task<int> EliminarMedicamentoAsync(int iidMedicamento);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public interface IMedicamentosChannel : ServiceMedicamento.IMedicamentos, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public partial class MedicamentosClient : System.ServiceModel.ClientBase<ServiceMedicamento.IMedicamentos>, ServiceMedicamento.IMedicamentos
    {
        
    /// <summary>
    /// Implemente este método parcial para configurar el punto de conexión de servicio.
    /// </summary>
    /// <param name="serviceEndpoint">El punto de conexión para configurar</param>
    /// <param name="clientCredentials">Credenciales de cliente</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public MedicamentosClient() : 
                base(MedicamentosClient.GetDefaultBinding(), MedicamentosClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IMedicamentos.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MedicamentosClient(EndpointConfiguration endpointConfiguration) : 
                base(MedicamentosClient.GetBindingForEndpoint(endpointConfiguration), MedicamentosClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MedicamentosClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(MedicamentosClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MedicamentosClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(MedicamentosClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MedicamentosClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceMedicamento.MedicamentoCLS>> ListarMedicamentosAsync()
        {
            return base.Channel.ListarMedicamentosAsync();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceMedicamento.FormaFarmaceuticaCLS>> ListaFormaFarmaceuticaAsync()
        {
            return base.Channel.ListaFormaFarmaceuticaAsync();
        }
        
        public System.Threading.Tasks.Task<ServiceMedicamento.MedicamentoCLS> RecuperarMedicamentoAsync(int iidMedicamento)
        {
            return base.Channel.RecuperarMedicamentoAsync(iidMedicamento);
        }
        
        public System.Threading.Tasks.Task<int> RegistraryActualizarMedicamentoAsync(ServiceMedicamento.MedicamentoCLS oMedicamentoCLS)
        {
            return base.Channel.RegistraryActualizarMedicamentoAsync(oMedicamentoCLS);
        }
        
        public System.Threading.Tasks.Task<int> EliminarMedicamentoAsync(int iidMedicamento)
        {
            return base.Channel.EliminarMedicamentoAsync(iidMedicamento);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IMedicamentos))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IMedicamentos))
            {
                return new System.ServiceModel.EndpointAddress("http://192.168.250.14:8081/Medicamentos.svc");
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return MedicamentosClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IMedicamentos);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return MedicamentosClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IMedicamentos);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IMedicamentos,
        }
    }
}
