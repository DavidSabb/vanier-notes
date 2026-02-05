# Week 3 - Game Programming 02 Notes

## Wednesday Lecture - Rotation

* ### Euler Angles

(10, 0, 0) - (x, y, z)

When dealing with euler angles you might have issues with gimbal lock

if rotate x by 90, your object will be aligned with the other axis

Gimbal lock: when you lose an axis of rotation

### Quaternion: for rotation, is a structure that allows you to avoid gimbal locks

Use empty parents as "pivots" to rotate objects like doors.