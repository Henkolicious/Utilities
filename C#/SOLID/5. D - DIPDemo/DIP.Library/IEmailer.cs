﻿namespace DIP.Library
{
    public interface IMessageSender
    {
        void SendMessage(IPerson person, string message);
    }
}