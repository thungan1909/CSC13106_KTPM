namespace W6_1110
{
    internal class DefaultContentChecker : ContentChecker
    {
        public override bool isAppropriate(Article article, Member member)
        {
            return base.isAppropriate(article, member);
        }
    }
}