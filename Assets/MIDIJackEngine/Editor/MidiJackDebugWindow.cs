using UnityEditor;
using System.Runtime.InteropServices;

namespace UnityEngine.MIDIJackEngine
{
    class MIDIJackDebugWindow : EditorWindow
    {
        #region Custom Editor Window Code

        [MenuItem("Window/MIDI Jack Debug")]
        public static void ShowWindow()
        {
           GetWindow<MIDIJackDebugWindow>("MIDI Jack Debug");
        }

        string tempKey;

        void NoteOn(MidiChannel channel, int note, float velocity)
        {
           tempKey = "Recent MIDI messages:";
            foreach (var message in MIDIDriverEngine.Instance.History)
            {
                if (note == 21) tempKey = "Note on: A0 / " + "Velocity:" + velocity;
                if (note == 22) tempKey = "Note on: A#0 / " + "Velocity:" + velocity;
                if (note == 23) tempKey = "Note on: B0 / " + "Velocity:" + velocity;
                if (note == 24) tempKey = "Note on: C1 / " + "Velocity:" + velocity;
                if (note == 25) tempKey = "Note on: C#1 / " + "Velocity:" + velocity;
                if (note == 26) tempKey = "Note on: D1 / " + "Velocity:" + velocity;
                if (note == 27) tempKey = "Note on: D#1 / " + "Velocity:" + velocity;
                if (note == 28) tempKey = "Note on: E1 / " + "Velocity:" + velocity;
                if (note == 29) tempKey = "Note on: F1 / " + "Velocity:" + velocity;
                if (note == 30) tempKey = "Note on: F#1 / " + "Velocity:" + velocity;
                if (note == 31) tempKey = "Note on: G1 / " + "Velocity:" + velocity;
                if (note == 32) tempKey = "Note on: G#1 / " + "Velocity:" + velocity;
                if (note == 33) tempKey = "Note on: A1 / " + "Velocity:" + velocity;
                if (note == 34) tempKey = "Note on: A#1 / " + "Velocity:" + velocity;
                if (note == 35) tempKey = "Note on: B1 / " + "Velocity:" + velocity;
                if (note == 36) tempKey = "Note on: C2 / " + "Velocity:" + velocity;
                if (note == 37) tempKey = "Note on: C#2 / " + "Velocity:" + velocity;
                if (note == 38) tempKey = "Note on: D2 / " + "Velocity:" + velocity;
                if (note == 39) tempKey = "Note on: D#2 / " + "Velocity:" + velocity;
                if (note == 40) tempKey = "Note on: E2 / " + "Velocity:" + velocity;
                if (note == 41) tempKey = "Note on: F2 / " + "Velocity:" + velocity;
                if (note == 42) tempKey = "Note on: F#2 / " + "Velocity:" + velocity;
                if (note == 43) tempKey = "Note on: G2 / " + "Velocity:" + velocity;
                if (note == 44) tempKey = "Note on: G#2 / " + "Velocity:" + velocity;
                if (note == 45) tempKey = "Note on: A2 / " + "Velocity:" + velocity;
                if (note == 46) tempKey = "Note on: A#2 / " + "Velocity:" + velocity;
                if (note == 47) tempKey = "Note on: B2 / " + "Velocity:" + velocity;
                if (note == 48) tempKey = "Note on: C3 / " + "Velocity:" + velocity;
                if (note == 49) tempKey = "Note on: C#3 / " + "Velocity:" + velocity;
                if (note == 50) tempKey = "Note on: D3 / " + "Velocity:" + velocity;
                if (note == 51) tempKey = "Note on: D#3 / " + "Velocity:" + velocity;
                if (note == 52) tempKey = "Note on: E3 / " + "Velocity:" + velocity;
                if (note == 53) tempKey = "Note on: F3 / " + "Velocity:" + velocity;
                if (note == 54) tempKey = "Note on: F#3 / " + "Velocity:" + velocity;
                if (note == 55) tempKey = "Note on: G3 / " + "Velocity:" + velocity;
                if (note == 56) tempKey = "Note on: G#3 / " + "Velocity:" + velocity;
                if (note == 57) tempKey = "Note on: A3 / " + "Velocity:" + velocity;
                if (note == 58) tempKey = "Note on: A#3 / " + "Velocity:" + velocity;
                if (note == 59) tempKey = "Note on: B3 / " + "Velocity:" + velocity;
                if (note == 60) tempKey = "Note on: C4 / " + "Velocity:" + velocity;
                if (note == 61) tempKey = "Note on: C#4 / " + "Velocity:" + velocity;
                if (note == 62) tempKey = "Note on: D4 / " + "Velocity:" + velocity;
                if (note == 63) tempKey = "Note on: D#4 / " + "Velocity:" + velocity;
                if (note == 64) tempKey = "Note on: E4 / " + "Velocity:" + velocity;
                if (note == 65) tempKey = "Note on: F4 / " + "Velocity:" + velocity;
                if (note == 66) tempKey = "Note on: F#4 / " + "Velocity:" + velocity;
                if (note == 67) tempKey = "Note on: G4 / " + "Velocity:" + velocity;
                if (note == 68) tempKey = "Note on: G#4 / " + "Velocity:" + velocity;
                if (note == 69) tempKey = "Note on: A4 / " + "Velocity:" + velocity;
                if (note == 70) tempKey = "Note on: A#4 / " + "Velocity:" + velocity;
                if (note == 71) tempKey = "Note on: B4 / " + "Velocity:" + velocity;
                if (note == 72) tempKey = "Note on: C5 / " + "Velocity:" + velocity;
                if (note == 73) tempKey = "Note on: C#5 / " + "Velocity:" + velocity;
                if (note == 74) tempKey = "Note on: D5 / " + "Velocity:" + velocity;
                if (note == 75) tempKey = "Note on: D#5 / " + "Velocity:" + velocity;
                if (note == 76) tempKey = "Note on: E5 / " + "Velocity:" + velocity;
                if (note == 77) tempKey = "Note on: F5 / " + "Velocity:" + velocity;
                if (note == 78) tempKey = "Note on: F#5 / " + "Velocity:" + velocity;
                if (note == 79) tempKey = "Note on: G5 / " + "Velocity:" + velocity;
                if (note == 80) tempKey = "Note on: G#5 / " + "Velocity:" + velocity;
                if (note == 81) tempKey = "Note on: A5 / " + "Velocity:" + velocity;
                if (note == 82) tempKey = "Note on: A#5 / " + "Velocity:" + velocity;
                if (note == 83) tempKey = "Note on: B5 / " + "Velocity:" + velocity;
                if (note == 84) tempKey = "Note on: C6 / " + "Velocity:" + velocity;
                if (note == 85) tempKey = "Note on: C#6 / " + "Velocity:" + velocity;
                if (note == 86) tempKey = "Note on: D6 / " + "Velocity:" + velocity;
                if (note == 87) tempKey = "Note on: D#6 / " + "Velocity:" + velocity;
                if (note == 88) tempKey = "Note on: E6 / " + "Velocity:" + velocity;
                if (note == 89) tempKey = "Note on: F6 / " + "Velocity:" + velocity;
                if (note == 90) tempKey = "Note on: F#6 / " + "Velocity:" + velocity;
                if (note == 91) tempKey = "Note on: G6 / " + "Velocity:" + velocity;
                if (note == 92) tempKey = "Note on: G#6 / " + "Velocity:" + velocity;
                if (note == 93) tempKey = "Note on: A6 / " + "Velocity:" + velocity;
                if (note == 94) tempKey = "Note on: A#6 / " + "Velocity:" + velocity;
                if (note == 95) tempKey = "Note on: B6 / " + "Velocity:" + velocity;
                if (note == 96) tempKey = "Note on: C7 / " + "Velocity:" + velocity;
                if (note == 97) tempKey = "Note on: C#7 / " + "Velocity:" + velocity;
                if (note == 98) tempKey = "Note on: D7 / " + "Velocity:" + velocity;
                if (note == 99) tempKey = "Note on: D#7 / " + "Velocity:" + velocity;
                if (note == 100) tempKey = "Note on: E7 / " + "Velocity:" + velocity;
                if (note == 101) tempKey = "Note on: F7 / " + "Velocity:" + velocity;
                if (note == 102) tempKey = "Note on: F#7 / " + "Velocity:" + velocity;
                if (note == 103) tempKey = "Note on: G7 / " + "Velocity:" + velocity;
                if (note == 104) tempKey = "Note on: G#7 / " + "Velocity:" + velocity;
                if (note == 105) tempKey = "Note on: A7 / " + "Velocity:" + velocity;
                if (note == 106) tempKey = "Note on: A#7 / " + "Velocity:" + velocity;
                if (note == 107) tempKey = "Note on: B7 / " + "Velocity:" + velocity;
                if (note == 108) tempKey = "Note on: C8 / " + "Velocity:" + velocity;

            }

           
        }


