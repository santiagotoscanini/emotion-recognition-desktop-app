using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessLogic
{
    public static class Module
    {
        public enum SentimentState
        {
            NEGATIVE,
            POSITIVE
        }
        public enum PhraseState
        {
            HIGH_POSITVE,
            MEDIUM_POSITIVE,
            LOW_POSITIVE,
            NEUTRAL,
            LOW_NEGATIVE,
            MEDIUM_NEGATIVE,
            HIGH_NEGATIVE
        }
    }
}
