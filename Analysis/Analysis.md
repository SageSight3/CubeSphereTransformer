# Cube-Sphere Trasnformer Application

Superscripts denote questions and problems documented in the [Issues List](./IssuesList.md).\
Italics denote a word defined in the [Glossary](./Glossary.md).

### Description

The Cube Sphere Transformer should be an application that takes a series of six user inputs: three rotation angles and three translation angles<sup>1</sup>, to calculate and apply *transformations* to a cube<sup>2</sup> in three dimensional space. Optionally, instead<sup>3</sup> of a cube, the application could apply the transofrmations to a set of 10 or more<sup>6</sup> spheres, sized and placed randomly in the 3D space. 

The inputs should be entered through an interactive gui, and both the rendering of the cube and/or spheres should update whenever any of the inputs is changed. Also optionally, projection math could be applied to the appearance of both, based off their distance from the viewer.

### Base Feature Requirements
* Project a 3D space onto a 2D plane<sup>4</sup>
* GUI for entering rotation and translation inputs
* Place an obect or objects into the 3D space
* Apply transformations from user input to *placed objects*
* Initially render placed objects
* Update the rendering of placed objects<sup>5</sup> whenever the user changes any input value
* Users should be able to reset the the 3D space without restarting it<sup>8</sup>

### Optional Feature Requirements
* Generate and place a set of ten or more spheres in the 3D spaces
* Spheres size and position should be random
* Spheres appearance should have something to indicate their orientation
* Have placed objects appearance altered by projection math depending on their distance from the viewer

### [System Context](./SystemContext.temp)

### [Use Cases](UseCases.md)

### [Issues List](./IssuesList.md)

### [Glossary](./Glossary.md)