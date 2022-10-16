namespace DuneEdit2.Models
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;

    using DuneEdit2.Enums;
    using DuneEdit2.Parsers;

    public record Generals
    {
        private readonly byte[] _dateAndTime = new byte[] { 0, 0 };

        private byte _charisma;

        private readonly int _contactDistance;

        private readonly byte _gameStage;

        private readonly byte[] _spice = new byte[] { 0 };
        private readonly byte _numberOfRalliedTroops;

        // this is RoomLocation/TypeOfPlace/DialogueAvailable/ExactPlace on NPC
        // the player location is also stored elsewhere, so changing these might not properly set Paul's location
        private readonly byte _locRoom;
        private readonly byte _locScene;
        private readonly byte _locDistance;
        private readonly byte _locIndex;

        private readonly byte[] _partyMembers = new byte[] { 0, 0 };
        private readonly ClsBitfield _NPCsHidden = new();

        public Generals()
        {
        }

        public Generals(List<byte> uncompressedData, ISaveGameOffsets offsets)
        {
            _spice = new byte[2]
            {
                uncompressedData[offsets.Spice],
                uncompressedData[offsets.Spice + 1]
            };
            _numberOfRalliedTroops = uncompressedData[offsets.NumberOfRalliedTroops];
            _gameStage = uncompressedData[offsets.GameStage];
            _contactDistance = uncompressedData[offsets.ContactDistance];
            _dateAndTime = new byte[2]
            {
                uncompressedData[offsets.DateTime],
                uncompressedData[offsets.DateTime + 1]
            };
            _charisma = uncompressedData[offsets.Charisma];

            _locRoom = uncompressedData[offsets.TimeCounters + 0x04];
            _locScene = uncompressedData[offsets.TimeCounters + 0x05];
            _locDistance = uncompressedData[offsets.TimeCounters + 0x06];
            _locIndex = uncompressedData[offsets.TimeCounters + 0x07];

            _partyMembers[0] = uncompressedData[offsets.PartyMembers];
            _partyMembers[1] = uncompressedData[offsets.PartyMembers + 1];
            _NPCsHidden = new ClsBitfield(uncompressedData[offsets.TimeCounters + 0x10] + (uncompressedData[offsets.TimeCounters + 0x11] << 8));

        }

        public static string DateGUI => "??";

        public byte CharismaByte
        {
            get => _charisma;
        }

        public byte CharismaGUI
        {
            get => Convert.ToByte(_charisma <= 1 ? 0 : _charisma / 2.0);

            set
            {
                checked
                {
                    var newValue = value * 2;
                    if (newValue > 0)
                    {
                        _charisma = (byte)newValue;
                    }
                    else
                    {
                        _charisma = 0;
                    }
                }
            }
        }

        public int ContactDistance => int.Parse(_contactDistance.ToString("X"), NumberStyles.HexNumber);

        public string DateAsHex => $"{_dateAndTime[0]:X2}{_dateAndTime[1]:X2}";

        public string GameStageAsHex => $"{_gameStage:X2}";

        public byte NumberOfRalliedTroops => _numberOfRalliedTroops;

        public byte GameStage => _gameStage;

        public string SpiceAsHex => $"{_spice[0]:X2}{_spice[1]:X2}";

        public int Spice
        {
            get
            {
                string s = _spice[1].ToString("X") + _spice[0].ToString("X");
                int num = int.Parse(s, NumberStyles.HexNumber);
                return checked(num * 10);
            }
        }

        public string GetGameStageDesc() => GameStageFinder.FindStage(_gameStage);

        public byte LocRoom => _locRoom;
        public byte LocScene => _locScene;
        public byte LocDistance => _locDistance;
        public byte LocIndex => _locIndex;

        private void SetPartyMember(byte id, int slot = 0)
        {
            if (_partyMembers[slot] <= 15)
            {
                _NPCsHidden.SetBit(id, false);
            }
            if (id <= 15)
            {
                _NPCsHidden.SetBit(id);
                _partyMembers[slot] = id;
            }
            else { _partyMembers[slot] = 255; }
        }

        public byte PartyMember0
        {
            get => _partyMembers[0];
            set => SetPartyMember(value);
        }
        public byte PartyMember1
        {
            get => _partyMembers[1];
            set => SetPartyMember(value, 1);
        }
        public ClsBitfield NPCsHidden => _NPCsHidden;
    }
}