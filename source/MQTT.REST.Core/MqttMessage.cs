namespace MQTT.REST.Core
{
    /// <summary>
    /// Describes a basic MQTT message that can be published or subscribed to
    /// </summary>
    public struct MqttMessage
    {
        public MqttMessage(string topic, string message, QualityOfService qos)
        {
            Topic = topic;
            Message = message;
            QoS = qos;
        }
        public string Topic { get; private set; }
        public string Message { get; private set; }
        public QualityOfService QoS { get; private set; }
    }

    /// <summary>
    /// Enumerates standard MQTT QualityOfService descriptors 
    /// </summary>
    public enum QualityOfService
    {
        Default = 0,
        AtLeastOnce = 1,
        ExactlyOnce = 2
    }

}
