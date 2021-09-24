# Static Timer Field Issue - IDE0052 making a bad suggestion.
This repo illustrates a problem with a code suggestion in Visual Studio that can change the program behavior in an undesired way.

The code in question results in the following suggestion:

    IDE0052	Private member 'Test._timer' can be removed as the value assigned to it is never read

However, heeding this suggestion results in the timer object getting garbage collected after the first invocation and failing to ever fire again. Ensuring the timer stays running it must be assigned to a static field to avoid becoming garbage collected.

Commenting out the two lines of code associated with the static field will show the difference in behavior.

