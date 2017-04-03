﻿using System;

namespace WowAPI.Character
{
    public class Character
    {
        private readonly string name, realm, region, locale;

        public Character(string name, string realm, string region, string locale)
        {
            this.name = name;
            this.realm = realm;
            this.region = region;
            this.locale = locale;
        }

        private object CreateNewInstance(Type type, string name)
        {
            return ApiHelper.CreateNewInstance(type, new object[] { this.name, realm, region, locale });
        }

        public Profile Profile()
        {
            return CreateNewInstance(typeof(Profile), "profile") as Profile;
        }

        public Achievements Achievements()
        {
            return CreateNewInstance(typeof(Achievements), "achievements") as Achievements;
        }

        public Appearance Appearance()
        {
            return CreateNewInstance(typeof(Appearance), "appearance") as Appearance;
        }

        public Guild Guild()
        {
            return CreateNewInstance(typeof(Guild), "guild") as Guild;
        }

        public Mounts Mounts()
        {
            return CreateNewInstance(typeof(Mounts), "mounts") as Mounts;
        }

        public HunterPets HunterPets()
        {
            return CreateNewInstance(typeof(HunterPets), "hunterpets") as HunterPets;
        }

        public Pets Pets()
        {
            return CreateNewInstance(typeof(Pets), "pets") as Pets;
        }

        public PetSlots PetSlots()
        {
            return CreateNewInstance(typeof(PetSlots), "petslots") as PetSlots;
        }

        public Professions Professions()
        {
            return CreateNewInstance(typeof(Professions), "professions") as Professions;
        }

        public PvP PvP()
        {
            return CreateNewInstance(typeof(PvP), "pvp") as PvP;
        }

        public Quests Quests()
        {
            return CreateNewInstance(typeof(Quests), "quests") as Quests;
        }

        public Reputation Reputation()
        {
            return CreateNewInstance(typeof(Reputation), "reputation") as Reputation;
        }

        public Stats Stats()
        {
            return CreateNewInstance(typeof(Stats), "stats") as Stats;
        }

        public Titles Titles()
        {
            return CreateNewInstance(typeof(Titles), "titles") as Titles;
        }
    }
}
