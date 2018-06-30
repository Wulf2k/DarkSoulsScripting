from DarkSoulsScriptingBundle import *
from time import *

print 1

addr = 0x140000020L

sleep(2)



try:
        print(RInt32(addr))


except:
        print("failed")

sleep(5)