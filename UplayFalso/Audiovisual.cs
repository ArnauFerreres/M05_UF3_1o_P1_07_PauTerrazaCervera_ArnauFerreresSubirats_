using System;
using System.Collections.Generic;
using System.Text;

namespace UplayFalso
{
    public abstract class Audiovisual
    {
        public string OriginalFormat;
        public double Bitrate;
        public float Duration;
    }

    public class Videos : Audiovisual
    {
        public int Resolution;
    }
    public class SoundTracks : Audiovisual
    {
        public int AmountTracks;
        public string NameTracks;
        public List<string> Episodes;
        public float SeasonLength;
    }
}
