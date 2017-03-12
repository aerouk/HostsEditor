using System;
using System.Net;

namespace HostsEditor
{
    /// <summary>
    /// Represents a WebClient with editable timeout property.
    /// </summary>
    class LimitableWebClient : WebClient
    {
        public int Timeout { get; set; }

        /// <summary>
        /// Creates a new instance of LimitableWebClient with a default timeout of 300 seconds.
        /// </summary>
        public LimitableWebClient()
        {
            Timeout = 300000;
        }

        /// <summary>
        /// Gets a web request from the specified Uri and the specified timeout.
        /// </summary>
        /// <param name="address">Uri to process request to</param>
        /// <returns>WebRequest from Uri</returns>
        protected override WebRequest GetWebRequest(Uri address)
        {
            var objWebRequest = base.GetWebRequest(address);

            objWebRequest.Timeout = Timeout;

            return objWebRequest;
        }
    }
}
