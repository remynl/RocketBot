﻿#region using directives

using System.Threading.Tasks;
using RocketBot2.WebSocketHandler.GetCommands.Tasks;
using PoGo.NecroBot.Logic.State;
using SuperSocket.WebSocket;

#endregion

namespace RocketBot2.WebSocketHandler.GetCommands
{
    internal class GetTrainerProfileHandler : IWebSocketRequestHandler
    {
        public GetTrainerProfileHandler()
        {
            Command = "GetTrainerProfile";
        }

        public string Command { get; }

        public async Task Handle(ISession session, WebSocketSession webSocketSession, dynamic message)
        {
            await GetTrainerProfileTask.Execute(session, webSocketSession, (string) message.RequestID);
        }
    }
}