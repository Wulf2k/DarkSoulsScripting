import clr
import System
clr.AddReference("DarkSoulsScripting")
from DarkSoulsScripting import *
from DarkSoulsScripting.Extra import *
from DarkSoulsScripting.AI_DEFINE import *
from DarkSoulsScripting import IngameFuncs as f
from DarkSoulsScripting import ExtraFuncs as ex

# Use Entity.Player. to access the player entity structure.
Entity.Player.AnimationSpeed = 1.25
Entity.Player.Stats.AppearanceScaleHead = 10
Entity.Player.Stats.AppearanceScaleChest = 10
Entity.Player.Stats.AppearanceScaleArms = 10
Entity.Player.Stats.AppearanceScaleWaist = 10
Entity.Player.Stats.AppearanceScaleLegs = 10


# WorldState is currently not mapped very much, expect more values to be added here later
WorldState.BonfireID = 1212962 # Sets respawn bonfire to Oolacile Township


f.SetEventSpecialEffect_2(10000, 33) # Immediately curse player
f.SetEventFlag(11210001, False)

Utils.WaitLoadCycle() #Wait until after the game finishes loading.

# Use f. to  access ingame functions with mapped parameters
f.ChrFadeIn(10000, 5.0, 0.0)

Entity.Player.Stats.AppearanceScaleHead = 1
Entity.Player.Stats.AppearanceScaleChest = 1
Entity.Player.Stats.AppearanceScaleArms = 1
Entity.Player.Stats.AppearanceScaleWaist = 1
Entity.Player.Stats.AppearanceScaleLegs = 1


# Use f.Unmapped to access ALL ingame lua functions with no parameters listed (in casse you need to use a function we haven't mapped out the parameters for)
print str(f.Unmapped.GetTravelItemParamId(7)) #No dea what this returns. If you find out, please let me know ;)

# Use ex. to access extra functions we've added to extend the functionality.
ex.MsgBoxOK("Hi there. Press OK to spawn your own Artorias bodyguard to help you through Oolacile Township.")

# Use Entity.FromName() to access the entity structure for the map name and entity name specified:
artorias = Entity.FromName("m12_01_00_00", "c4100_0000") #Gets Artorias, but ONLY if he's loaded, so warp to Oolacile Township or something

# the ChrID property in entity structure gets the ChrID of that entity for use with various functions.
f.SetDisable(artorias.ChrID, False)

artorias.DisableEventBackreadState = False

# Do note, however, that there are some entities that literally always spawn and have no special events. 
# These entities will have -1 as their ChrID and, as such, these functions will not work.
# However, you can still do some of the things those functions do by directly modifying the entity:
artorias.EnableLogic = True

artorias.TeamType = TEAM_TYPE.BattleFriend
# artorias.ChrType = CHR_TYPE.WhiteGhost


# There are also some helper functions in many of the ingame structures mapped out that we added to make things easier:
artorias.WarpToEntity(Entity.Player) # Warps Artorias to the exact same location as the player

# Some of the ingame structures contain other structures:
Entity.Player.Stats.Covenant = COVENANT.Darkwraith
Entity.Player.Stats.DevotionDarkwraith = 99

while True:
    if Entity.Player.Stats.AppearanceScaleHead < 10:
        Entity.Player.Stats.AppearanceScaleHead *= 1.005
        Entity.Player.Stats.AppearanceScaleChest *= 1.005
        Entity.Player.Stats.AppearanceScaleArms *= 1.005
        Entity.Player.Stats.AppearanceScaleWaist *= 1.005
        Entity.Player.Stats.AppearanceScaleLegs *= 1.005
        Entity.Player.AnimationSpeed *= 0.999

    ex.Wait(16)