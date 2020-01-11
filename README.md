# LightPad #

# Table of Contents

[Description](#Description)  
<a name="Description"/>

[Planned Features](#Planned_Features)  
<a name="Planned_Features"/>

[What I learnt](#What_I_Learnt)  
<a name="What_I_Learnt"/>

[Constraints](#Constraints)  
<a name="Constraints"/>

[Improvements](#Improvements)  
<a name="Improvements"/>

[Credits](#Credits)  
<a name="Credits"/>

[Screenshots](#Screenshots)
<a name="Screenshots"/>


### Description:

When I created this project it started out as an online challenge to create a simple project that just shows information on the application. 


### Planned Features:
* *Better interfaces*


### What I learnt:

- Better planning using Trello board
- Placing comments in the application
- Using keyboard shotcuts to reduce development time
- Writing cleaner code
- Better understanding of interfaces
- How to use GitHub properly
- How to track GitHub changes
- How to revert back to original changes in GitHub
- Unit Testing to check functions work

### Constraints:

I had some problems where the application wouldn't save and it would crash the application, however I solved this problem. Also another problem was that the application was taking a lot of RAM up when the user would start clicking on the objects.

### Improvements:

I think the interface could be changed and also if the user clicked on the bold icon and decided to click on it again to turn off the feature, it won't let the user. I think this should be fixed as this is a flaw within the application.

### Ad-Hoc Testing

- Tester: Ainsley crawford
- Date: 02/12/19
- Title: Ad hoc testing of the LightPad application revealed the defects described below

1. Ctrl+u has two functions:
	Pressing ctrl+u once performs the undo function. However, pressing ctrl+u a second time without perfroming any other actions then toggles on the underline font type.
	Additionally, ctrl+u can toggle the underline font on, but cannot toggle it off (unless the previous action was to underline a selection of text, in which case the underline is removed because the previous action is undone).
	NB: Ctrl+z properly executes the undo function.

2. The app does not allow different font sizes:
	A uniform font size is maintained, even when a portion of text is highlighted in an attempt to diversify the body of text.
	Interestingly, it is possible to have multiple font colours, which indicates this fault is repairable.

3. Non-functional bold tab in tool bar:
	Although the keybard short-cut ctrl+b functions, the tab does not produce any effect.

________________________________________________________________________________________________________________________________________



### Development Changes

[New Changes]
+ Added confirmation box when user exits the application
* Moved dark mode into the format tab
* Moved the links button into the "Extra" menu
* Renamed light mode into "normal mode"
* Fixed word count not counting words after a new line was created
* Fixed when hovering over the "Font Size" button, it would show the highlighted text as "Font SIze"
* Fixed save not working correctly
* Fixed the quick save not saving
* Fixed the menu having spaces between the options bar
* Changed Icon for quick save
* Changed the colour of dark mode to a darker colour
* Corrected changes in the document
* Corrected changes in the application
- Removed unused file
________________________________________________________________________________________________________________________________________


### Screenshots

![IMG002](https://user-images.githubusercontent.com/45819118/72181775-f63be500-33e1-11ea-9185-25aed9574182.PNG)
I then decided to create the application that allows the project to save, edit and do other things with the application. LightPad allows the user to create documents and store information which they can retrieve later. Documents can be edited at any time.



![IMG001](https://user-images.githubusercontent.com/45819118/72182073-9bef5400-33e2-11ea-846c-379f93856e49.PNG)
With LightPad the user can also set the application to dark mode to restrain the application from damaging their eyes.

![IMG003](https://user-images.githubusercontent.com/45819118/72182075-9bef5400-33e2-11ea-937b-6910e20e46c7.PNG)
User can also revert back to the white background if they don't like to using the black background.

![IMG004](https://user-images.githubusercontent.com/45819118/72182076-9c87ea80-33e2-11ea-9076-a93381336570.PNG)
The user can change the font size, colour and insert the date/time in the document. If the user needs to check how many words they have typed in the document then they can right click and then activate that function.

### Credits
- Gulam Qasim (Author)
- Ainsley Crawford (Tester)