        void NoteOff(MidiChannel channel, int note)
        {
            tempKey = "Recent MIDI messages:";
            foreach (var message in MIDIDriverEngine.Instance.History)
            {
                if (note == 21) tempKey = "Note off: A0  ";
                if (note == 22) tempKey = "Note off: A#0  ";
                if (note == 23) tempKey = "Note off: B0  ";
                if (note == 24) tempKey = "Note off: C1  ";
                if (note == 25) tempKey = "Note off: C#1  ";
                if (note == 26) tempKey = "Note off: D1  ";
                if (note == 27) tempKey = "Note off: D#1  ";
                if (note == 28) tempKey = "Note off: E1  ";
                if (note == 29) tempKey = "Note off: F1  ";
                if (note == 30) tempKey = "Note off: F#1  ";
                if (note == 31) tempKey = "Note off: G1  ";
                if (note == 32) tempKey = "Note off: G#1  ";
                if (note == 33) tempKey = "Note off: A1  ";
                if (note == 34) tempKey = "Note off: A#1  ";
                if (note == 35) tempKey = "Note off: B1  ";
                if (note == 36) tempKey = "Note off: C2  ";
                if (note == 37) tempKey = "Note off: C#2  ";
                if (note == 38) tempKey = "Note off: D2  ";
                if (note == 39) tempKey = "Note off: D#2  ";
                if (note == 40) tempKey = "Note off: E2  ";
                if (note == 41) tempKey = "Note off: F2  ";
                if (note == 42) tempKey = "Note off: F#2  ";
                if (note == 43) tempKey = "Note off: G2  ";
                if (note == 44) tempKey = "Note off: G#2  ";
                if (note == 45) tempKey = "Note off: A2  ";
                if (note == 46) tempKey = "Note off: A#2  ";
                if (note == 47) tempKey = "Note off: B2  ";
                if (note == 48) tempKey = "Note off: C3  ";
                if (note == 49) tempKey = "Note off: C#3  ";
                if (note == 50) tempKey = "Note off: D3  ";
                if (note == 51) tempKey = "Note off: D#3  ";
                if (note == 52) tempKey = "Note off: E3  ";
                if (note == 53) tempKey = "Note off: F3  ";
                if (note == 54) tempKey = "Note off: F#3  ";
                if (note == 55) tempKey = "Note off: G3  ";
                if (note == 56) tempKey = "Note off: G#3  ";
                if (note == 57) tempKey = "Note off: A3  ";
                if (note == 58) tempKey = "Note off: A#3  ";
                if (note == 59) tempKey = "Note off: B3  ";
                if (note == 60) tempKey = "Note off: C4  ";
                if (note == 61) tempKey = "Note off: C#4  ";
                if (note == 62) tempKey = "Note off: D4  ";
                if (note == 63) tempKey = "Note off: D#4  ";
                if (note == 64) tempKey = "Note off: E4  ";
                if (note == 65) tempKey = "Note off: F4  ";
                if (note == 66) tempKey = "Note off: F#4  ";
                if (note == 67) tempKey = "Note off: G4  ";
                if (note == 68) tempKey = "Note off: G#4  ";
                if (note == 69) tempKey = "Note off: A4  ";
                if (note == 70) tempKey = "Note off: A#4  ";
                if (note == 71) tempKey = "Note off: B4  ";
                if (note == 72) tempKey = "Note off: C5  ";
                if (note == 73) tempKey = "Note off: C#5  ";
                if (note == 74) tempKey = "Note off: D5  ";
                if (note == 75) tempKey = "Note off: D#5  ";
                if (note == 76) tempKey = "Note off: E5  ";
                if (note == 77) tempKey = "Note off: F5  ";
                if (note == 78) tempKey = "Note off: F#5  ";
                if (note == 79) tempKey = "Note off: G5  ";
                if (note == 80) tempKey = "Note off: G#5  ";
                if (note == 81) tempKey = "Note off: A5  ";
                if (note == 82) tempKey = "Note off: A#5  ";
                if (note == 83) tempKey = "Note off: B5  ";
                if (note == 84) tempKey = "Note off: C6  ";
                if (note == 85) tempKey = "Note off: C#6  ";
                if (note == 86) tempKey = "Note off: D6  ";
                if (note == 87) tempKey = "Note off: D#6  ";
                if (note == 88) tempKey = "Note off: E6  ";
                if (note == 89) tempKey = "Note off: F6  ";
                if (note == 90) tempKey = "Note off: F#6  ";
                if (note == 91) tempKey = "Note off: G6  ";
                if (note == 92) tempKey = "Note off: G#6  ";
                if (note == 93) tempKey = "Note off: A6  ";
                if (note == 94) tempKey = "Note off: A#6  ";
                if (note == 95) tempKey = "Note off: B6  ";
                if (note == 96) tempKey = "Note off: C7  ";
                if (note == 97) tempKey = "Note off: C#7  ";
                if (note == 98) tempKey = "Note off: D7  ";
                if (note == 99) tempKey = "Note off: D#7  ";
                if (note == 100) tempKey = "Note off: E7  ";
                if (note == 101) tempKey = "Note off: F7  ";
                if (note == 102) tempKey = "Note off: F#7  ";
                if (note == 103) tempKey = "Note off: G7  ";
                if (note == 104) tempKey = "Note off: G#7  ";
                if (note == 105) tempKey = "Note off: A7  ";
                if (note == 106) tempKey = "Note off: A#7  ";
                if (note == 107) tempKey = "Note off: B7  ";
                if (note == 108) tempKey = "Note off: C8  ";

            }
        }

