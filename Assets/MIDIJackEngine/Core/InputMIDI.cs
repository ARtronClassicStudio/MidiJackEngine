namespace UnityEngine
{
    public static class InputMIDI
    {
        /// <summary>
        /// MIDI event delegates: On.
        /// </summary>
        public static MIDIJackEngine.MIDIDriverEngine.NoteOnDelegate NoteOnDelegate
        {
            get => MIDIJackEngine.MIDIDriverEngine.Instance.noteOnDelegate;
            set => MIDIJackEngine.MIDIDriverEngine.Instance.noteOnDelegate = value;
        }

        /// <summary>
        /// MIDI event delegates: Off.
        /// </summary>
        public static MIDIJackEngine.MIDIDriverEngine.NoteOffDelegate NoteOffDelegate {
            get => MIDIJackEngine.MIDIDriverEngine.Instance.noteOffDelegate; 
            set => MIDIJackEngine.MIDIDriverEngine.Instance.noteOffDelegate = value; 
        }
        /// <summary>
        /// MIDI event delegates: Knob.
        /// </summary>
        public static MIDIJackEngine.MIDIDriverEngine.KnobDelegate KnobDelegate
        {
            get => MIDIJackEngine.MIDIDriverEngine.Instance.knobDelegate;
            set => MIDIJackEngine.MIDIDriverEngine.Instance.knobDelegate = value;
        }


        public static bool AnyKey()
        {
            return MIDIJackEngine.MIDIDriverEngine.Instance.AnyKey;
        }

        public static int AnyKeyInt()
        {
            return MIDIJackEngine.MIDIDriverEngine.Instance.AnyKeyInt;
        }

        /// <summary>
        /// When the user has pressed the button and is holding it.
        /// </summary>
        /// <param name="channel">Set channel.</param>
        /// <param name="noteNumber">Set note number.</param>
        /// <returns></returns>
        public static float GetKey(MIDIJackEngine.MidiChannel channel,int noteNumber)
        {
           
            return MIDIJackEngine.MIDIDriverEngine.Instance.GetKey(channel, noteNumber);
        }
        /// <summary>
        /// When the user has pressed the button and is holding it.
        /// </summary>
        /// <param name="noteNumber">Set note number.</param>
        /// <returns></returns>
        public static float GetKey(int noteNumber)
        {
            return MIDIJackEngine.MIDIDriverEngine.Instance.GetKey(MIDIJackEngine.MidiChannel.ChannelAll, noteNumber);
        }

        /// <summary>
        /// When the user has pressed the button and is holding it. For bool.
        /// </summary>
        /// <param name="channel">Set channel.</param>
        /// <param name="noteNumber">Set note number.</param>
        /// <returns></returns>
        public static bool GetKeyBool(MIDIJackEngine.MidiChannel channel,int noteNumber)
        {
            return System.Convert.ToBoolean(MIDIJackEngine.MIDIDriverEngine.Instance.GetKey(MIDIJackEngine.MidiChannel.ChannelAll,noteNumber));
        }

        /// <summary>
        /// When the user has pressed the button and is holding it. For bool.
        /// </summary>
        /// <param name="noteNumber">Set note number.</param>
        /// <returns></returns>
        public static bool GetKeyBool (int noteNumber)
        {
            return System.Convert.ToBoolean(MIDIJackEngine.MIDIDriverEngine.Instance.GetKey(MIDIJackEngine.MidiChannel.ChannelAll, noteNumber));
        }

        /// <summary>
        /// When the user clicked on the button.
        /// </summary>
        /// <param name="channel">Set channerl.</param>
        /// <param name="noteNumber">Set note number.</param>
        /// <returns></returns>
        public static bool GetKeyDown(MIDIJackEngine.MidiChannel channel, int noteNumber)
        {
            return MIDIJackEngine.MIDIDriverEngine.Instance.GetKeyDown(channel, noteNumber);
        }

        /// <summary>
        /// When the user clicked on the button.
        /// </summary>
        /// <param name="noteNumber">Set not number.</param>
        /// <returns></returns>
        public static bool GetKeyDown(int noteNumber)
        {
            return MIDIJackEngine.MIDIDriverEngine.Instance.GetKeyDown(MIDIJackEngine.MidiChannel.ChannelAll, noteNumber);
        }

        /// <summary>
        /// When the user released the button.
        /// </summary>
        /// <param name="channel">Set channel</param>
        /// <param name="noteNumber">Set note number</param>
        /// <returns></returns>
        public static bool GetKeyUp(MIDIJackEngine.MidiChannel channel, int noteNumber)
        {
            return MIDIJackEngine.MIDIDriverEngine.Instance.GetKeyUp(channel, noteNumber);
        }
        /// <summary>
        /// When the user released the button.
        /// </summary>
        /// <param name="noteNumber">Set note number</param>
        /// <returns></returns>
        public static bool GetKeyUp(int noteNumber)
        {
            return MIDIJackEngine.MIDIDriverEngine.Instance.GetKeyUp(MIDIJackEngine.MidiChannel.ChannelAll, noteNumber);
        }

        /// <summary>
        /// Provides the CC (knob) list.
        /// </summary>
        /// <param name="channel">Set channel</param>
        /// <returns></returns>
        public static int[] GetKnobNumbers(MIDIJackEngine.MidiChannel channel)
        {
            return MIDIJackEngine.MIDIDriverEngine.Instance.GetKnobNumbers(channel);
        }
        /// <summary>
        /// Provides the CC (knob) list.
        /// </summary>
        /// <returns></returns>
        public static int[] GetKnobNumbers()
        {
            return MIDIJackEngine.MIDIDriverEngine.Instance.GetKnobNumbers(MIDIJackEngine.MidiChannel.ChannelAll);
        }

        /// <summary>
        /// Returns the CC (knob) value.
        /// </summary>
        /// <param name="channel">Set channel</param>
        /// <param name="knobNumber">Set knob number</param>
        /// <param name="defaultValue">Set default value</param>
        /// <returns></returns>
        public static float GetKnob(MIDIJackEngine.MidiChannel channel, int knobNumber, float defaultValue = 0)
        {
            return MIDIJackEngine.MIDIDriverEngine.Instance.GetKnob(channel, knobNumber, defaultValue);
        }
        /// <summary>
        /// Returns the CC (knob) value.
        /// </summary>
        /// <param name="knobNumber">Set knob number</param>
        /// <param name="defaultValue">Set default value</param>
        /// <returns></returns>
        public static float GetKnob(int knobNumber, float defaultValue = 0)
        {
            return MIDIJackEngine.MIDIDriverEngine.Instance.GetKnob(MIDIJackEngine.MidiChannel.ChannelAll, knobNumber, defaultValue);
        }
    }
}
