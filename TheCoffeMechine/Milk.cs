﻿using System;

namespace TheCoffeMechine
{
    class Milk
    {
        private int volume = 0;
        private int volumeOneCup = 100;

        public Milk(int volume)
        {
            this.volume = volume;
        }

        public Boolean isAvailable()
        {
            return volume >= volumeOneCup;
        }

        public void addMilk(int volume)
        {
            this.volume += volume;
        }

        public int makeOneCup()
        {
            this.volume = this.volume - this.volumeOneCup;
            return volumeOneCup;
        }

        public int getVolume()
        {
            return this.volume;
        }
    }
}
