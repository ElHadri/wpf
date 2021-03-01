using System.ServiceModel;

namespace CH05.SingleInstAppWCF
{
    [ServiceContract]
    interface IActivateWindow
    {
        [OperationContract]
        void Activate(string[] args);
    }
}
