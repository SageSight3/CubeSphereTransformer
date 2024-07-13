# Issues List

Num | Category | Priority | Issue | Status
---|---|---|---|---
1 | User Input | High | Are the translation input meant to be angles or offsets? | closed
2 | Features | Medium |  Is the cube's size arbitrary, and should it be able to be constant or *dynamic*? Should its size be chosen by the user, randomly generated, etc.? | open<sup>1</sup>
3 | Features | Low | If implementing the optional features outlined in the application request, should the original functionality of the program (the cube transformer) be preserved? | open<sup>2</sup>
4 | Implementation | High | Should this application be built from the ground up, or would it preferred if a preexisting 3D graphics engine, like Unity or Unreal, were used instead, since they've already been optimized for these kinds of purposes? | closed
5 | Rendering | Medium | What should the application do, if an entered transformation would translate a placed object outside the FOV of the viewer? | open
6 | Features | Medium | Is the number of spheres generated after 10 fixed or dynamic, and if it's dynamic, should the number of them be controlled by the user, randomly generated, or something else? | open
7 | Features | Low | Should the application give users the ability to select and delete individual 3D objects? | open
8 | Features | Medium | For use cases where placed objects have dynamic starting values for their *attributes*, when the 3D space is reset, should it be that new objects are generated, that the application just returns the current placed objects to their original positions and orientations, or should the user be provided with the option to do either or? | open
9 | User Input | Medium | Input values should be saved when switching between translation and rotation | open
10 | User Input | High | UI should update to show relevant information to selected translation types | open

## Notes

1. If no preference is provided, base functionality should operate on a constant arbitrarily sized cube, with reach goals providing users the option to choose the cube's size for themselves, or have it be randomly generated.

2. If not specified. Original app function should be preserved.

