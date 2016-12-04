/* Copyright (c) 2012 The ANTLR Project Contributors. All rights reserved.
 * Use is of this file is governed by the BSD 3-clause license that
 * can be found in the LICENSE.txt file in the project root.
 */
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Sharpen;

namespace Antlr4.Runtime.Atn
{
    /// <author>Sam Harwell</author>
    /// <since>4.2</since>
    public enum LexerActionType
    {
        Channel,
        Custom,
        Mode,
        More,
        PopMode,
        PushMode,
        Skip,
        Type
    }
}
