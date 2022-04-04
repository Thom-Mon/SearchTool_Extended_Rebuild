# SearchTool_Extended_Rebuild
Rebuild of the search-engine. Search filesystem with size and extension filters.

Download: https://github.com/Thom-Mon/SearchTool_Extended_Rebuild/tree/master/Download-Archive


### Example of main window searching all contents of a folder
![alt text](https://github.com/Thom-Mon/SearchTool_Extended_Rebuild/blob/master/Screenshots/Screenshot_main.JPG)
___

### Example of contextmenue options
![alt text](https://github.com/Thom-Mon/SearchTool_Extended_Rebuild/blob/master/Screenshots/Screenshot_contextmenue.JPG)
* Open in Explorer: Opens the folder the file is found in, and selects it automatically.
* Filter by Extension: Offers you the option to filter by the found files extension. So the result only shows files with the selected extension
* Clear all filters: Resets all the provided filters to show the whole result again (size-Filter is not affected by this)


## Add the SearchTool to the contextmenue on Windows
### -> manually:
1. Store the program where you want to have it saved. I suggest somewhere on the programs-folder.
2. Open the registry on your windows-pc on: 
   Computer\HKEY_CLASSES_ROOT\Directory\Background\shell\
3. Add a folder there with any name like "SearchTool" (or whatever you want, this is what you see on the contextmenue later on)
4. Add a string element with the name "icon" in that folder.
5. Add the path to the .exe to the icon string-element (example):
   "C:\Users\JohnnyDoe\source\repository\SuchFunktion\SuchFunktion\bin\Debug\SearchTool.exe"
6. Add a folder to the folder you created in the registry, name it "command"
7. Within this folder there has to be a string-element, you can use the "Standard" (which comes with a newly created folder).
8. Add the path to your .exe-file like in (5.) and add a "%V  to the end of the path, your string should now look like this:
   "C:\Users\JohnnyDoe\source\repository\SuchFunktion\SuchFunktion\bin\Debug\SearchTool.exe" "%V
9. That´s it! If everything has been done right you should now be able to open the searchtool by right-clicking in a folder.
Note: The folder where you open the search-tool using the context-menue is automatically set as search folder. Neat!
