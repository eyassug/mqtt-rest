using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQTT.REST.Core
{
    /// <summary>
    /// Base interface for classes that publish a message to an MQTT broker
    /// </summary>
    public interface IMqttMessagePublisher
    {
        /// <summary>
        /// Publishes a MQTT message
        /// </summary>
        /// <param name="message">The MQTT message to be published</param>
        void Publish(MqttMessage message);
        /// <summary>
        /// Publishes a MQTT message asynchronously
        /// </summary>
        /// <param name="message">The MQTT message to be published</param>
        /// <returns></returns>
        Task PublishAsync(MqttMessage message);
    }
}
