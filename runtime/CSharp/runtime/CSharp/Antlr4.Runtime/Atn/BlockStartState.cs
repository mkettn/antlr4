/* Copyright (c) 2012 The ANTLR Project Contributors. All rights reserved.
 * Use is of this file is governed by the BSD 3-clause license that
 * can be found in the LICENSE.txt file in the project root.
 */
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Sharpen;

namespace Antlr4.Runtime.Atn
{
    /// <summary>
    /// The start of a regular
    /// <c>(...)</c>
    /// block.
    /// </summary>
    public abstract class BlockStartState : DecisionState
    {
        public BlockEndState endState;
    }
}
