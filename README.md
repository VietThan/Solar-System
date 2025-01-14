# Solar System Simulation

<p align="left">
	<img src="https://img.shields.io/badge/platform-Unity 2019.2.6f1-blueviolet?style=for-the-badge"
			 alt="platform">
	<img src="https://img.shields.io/badge/OS-Windows-0078d7?style=for-the-badge"
			 alt="platform">
	<img src="https://img.shields.io/badge/OS-Mac-red?style=for-the-badge"
			 alt="platform">
	<img src="https://img.shields.io/badge/language-Csharp-brightgreen?style=for-the-badge"
			 alt="language">
	<img src="https://img.shields.io/badge/VR-Oculus Rift 1.43-important?style=for-the-badge"
			 alt="vr">
</p>

Table of Contents
=================

   * [Solar System Simulation](#solar-system-simulation)
      * [About This Game](#about-this-game)
      * [Game Controls](#game-controls)
         * [Right Controller:](#right-controller)
         * [Left Controller:](#left-controller)
         * [Dashboard Capabilities:](#dashboard-capabilities)
         * [Back Monitors](#back-monitors)
         * [Troubleshooting and FAQ](#troubleshooting-and-faq)
      * [Information for Particular Project Aspects](#information-for-particular-project-aspects)
         * [Starry Sky Creation](#starry-sky-creation)
         * [Audio](#audio)
      * [Sources, Assets and Relevant Links](#sources-assets-and-relevant-links)
         * [Trello](#trello)
         * [Data/Information Resources](#datainformation-resources)
         * [Unity Assets](#unity-assets)
         * [External Models](#external-models)
      * [Author and Acknowledgements](#author-and-acknowledgements)



## About This Game

<p align="center"><p align="center"><img src="ezgif.com-video-to-gif.gif" width=700></p>
<p align="center"><p align="center"><img src="travel-demo.gif" width=700></p>

This game is a simulation of the Milky Way solar system. Our goal was to create a simulation that focused on the sheer size of the solar system and the time that it would take to travel the distances between planets. While limiting the player to realistic speed would not be an enjoyable experience, we attempted to emphasize the experience of time and distance by keeping a realistic distance, allowing the speed to be extremely unrealistic, and using time to warp the user's experience. The user starts at the sun and is able to pilot their spaceship between Mercury, Venus, Earth, Mars, Jupiter, Saturn, Uranus, Neptune, and Pluto.


## Game Controls
### Right Controller: 

Thumbstick Up: Accelerate Ship 

Thumbstick Down: Decelerate Ship 

Press A: Reset speed to 1 m/s

Press B: Revert to Original Speed

Point index finger to activate/deactivate objects on mini map

### Left Controller: 
Thumbstick Up: Move Ship Forward 

Thumbstick Down: Move Ship Backwards 

Thumbstick Left: Rotate Ship Left

Thumbstick Right: Rotate Ship Right

Point index finger to activate/deactivate objects on mini map

### Dashboard Capabilities: 
**Left Side Dashboard- 3D Mini Map:**
<p>
    <img src="Screenshot (2).png" width="800" height="500" />
</p>
<p>
    <img src="Screenshot (3).png" width="800" height="500" />
</p>

Map shows the current positions of the planets and spaceship in the solar system.

Highlight a planet using your index finger to point and touch the planet on the planet tracker/mini map. Touch the planet again to deactivate the planet tracker. Highlighting a planet on the planet tracker causes a position marker to appear above the actual planet outside the ship, along with planet name, current distance from planet, and estimate time of arrival to planet at current speed.  Multiple trackers can be activated at a time. 

**Center of Dashboard- Planet Proximity and Information:**
<p>
    <img src="Screenshot (5).png" width="800" height="500" />
</p>

Display warns if a planet is in close proximity and the information related to the respective planet. The type of information displayed is the planet's average distance from the sun, radius, number of moons and/or rings, as well as type of planet (i.e. Terrestrial, Gas Giant, Ice Giant)


**Right of Dashboard-Speed:**
<p>
    <img src="Screenshot (4).png" width="800" height="500" />
</p>

Display shows current speed in meters per second and in multiples of the speed of light. 

### Back Monitors
<p>
    <img src="Screenshot (6).png" width="800" height="500" />
</p>

Behind the player is a set of computer monitors that display the instructions of the game for the player to reference during the game.


### Troubleshooting and FAQ
**Planets aren't highlighting on mimi map when I touch them**

Make sure that the hand being used to touch the planets has the index finger extended in a pointing gesture. To do this, make sure your index finger is not touching physically touching the Oculus controller.

**I keep moving past the planets without seeing them**

It is most likely that you are moving too quickly. To slow down, press the A button on the right controller to reset your speed to zero, and slowly increase your speed from there.

**How do I see what planet I am selecting on the mini map?/ Where is the planet I selected?**

If you are having trouble finding the planet marker for the planet you selected, physically rotate yourself to look around the ship. The planet may appear anywhere 360 degrees around the spaceship. The marker will tell you which planet(s) is selected.

**Where am I?**

If you look at the mini map, there is a small red cone. This represents your current position in the solar system.

**Why is baby Yoda here?**

Because why not. He's cute.
<p>
    <img src="Screenshot (7).png" width="800" height="500" />
</p>

**General Gameplay Tips?**

- You can move the ship with the left controller and change speed with right controller at the same time.
- Slow down as you approach a planet



## Information for Particular Project Aspects
### Starry Sky Creation
Created By: Viet Than

The only <a href="https://thomaskole.wordpress.com/portfolio/how-to-generate-a-physically-accurate-star-field-in-unity-using-real-world-data/">guide</a> is outdated so Viet is trying to recreate that with the newer version of Unity.

Read guide and progress log here: <a href="StarrySkyCreation.md">Starry Sky Creation: Working with Unity3D Particle Effect System</a>

### Audio
Planet Sounds: The planet sounds are created from converting the radio frequencies gathered from satellites near planets into audio.

<a href="https://www.youtube.com/watch?v=GvMbUxqGuOc"> Sun Audio</a>

<a href="https://www.youtube.com/watch?v=894Aejo-R0U"> Mercury Audio </a>

<a href="https://www.youtube.com/watch?v=-ewPtH31Xr8"> Venus Audio</a>

<a href="https://www.youtube.com/watch?v=NhAXIjJ56xE"> Earth Audio</a>

<a href="https://www.youtube.com/watch?v=PseSJoicfrg"> Mars Audio</a>

<a href="https://www.youtube.com/watch?v=e3fqE01YYWs"> Jupiter Audio</a>

<a href="https://www.youtube.com/watch?v=X_JAvVjKeWI"> Saturn Audio</a>

<a href="https://www.youtube.com/watch?v=F8JMFVK-LjA"> Uranus Audio</a>

<a href="https://www.youtube.com/watch?v=rwnpXll_A_E"> Neptune Audio</a>

<a href="https://www.youtube.com/watch?v=4xpR4hyPSlE"> Pluto Audio</a>

Ship Background Music: Blue Danube Waltz by Dieter Goldmann Strings


## Sources, Assets and Relevant Links
### Trello
To access our Trello board: <a href="https://trello.com/invite/b/dn2gKOlD/d1af0289d0a9df8f983986a54db01d8b/solar-system-simulation">Link</a>

### Data/Information Resources 
<a href="https://solarsystem.nasa.gov/planets/overview/"> Planet Information 
	
### Unity Assets
<a href="https://assetstore.unity.com/packages/3d/environments/sci-fi/solar-system-24810"> Solar System Assets V3.0</a>: Planet prefabs with textures

<a href="https://assetstore.unity.com/packages/3d/environments/sci-fi/sci-fi-styled-modular-pack-82913">Sci-Fi Styled Modular Pack V1.0</a>: Projector Prefab and Hologram Material



### External Models 
Spaceship Model created by Quinton Hoffman

<a href="https://www.thingiverse.com/thing:4001171">Smile Baby Yoda</a> created by Multiverse3DDesigns

## Author and Acknowledgements
Student Group: Quinton Hoffman, Adrian Florea, Dayana Espinoza, Malia Latimer, and Viet Than

Client: David Weintraub (Prof. Department of Physics and Astronomy)

Class instructor: Ole Molvig (Prof. Department of History) and Bobby Bodenheimer (Prof. Department of EECS), Vanderbilt University, US.



