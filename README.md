### 1. Install Python support in Visual Studio 2017
* Run the Visual Studio Installer (Quick way to get to it is under "Programs and Features" right click on Microsoft Visual Studio 2017 and click "Change"
* Click "Modify"
* Switch to the "Individual Components" tab
* Check the box next to "Python language support"
  * Note: You do not need to install Python 2 or 3 runtime since you'll be using the IronPython runtime instead
### 2. Install IronPython
* Download and run the .msi installer for IronPython and follow the directions (make sure Visual Studio is closed): https://github.com/IronLanguages/main/releases/tag/ipy-2.7.7
### 3. Running the included test project
* Download the [latest development release of DarkSoulsScripting](https://github.com/Wulf2k/DarkSoulsScripting/releases)
* Open the solution in Visual Studio 2017
* Install the Module initializer package (basically lets DarkSoulsScripting initialize itself for you, also required to build correctly):
  * Open the **Package Manager Console** (*View -> Other Windows -> Package Manager Console*)
  * On the top of the package manager console is a dropdown list labeled "Default project:". Make sure this is set to DarkSoulsScripting
  * Paste this in and hit Enter: `Install-Package InjectModuleInitializer -Version 1.5.0`
* Once it's done, press the *F6 key* and see if it builds
* Under the **ScriptTester** project double-click on the ScriptTester.py file: 

    ![Image of the solution explorer view](https://i.imgur.com/FbZtMjy.png)
  * **Important**: Look at the import statements at the top of the python script. If they have squiggly error lines under them, try restarting Visual Studio (it may need to refresh now that you've built the project).
* Make sure the latest Steam version of Dark Souls: Prepare to Die Edition is running.
* Load a save of your choosing. ***Note: Saving is automatically disabled for the rest of the play session upon running ANY script. This will allow you to test things without overwriting your save (unless you manually call 'SetSaveEnable` in your script, of course)***
* Press F5 to build the test script and immediately kill your player.
  * Note: If you get an error along the lines of "A library project cannot be executed directly", then simply right-click on the *ScriptTester* project and choose "Set as StartUp Project" and then press F5
