﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Nether.Web.Features.PlayerManagement
{
    /// <summary>
    /// Player Extended info request object
    /// </summary>
    public class PlayerExtendedPostRequestModel
    {
        /// <summary>
        /// Player ID. When ommited will be autogenerated.
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// Gamertag, must be uniqueue.
        /// </summary>
        [Required]
        public string Gamertag { get; set; }

        /// <summary>
        /// Extended player information (e.g. JSON)
        /// </summary>
        public string ExtendedInformation { get; set; }

  
    }
}
