﻿// Copyright (c) Microsoft Corporation. All rights reserved.// Licensed under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernApps.CommunityBot.Common.Events
{
    public interface IEventProvider
    {
        Task SendEventAsync(IEvent eventToSend);
    }
}
