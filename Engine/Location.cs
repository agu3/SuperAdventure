using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Location
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Item ItemReqeustedToEnter { get; set; }
        public Quest QuestAvailableHere { get; set; }
        public Monster MonsterLivingHere { get; set; }
        public Location LocatioToNorth { get; set; }
        public Location LocatioToEast { get; set; }
        public Location LocatioToSouth { get; set; }
        public Location LocatioToWest { get; set; }
        
        public Location(int iD, string name, string description, Item itemReqeustedToEnter = null, Quest questAvailableHere = null,
            Monster monsterLivingHere = null)
        {
            ID = iD;
            Name = name;
            Description = description;
            ItemReqeustedToEnter = itemReqeustedToEnter;
            QuestAvailableHere = questAvailableHere;
            MonsterLivingHere = monsterLivingHere;
        }

        
        


    }

    
}
