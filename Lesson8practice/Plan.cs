using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson8practice
{
    class Plan
    {
        public enum Renewal
        {
            Monthly,
            SixMonth,
            Annually,
            TwoYear,
            ThreeYear
        }

        public Renewal renewal;

        public Plan()
        {

        }

        public void ChangeRenewal(Plan.Renewal renew)
        {
            renewal = renew;
        }
    }
}
