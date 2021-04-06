
using System;
using System.Collections.Generic;
using Catalyst;
using Mosaik.Core;

namespace Catalyst.Models
{
    public static partial class Polish
    {
        internal sealed class Lemmatizer : ILemmatizer
        {
            public Language Language => Language.Polish;

            public string GetLemma(IToken token)
            {
                return new string(GetLemmaAsSpan(token));
            }

            public ReadOnlySpan<char> GetLemmaAsSpan(IToken token)
            {
                return token.ValueAsSpan;
            }

            public bool IsBaseForm(IToken token)
            {
                return false;
            }
        }
    }
}
