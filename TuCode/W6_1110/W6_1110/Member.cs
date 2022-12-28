using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace W6_1110
{
    public class Member
    {
        public int ID { get; internal set; }

        internal void Notify(NewsChannel newsChannel, Article article)
        {
            throw new NotImplementedException();
        }
    }
}