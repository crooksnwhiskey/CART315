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