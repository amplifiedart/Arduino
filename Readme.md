# Research for automating animation with a Wemos D1 mini

## Operational Parameters
1. Hardware WEMOS D1 mini with 8 NeoPixel rings consisting of 120 NeoPixels (RGB) LEDs. WS2812. 

## Problem statement
The WEMOS D1 mini has limited memory and the amount of frames we want to store may be large. Possible solution is to use a SD Card on which we can store the needed data (Reading will cost additional code space limiting the memory capacity). 

## Simple implementation
Store the frames in files on the SD card. Place a menu list with possible animations on the SD Card.

### SD Storage structure
/
	Menu.lst		File consisting of the menu item and associated filename
	Filename.anim		Animation file that will be available
	File2.anim		Another animation file.

### Menu.lst format
Filename.anim|Menu Title
File2.anim|Second Menu Item

### Anim File format
Byte Array of 4 x 120 bytes, each group of 4 is build as follows:
[C][R][G][B] Where each byte provides the following:
R	Red component of the Led
G	Green component of the Led
B	Blue component of the Led 
C	Control, allowing commands to be incorporated. Currently to have a limited implementation.

| Command | RGB Implementation | Description |
| --- | --- | --- |
| 00 | RGB | The next pixel will get the RGB assigned color, when beyond the amount of pixels will ignore |
| 01 | Led location | The next led location [0..119] |
| 10 | Frame time | Set the frame time in milliseconds ( 40 = 25fps ) |
| 11 | Frame time | Pause the frame for the given time in ms |
| 20 | Next/End Frame | Will go and start reading the next frame, after the last one will start over as new frame. |

Examples:

| Code | Frame Location | Explanation |
| --- | --- | --- |
| [007F0000] | In Frame | The next pixel is set to Red  |
| [01000040] | In Frame |  Will set the pointer to pixel 64, when the previous pixel was higher, will ignore the jump. |
| [10000028] | Start |  Will set the frame time to 40 ms. |
| [110001F4] | Start |  Will pause the current frame for half a second (500 ms) |
| [20000000] | End |  Will goto the next frame (more date after this command) or will start over when there is no more data. |





