# InputSystemFPCharacter

A very very basic first person controller and character for Unity using the new Input System

It is in no way well architected or "good", but provides the most basic possible template I could think of after being baffled by the complexity of the new Standard Assets FPS controller released by Unity.

There is a single prefab you can drop into your scene that should "just work". This contains the lone first person controller script, which itself references an automatically generated script from the controller settings file.

The control scheme supports keyboard wasd + mouse for move and look, and/or gamepad left-stick and right-stick move and look, by default. Right mouse / right trigger on the gamepad zooms in your view. There is also a basic crouch on left trigger / left ctrl key.

There is no run/sprint or jump, but these should be easy to add. There is also a stubbed-out control option to use the start button on gamepad or esc key on keyboard to bring up a pause menu.

Feel free to adapt and use this character/controller as you wish. Happy to consider pull requests that fix/add features as long as they keep things simple (i.e. single file single prefab) and are easy for others to learn from.

You can read about Unity's new input system here: https://docs.unity3d.com/Packages/com.unity.inputsystem@1.1/manual/Installation.html

Code was inspired by and adapted from the following character controller and tutorial videos:

Ben Esposito (@torahhorse) First Person Drifter for Unity: http://www.torahhorse.com/index.php/portfolio/first-person-drifter-for-unity/

Brackeys First Person Movement in Unity - FPS Controller: https://www.youtube.com/watch?v=_QajrabyTJc

Cinemachine First Person Controller w/ Input System - Unity Tutorial: https://www.youtube.com/watch?v=5n_hmqHdijM
