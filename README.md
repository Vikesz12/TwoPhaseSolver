# TwoPhaseSolver
Kociemba's algorithm implementation in C#. 

I originaly made for a Mindstorms EV3 cube-solving robot, but it can be used in any situation. Note that I do not have any real experience in coding well, so the code is pretty much a mess without comments. It can still be used very well.

# Info
Solves the rubik's cube using a two-phase algorithm. The code first maps different permuations of the cube as natural numbers. Then, it uses precomputed tables to apply moves to these numbers. The search is IDA*-like with four different prune tables as a heuristic. The code first tries to solve the cube in a position where all edges and corners have an orientation of 0 (phase 1), to then solve it as a whole (phase 2). Prune tables for phase 1 go up to depth 12 (they cover all of it) while phase 2 tables only cover depth 12 out of a maximum of 18. This means that the code will sometimes run very slow when asked to solve for a 20 or sometimes 21 move solution. It works great from 22 to 24 moves.

# Notes
The search class does look like the one in Kociemba's Java implementation. I had problems with the search so I looked up how he did it. I do not claim I invented the entirety of this program.
