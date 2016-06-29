using System;
using System.Collections.Generic;

namespace MQTT.REST.Core
{
    /// <summary>
    /// Base class to describe a REST request initiated from an MQTT message 
    /// </summary>
    public class MqttRestRequest
    {
        public MqttRestRequest()
        {
            Id = Guid.NewGuid();
        }
        /// <summary>
        /// A unique identifier for a single MqttRestRequest object that can (optionally) be set by the client
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Request type (one of the standard HttpVerbs)
        /// </summary>
        public HttpVerbs HttpVerb { get; set; }
        /// <summary>
        /// REST Api Endpoint (URI)
        /// </summary>
        public string Endpoint { get; set; }
        /// <summary>
        /// Request headers (key-value pairs)
        /// </summary>
        public Dictionary<string, object> Headers { get; set; }
        /// <summary>
        /// JSON representation of the request body
        /// </summary>
        public string Body { get; set; }
    }
    /// <summary>
    /// Enumerates standard HTTP verbs (GET, POST, PUT, PATCH, DELETE)
    /// </summary>
    public enum HttpVerbs
    {
        GET,
        POST,
        PUT,
        PATCH,
        DELETE
    }
    
}
