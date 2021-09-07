# InputSystemFPCharacter

A very very basic first person controller and character for Unity using the new Input System

It is in no way well architected or "good", but provides the most basic possible template I could think of after being baffled by the complexity of the new Standard Assets FPS controller released by Unity.

There is a single prefab you can drop into your scene that should "just work". This contains the lone first person controller script, which itself references an automatically generated script from the controller settings file.

The control scheme supports keyboard wasd + mouse or gamepad controls by default. Right mouse / right trigger on the gamepad zooms in your view. There is no run/sprint or jump, but these should be easy to add. The character already supports gravity and will fall off ledges etc.

Feel free to adapt and use this character/controller as you wish. Happy to consider pull requests that add features as long as they keep things simple (i.e. single file single prefab) and are easy for others to learn from.

You can read about Unity's new input system here: https://docs.unity3d.com/Packages/com.unity.inputsystem@1.1/manual/Installation.html

Code was inspired by and adapted from the following tutorial videos and scripts:

Ben Esposito (@torahhorse) First Person Drifter for Unity: http://www.torahhorse.com/index.php/portfolio/first-person-drifter-for-unity/

Brackeys First Person Movement in Unity - FPS Controller: https://www.youtube.com/watch?v=_QajrabyTJc

Cinemachine First Person Controller w/ Input System - Unity Tutorial: https://www.youtube.com/watch?v=5n_hmqHdijM
