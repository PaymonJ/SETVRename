# SETVRename
Renames TV show files to Season/Episode format.

## Preface

This application was created to assist [theRenamer](http://www.therenamer.com) in archiving TV shows from DVD and Blu-Ray by renaming the files to the required input format.

The required file naming format for theRenamer:

```
Show/
    Season 1/
        S01E01.mp4
        S01E02.mp4
        S01E03.mp4
        S01E04.mp4
        S01E05.mp4
        S01E06.mp4
        S01E07.mp4
        S01E08.mp4
```

File naming format from DVDs:

```
Show/
    Season 1/
        title00.mp4
        title01.mp4
        title02.mp4
        title03.mp4
        title04.mp4
        title05.mp4
        title06.mp4
        title07.mp4
```

This application helps the user to convert the file names from DVD's naming format to the naming format required by the Renamer.

## Installation

1. Ensure you have the proper .NET redistributables installed on your PC
2. download this repository to desired folder


## Usage

1. Place your video files in order within a folder titled `Season X` (*X* being the season that this group of episodes belong to).
2. Run `SETVRename.exe "/path/to/Season X"`
  * The program then renames all the files in `/path/to/Season X` to `SXEY`, where `X` is the season number in the containing folder name, and `Y` is the files's position in sorted alphabetical order within the folder.

