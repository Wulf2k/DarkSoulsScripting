from DarkSoulsScriptingBundle import *
from time import *

print 1

try:
        currmap = Map.GetCurrent()

        print(currmap.Area)
        print(currmap.Block)
        print(currmap.GetName())

        WorldChrMan.LocalPlayer.MovementCtrl.AnimationSpeed = 1.0
        
        print("Chardata1: ", hex(int(WorldChrMan.LocalPlayer.Address)))

        print(WorldChrMan.LocalPlayer.MovementCtrl.Transform.X)
        print(WorldChrMan.LocalPlayer.MovementCtrl.Transform.Y)
        print(WorldChrMan.LocalPlayer.MovementCtrl.Transform.Z)

        #print(currmap.GetChrsAsEnemies()[2].TalkID)


        #print(hex(int(currmap.StartOfChrStruct)))
        nmes = currmap.GetChrsAsEnemies()
        nme = nmes[26]

        #print(hex(int(nme.UnknownMSBStructPointer)))
        #print(nme.UnknownMSBStructIndex)
        print(nme.ModelName)

        f.EnableHide(10000, 1)
        print hex(nme.Handle)
        #WorldChrMan.LocalPlayer.WarpToEnemy(nme)

        #print WorldChrMan.LocalPlayer.Handle
        

        #WorldChrMan.LocalPlayer.WarpToEnemy(nme)
        

        print hex(WorldChrMan.LocalPlayer.TargetHandle)

        target = WorldChrMan.LocalPlayer.GetTargetAsEnemy()

        print hex(target.Handle)






except:
        print("failed")

sleep(10)