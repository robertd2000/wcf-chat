using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Wcf_chat
{
    // ПРИМЕЧАНИЕ. Можно использовать команду "Переименовать" в меню "Рефакторинг", чтобы изменить имя интерфейса "IService1" в коде и файле конфигурации.
    [ServiceContract(CallbackContract =typeof(IServiceChatCallback))]
    public interface IServiceChat
    {
        [OperationContract]
        int Connect(string name);

        [OperationContract]
        void Disconnect(int id);

        [OperationContract(IsOneWay = true)]
        void SendMessage(string message, int id);
    }

    public interface IServiceChatCallback
    {
        [OperationContract(IsOneWay = true)]
        void MessageCallback(string message);
    }
}
