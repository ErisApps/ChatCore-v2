﻿using System.Collections.ObjectModel;
using ChatCore.Utilities;

namespace ChatCore.Interfaces
{
    public interface IChatMessage
    {
        /// <summary>
        /// The internal identifier for this chat message
        /// </summary>
        string Id { get; }
        /// <summary>
        /// True if this message was generated by the underlying chat service, and not by another user.
        /// </summary>
        bool IsSystemMessage { get; }
        /// <summary>
        /// True if the message is a /me message, or whatever the equivalent is on the current chat service.
        /// </summary>
         bool IsActionMessage { get; }
        /// <summary>
        /// True if the message should be highlighted (pings, subscriber notifications, etc)
        /// </summary>
        bool IsHighlighted { get; }
        /// <summary>
        /// True if the logged in user was tagged/pinged in this message.
        /// </summary>
        bool IsPing { get; }
        /// <summary>
        /// The exact message the user sent into the chat, *with* any custom formatting applied by the chat service.
        /// </summary>
        string Message { get; }
        /// <summary>
        /// The user who sent this message
        /// </summary>
        IChatUser Sender { get; }
        /// <summary>
        /// The channel this message was sent in
        /// </summary>
        IChatChannel Channel { get; }
        /// <summary>
        /// A list of *all* the emotes/emojis contained in this message, in reverse order to make replacing them with something else extremely simple.
        /// </summary>
        IChatEmote[] Emotes { get; }
        /// <summary>
        /// All the raw metadata associated with this message. This contains platform-specific data for devs who want to access any extra data that may not have been parsed.
        /// </summary>
        ReadOnlyDictionary<string, string> Metadata { get; }

        JSONObject ToJson();
    }
}
