﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Nether.Analytics
{
    public interface IMessageListener<T>
    {
        Task StartAsync(Func<IEnumerable<T>, Task> messageHandler);
        Task StopAsync();
    }
}