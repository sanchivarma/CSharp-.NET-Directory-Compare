------------------------
DIRECTORY COMPARER v1.0
------------------------
Technology : C#.NET

Introduction
>> The following application inputs 2 directory path from user and displays the comparison between the two folder structures.

Walkthrough

### WINDOWS ###

1) Main Window  [Screeenshots Folder/1.png]
>> Run the application. 
   (Either using Visual Studio (>= VS2015)
    or DirectoryComparer\bin\Release\Directory Comparer.exe)

>> A screen will popup
   - Choose path for Folder 1 and 2 for comparison
   - Check the Recursive option, if complete all-depth level structure of both folders is to be compared.
   - Uncheck the Recursive option if files of only Top Root Directory path are required to be compared
>> Click "Start"to trigger the comparison
>> The progress bar will display the progress of comparison.
>> Once comparison is complete, a window will open displaying the result.

2) Results Window

# TABS 
  I) "Directory View" Tab [Screeenshots Folder/2.png]
     >> Default 1st Tab : "Directory View" is displayed.
     >> This tab displays expandable/collapsible ditecory structure view (default expanded)

  II) "Directory Compare Results" Tab [Screeenshots Folder/3.png]
     >> Click on this tab to view the complete comparison results.
     >> It displays a comparison table with fields :
        * Serial No. => Incrementing Index (Displays folder Icon for folders)
        * File/Folder Name => Current file/folder name under comparison
        * Left Folder => Left/1st Folder path for that file/folder (if exists)
        * Right Folder => Right/2nd Folder path for that file/folder (if exists)
        * Match Status => Status displaying if file present in Left Folder only, Right Folder Only or both.

  III) "Directory Sync Output" Tab [Screeenshots Folder/4.png]
     >> Click on this tab to view the steps to be followed to Synchronize Folder2 (Right Folder) structure with Folder1 (Left folder).
     >> It displays a table for the steps :
        * ID => Incrementing Index
        * Name => Current file/folder name under synchronization step
        * Type => File/Folder
        * Path => File/Folder path
        * Action => Action to be performed to being right folder in sync with left folder.

3) Preferences Window [Screeenshots Folder/5.png]
>> This window can be reached by clicking : File -> Preferences in the results window
>> This allows to set :
   * Default left and right directory paths
   * Additional columns with file/folder details if desired.

4) About [Screeenshots Folder/6.png]
>> Basic about-text

### TOOLBAR ###

1) FILE [Screeenshots Folder/toolbar_FILE.png]
  * Compare Folders >> To go back to main window
  * Preferences >> Open preferences window
  * Save Results
    >> As XML => To save the comparison results in XML Format
    >> As CSV => To save the comparison results in CSV Format
       [PS : CHange the column format to Date when opening in Excel]
  * Exit >> Exit the application

2) VIEW [Screeenshots Folder/toolbar_VIEW.png]
  * Both Results >> View comparison for files and folders for both directories(left and right)
  * Left Side Only >> View comparison for files and folders for left folder only
  * Right Side Only >> View comparison for files and folders for right folder only

3) FILTER [Screeenshots Folder/toolbar_FILTER.png]
  * Show All >> Show all comparison results
  * Show Matches Only >> Show Files/Folders with matching structure comparing both folders
  * Show Mismatches Only >> Show Files/Folders with that do not match in structure comparing both folders
  * Show Left Files Only >> View comparison for files and folders for left folder only
  * Show Right Files Only >> View comparison for files and folders for right folder only

4) HELP  [Screeenshots Folder/toolbar_HELP.png]
  * About >> Displays About Window with basic application version and developer details

