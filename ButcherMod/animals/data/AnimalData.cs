﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHusbandryMod.animals
{
    public class AnimalData
    {
        public CowItem Cow;
        public PigItem Pig;
        public ChickenItem Chicken;
        public DuckItem Duck;
        public RabbitItem Rabbit;
        public SheepItem Sheep;
        public GoatItem Goat;

        public AnimalData()
        {
            Cow = new CowItem();
            Pig = new PigItem();
            Chicken = new ChickenItem();
            Duck = new DuckItem();
            Rabbit = new RabbitItem();
            Sheep = new SheepItem();
            Goat = new GoatItem();
        }

        public AnimalItem getAnimalItem(Animal animalEnum)
        {
            switch (animalEnum)
            {
                case Animal.Cow:
                    return Cow;
                case Animal.Pig:
                    return Pig;
                case Animal.Chicken:
                    return Chicken;
                case Animal.Duck:
                    return Duck;
                case Animal.Rabbit:
                    return Rabbit;
                case Animal.Sheep:
                    return Sheep;
                case Animal.Goat:
                    return Goat;
                default:
                    throw new ArgumentException("Invalid Animal");
            }
        }
    }
}
