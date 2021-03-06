// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Security.Authentication.ExtendedProtection;

namespace System.Net
{
    public abstract class TransportContext
    {
        public abstract ChannelBinding? GetChannelBinding(ChannelBindingKind kind);
    }
}
