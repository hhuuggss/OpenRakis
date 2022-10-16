namespace DuneEdit2.Models
{
    public interface ISaveGameOffsets
    {
        public int TimeCounters { get; }
        public int Troops { get; }
        public int Locations { get; }
        public int NPCs { get; }
        public int Smugglers { get; }
        public int Charisma { get; }
        public int ContactDistance { get; }
        public int DateTime { get; }
        public int DateTimeSaveScreen { get; }
        public int NumberOfRalliedTroops { get; }
        public int GameStage { get; }
        public int Spice { get; }
        public int Dialogues { get; }
        public int PartyMembers { get; }
    }

    public record Dune21Offsets : ISaveGameOffsets
    {
        int ISaveGameOffsets.TimeCounters { get { return 17339; } }
        int ISaveGameOffsets.Troops { get { return 19557; } }
        int ISaveGameOffsets.Locations { get { return 17595; } }
        int ISaveGameOffsets.NPCs { get { return 21395; } }
        int ISaveGameOffsets.Smugglers { get { return 21651; } }
        int ISaveGameOffsets.Charisma { get { return 17380; } }
        int ISaveGameOffsets.ContactDistance { get { return 21807; } }// TBD
        int ISaveGameOffsets.DateTime { get { return 21805; } }// TBD
        int ISaveGameOffsets.DateTimeSaveScreen { get { return 0; } }// TBD
        int ISaveGameOffsets.GameStage { get { return 17381; } }// TBD
        int ISaveGameOffsets.NumberOfRalliedTroops => 17379; //TBD
        int ISaveGameOffsets.Spice { get { return 17499; } } // TBD
        int ISaveGameOffsets.Dialogues { get { return 13113; } } // TBD
        int ISaveGameOffsets.PartyMembers { get { return 21773; } }
    }

    public record Dune23Offsets : ISaveGameOffsets
    {
        int ISaveGameOffsets.TimeCounters { get { return 17359; } }
        int ISaveGameOffsets.Troops { get { return 19577; } }
        int ISaveGameOffsets.Locations { get { return 17615; } }
        int ISaveGameOffsets.NPCs { get { return 21415; } }
        int ISaveGameOffsets.Smugglers { get { return 21671; } }
        int ISaveGameOffsets.Charisma { get { return 17400; } } // TBD
        int ISaveGameOffsets.ContactDistance { get { return 21829; } } // TBD
        int ISaveGameOffsets.DateTime { get { return 21827; } } // TBD
        int ISaveGameOffsets.DateTimeSaveScreen { get { return 0; } } // TBD
        int ISaveGameOffsets.NumberOfRalliedTroops => 17399; //TBD
        int ISaveGameOffsets.GameStage { get { return 17401; } } // TBD
        int ISaveGameOffsets.Spice { get { return 17519; } } // TBD
        int ISaveGameOffsets.Dialogues { get { return 13113; } } // TBD
        int ISaveGameOffsets.PartyMembers { get { return 21793; } }
    }

    public record Dune24Offsets : ISaveGameOffsets
    {
        int ISaveGameOffsets.TimeCounters { get { return 17369; } }
        int ISaveGameOffsets.Troops { get { return 19587; } }
        int ISaveGameOffsets.Locations { get { return 17625; } }
        int ISaveGameOffsets.NPCs { get { return 21425; } }
        int ISaveGameOffsets.Smugglers { get { return 21681; } }
        int ISaveGameOffsets.Charisma { get { return 17410; } } // TBD
        int ISaveGameOffsets.ContactDistance { get { return 21839; } } // TBD
        int ISaveGameOffsets.DateTime { get { return 21837; } } // TBD
        int ISaveGameOffsets.DateTimeSaveScreen { get { return 0; } } // TBD
        int ISaveGameOffsets.NumberOfRalliedTroops => 17409; //TBD
        int ISaveGameOffsets.GameStage { get { return 17411; } } // TBD
        int ISaveGameOffsets.Spice { get { return 17529; } } // TBD
        int ISaveGameOffsets.Dialogues { get { return 13113; } } // TBD
        int ISaveGameOffsets.PartyMembers { get { return 21803; } }
    }

    public record Dune37Offsets : ISaveGameOffsets
    {
        int ISaveGameOffsets.TimeCounters { get { return 17439; } }
        int ISaveGameOffsets.Troops { get { return 19657; } }
        int ISaveGameOffsets.Locations { get { return 17695; } }
        int ISaveGameOffsets.NPCs { get { return 21495; } }
        int ISaveGameOffsets.Smugglers { get { return 21751; } }
        int ISaveGameOffsets.Charisma { get { return 17480; } }
        int ISaveGameOffsets.ContactDistance { get { return 21909; } }
        int ISaveGameOffsets.DateTime { get { return 21907; } }
        int ISaveGameOffsets.DateTimeSaveScreen { get { return 0; } }
        int ISaveGameOffsets.NumberOfRalliedTroops => 17479;
        int ISaveGameOffsets.GameStage { get { return 17481; } }
        int ISaveGameOffsets.Spice { get { return 17599; } }
        int ISaveGameOffsets.Dialogues { get { return 13113; } }
        int ISaveGameOffsets.PartyMembers { get { return 21873; } }
    }
}
