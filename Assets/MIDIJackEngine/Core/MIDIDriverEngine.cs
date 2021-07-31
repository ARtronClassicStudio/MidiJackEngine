using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace UnityEngine.MIDIJackEngine
{
    public class MIDIDriverEngine
    {
        #region Internal Data

        class ChannelState
        {

            public float[] _noteArray;

         
            public Dictionary<int, float> _knobMap;

            public ChannelState()
            {
                _noteArray = new float[128];
                _knobMap = new Dictionary<int, float>();
            }
        }

  
        ChannelState[] _channelArray;

    
        int _lastFrame;

        #endregion

        #region Accessor Methods

        public float GetKey(MidiChannel channel, int noteNumber)
        {
            UpdateIfNeeded();
            var v = _channelArray[(int)channel]._noteArray[noteNumber];
            if (v > 1) return v - 1;
            if (v > 0) return v;
            return 0.0f;
        }

        public bool AnyKey
        {
            get
            {
                int k = 0;
                foreach (var key in Instance.History)
                {
                    k = key.data1;
                }
                return System.Convert.ToBoolean(k);
            }
           
        }

        public int AnyKeyInt
        {
            get
            {
                int k = 0;
                foreach(var key in Instance.History)
                {
                    k = key.data1;
                }
                return k;
            }
        }

        public bool GetKeyDown(MidiChannel channel, int noteNumber)
        {
            UpdateIfNeeded();
            return _channelArray[(int)channel]._noteArray[noteNumber] > 1;
        }

        public bool GetKeyUp(MidiChannel channel, int noteNumber)
        {
            UpdateIfNeeded();
            return _channelArray[(int)channel]._noteArray[noteNumber] < 0;
        }

        public int[] GetKnobNumbers(MidiChannel channel)
        {
            UpdateIfNeeded();
            var cs = _channelArray[(int)channel];
            var numbers = new int[cs._knobMap.Count];
            cs._knobMap.Keys.CopyTo(numbers, 0);
            return numbers;
        }

        public float GetKnob(MidiChannel channel, int knobNumber, float defaultValue)
        {
            UpdateIfNeeded();
            var cs = _channelArray[(int)channel];
            if (cs._knobMap.ContainsKey(knobNumber)) return cs._knobMap[knobNumber];
            return defaultValue;
        }

        #endregion

        #region Event Delegates

        public delegate void NoteOnDelegate(MidiChannel channel, int note, float velocity);
        public delegate void NoteOffDelegate(MidiChannel channel, int note);
        public delegate void KnobDelegate(MidiChannel channel, int knobNumber, float knobValue);

        public NoteOnDelegate noteOnDelegate { get; set; }
        public NoteOffDelegate noteOffDelegate { get; set; }
        public KnobDelegate knobDelegate { get; set; }

        #endregion

        #region Editor Support

        #if UNITY_EDITOR

        
        const float _updateInterval = 1.0f / 30;
        float _lastUpdateTime;

        bool CheckUpdateInterval()
        {
            var current = Time.realtimeSinceStartup;
            if (current - _lastUpdateTime > _updateInterval || current < _lastUpdateTime) {
                _lastUpdateTime = current;
                return true;
            }
            return false;
        }

        
        int _totalMessageCount;

        public int TotalMessageCount {
            get {
                UpdateIfNeeded();
                return _totalMessageCount;
            }
        }

        public Queue<MIDIMessage> History { get; }

#endif

        #endregion

        #region Public Methods

        MIDIDriverEngine()
        {
            _channelArray = new ChannelState[17];
            for (var i = 0; i < 17; i++)
                _channelArray[i] = new ChannelState();

            #if UNITY_EDITOR
            History = new Queue<MIDIMessage>();
            #endif
        }

        #endregion

        #region Private Methods

        void UpdateIfNeeded()
        {
            if (Application.isPlaying)
            {
                var frame = Time.frameCount;
                if (frame != _lastFrame) {
                    Update();
                    _lastFrame = frame;
                }
            }
            else
            {
                #if UNITY_EDITOR
                if (CheckUpdateInterval()) Update();
                #endif
            }
        }

        void Update()
        {
           
            foreach (var cs in _channelArray)
            {
                for (var i = 0; i < 128; i++)
                {
                    var x = cs._noteArray[i];
                    if (x > 1)
                        cs._noteArray[i] = x - 1; 
                    else if (x < 0)
                        cs._noteArray[i] = 0; 
                }
            }

           
            while (true)
            {
                
                var data = EngineDequeueIncomingData();
                if (data == 0) break;

               
                var message = new MIDIMessage(data);

               
                var statusCode = message.status >> 4;
                var channelNumber = message.status & 0xf;
               
              
                if (statusCode == 9)
                {
                    var velocity = 1.0f / 127 * message.data2 + 1;
                    _channelArray[channelNumber]._noteArray[message.data1] = velocity;
                    _channelArray[(int)MidiChannel.ChannelAll]._noteArray[message.data1] = velocity;
                    noteOnDelegate?.Invoke((MidiChannel)channelNumber, message.data1, velocity - 1);
                }

              
                if (statusCode == 8 || (statusCode == 9 && message.data2 == 0))
                {
                    _channelArray[channelNumber]._noteArray[message.data1] = -1;
                    _channelArray[(int)MidiChannel.ChannelAll]._noteArray[message.data1] = -1;
                    noteOffDelegate?.Invoke((MidiChannel)channelNumber, message.data1);
                }

               
                if (statusCode == 0xb)
                {
                   
                    var level = 1.0f / 127 * message.data2;
                    
                    _channelArray[channelNumber]._knobMap[message.data1] = level;
                   
                    _channelArray[(int)MidiChannel.ChannelAll]._knobMap[message.data1] = level;
                    knobDelegate?.Invoke((MidiChannel)channelNumber, message.data1, level);
                }

                #if UNITY_EDITOR
           
                _totalMessageCount++;
                History.Enqueue(message);
                #endif
            }

            #if UNITY_EDITOR
           
            while (History.Count > 8)
                History.Dequeue();
            #endif
        }

        #endregion

        #region Native Plugin Interface

        [DllImport("MIDIEngine", EntryPoint= "DequeueIncomingData")]
        public static extern ulong EngineDequeueIncomingData();

        #endregion

        #region Singleton Class Instance

        static MIDIDriverEngine _instance;

        public static MIDIDriverEngine Instance {
            get {
                if (_instance == null) {
                    _instance = new MIDIDriverEngine();
                    if (Application.isPlaying)
                        MidiStateUpdater.CreateGameObject(
                            new MidiStateUpdater.Callback(_instance.Update));
                }
                return _instance;
            }
        }

        #endregion
    }
}
