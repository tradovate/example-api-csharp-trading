/* 
 * 
 * Tradovate API, WebSocket for MarketData implementation
 *
*/

using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tradovate.Services.Client;

namespace Tradovate.MarketData
{
    class WSClient : WebSocketClient
    {
        public WSClient(string uri) : base(uri)
        {
        }

        public delegate void IncomingMessageEventHandler(IncomingMessage message);
        public IncomingMessageEventHandler IncomingMessage { get; set; }

        protected override void HandleEvent(IncomingMessage message)
        {
            base.HandleEvent(message);
            IncomingMessage?.Invoke(message);
        }
    }
}