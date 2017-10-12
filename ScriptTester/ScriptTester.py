from DarkSoulsScriptingBundle import *

import random

# Use Chr.Player. to access the player chr structure.
Chr.Player.DisableGravity2 = True # Yes there are 2 disable gravity values. The second one seems to be the only correct one though. Wulf still hasn't confirmed.
Chr.Player.Stats.AppearanceScaleHead = 10
Chr.Player.Stats.AppearanceScaleChest = 10
Chr.Player.Stats.AppearanceScaleArms = 10
Chr.Player.Stats.AppearanceScaleWaist = 10
Chr.Player.Stats.AppearanceScaleLegs = 10

# WorldState is currently not mapped very much, expect more values to be added here later
WorldState.BonfireID = 1212962 # Sets respawn bonfire to Oolacile Township


f.SetEventSpecialEffect_2(10000, 33) # Immediately curse player
f.SetEventFlag(11210001, False)

# Some utility modules exist (more will be added as needed):
Utils.WaitLoadCycle() #Wait until after the game finishes loading.

# Use f. to  access ingame functions with mapped parameters
f.ChrFadeIn(10000, 5.0, 0.0)

Chr.Player.Stats.AppearanceScaleHead = 1
Chr.Player.Stats.AppearanceScaleChest = 1
Chr.Player.Stats.AppearanceScaleArms = 1
Chr.Player.Stats.AppearanceScaleWaist = 1
Chr.Player.Stats.AppearanceScaleLegs = 1


# Use f.Unmapped to access ALL ingame lua functions with no parameters listed (in casse you need to use a function we haven't mapped out the parameters for)
print str(f.Unmapped.GetTravelItemParamId(7)) #No dea what this returns. If you find out, please let me know ;)

# Use ex. to access extra functions we've added to extend the functionality.
ex.MsgBoxOK("Hi there. Press OK to spawn your own Artorias bodyguard to help you through Oolacile Township.")

# Use Chr.FromName() to access the entity structure for the map name and entity name specified:
artorias = Chr.FromName("m12_01_00_00", "c4100_0000") #Gets Artorias, but ONLY if he's loaded, so warp to Oolacile Township or something

# the ID property in Chr structure gets the ChrID of that Chr for use with various functions.
f.SetDisable(artorias.ID, False)

artorias.DisableEventBackreadState = False

# Do note, however, that there are some Chr's that literally always spawn and have no special events. 
# These Chr's will have -1 as their ID and, as such, these functions will not work.
# However, you can still do some of the things those functions do by directly modifying the Chr:
artorias.Nav.EnableLogic = True

artorias.TeamType = TEAM_TYPE.BattleFriend
# artorias.ChrType = CHR_TYPE.WhiteGhost


# There are also some helper functions in many of the ingame structures mapped out that we added to make things easier:
artorias.WarpToChr(Chr.Player) # Warps Artorias to the exact same location as the player

# Some of the ingame structures contain other structures:
Chr.Player.Stats.Covenant = COVENANT.Darkwraith
Chr.Player.Stats.DevotionDarkwraith = 99

#### As of Pre-Release 0.2: ####

# Many structs were updated to have new values
Chr.Player.OmissionLevel = 8

# Structs added:
Game.ClearCount = 6 #Makes game NG+6

Game.LocalStats.Covenant = COVENANT.Darkwraith #Has same effect as Chr.Player.Stats

Game.Options.CameraSpeed = random.randint(1, 10) #randomizes camera speed setting in options menu

Game.Tendency.CharacterBlackWhiteTendency = 1 #Changes character tendency. Likely will have no effect whatsoever.

ChrDbg.AllNoMPConsume = True #Would make every chr in the game not consume MP, if this was Demon's Souls (don't worry, ChrDebug also has plenty of Dark Souls debug options)

ChrFollowCam.FovY = 0.8 #Messes with fied of view

WorldState.IsDisableAllAreaEvent = True

while True:
    ex.SetLineHelpTextPos(225, 192);
    ex.SetLineHelpText("Current Animation: " + str(Misc.PlayerCurrentAnimation)) # Displays player current animation. Misc module contains some other neat stuff too.
    ex.Wait(33)