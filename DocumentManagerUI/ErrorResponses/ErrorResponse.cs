using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;

namespace DocumentManager.API.ErrorResponses
{
    public class ErrorResponse
    {
        public string ErrorMessage { get; set; }
        public ErrorResponse(string errorMessage)
        {
            ErrorMessage = errorMessage;
        }
    }
}
