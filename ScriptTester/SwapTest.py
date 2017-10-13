from DarkSoulsScriptingBundle import *
import System
import random

#Basic default vars:
jumpAmt = 0.3
jumpSteps = 8

debugSlowmo = False

def CheckAnim(anim, modelName):
    if modelName == "c0000": # Human
        if anim == 7586: #Estus sip
            return False
        elif anim >= 7000 and anim <= 7064: #All ladder animations
            return False
        else:
            return True
    else:
        #TODO
        return True

def WaitLoad():
    while Utils.IsGameLoading():
        ex.Wait(33)

def GetLocalPlayerPointer():
    plrPtr = Hook.RInt32(0x137DC70)

    if plrPtr < Hook.DARKSOULS.SafeBaseMemoryOffset:
        WaitLoad()

    plrPtr = Hook.RInt32(plrPtr + 0x4)

    if plrPtr < Hook.DARKSOULS.SafeBaseMemoryOffset:
        WaitLoad()
    
    plrPtr = Hook.RInt32(plrPtr)

    if plrPtr < Hook.DARKSOULS.SafeBaseMemoryOffset:
        WaitLoad()

    return plrPtr

def CheckIfChrIsPlayer(c):
    assert type(c) is Chr
    return (c.Address == GetLocalPlayerPointer())

def GetChrCurrentAnim(c, isPlr):
    assert type(c) is Chr
    
    if isPlr:
        return Misc.PlayerCurrentAnimation
    else:
        return c.Nav.Controller.AnimationID

def HandleAnim(modelName, animInstance, animID):
    if debugSlowmo:
        animInstance.Speed = 0.5

    if modelName == "c0000":
        if animID == 700 or animID == 680 or animID == 900:
            if animInstance.ElapsedTime < (jumpAmt * 0.65):
                animInstance.ElapsedTime += (jumpAmt / jumpSteps / 4)
            elif animInstance.ElapsedTime < (jumpAmt * 1.15):
                animInstance.ElapsedTime -= (jumpAmt / jumpSteps / 4.5)
            else:
                animInstance.ElapsedTime += (jumpAmt / jumpSteps) / (4 + animInstance.ElapsedTime)
        elif animInstance.ElapsedTime < jumpAmt:
            animInstance.ElapsedTime += (jumpAmt / jumpSteps) / (1 + animInstance.ElapsedTime)
    #Default:
    elif animInstance.ElapsedTime < jumpAmt:
        animInstance.ElapsedTime += (jumpAmt / jumpSteps) / (1 + animInstance.ElapsedTime)

def ApplyAgilityToChr(c):
    assert type(c) is Chr

    anims = c.Nav.GetAnimInstances()
    chrIsPlayer = CheckIfChrIsPlayer(c)
    curAnim = GetChrCurrentAnim(c, chrIsPlayer)
    mdlName = c.ModelName

    ex.SetKeyGuideText(str(curAnim))

    if curAnim > -1 and CheckAnim(curAnim, mdlName):
        for i in range(0, anims.Count):
            HandleAnim(mdlName, anims[i], curAnim)

while True:
    ApplyAgilityToChr(Chr.Player)
    ex.Wait(16)