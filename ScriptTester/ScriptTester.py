import clr
import System
import random

clr.AddReference("DarkSoulsScripting")
from DarkSoulsScripting import *
from DarkSoulsScripting.Extra import *
from DarkSoulsScripting import IngameFuncs as f
from DarkSoulsScripting import ExtraFuncs as ex

while True:
    #f.ChrFadeIn(10000, 5.0, 0.0)
    Entity.Player.ChrType = random.randint(0,7)
    print str(Entity.Player.ChrType)