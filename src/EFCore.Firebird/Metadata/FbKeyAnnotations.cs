// Copyright (c) 2017 Jean Ressouche @SouchProd. All rights reserved.
// https://github.com/souchprod/SouchProd.EntityFrameworkCore.Firebird
// This code inherit from the .Net Foundation Entity Core repository (Apache licence)
// and from the Pomelo Foundation Mysql provider repository (MIT licence).
// Licensed under the MIT. See LICENSE in the project root for license information.

using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Microsoft.EntityFrameworkCore.Metadata
{
    public class FbKeyAnnotations : RelationalKeyAnnotations, IFirebirdKeyAnnotations
    {
        public FbKeyAnnotations([NotNull] IKey key)
            : base(key)
        {
        }

        protected FbKeyAnnotations([NotNull] RelationalAnnotations annotations)
            : base(annotations)
        {
        }
    }
}
