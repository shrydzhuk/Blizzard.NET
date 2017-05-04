﻿namespace WowAPI.Character
{
    public class Spell
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }
        public string CastTime { get; set; }
        public string Cooldown { get; set; }
        public string Subtext { get; set; }
        public string Range { get; set; }
        public string PowerCost { get; set; }
    }
}
