from DarkSoulsScriptingBundle import *
import System
import random

UPDATE_RATE = 60.0
updateLoopCount = 0

def SwapChrPointers(map, chrList, c, ch):

    if c.ModelName == "c1000":
        return

    randChrHeader = ch
    randChr = c
    while randChrHeader.ChrPtr == c.Address or randChr.ModelName == "c1000":
        randChrHeader = chrList[random.randint(0, chrList.Count - 1)]
        randChr = randChrHeader.GetChr()

    swapPtr = randChrHeader.ChrPtr

    randChrHeader.ChrPtr = ch.ChrPtr

    ch.ChrPtr = swapPtr

def SwapChrPointerWithPlayerPtr(map, chrList, c, ch):

    if c.ModelName == "c1000":
        return

    #swapPtr = Chr.Player.Header.ChrPtr

    Chr.Player.Header.ChrPtr = ch.ChrPtr

    #ch.ChrPtr = swapPtr

def DoStuffToChr(map, chrList, c, ch):

    # SwapChrPointers(map, chrList, c, ch)
    SwapChrPointerWithPlayerPtr(map, chrList, c, ch)

def ARTORIAS_TEST():
    artorias = Chr.FromName("m12_01_00_00", "c4100_0000")
    artorias.WarpToChr(Chr.Player)
    Chr.Player.HeaderPtr = artorias.HeaderPtr
    artorias.DebugControllerPtr = Chr.Player.Nav.ControllerPtr
    artorias.View()
    artorias.Nav.EnableLogic = True


def UpdateLoop():
    Utils.WaitForLoadingScreenEnd()

    entityCount = 0
    entityUpdateCount = 0

    block = f.GetCurrentMapBlockNo()
    area = f.GetCurrentMapAreaNo()

    mapEntries = Map.GetEntries()
    for m in range(0, mapEntries.Count):
        # print "Map " + str(m)

        ###########################################

        if mapEntries[m].Area != area or mapEntries[m].Block != block:
            continue

        ###########################################

        chrs = mapEntries[m].GetChrHeaders()
        for c in range(0, chrs.Count):
            entityCount += 1
            if chrs[c].IsDisable:
                continue
            actualChr = chrs[c].GetChr()
            if actualChr is None:
                continue
            elif actualChr.NavPtr < Hook.DARKSOULS.SafeBaseMemoryOffset:
                continue
            elif actualChr.DisableEventBackreadState:
                continue
            
            DoStuffToChr(mapEntries, chrs, actualChr, chrs[c])

            entityUpdateCount += 1


    global updateLoopCount
    updateLoopCount += 1
    ex.SetLineHelpTextPos(0,0)
    ex.SetLineHelpText(System.String.Format("[m{0:D2}_{1:D2}_00_00][{2:D8}/{3:D8}][{4:D8}]", area, block, entityUpdateCount, entityCount, updateLoopCount))


randChr = Chr.Player

def SWAP_RANDOM_ENTITY():

    global randChr

    block = f.GetCurrentMapBlockNo()
    area = f.GetCurrentMapAreaNo()

    mapEntries = Map.GetEntries()
    for m in range(0, mapEntries.Count):

        if mapEntries[m].Area != area or mapEntries[m].Block != block:
            continue

        chrs = mapEntries[m].GetChrHeaders()

        randHeaderIndex = -1
        randHeader = Chr.Player.Header
        randChr = Chr.Player

        while randHeaderIndex == -1:
            randHeaderIndex = random.randint(0, chrs.Count - 1)
            randHeader = chrs[randHeaderIndex]

            if randHeader.DeadFlag or randHeader.IsDisable or randHeader.IsHide:
                randHeaderIndex = -1
                continue
            else:
                randChr = randHeader.GetChr()
                if randChr.ID <= 0 or randChr.NoUpdate or randChr.DisableEventBackreadState or randChr.DisableDrawingA or randChr.DisableDrawingB or (not randChr.Nav.EnableLogic):
                    randHeaderIndex = -1
                    continue

        if randHeaderIndex < 0:
            return

        randHeader = chrs[randHeaderIndex]
        randChr = randHeader.GetChr()

        
        f.SetDisableGravity(10000, True)
        f.Unmapped.SetColiEnable(10000, False)
        f.SetDrawEnable(10000, False)

        f.SetDisable(randChr.ID, False)
        f.EnableAction(randChr.ID, True)
        f.EnableLogic(randChr.ID, True)
        f.ChrDisableUpdate(randChr.ID, False)


        Chr.Player.HeaderPtr = randHeader.Address

        

        randChr.View()
        randChr.DebugControllerPtr = Chr.Player.Nav.ControllerPtr

        randChr.NoAttack = False
        randChr.TeamType = Chr.Player.TeamType
        randChr.NoMove = False
        randChr.DrawGroup1 = -1
        randChr.DrawGroup2 = -1
        randChr.DrawGroup3 = -1
        randChr.DrawGroup4 = -1
        randHeader.IsDisable = False
        randHeader.IsHide = False

        

        Chr.Player.WarpToChr(randChr)

SWAP_RANDOM_ENTITY()

gp = Gamepad.PS3()

def SWAP_UPDATE_LOOP():

    justLoaded = False

    while Utils.IsGameLoading():
        justLoaded = True
        ex.Wait(250)

    if justLoaded:
        ex.Wait(2000)
        SWAP_RANDOM_ENTITY()

    if randChr.Address != Chr.Player.Address:
        Chr.Player.WarpToChr(randChr)

    if gp.L3 and (not gp.PrevL3):
        randChr.HP = 0

ticks = Utils.GetTickSpanFromHz(UPDATE_RATE)

while True:
    # Utils.FixedTimestep(UpdateLoop, ticks)
    Utils.FixedTimestep(SWAP_UPDATE_LOOP, ticks)

#SWAP_RANDOM_ENTITY()