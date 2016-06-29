using System.Threading.Tasks;

namespace MQTT.REST.Core
{
    /// <summary>
    /// Base interface for classes that handle an MqttRestRequest
    /// </summary>
    public interface IMqttRestRequestHandler
    {
        /// <summary>
        /// Handles a MqttRestRequest (i.e. sends an HTTP Request based on the supplied parameters)
        /// </summary>
        /// <param name="request">The request parameters (i.e. endpoint, HttpVerb, Body)</param>
        void Handle(MqttRestRequest request);
        /// <summary>
        /// Handles a MqttRestRequest asynchronously
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task HandleAsync(MqttRestRequest request);
    }
}
