﻿using QQ.Framework.Domains;
using QQ.Framework.Packets.Receive.Message;

namespace QQ.Framework.Utils
{
    public class DefaultReceiveCommand : ReceiveCommand
    {
        private Receive_Currency _packet;
        private QQEventArgs<Receive_Currency> _event_args;

        public DefaultReceiveCommand(byte[] data, QQClient client) : base(data, client)
        {
            _packet = new Receive_Currency(data, client.QQUser);
            _event_args = new QQEventArgs<Receive_Currency>(client, _packet);
        }

        public override void Receive()
        {
            _client.OnReceive_Currency(_event_args);
        }
    }
}