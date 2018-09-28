using System.Collections.Generic;

namespace aspnet_core___Copia.Models
{
        public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}