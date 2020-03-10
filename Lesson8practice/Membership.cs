using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson8practice
{
    class Membership
    {
        public enum Level
        {
            Basic,
            Premium,
            Lifetime
        }

        public Plan plan;
        public Level level;

        public Membership()
        {
            plan = new Plan();
        }

        public void ChangeMembership(Membership.Level newlevel)
        {
            level = newlevel;
        }
    }
}
