using System;
using System.Collections.Generic;
using System.Text;

namespace TheCoffeMechine
{
    class Milk
    {
        private int ml = 0;
        private int oneCupCoffe = 25;

        public Milk(int ml)
        {
            this.ml = ml;
        }

        public Boolean isAvailable()
        {
            return this.ml >= this.oneCupCoffe;
        }

        public void makeOneCup()
        {
            this.ml = this.ml - oneCupCoffe;
        }

        public int getml()
        {
            return this.ml;
        }
    }
}
