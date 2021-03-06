// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.ComponentModel.Composition.Primitives;

namespace System.ComponentModel.Composition.ReflectionModel
{
    internal class ImportingParameter : ImportingItem
    {
        public ImportingParameter(ContractBasedImportDefinition definition, ImportType importType)
            : base(definition, importType)
        {
        }
    }
}
