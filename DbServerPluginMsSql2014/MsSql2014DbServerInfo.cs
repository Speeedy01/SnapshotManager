﻿//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DbServerPluginMsSql2014
{
    using DbServerPlugin;

    /// <summary>
    /// See <see cref="IDbServerInfo"/>.
    /// </summary>
    public class MsSql2014DbServerInfo : IDbServerInfo
    {
        /// <summary>
        /// See <see cref="IDbServerInfo.Description"/>.
        /// </summary>
        public string Description => MsSql2014.Description;
    }
}
