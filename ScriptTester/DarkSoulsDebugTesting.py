from DarkSoulsScriptingBundle import *
from time import *

print 1

try:
        currmap = Map.GetCurrent()

        print(currmap.Area)
        print(currmap.Block)
        print(currmap.GetName())

        WorldChrMan.LocalPlayer.MovementCtrl.AnimationSpeed = 1.0
        
        print(WorldChrMan.LocalPlayer.MovementCtrl.Transform.X)
        print(WorldChrMan.LocalPlayer.MovementCtrl.Transform.Y)
        print(WorldChrMan.LocalPlayer.MovementCtrl.Transform.Z)


        print(hex(int(currmap.StartOfChrStruct)))
        nmes = currmap.GetChrsAsEnemies()
        nme = nmes[27]

        print(hex(int(nme.UnknownMSBStructPointer)))
        print(nme.UnknownMSBStructIndex)
        print(nme.ModelName)

        WorldChrMan.LocalPlayer.WarpToEnemy(nme)

        nme.SwitchControlPlayer()


        



        




except:
        print("failed")

sleep(10)