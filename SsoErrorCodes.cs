using System.Collections.Generic;

namespace IT_ELECTIVE_2_LOPEZ_FINALS.Models
{
    public static class SsoErrorCodes
    {
        public static readonly Dictionary<string, string> Codes = new()
        {
            { "ERR_AUTH_001", "Missing Authorization Header or Bearer Token." },
            { "ERR_AUTH_002", "JWT Signature Verification Failed." },
            { "ERR_AUTH_003", "Token has expired." },
            { "ERR_AUTH_004", "User account inactive or disabled." }
        };
    }
}