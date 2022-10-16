using DuneEdit2.Parsers;

namespace DuneEdit2.Models
{
    public record NPC
    {
        public int Id { get; set; }
        public int StartOffset { get; set; }
        public byte RoomLocation { get; set; }
        public byte TypeOfPlace { get; set; }
        public byte DialogueAvailable { get; set; }
        public byte ExactPlace { get; set; }
        public ushort DialoguePointer { get; set; }
        public byte UnknownByte1 { get; set; }
        public byte UnknownByte2 { get; set; }
        public byte UnknownByte3 { get; set; }
        public byte UnknownByte4 { get; set; }
        public byte UnknownByte5 { get; set; }
        public byte UnknownByte6 { get; set; }
        public byte UnknownByte7 { get; set; }
        public byte UnknownByte8 { get; set; }
        public byte SpriteId { get; set; } 
        public ClsBitfield? StatusBitfield { get; set; }
        public int Status
        {
            get { if (StatusBitfield != null) { return StatusBitfield.Bitfield; } else { return 0; } }
            set { if (StatusBitfield != null) { StatusBitfield.Bitfield = value; } }
        }
        public bool SpokenTo
        {
            get => StatusBitfield?.GetBit(5) != 0;
            set => StatusBitfield?.SetBit(5, value);
        }
        public bool IsCurrentPartyMember
        {
            get => StatusBitfield?.GetBit(6) != 0;
            set => StatusBitfield?.SetBit(6, value);
        }
        public bool RecruitmentDisabled
        {
            get => StatusBitfield?.GetBit(7) != 0;
            set => StatusBitfield?.SetBit(7, value);
        }
    }
}
