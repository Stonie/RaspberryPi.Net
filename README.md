RaspberryPi.Net
===============

Raspberry PI .NET library

Quick Start:

Grab the latest Debian (“Raspbian”) image:
http://www.raspberrypi.org/downloads

Flash the image to your SD Card, boot it.
On the command line, install the mono runtime:

```bash
# apt-get update 
# apt-get install mono-runtime
```
Clone this repo (or upstream)... build and compile with VS.net or Mono Develop locally on a dev desktop.
NOTE: Mono Develop runs too slowly on the RPi!

Once you have built locally, copy your executables from /bin/ to your RPi (try sftp with filezilla - or install Samba)

Then back on the command-line on the RPi:

# mono yourexecutable.exe

Have fun. 