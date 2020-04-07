All Star Watersports Image Viewer
=================================
A simple Windows Forms application for viewing and converting MIB (.mib) files found in the PS1 game All Star Watersports (Europe). Also includes functionality to extract PAK (.pak) files that are found in the game's files, which often include MIB files.
Mainly intended to be a personal challenge to learn WinForms and how to integrate it with basic function management.
Uses a snippet of code from [Barubary's TiledGGD](https://github.com/Barubary/tiledggd) to process image palette colours.

Formats
-------
### MIB (.mib, .cmb)
MIB files are used for both textures and palettes.
MIB textures (.mib) can be either 8bpp or 16bpp, with the former relying on a colour palette MIB (.cmb).
Colour palette MIBs are functionally the same as a MIB texture, being a 16bpp image with a height of 1px and the width being representative of how many colours there are.
The MIB file format is as follows:
```
char {4}        Magic ID/Header ("MIB\0")
uint32 {4}      Bits per pixel (Either 0x8 or 0x10)
uint16 {2}      Width in pixels
uint16 {2}      Height in pixels
char {16}       Palette MIB name (If 8bpp, null terminated without ".cmb" extension; If 16bpp, all null)
byte {x}        Image data
```

### PAK (.pak)
PAK files are non-compressed package files used to bundle a number of other files.
The PAK file format is as follows:
```
char {4}        Magic ID/Header ("PAK\0")
uint32 {4}      Number of file entries
// For each entry
    char {32}   File name
    uint32 {4}  File length
    uint32 {4}  File offset in PAK
byte {x}        Packed file data
```