        void OnGUI()
        {


            GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),Resources.Load("g")as Texture2D,ScaleMode.StretchToFill);
            var endpointCount = EngineCountEndpoints();

            // Endpoints
            var temp = "Detected MIDI devices:";
            for (var i = 0; i < endpointCount; i++)
            {
                var id = EngineGetEndpointIdAtIndex(i);
                var name = GetEndpointName(id);
                temp += "\n" + id.ToString("X8") + ": " + name;
            }
            var old = "Recent MIDI Old messages:";
            foreach (var message in MIDIDriverEngine.Instance.History)
            {
                old = message.ToString();
            }

            GUILayout.BeginHorizontal();
        

            EditorGUILayout.HelpBox(temp.ToString(),MessageType.Info,true);
            EditorGUILayout.HelpBox(old, MessageType.Info, true);
            GUILayout.EndHorizontal();

            // Message history
            //temp = "Recent MIDI messages:";
           // foreach (var message in MIDIDriverEngine.Instance.History)
           // {
               // temp = "Note:" + message.data1.ToString();
            InputMIDI.NoteOnDelegate+=NoteOn;
            InputMIDI.NoteOffDelegate += NoteOff;
           // }


             GUILayout.Label(tempKey);
            

            GUIStyle tex = new GUIStyle();
            v = GUILayout.BeginScrollView(v);
            GUILayout.BeginHorizontal();
            for (int i = 0; i < 7; i++)
            {

                GUILayout.Label(Resources.Load("k") as Texture2D, tex,GUILayout.Height(100),GUILayout.Width(100));

            }
            GUILayout.EndHorizontal();


