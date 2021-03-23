using Newtonsoft.Json;
using System.Text;

namespace Org.Messaging
{
    public static class MessageExtensions
    {
        /// <summary>
        /// Serliazes a message body and wraps it in an envelope for sending
        /// </summary>
        /// <param name="message">Message to wrap</param>
        /// <returns>Wrapped message</returns>
        public static Envelope Wrap(this object message)
        {
            var json = JsonConvert.SerializeObject(message);
            return new Envelope
            {
                Subject = message.GetType().FullName,
                Body = Encoding.Unicode.GetBytes(json)
            };
        }
    }
}
