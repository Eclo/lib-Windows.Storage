﻿//
// Copyright (c) 2018 The nanoFramework project contributors
// See LICENSE file in the project root for full license information.
//

using System;

namespace Windows.Storage
{
    /// <summary>
    /// Contains info about the service that stores files and folders. Files and folders may be stored either by the local file system or by a remote service like Microsoft OneDrive.
    /// </summary>
    public sealed class StorageProvider : IStorageProvider
    {
        private readonly string _displayName;
        private readonly string _id;

        public string DisplayName => _displayName;

        public string Id => _id;

        //public IAsyncOperation<bool> IsPropertySupportedForPartialFileAsync(String propertyCanonicalName)
        //{ }

    }
}
