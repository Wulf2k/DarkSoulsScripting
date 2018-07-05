from DarkSoulsScriptingBundle import *
from time import *

print 1

try:
        Game.Options.CameraSpeed = 1
        print(Game.LocalPlayerStats.Name)
        print(hex(int(Game.LocalPlayerStats.Address)))

except:
        print("failed")

sleep(20)