using System;

namespace FreeboxAPI.API
{
    /// <summary>
    /// APIResponse
    /// </summary>
    public class APIResponse
    {
        /// <summary>
        /// Default constructor.
        /// </summary>
        public APIResponse() { }
        /// <summary>
        /// Parameters constructor.
        /// </summary>
        /// <param name="success">Is the request a success.</param>
        /// <param name="result">Result of the request.</param>
        /// <param name="error">If not success, error code.</param>
        /// <param name="msg">Error msg.</param>
        public APIResponse(bool success, object result, string error, string msg)
        {
            Success = success;
            Result = result;
            ErrorCode = error;
            Msg = msg;
        }

        /// <summary>
        /// Indicates if the request was successful.
        /// </summary>
        public bool  Success { get; protected set; }
        /// <summary>
        /// The result of the request. 
        /// (It may be omitted if the request does not expect any result)
        /// </summary>
        public object Result { get; protected set; }
        /// <summary>
        /// In case of request error, this ErrorCode provides information about the error.
        /// The possible ErrorCode values are documented for each API.
        /// </summary>
        public string ErrorCode { get; protected set; }
        /// <summary>
        /// In case of error, provides a French error message relative to the error.
        /// </summary>
        public string Msg { get; protected set; }
    }
}
