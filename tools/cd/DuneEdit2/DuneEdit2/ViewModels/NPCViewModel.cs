namespace DuneEdit2.ViewModels
{
    using DuneEdit2.Models;
    using DuneEdit2.Parsers;

    using ReactiveUI;

    public class NPCViewModel : ViewModelBase
    {

        private NPC _npc;
        public NPCViewModel(NPC npc)
        {
            _npc = npc;
            HasChanged = false;
        }

        public NPC NPC => _npc;

        public string? Name => NameOverride != null ? NameOverride : _npc.Id + ": " + NPCNameFinder.GetNPCName(_npc.SpriteId);

        public string? NameOverride;

        public int StartOffset => _npc.StartOffset;

        private bool _hasChanged = false;

        public bool HasChanged
        {
            get => _hasChanged;
            set
            {
                _hasChanged = value;
                this.RaisePropertyChanged(nameof(HasChanged));
            }
        }

        public byte RoomLocation
        {
            get => _npc.RoomLocation;
            set
            {
                _npc.RoomLocation = value;
                HasChanged = true;
                this.RaisePropertyChanged(nameof(RoomLocation));
            }
        }

        public byte TypeOfPlace
        {
            get => _npc.TypeOfPlace;
            set
            {
                _npc.TypeOfPlace = value;
                HasChanged = true;
                this.RaisePropertyChanged(nameof(TypeOfPlace));
            }
        }

        public byte DialogueAvailable
        {
            get => _npc.DialogueAvailable;
            set
            {
                _npc.DialogueAvailable = value;
                HasChanged = true;
                this.RaisePropertyChanged(nameof(DialogueAvailable));
            }
        }

        public byte ExactPlace
        {
            get => _npc.ExactPlace;
            set
            {
                _npc.ExactPlace = value;
                HasChanged = true;
                this.RaisePropertyChanged(nameof(ExactPlace));
            }
        }

        public ushort DialoguePointer
        {
            get => _npc.DialoguePointer;
            set
            {
                _npc.DialoguePointer = value;
                HasChanged = true;
                this.RaisePropertyChanged(nameof(DialoguePointer));
            }
        }

        public byte UnknownByte1
        {
            get => _npc.UnknownByte1;
            set
            {
                _npc.UnknownByte1 = value;
                HasChanged = true;
                this.RaisePropertyChanged(nameof(UnknownByte1));
            }
        }

        public byte UnknownByte2
        {
            get => _npc.UnknownByte2;
            set
            {
                _npc.UnknownByte2 = value;
                HasChanged = true;
                this.RaisePropertyChanged(nameof(UnknownByte2));
            }
        }

        public byte UnknownByte3
        {
            get => _npc.UnknownByte3;
            set
            {
                _npc.UnknownByte3 = value;
                HasChanged = true;
                this.RaisePropertyChanged(nameof(UnknownByte3));
            }
        }

        public byte UnknownByte4
        {
            get => _npc.UnknownByte4;
            set
            {
                _npc.UnknownByte4 = value;
                HasChanged = true;
                this.RaisePropertyChanged(nameof(UnknownByte4));
            }
        }

        public byte UnknownByte5
        {
            get => _npc.UnknownByte5;
            set
            {
                _npc.UnknownByte5 = value;
                HasChanged = true;
                this.RaisePropertyChanged(nameof(UnknownByte5));
            }
        }

        public byte UnknownByte6
        {
            get => _npc.UnknownByte6;
            set
            {
                _npc.UnknownByte6 = value;
                HasChanged = true;
                this.RaisePropertyChanged(nameof(UnknownByte6));
            }
        }

        public byte UnknownByte7
        {
            get => _npc.UnknownByte7;
            set
            {
                _npc.UnknownByte7 = value;
                HasChanged = true;
                this.RaisePropertyChanged(nameof(UnknownByte7));
            }
        }

        public byte UnknownByte8
        {
            get => _npc.UnknownByte8;
            set
            {
                _npc.UnknownByte8 = value;
                HasChanged = true;
                this.RaisePropertyChanged(nameof(UnknownByte8));
            }
        }

        public byte SpriteId
        {
            get => _npc.SpriteId;
            set
            {
                _npc.SpriteId = value;
                HasChanged = true;
                this.RaisePropertyChanged(nameof(SpriteId));
                this.RaisePropertyChanged(nameof(Name));
            }
        }

        public int Status
        {
            get => _npc.Status;
            set
            {
                _npc.Status = value;
                HasChanged = true;
                RaiseStatusChanged();
            }
        }

        public bool SpokenTo
        {
            get => _npc.SpokenTo;
            set
            {
                _npc.SpokenTo = value;
                HasChanged = true;
                RaiseStatusChanged();
            }
        }

        public bool IsCurrentPartyMember
        {
            get => _npc.IsCurrentPartyMember;
            set
            {
                _npc.IsCurrentPartyMember = value;
                HasChanged = true;
                RaiseStatusChanged();
            }
        }
        public bool RecruitmentDisabled
        {
            get => _npc.RecruitmentDisabled;
            set
            {
                _npc.RecruitmentDisabled = value;
                HasChanged = true;
                RaiseStatusChanged();
            }
        }

        private void RaiseStatusChanged()
        {
            this.RaisePropertyChanged(nameof(Status));
            this.RaisePropertyChanged(nameof(SpokenTo));
            this.RaisePropertyChanged(nameof(IsCurrentPartyMember));
            this.RaisePropertyChanged(nameof(RecruitmentDisabled));
        }

    }
}
