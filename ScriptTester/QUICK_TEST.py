from DarkSoulsScriptingBundle import *

UPDATE_RATE = 60.0

ChrDbg.PlayerHide = True

gp = Gamepad.PS3()

CodeHooks.TargetedChrPtrRecorder.PatchCode()

playingAs = None

def SwapWithChr(c):
    global playingAs

    if playingAs != None:
        playingAs.ReturnControlPlayer()
        #swapTeam = playingAs.TeamType
        playingAs.TeamType = c.TeamType

    
    WorldChrMan.LocalPlayer.SlotPtr = c.SlotPtr
    f.SetDisableGravity(10000, True)
    f.Unmapped.SetColiEnable(10000, False)
    f.SetDrawEnable(10000, False)
    c.DrawGroup1 = -1
    c.DrawGroup2 = -1
    c.DrawGroup3 = -1
    c.DrawGroup4 = -1
    c.SwitchControlPlayer()

    f.SetDisable(c.ID, False)
    f.EnableAction(c.ID, True)
    f.EnableLogic(c.ID, True)
    f.ChrDisableUpdate(c.ID, False)

    c.TeamType = WorldChrMan.LocalPlayer.TeamType
    c.View()

    playingAs = c

def UpdateLoop():

    global playingAs

    justLoaded = False

    while Utils.IsGameLoading():
        justLoaded = True
        ex.Wait(66)

    if justLoaded:
        ex.Wait(2000)
        playingAs = None

    gp.Read()

    if gp.L3 and (not gp.PrevL3):
        f.ForcePlayAnimation(10000, -1)
        if playingAs == None:
            targetPtr = CodeHooks.TargetedChrPtrRecorder.RecordedValue
            if targetPtr > Hook.DARKSOULS.SafeBaseMemoryOffset:
                target = Enemy.FromPtr(targetPtr)
                SwapWithChr(target)
                f.EnableLogic(10000, False)
        else:
            WorldChrMan.LocalPlayer.WarpToEnemy(playingAs)
            playingAs.ReturnControlPlayer()
            playingAs = None
            WorldChrMan.LocalPlayer.MovementCtrl.AnimationSpeed = 1
            WorldChrMan.LocalPlayer.DisableDrawingA = False
            f.EnableLogic(10000, True)


    if playingAs != None:
        WorldChrMan.LocalPlayer.WarpToEnemy(playingAs)
        WorldChrMan.LocalPlayer.MovementCtrl.AnimationSpeed = 0

ticks = Utils.GetTickSpanFromHz(UPDATE_RATE)
playingAs = None
while True:
    Utils.FixedTimestep(UpdateLoop, ticks)