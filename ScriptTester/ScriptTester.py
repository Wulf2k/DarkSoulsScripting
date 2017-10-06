import clr
import time
import random

clr.AddReference("DarkSoulsScripting")
from DarkSoulsScripting import *
from DarkSoulsScripting import Functions as f



Hook.Init()

startTime = time.time()

count = 0

while True:
    # f.ChrFadeIn(10000, 5.0, 0);
    Entity.Player.ChrType = random.randint(1,3)
    timer = (time.time() - startTime);
    hz = count / timer;
    dispStr = "Timer: " + str(timer) + ", Count: " + str(count) + ", Hz: " + str(hz)
    # print dispStr
    f.Extra.SetKeyGuideText(dispStr)
    count = count + 1