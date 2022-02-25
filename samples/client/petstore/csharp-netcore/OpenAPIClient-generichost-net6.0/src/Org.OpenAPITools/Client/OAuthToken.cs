// <auto-generated>



using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Org.OpenAPITools.Client
{
    /// <summary>
    /// A token constructed with OAuth.
    /// </summary>
    public class OAuthToken : TokenBase
    {
        private string _raw;

        /// <summary>
        /// Constructs an OAuthToken object.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="timeout"></param>
        public OAuthToken(string value, TimeSpan? timeout = null) : base(timeout)
        {
            _raw = value;
        }

        /// <summary>
        /// Places the token in the header.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="headerName"></param>
        public virtual void UseInHeader(System.Net.Http.HttpRequestMessage request, string headerName)
        {
            request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", _raw);
        }
    }
}