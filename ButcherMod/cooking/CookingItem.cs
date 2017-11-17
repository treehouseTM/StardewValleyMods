﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButcherMod.cooking
{
    public class CookingItem
    {
        public int Price;
        public int Edibility;
        public int Farming;
        public int Fishing;
        public int Mining;
        public int Luck;
        public int Foraging;
        public int MaxEnergy;
        public int Magnetism;
        public int Speed;
        public int Defense;
        public int Attack;
        public int Duration;

        public CookingItem(int price, int edibility, int farming, int fishing, int mining, int luck, int foraging, int maxEnergy, int magnetism, int speed, int defense, int attack, int duration)
        {
            Price = price;
            Edibility = edibility;
            Farming = farming;
            Fishing = fishing;
            Mining = mining;
            Luck = luck;
            Foraging = foraging;
            MaxEnergy = maxEnergy;
            Magnetism = magnetism;
            Speed = speed;
            Defense = defense;
            Attack = attack;
            Duration = duration;
        }

        public string FillObjectString(string objectString)
        {
            return String.Format(objectString, Price, Edibility, Farming, Fishing, Mining, Luck, Foraging, MaxEnergy, Magnetism, Speed, Defense, Attack, Duration);
        }
    }
}