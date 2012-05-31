using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace libMiracle
{
    public enum CharClass
    {
        DeathKnight = 1,
        Druid = 2, 
        Hunter = 3,
        Mage = 4, 
        Paladin = 5,
        Priest = 6,
        Rogue = 7,
        Shaman = 8,
        Warlock = 9,
        Warrior = 10
    }

    public enum CharRole
    {
        DPS = 1,
        Healer = 2,
        Tank = 3
    }

    public enum CharProfession
    {
        Alchemy, Blacksmithing, Enchanting, Engineering, Herbalism, Inscription, Jewelcrafting, 
        Leatherworking, Mining, Skinning, Tailoring
        
    }

    public enum GuildRank
    {
        Newbie, Alternative, Inititate, Veteran, Officer, GuildMaster
    }
}
