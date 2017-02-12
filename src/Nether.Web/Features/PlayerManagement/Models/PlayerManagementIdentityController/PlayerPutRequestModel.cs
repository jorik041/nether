﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.ComponentModel.DataAnnotations;

namespace Nether.Web.Features.PlayerManagement.Models.PlayerManagementIdentity
{
    /// <summary>
    /// Player info request object
    /// </summary>
    public class SetGamertagRequestModel
    {
        /// <summary>
        /// Gamertag
        /// </summary>
        [Required]
        public string Gamertag { get; set; }
    }
}
