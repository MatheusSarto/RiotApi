﻿namespace RiotApi.DataStructures
{
    public class PerkStyleDto
    {
        public string Description { get; set; }
        public List<PerkStyleSelectionDto> Selections { get; set; }
        public int Style { get; set; }
    }
}
