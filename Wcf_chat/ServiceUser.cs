using System.ServiceModel;

namespace Wcf_chat
{
    class ServiceUser
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public OperationContext operationContext { get; set; }

    }
}
