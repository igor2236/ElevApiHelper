using ElevApiHelper.Interfaces;
using ElevApiHelper.Models;
namespace ElevApiHelper.Services
{
    internal class SmsService : ISmsService
    {
        //POST
        //sms/send
        //Envio de SMS
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sms"></param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public object SendSms(Sms sms)
        {
            throw new System.NotImplementedException();
        }

        //GET
        //sms/devices
        //Retorna as boards e canais de SMS
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public object GetSmsDevices()
        {
            throw new System.NotImplementedException();
        }

    }
}
