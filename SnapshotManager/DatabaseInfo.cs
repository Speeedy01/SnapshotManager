﻿//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace SnapshotManager
{
    using System.Collections.Generic;
    using Base;

    /// <summary>
    /// Represents a database.
    /// </summary>
    public class DatabaseInfo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DatabaseInfo"/> class.
        /// </summary>
        public DatabaseInfo(
            ConnectionInfo connection,
            string name,
            IEnumerable<string> physicalFilePaths)
        {
            ArgumentChecks.AssertNotNull(connection, nameof(connection));
            ArgumentChecks.AssertNotNullOrEmpty(name, nameof(name));
            ArgumentChecks.AssertNotNull(physicalFilePaths, nameof(physicalFilePaths));

            this.Connection = connection;
            this.Name = name;
            this.PhysicalFilePaths = physicalFilePaths;
        }

        /// <summary>
        /// Gets the connection associated with this database.
        /// </summary>
        public ConnectionInfo Connection { get; }

        /// <summary>
        /// Gets the database name.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets physical file paths (including location and file name).
        /// </summary>
        public IEnumerable<string> PhysicalFilePaths { get; }

        /// <summary>
        /// See <see cref="object.ToString"/>.
        /// </summary>
        public override string ToString()
        {
            return this.Name;
        }
    }
}
