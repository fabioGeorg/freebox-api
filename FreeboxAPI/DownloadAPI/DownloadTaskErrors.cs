
namespace FreeboxAPI.DownloadAPI
{
    /// <summary>
    /// DownloadTaskErrors
    /// </summary>
    public enum DownloadTaskErrors
    {
        /// <summary>
        /// No error.
        /// </summary>
        none,
        /// <summary>
        /// Internal error.
        /// </summary>
        @internal,
        /// <summary>
        /// The disk is full.
        /// </summary>
        disk_full,
        /// <summary>
        /// Unknown error
        /// </summary>
        unknown,
        /// <summary>
        /// Parse error.
        /// </summary>
        parse_error,
        /// <summary>
        /// HTTP 301 error.
        /// </summary>
        http_301,
        /// <summary>
        /// HTTP 400 error.
        /// </summary>
        http_400,
        /// <summary>
        /// HTTP 401 error.
        /// </summary>
        http_401,
        /// <summary>
        /// HTTP 402 error.
        /// </summary>
        http_402,
        /// <summary>
        /// HTTP 403 error.
        /// </summary>
        http_403,
        /// <summary>
        /// HTTP 404 error.
        /// </summary>
        http_404,
        /// <summary>
        /// HTTP 405 error.
        /// </summary>
        http_405,
        /// <summary>
        /// HTTP 406 error.
        /// </summary>
        http_406,
        /// <summary>
        /// HTTP 407 error.
        /// </summary>
        http_407,
        /// <summary>
        /// HTTP 408 error.
        /// </summary>
        http_408,
        /// <summary>
        /// HTTP 409 error.
        /// </summary>
        http_409,
        /// <summary>
        /// HTTP 410 error.
        /// </summary>
        http_410,
        /// <summary>
        /// HTTP 411 error.
        /// </summary>
        http_411,
        /// <summary>
        /// HTTP 412 error.
        /// </summary>
        http_412,
        /// <summary>
        /// HTTP 413 error.
        /// </summary>
        http_413,
        /// <summary>
        /// HTTP 414 error.
        /// </summary>
        http_414,
        /// <summary>
        /// HTTP 415 error.
        /// </summary>
        http_415,
        /// <summary>
        /// HTTP 416 error.
        /// </summary>
        http_416,
        /// <summary>
        /// HTTP 417 error.
        /// </summary>
        http_417,
        /// <summary>
        /// HTTP 422 error.
        /// </summary>
        http_422,
        /// <summary>
        /// HTTP 423 error.
        /// </summary>
        http_423,
        /// <summary>
        /// HTTP 424 error.
        /// </summary>
        http_424,
        /// <summary>
        /// HTTP 425 error.
        /// </summary>
        http_425,
        /// <summary>
        /// HTTP 426 error.
        /// </summary>
        http_426,
        /// <summary>
        /// HTTP 427 error.
        /// </summary>
        http_427,
        /// <summary>
        /// HTTP 428 error.
        /// </summary>
        http_428,
        /// <summary>
        /// HTTP 429 error.
        /// </summary>
        http_429,
        /// <summary>
        /// HTTP 430 error.
        /// </summary>
        http_430,
        /// <summary>
        /// HTTP 431 error.
        /// </summary>
        http_431,
        /// <summary>
        /// Other 4xx HTTP errors.
        /// </summary>
        http_4xx,
        /// <summary>
        /// HTTP 500 error.
        /// </summary>
        http_500,
        /// <summary>
        /// HTTP 501 error.
        /// </summary>
        http_501,
        /// <summary>
        /// HTTP 502 error.
        /// </summary>
        http_502,
        /// <summary>
        /// HTTP 503 error.
        /// </summary>
        http_503,
        /// <summary>
        /// HTTP 504 error.
        /// </summary>
        http_504,
        /// <summary>
        /// HTTP 505 error.
        /// </summary>
        http_505,
        /// <summary>
        /// HTTP 506 error.
        /// </summary>
        http_506,
        /// <summary>
        /// HTTP 507 error.
        /// </summary>
        http_507,
        /// <summary>
        /// HTTP 508 error.
        /// </summary>
        http_508,
        /// <summary>
        /// HTTP 509 error.
        /// </summary>
        http_509,
        /// <summary>
        /// HTTP 510 error.
        /// </summary>
        http_510,
        /// <summary>
        /// HTTP 511 error.
        /// </summary>
        http_511,
        /// <summary>
        /// Other 5xx HTTP errors.
        /// </summary>
        http_5xx,
        /// <summary>
        /// Too many HTTP redirections.
        /// </summary>
        http_redirections_exceeded,
        /// <summary>
        /// Cannot find the requested group on server.
        /// </summary>
        nzb_no_group,
        /// <summary>
        /// Article not found on the server.
        /// </summary>
        nzb_not_found,
        /// <summary>
        /// Invalid article CRC.
        /// </summary>
        nzb_invalid_crc,
        /// <summary>
        /// Invalid article size.
        /// </summary>
        nzb_invalid_size,
        /// <summary>
        /// Invalid filename.
        /// </summary>
        nzb_invalid_filename,
        /// <summary>
        /// Error opening.
        /// </summary>
        nzb_open_failed,
        /// <summary>
        /// Error writing.
        /// </summary>
        nzb_write_failed,
        /// <summary>
        /// Missing article size.
        /// </summary>
        nzb_missing_size,
        /// <summary>
        /// Article decoding error.
        /// </summary>
        nzb_decode_error,
        /// <summary>
        /// Missing article segments.
        /// </summary>
        nzb_missing_segments,
        /// <summary>
        /// Other nzb error.
        /// </summary>
        nzb_error,
        /// <summary>
        /// Unknown host.
        /// </summary>
        unknown_host,
        /// <summary>
        /// Timeout.
        /// </summary>
        timeout,
        /// <summary>
        /// Invalid credentials.
        /// </summary>
        bad_authentication,
        /// <summary>
        /// Remote host refused connection.
        /// </summary>
        connection_refused,
        /// <summary>
        /// Nzb server need authentication.
        /// </summary>
        nzb_authentication_required,
        /// <summary>
        /// Unable to announce on tracker.
        /// </summary>
        bt_tracker_error,
        /// <summary>
        /// Missing torrent files.
        /// </summary>
        bt_missing_files,
        /// <summary>
        /// Error accessing torrent files.
        /// </summary>
        bt_file_error,
        /// <summary>
        /// Error accessing task context file.
        /// </summary>
        missing_ctx_file
    }
}
