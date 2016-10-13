﻿namespace Discord.Commands
{
    public struct CommandContext
    {
        public IGuild Guild { get; }
        public IMessageChannel Channel { get; }
        public IUser User { get; }
        public IUserMessage Message { get; }

        public bool IsPrivate => Channel is IPrivateChannel;

        public CommandContext(IGuild guild, IMessageChannel channel, IUser user, IUserMessage msg)
        {
            Guild = guild;
            Channel = channel;
            User = user;
            Message = msg;
        }
    }
}
