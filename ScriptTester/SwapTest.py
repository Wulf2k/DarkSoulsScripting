from DarkSoulsScriptingBundle import *
import System
import random

#Basic default vars:
baseJumpAmt = 0.3
baseJumpSteps = 12.0
debugSlowmo = False
UPDATE_RATE = 60.0

debugViewChr = "c4100"

#init:
jumpAmt = 0
jumpSteps = 1
def CheckAnim(anim, modelName):
    global jumpAmt
    global jumpSteps
    jumpAmt = baseJumpAmt
    jumpSteps = baseJumpSteps

    if modelName == "c0000": # Human
        if anim == -1:
            return False
        elif anim == 7586: #Estus sip
            jumpAmt /= 1.25
            jumpSteps *= 1.25
            return True
        elif anim >= 7000 and anim <= 7064: #All ladder animations
            return False
        elif anim % 1000 == 900: #Rolling attacks
            jumpAmt = 0.20
            return True
        elif (anim / 1000 == 203) or (anim / 1000 == 204): #Dagger R1 (1Hand) (2Hand)
            jumpAmt = 0.25
            jumpSteps = baseJumpSteps * 2
            return True
        elif (anim % 1000 == 102): #Parry animations
            jumpAmt /= 2
            jumpSteps *= 2
        else:
            return True
    elif modelName == "c4100":
        #jumpAmt *= 1.5
        #jumpSteps /= 1.5
        return True
    else:
        #TODO
        jumpAmt *= 2
        jumpSteps /= 2
        return True

def WaitLoad():
    while Utils.IsGameLoading():
        ex.Wait(33)

def CheckIfChrIsPlayer(c):
    assert type(c) is Chr
    return (c.Address == Chr.PlayerPtr)

def GetChrCurrentAnim(c, isPlr):
    assert type(c) is Chr
    
    if isPlr:
        return Misc.PlayerCurrentAnimation
    else:
        if c.Nav.Controller.AIControllerPtr > 0:
            return c.Nav.Controller.AIController.AnimationID #c.Nav.Controller.AnimationID
        else:
            return c.Nav.Controller.AnimationID

def HandleAnim(modelName, animInstance, animID):
    if debugSlowmo:
        animInstance.Speed = 0.5

    if animInstance.LoopCount > 0:
        return

    time = animInstance.ElapsedTime

    if modelName == "c0000":
        if (animID >= 700 and animID <= 703) or animID == 680 or animID == 900: #Rolls, jumping attacks, and something else
            if time < (jumpAmt * 0.65):
                animInstance.ElapsedTime = time + (jumpAmt / jumpSteps / 4)
            elif time >= (jumpAmt * 1.05) and time < (jumpAmt * 1.35):
                animInstance.Speed = 1.25
                animInstance.ElapsedTime = time - (jumpAmt / jumpSteps / 4.5)
            else:
                animInstance.ElapsedTime = time + (jumpAmt / jumpSteps) / (4 + time)
        elif time < jumpAmt:
            animInstance.ElapsedTime = time + (jumpAmt / jumpSteps) / (1 + time)
    #Default:
    elif modelName == "c4100":
        if (animID >= 700 and animID <= 703): #Rolls
            if time < (jumpAmt * 0.65):
                animInstance.ElapsedTime = time + (jumpAmt / jumpSteps / 4)
            elif time >= (jumpAmt * 1.05) and time < (jumpAmt * 1.35):
                animInstance.ElapsedTime = time - (jumpAmt / jumpSteps / 4.5)
            else:
                animInstance.ElapsedTime = time + (jumpAmt / jumpSteps) / (4 + time)

        else:
            animInstance.ElapsedTime = time + (jumpAmt / jumpSteps) / (1 + time)
    elif time < jumpAmt:
        animInstance.ElapsedTime = time + (jumpAmt / jumpSteps) / (1 + time)

numCalls = 0

def ApplyAgilityToChr(c):
    assert type(c) is Chr

    anims = c.Nav.GetAnimInstances()
    chrIsPlayer = CheckIfChrIsPlayer(c)
    curAnim = GetChrCurrentAnim(c, chrIsPlayer)
    mdlName = c.ModelName

    #if mdlName == debugViewChr:
    #    global numCalls
    #    numCalls += 1
    #    ex.SetKeyGuideTextPos(0, 0)
    #    ex.SetKeyGuideText(System.String.Format("[NumCalls:{0:D8}][Chr:{1}][CurAnim:{2}]", numCalls, mdlName, curAnim))

    if CheckAnim(curAnim, mdlName):
        for i in range(0, anims.Count):
            #if anims[i].Speed == 0:
            #    break
            HandleAnim(mdlName, anims[i], curAnim)

#### ARTORIAS DEBUG: ####
#WorldState.BonfireID = 1212962
#f.SetEventFlag(11210001, False)
#f.SetEventSpecialEffect_2(10000, 3220)

#Utils.WaitLoadCycle()

#artorias = Chr.FromName("m12_01_00_00", "c4100_0000")
#Chr.Player.WarpToChr(artorias)

#########################

#Chr.Player.DeadMode = True
#Chr.Player.DisableHpGauge = True
#Chr.Player.NoDamage = True
#Chr.Player.NoDead = True
#Chr.Player.EnableInvincible = True

#artorias.DeadMode = True
#artorias.DisableHpGauge = True
#artorias.NoDamage = True
#artorias.NoDead = True
#artorias.EnableInvincible = True

updateLoopCount = 0

def UpdateLoop():
    Utils.WaitForLoadingScreenEnd()
    #f.SetHp(10000, 1.0)
    ApplyAgilityToChr(Chr.Player)
    #ApplyAgilityToChr(artorias)

    entityCount = 0
    entityUpdateCount = 0

    mapEntries = Map.GetEntries()
    for m in range(0, mapEntries.Count):
        # print "Map " + str(m)
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
            elif actualChr.Nav.AnimationPtr < Hook.DARKSOULS.SafeBaseMemoryOffset:
                continue
            elif actualChr.DisableEventBackreadState:
                continue

            #print "Applying agility to chr " + str(m) + ":" + str(c) + ":" + actualChr.ModelName
            ApplyAgilityToChr(actualChr)
            entityUpdateCount += 1

    global updateLoopCount
    updateLoopCount += 1
    ex.SetLineHelpTextPos(0,0)
    ex.SetLineHelpText(System.String.Format("[{0:D8}/{1:D8}][{2:D8}]", entityUpdateCount, entityCount, updateLoopCount))

ticks = Utils.GetTickSpanFromHz(UPDATE_RATE)

f.SetEventSpecialEffect_2(10000,3090)

Game.ClearCount = 0

while True:
    Utils.FixedTimestep(UpdateLoop, ticks)