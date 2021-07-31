namespace UnityEngine.MIDIJackEngine
{
    /// <summary>
    /// MIDI channel names.
    /// </summary>
    public enum MidiChannel
    {
        Channel_0,    
        Channel_1,    
        Channel_2,
        Channel_3,
        Channel_4,
        Channel_5,
        Channel_6,
        Channel_7,
        Channel_8,
        Channel_9,
        Channel_10,
        Channel_11,
        Channel_12,
        Channel_13,
        Channel_14,
        Channel_15,
        ChannelAll     
    }

    /// <summary>
    /// MIDI message structure.
    /// </summary>
    public struct MIDIMessage
    {
        [SerializeField]
        public readonly uint source;
        [SerializeField]
        public readonly byte status;
        [SerializeField]
        public readonly byte data1;
        [SerializeField]
        public readonly byte data2;

        /// <summary>
        /// MIDI message structure.
        /// </summary>
        /// <param name="data"></param>
        public MIDIMessage(ulong data)
        {
            source = (uint)(data & 0xffffffffUL);
            status = (byte)((data >> 32) & 0xff);
            data1 = (byte)((data >> 40) & 0xff);
            data2 = (byte)((data >> 48) & 0xff);
        }

        public override string ToString()
        {

             const string fmt = "s({0:X2}) d({1:X2},{2:X2}) from {3:X8}";
             return string.Format(fmt, status, data1, data2, source);
        }
    }
}
