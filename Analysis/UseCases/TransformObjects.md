# Transform Objects

### Description

The user changes an input value for transforming an object, and the CST updates the rendering of objects within the 3D space.

### Important Considerations

1. Object rendering should update immediately, as input is changed

## Conversations

**Happy Path** - Alt: In View Valid User Input\
**Actor:** User

User Action | System Response
---|---
User enters a valid value in an input field | .
. | CST verifies input is valid
. | CST updates rendering of placed objects to reflect the changed value

--- 
<br>

**Bad Input** - Alt: Invalid Use Input\
**Actor:** User

User Action | System Response
---|---
User enters an invalid value into an input field | .
. | CST checks for valid input
. | CST alerts User of invalid input, does not attempt to update rendering of placed objects

---
<br>

**Out of View Input** - Alt: Off-Screen Placed Objects\
**Actor:** User

User Action | System Response
---|---
User enters input that would translate an object, partially or totally move an object out of bounds | .
. | CST validates input
. | *See below*
Refer to issue 5 in the [Issues List](../IssuesList.md) for more info

---
<br>

**Out of View Object** - Alt: 
---
etc.

