# _Anagram_

#### _C# console application for bakery , Feb 28 2020_

#### By _** Alyssa Colistro & Fatma C. Dogan**_

## Description

Console application where a user can input a single word and a list of other words that may be anagrams.

## Project Specifications

| Behavior | Input | Output |
|---|:---:|:---:|
|User input a word | bread | "bread" |
|User inputs series of words | beard, bed, cat, dog |  "beard, bed, cat, dog"|
|Program converts each of list item to character array |  "beard, bed, cat, dog" | ["b","e","a","r","d"], ...etc |
|Program converts main word to character array | "bread" | ["b","e","a","r","d"]|
|Program sorts characters in alphabetical order | ["b","e","a","r","d"] | ["a","b","d","e","r"] |
|Program converts character arrays to strings | ["a","b","d","e","r"] | "abder" |
|Program compares main word with each words in the list and returns anagram words | "abder" |  "beard" |




## Setup/Installation Requirements

_In Terminal:_

* Navigate to where you want this application to be saved, i.e.:
```cd desktop```
* Clone the file from GitHub with HTTPS
```git clone https://github.com/fc-dogan/Pierre-s-Bakery.git ```
* Open file in your preferred text editor
* On Mac: ```open -a {your text editor} ```
* On Windows: ```Pierre-s-Bakery```

_Download Manually:_

* Navigate to https://github.com/fc-dogan/Pierre-s-Bakery.git.
* Click the green "Clone or Download" button.
* Click "Download ZIP".
* Click downloaded file to unzip.
* Open folder called "Pierre-s-Bakery".


_Note For Editors:_ 
* Download the .NET Core SDK [Software Development Kit](https://dotnet.microsoft.com/download)
* Open the .Net Core SDK file and install
* To confirm installation was successful, run the ```$ dotnet --version``` command in your terminal

* Install dotnet script, run the ```$ dotnet tool install -g dotnet-script``` command in your terminal
* Restart your terminal to complete installation, and run the ```$ dotnet run``` command to run application within your terminal - Note: To exit, simply press ```Ctrl + C```
## Known Bugs

_No known bugs at this time._


## Technologies Used

* C#
* .Net Core