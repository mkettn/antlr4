/* Copyright (c) 2012 The ANTLR Project Contributors. All rights reserved.
 * Use is of this file is governed by the BSD 3-clause license that
 * can be found in the LICENSE.txt file in the project root.
 */
using Antlr4.Runtime;
using Antlr4.Runtime.Dfa;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Sharpen;

namespace Antlr4.Runtime.Dfa
{
    public class LexerDFASerializer : DFASerializer
    {
        public LexerDFASerializer(DFA dfa)
            : base(dfa, Vocabulary.EmptyVocabulary)
        {
        }

        [return: NotNull]
        protected internal override string GetEdgeLabel(int i)
        {
            return "'" + (char)i + "'";
        }
    }
}
