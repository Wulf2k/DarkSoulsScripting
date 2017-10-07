import clr
import System
clr.AddReference("DarkSoulsScripting")
from DarkSoulsScripting import *
from DarkSoulsScripting.Extra import *
from DarkSoulsScripting.AI_DEFINE import *
from DarkSoulsScripting import IngameFuncs as f
from DarkSoulsScripting import ExtraFuncs as ex

# Use f. to  access ingame functions with mapped parameters
# Use f.Unmapped to access ALL ingame lua functions with no parameters listed (in casse you need to use a function we haven't mapped out the parameters for)
# Use ex. to access extra functions we've added to make things easier

# Use Entity.Player. to access the player entity structure.
# Use Entity.FromName("m12_01_00_00", "c4100_0000") to access the entity struct for Artorias (if he's loaded)
# etc


# Starter script - Instantly kill your player:
Entity.Player.HP = 0