using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace W6_1110
{
    public class NewsChannel
    {
        protected Dictionary<int, Article> articles = new Dictionary<int, Article>();
        protected Dictionary<int, Member> subscibers = new Dictionary<int, Member>();
        protected Dictionary<int, List<String>> preferences = new Dictionary<int, List<String>>();

        public bool Subscribe(Member member, List<String> keywords)
        {
            subscibers.Add(member.ID, member);
            preferences.Add(member.ID,keywords);
            return true;
        }

        public bool Unsubscribe(int ID)
        {
            subscibers.Remove(ID);
            preferences.Remove(ID);
            return true;
        }
       public bool PostArticle(Article article, Member author)
        {
          articles.Add(article.ID, article);
          NotifyAll(article);
        }

        private void NotifyAll(Article article)
        {
            throw new NotImplementedException();
            //29:04
        }
}