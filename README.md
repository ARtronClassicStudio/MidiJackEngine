# MIDI Jack Engine
MIDI Jack Engine is a MIDI input plugin for Unity.

# System Requirements
Unity 2020.3.14f1 (LST)

Only for Windows
# Installation
Download and import MidiJack.unitypackage into your project. That’s it!

See the troubleshooting topics if you encounter any problems.

API Reference
The basic functions of MIDI Jack are provided in the MidiMaster class.

The channel arguments in the following functions can be omitted. In that case, the functions return the values in the All-Channel slot, which stores mixed status of all active channels.

MidiMaster.GetKey (channel, noteNumber)

Returns the velocity value while the key is pressed, or zero while the key is released. The value ranges from 0.0 (note-off) to 1.0 (maximum velocity).

MidiMaster.GetKeyDown (channel, noteNumber)

Returns true during the frame the user starts pressing down the key.

MidiMaster.GetKeyUp (channel, noteNumber)

Returns true during the frame the user releases the key.

MidiMaster.GetKnob (channel, knobNumber, defaultValue)

Returns the controller value (CC). The value ranges from 0.0 to 1.0.

MidiMaster.GetKnobNumbers (channel)

Returns the list of active controllers.

There are also delegates for the each type of MIDI event.

MidiMaster.noteOnDelegate (channel, noteNumber, velocity)
MidiMaster.noteOffDelegate (channel, noteNumber)
MidiMaster.knobDelegate (channel, knobNumber, konbValue)
MIDI Monitor Window
MIDI Jack provides the MIDI Monitor window, which shows the list of active devices and incoming MIDI messages.

monitor

The MIDI Monitor window is available from the menu Window -> MIDI Jack.

Current Limitations
Currently MIDI Jack only supports Windows and OS X. No iOS support yet.
Only supports note and CC messages. No support for program changes nor SysEx.
The MIDI Jack plugin always tries to capture all available MIDI devices. On Windows this behavior may conflict with other MIDI applications.
