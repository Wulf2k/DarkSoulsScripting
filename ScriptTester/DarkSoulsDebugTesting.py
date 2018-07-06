from DarkSoulsScriptingBundle import *
from time import *

print 1

try:
        Game.Options.CameraSpeed = 1
        print(Game.LocalPlayerStats.Name)
        print(Map.MapEntryCount)

        currmap = Map.GetCurrent()

        print(currmap.Area)
        print(currmap.Block)
        print(currmap.GetName())

        print(hex(int(WorldChrMan.LocalPlayer.Address)))


        




except:
        print("failed")

sleep(20)