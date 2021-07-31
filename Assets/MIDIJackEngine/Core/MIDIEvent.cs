using UnityEngine.Events;

namespace UnityEngine.MIDIJackEngine
{
    [AddComponentMenu("MIDI Jack Engine/MIDI Event")]
    public class MIDIEvent : MonoBehaviour
    {
        enum RunMode
        {
            Update,
            Start
        }
        [SerializeField]
        private RunMode runMode;
        [Space(10)]
        [SerializeField]
        private UnityEvent OnGetKey;
        [SerializeField]
        private UnityEvent OffGetKey;
        [Space(10)]
        [SerializeField]
        private UnityEvent OnGetKeyDown;
        [SerializeField]
        private UnityEvent OffGetKeyDown;
 


        private void Start()
        {
            if(runMode == RunMode.Start)
            {
                if (InputMIDI.GetKeyBool(InputMIDI.AnyKeyInt()))
                {
                    OnGetKey.Invoke();
                }
                else
                {
                    OffGetKey.Invoke();
                }

                if (InputMIDI.GetKeyDown(InputMIDI.AnyKeyInt()))
                {
                    OnGetKeyDown.Invoke();
                }
                else
                {
                    OffGetKeyDown.Invoke();
                }

            }
        }

        private void Update()
        {
            if (runMode == RunMode.Update)
            {
                if (InputMIDI.GetKeyBool(InputMIDI.AnyKeyInt()))
                {
                    OnGetKey.Invoke();
                }
                else
                {
                    OffGetKey.Invoke();
                }

                if (InputMIDI.GetKeyDown(InputMIDI.AnyKeyInt()))
                {
                    OnGetKeyDown.Invoke();
                }
                else
                {
                    OffGetKeyDown.Invoke();
                }

            }
        }

    }
}
