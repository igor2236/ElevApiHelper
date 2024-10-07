using ElevApiHelper.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace ElevApiHelper.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface ISmsService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sms"></param>
        /// <returns></returns>
        object SendSms(SmsRequest sms);
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        object GetSmsDevices();
    }
}
