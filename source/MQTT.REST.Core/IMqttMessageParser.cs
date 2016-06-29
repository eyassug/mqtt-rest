namespace MQTT.REST.Core
{
    /// <summary>
    /// Base interface to parse incoming MQTT messages into REST Api Requests
    /// </summary>
    public interface IMqttMessageParser
    {
        /// <summary>
        /// Accepts an MQTT message and parses it into a REST API Request
        /// </summary>
        /// <param name="message">MQTT message constructed from a subscription to a topic</param>
        /// <returns>An MqttRestRequest object that can be handled by an instance of type IMqttRestRequestHandler class</returns>
        MqttRestRequest Parse(MqttMessage message);
    }
}
