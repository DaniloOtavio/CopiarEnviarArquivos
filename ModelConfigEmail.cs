using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopiaCompactaFiscal
{
    internal class ModelConfigEmail
    {
        public string EmailRemetente { get; set; } = "";
        public string SenhaEmail { get; set; } = "";
        public int PortaSMTP { get; set; }
        public string ServidorSMTP { get; set; } = "";
        public Auth Auth { get; set; }
    }

    internal enum Auth
    {
        SSL,
        TLS
    }
}
