# Wednesday Lecture Game Dev

## Colliders

### The simplest colliders are primitive collider types. 3D tese are the box colliders, sphere colliders and capsule colliders

Capsule collider is usually used for player collision because it allows smoother sliding motion in an incline

Choose the right collider:

* Mesh collider: Rule of thumb, dont use one if you dont have to. Usualy only used for complex objects

When we talk about collision or colliders, if they are not set with a trigger they are going to stop that object. Trigger in the sense of physics, is a special setup of colliders that give

* Rigid Body: Body that does not deform

* Soft Body: The shape of soft bodies can change, meaning that the relative distance of two points on the object is not fixed

## physic objects

* Static object: Object that does not move, consider that is not moving. For physics engine, object that does not move and will never move

* Kinematic object: moves but without physics. animations, code but not physics. Rigid body and collider

* Dynamic objects: moved with physics, can be moved, pushed by force. Rigid body, collider but kinematic set to false