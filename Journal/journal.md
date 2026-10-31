PROTOTYPE 1

Sept 18 - Sept 22

My original Idea was to create a version of pong where the paddles were locked on the x axis, but the rotation was unlocked which would let the player "spin" the paddle and see how the ball would interact with that.

I tried to make the game using the downloaded prefabs, without copying the scene, but that became too hard for me to keep up with so I restarted the whole project.

 Sept 22

When I turned off the z rotation constraint, the ball would just plow through the paddle, so I increased the mass of the paddle, which made it feel sluggish, but at least the ball can bounce off of it. 

To fix the sluggish feeling, I turned up the linear damping to 100 and increased the paddle speed to 500.

Some ideas I have now 

- let the player spin with a and d keys
- penalize the last player who touched the ball if the ball reaches a certain low speed.


Used this video to help with rotation. https://youtu.be/2NOX7xZIw-Q

used that video to help get the ball at a certain speed that increases as well.

the problem of the ball being too vertical still remains.

I really cant fix it on my own so im going to try to lean into it?

maybe the ceiling and floor can have some sort of force that launches the ball towards the other direction or something idk.

Sept 23

After sleeping on it, I think the idea of adding areas that can lauch the ball to the floor and ceiling is a good idea. Hopefully I can figure out how to code that.

Using unity's guides and the vscode suggestions (idk if thats allowed lol) I made a boost pad-like object that launches the ball to the direction of the side of the pad it hits. this adds a balance of randomness but also skill, and I like it better than my original idea.

whats next is to clean up the game and either take away the cpu and add another player or remove the rotation on the paddles so its more balanced.

Spet 27

all the basic game mechanics are fixed and the core game runs smoothly. whats next is to give the game a makeover and make it look better. I can do this by finding a theme or add to the interface.

Sept 29

added some simple arrows to help the player.

overall im happy with how the prototype turned out, I tried not to make it too overwhelmed with new mechanics because I have a history of adding too many things and making the game unplayable. 
I like how my game now has a much steeper skill curve while still being very playable!

**Prototype 2**

oct 5:

I started by brainstorming which games I like that I could take inspiration from.
I am having a hard time coming up with combinations.
I think I need to think simpler.

oct 8 

I was looking through my embarrassingly giant game library trying to think of games that would mesh well with the provided templates and one game really stood out to me. Superhot. I was thinking of using the time mechanics and putting it inside flappy bird.

oct 10

after looking at the code for flappy bird, i couldnt figure out a reasonable way to do the superhot time slow, so I came up with a different game instead. my new idea is to get inspiration from the fromsoft games like sekiro and add it to brick breaker. my initial idea is to add a parry timer countdown when a button is presses and if the ball hits the paddle within that timer then the ball gets parried, and if not then the player takes damage.

oct 11

I made the basic parry system, but it was very hard to make work with a healthbar. I was able to figure it out after watching this tutorial: https://youtu.be/BLfNP4Sc_iA
with the damage system now working, I feel like I have an actual game. The problem now is Whats next? how can I make the game feel more like sekiro?. I think I can start by either making a "boss" health bar that just displays the number of bricks left, or I can make something happen when the player dies, because now it just restarts.

I know I also want to add visual cues so that the player knows if they parried

oct 12

today I added a lot. to start I added visual cues for the player so they know if they parried or take damage. then I added a health system for the level that is very similar to sekiro... basically when the player parries a bunch, a bar fills up and if they fill up the bar enough they defeat the level. if the player gets hit or takes damage, the parry bar loses points. there is two ways to beat the game like in sekiro, break all the blocks or parry your way to victory.

now that I have a game that I can say takes inspiraton from sekiro, I wonder what I can do to further make the game like sekiro or just more fun in general.

I still need to add everything to the second level and make everything look nicer. I also maybe want to add words as another visual cue when players parry or get hit.

oct 15

after thinking of some more ideas to make the game more sekiro-like, I came up with a couple of ideas.
first, a big part of sekiro is the ressurection that happens when you die. I feel like i could make ths pretty easily ... also there is unparryable attacks which i can try to implement, but the the game you can dodge and you cant exactly do that in brick breaker, so I was thinking of adding another key that you have to press at random times to dodge.

oct 19
I ended up opting for the resurrection path and found a way to revive the player at half health when dead. The game felt unresponsive so I added some text to show the player when you resurrect. I used this as help:
https://discussions.unity.com/t/gradually-changing-canvas-alpha/690667

I wanted to do the same thing to add a death screen however I had a hard time figuring out how to not immediately restart the game upon death. I figured it out by adding a timer and importantly stopping the ball from appearing so the game doesn't continue after death. 

I also added all my modifications to the second level.

I think I am finished for now, but If I had more time there are still modifications I would make. 

As of right now I feel like the game still lacks long-term playability... the game just stops after both levels are done, this makes the game not very replayable.

in the future I think It would be fun to add more levels and make them more unique to make the game feel more like you are fighting a boss rather than progressing levels.

oct 20

I ended up doing a bit more cause I felt the game was still lacking just a bit more of the sekiro theme so i changed the paddle sprite into a katana I drew. something i didnt think of was if the colour changing aspect would still work once I changed the sprite... by some miracle it did and it looks super cool. Now I am really done I think!


**Prototype 3**

The Idea for this one came from another class where I had made a speaker model in blender.

that along with the noise my keyboard makes inspired me to make a soundscape of my desk. what i mean by this is I noticed the only sound in my room is my keyboard which is loud not because its a loud keyboard, but rather because the rest of my setup is very quiet.

I thought it would be cool to record the sounds that my actual mouse and keyboard make to make it feel more personal.

I found it interesting that since my mouse is silent, the only thing that realy makes noise is my keyboard, so I made that the center of attention. 

the desk feels a bit empty still and I want to add different footsteps

oct 30

I followed this tutorial: https://youtu.be/r1dgRE0GM9A to help me implement different footstep sounds depending on the material the player is on. I did this because the game felt a bit empty still because of the lack of objects. making the mousepad a different sound was a way of trying to make the game feel more full while still keeping the aesthetics not cluttered.

earlier i said I wanted to make the keyboard the center of attention so I adjusted the volumes of everything to make that item stick out more and I fixed a problem I was having where the sounds were too low... turns out my speakers were just too loud while i was making the game.

the game still feels a bit short as theres not much to explore, but its a good early prototype for a game where you explore the passive sounds that are usually ignored.