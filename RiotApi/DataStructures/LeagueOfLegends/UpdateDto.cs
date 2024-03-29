﻿namespace RiotApi.DataStructures.LeagueOfLegends
{
    /**
    * @brief Status Information.
    * \class UpdateDto
    * \file UpdateDto.cs
    * \date 25/03/2023
    */
    public class UpdateDto
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public bool Publish { get; set; }

        /**
         * @brief Legal Values: Riotclient, Riotstatus, Game.
         */
        public List<string> Publish_Locations { get; set; }
        public List<ContentDto> Translations { get; set; }
        public string Created_At { get; set; }
        public string Updated_At { get; set; }
    }
}
