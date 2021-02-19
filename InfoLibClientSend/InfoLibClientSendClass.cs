using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace InfoLibClientSend
{
    [Serializable]
    public class InfoLibClientSendClass
    {
        public string MSG { get; set; }
        public IPEndPoint remoteEP { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int? UserId { get; set; }
        public int? GroupId { get; set; }
        public int? TestId { get; set; }
        public int? TestMark { get; set; }
    }
}