            GUILayout.BeginHorizontal();
            for (int i = 1; i <= 7; i++)
            {

                GUILayout.Label("C"+i, GUILayout.Height(100), GUILayout.Width(100));

            }
            GUILayout.EndHorizontal();




            //Start Find Key
            foreach(var m in MIDIDriverEngine.Instance.History)
            {
                idKey = m.data1;
            }
         
            if (idKey == 24)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(-3,77,50,50));
                    GUILayout.Label(Resources.Load("p")as Texture2D);
                    GUILayout.EndArea();
                }
            }   
            if (idKey == 25)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(6.1f, 77, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 24)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(-3, 77, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 26)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(12, 77, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 28)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(26, 77, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 29)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(40, 77, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 31)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(54, 77, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 33)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(68, 77, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 35)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(83, 77, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 36)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(97, 77, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 38)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(112, 77, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 40)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(126, 77, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 41)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(140, 77, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 43)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(155, 77, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 45)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(168, 77, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 47)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(183, 77, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 48)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(197, 77, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 50)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(212, 77, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 52)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(225, 77, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 53)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(240, 77, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 55)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(254, 77, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 57)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(268, 77, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 59)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(283, 77, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 60)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(298, 77, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 62)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(312, 77, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 64)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(326, 77, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 65)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(340, 77, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 67)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(355, 77, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 69)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(369, 77, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 71)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(383, 77, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 72)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(397, 77, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 74)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(412, 77, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 76)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(425, 77, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 77)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(440, 77, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 79)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(454, 77, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 81)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(468, 77, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 83)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(483, 77, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 84)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(497, 77, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 86)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(512, 77, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 88)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(526, 77, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 89)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(540, 77, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 91)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(555, 77, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 93)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(568, 77, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 95)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(582, 77, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 96)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(597, 77, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 98)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(612, 77, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 100)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(626, 77, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 101)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(640, 77, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 103)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(654, 77, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 105)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(668, 77, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 107)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(683, 77, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 25)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(6, 26, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 27)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(21, 26, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 30)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(49, 26, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 32)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(63, 26, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 34)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(78, 26, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 37)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(107, 26, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 39)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(121, 26, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 42)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(149, 26, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 44)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(164, 26, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 46)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(178, 26, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 49)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(206, 26, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 51)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(221, 26, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 54)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(249, 26, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 56)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(263, 26, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 58)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(278, 26, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 61)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(306, 26, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 63)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(321, 26, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 66)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(349, 26, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 68)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(363, 26, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 70)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(378, 26, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 73)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(406, 26, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 75)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(420, 26, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 78)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(449, 26, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 80)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(463, 26, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 82)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(478, 26, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 85)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(507, 26, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 87)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(521, 26, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 90)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(549, 26, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 92)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(564, 26, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 94)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(578, 26, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 97)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(606, 26, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 99)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(621, 26, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 102)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(649, 26, 50,50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 104)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(663, 26, 50, 50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
            if (idKey == 106)
            {
                if (InputMIDI.GetKeyBool(idKey))
                {
                    GUILayout.BeginArea(new Rect(678, 26, 50,50));
                    GUILayout.Label(Resources.Load("p") as Texture2D);
                    GUILayout.EndArea();
                }
            }
           

            //End Find Key 

            GUILayout.EndScrollView();

        }

        #endregion

        #region Update And Repaint

        const int _updateInterval = 15;
        int _countToUpdate;
        int _lastMessageCount;
        Vector2 v;
        int idKey;


        string tx;

        private void Update()
        {
            if (--_countToUpdate > 0) return;

            var mcount = MIDIDriverEngine.Instance.TotalMessageCount;
            if (mcount != _lastMessageCount) {
                Repaint();
                _lastMessageCount = mcount;
            }

            _countToUpdate = _updateInterval;
        }

        #endregion

        #region Native Plugin Interface

        [DllImport("MIDIEngine", EntryPoint="CountEndpoints")]
        static extern int EngineCountEndpoints();

        [DllImport("MIDIEngine", EntryPoint="GetEndpointIDAtIndex")]
        static extern uint EngineGetEndpointIdAtIndex(int index);

        [DllImport("MIDIEngine")]
        static extern System.IntPtr GetEndpointName(uint id);

        static string GetName(uint id) {
            return Marshal.PtrToStringAnsi(GetEndpointName(id));
        }

        #endregion
    }
}