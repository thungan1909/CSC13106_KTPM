using System;

namespace W6_1110
{
    internal class ContentChecker
    {
        public virtual bool isAppropriate(Article article, Member member, System.Collections.Generic.List<string> list)
        {
            return true;
        }
    }
}