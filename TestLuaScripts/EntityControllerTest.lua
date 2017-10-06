xinput_dll_offset = GetIngameDllAddress("XInput1_3.dll")
--Buttons
BTN_A        = 0x1000
BTN_B        = 0x2000
BTN_X        = 0x4000
BTN_Y        = 0x8000
BTN_LB       = 0x0100
BTN_RB       = 0x0200
BTN_HOME     = 0x0400
BTN_BACK     = 0x0020
BTN_LThumb   = 0x0040
BTN_RThumb   = 0x0080
BTN_START    = 0x0010
BTN_UP       = 0x0001
BTN_DOWN     = 0x0002
BTN_LEFT     = 0x0004
BTN_RIGHT    = 0x0008
BTN_CROSS    = 0x1000
BTN_CIRCLE   = 0x2000
BTN_SQUARE   = 0x4000
BTN_TRIANGLE = 0x8000
BTN_L1       = 0x0100
BTN_R1       = 0x0200
BTN_PS       = 0x0400
BTN_SELECT   = 0x0020
BTN_L3       = 0x0040
BTN_R3       = 0x0080

buttonBitmaskValue = 0;
prevButtonBitmaskValue = 0;

L2 = 0
R2 = 0

LSX = 0
LSY = 0
RSX = 0
RSY = 0

function CheckButton(maskTest)
    return Utils:BitmaskCheck(buttonBitmaskValue, maskTest);
end

function CheckPrevButton(maskTest)
    return Utils:BitmaskCheck(prevButtonBitmaskValue, maskTest);
end

function CheckButtonPressed(maskTest)
    cur = CheckButton(maskTest);
    prev = CheckPrevButton(maskTest);
    
    return (cur and (not prev));
end

function ReadController()
    addr = RInt32(RInt32(xinput_dll_offset + 0x10C44)) + 0x0028
    buttonBitmaskValue = RUInt16(addr);
    
    L2 = RByte(addr + 3) / 255.0
    R2 = RByte(addr + 2) / 255.0
    
    LSX = RInt16(addr + 4) / 32767.0
    LSY = RInt16(addr + 6) / 32767.0
    RSX = RInt16(addr + 8) / 32767.0
    RSY = RInt16(addr + 10) / 32767.0
end

entityName = "c4100_0000"; --Artorias
mapName = "m12_00_00_01"
entityId = 1210820
entityPtr = GetEntityPtr(entityId);--GetEntityPtrByName(mapName, entityName);

Print(""..entityPtr);

StopPlayer()

CamFocusEntity(entityPtr);
ControlEntity(entityPtr, false);
ControlEntity(GetEntityPtr(10000), true);
SetDisable(entityId, false);
SetDrawEnable(int(entityId), true);
ForceEntityDrawGroup(entityPtr);
ChrResetAnimation(entityId, true)
EnableLogic(int(entityId), true);
EnableAction(int(entityId), true)
SetDeadMode(entityId, true)
SetDeadMode2(entityId, true)
--ChrDisableUpdate(int(entityId), false)
--ChrResetRequest(entityId, true)
--ResetThink(entityId)

--WarpEntity_Player(entityPtr);




--Print(""..GetTargetChrID(entityId))

--ForceEntityDrawGroup(entityPtr)

--SetDisable(entityId, false)

SetCompletelyNoMove(entityId, false)

DisableMove(entityId, true)

SetCompletelyNoMove(10000, true)

WarpPlayer_Entity(entityPtr)

x = 0.0 + LSX * 5
y = 0
z = 0.0 + LSY * 5
r = 0

--WarpEntity_Coords(entityPtr, GetEntityPosX(entityPtr) + x, GetEntityPosY(entityPtr) + y, GetEntityPosZ(entityPtr) + z, GetEntityRotation(entityPtr) + r)
ChainA = { 3010, 3006, 3003, 3009, 3010, 3006, 3003, 3009, 3010, 3006, 3003, 3009, 3010, 3006, 3003 }
ChainACuck = { 0.1, 0.1, 0.1, 0.1, 0.1, 0.1, 0.1, 0.1, 0.1, 0.1, 0.1, 0.1, 0.1, 0.1, 0.1 }
ChainADecay = { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 }

chainRandMin = 3000
chainRandMax = 3014

function RandomizeChain(chain)
    for i,j in ipairs(chain) do 
        chain[i] = (chainRandMin + (math.random() * (chainRandMax - chainRandMin)))
    end
end

CurrentChain = ChainA
CurrentChainCuck = ChainACuck
CurrentChainDecay = ChainADecay

ChainProgress = 1

cuckTimer = 0
decayTimer = 0

rollCuck = 900

prevClock = os.clock()

function cucked() return cuckTimer > 0 end

function DoChainAnim()
    --ForcePlayAnimation(entityId, CurrentChain[ChainProgress])
end
dodge = 700
walkSlow = 200
run = 500
function RollInCurrentDirection()
    dir = 0
    if LSY > 0.6 then 
        dir = 0
    elseif LSY < -0.6 then 
        dir = 1
    elseif LSX < -0.6 then 
        dir = 2
    elseif LSX > 0.6 then 
        dir = 3
    end
    
    --ForcePlayAnimation(entityId, dodge + dir)
    --Wait(rollCuck)
    
    
    
    --ForcePlayAnimation(entityId, 0)
    
    --ForcePlayAnimation(entityId, 9999)
    
    --ForcePlayAnimation(entityId, 0)
    --StopLoopAnimation(entityId, 0)
    --ForcePlayAnimation(entityId, run + dir)
    
    
end

while true do
    ReadController()
    
    if (CheckButtonPressed(BTN_R1)) and (not cucked()) then
    
        if ChainProgress < #CurrentChain then
            DoChainAnim();
            ChainProgress = ChainProgress + 1
        else
            ChainProgress = 1
            RandomizeChain(CurrentChain)
        end
        
        cuckTimer = CurrentChainCuck[ChainProgress]
    end
    
    curClock = os.clock()
    
    deltaTime = (curClock - prevClock)
    
    if cuckTimer > 0 then
        cuckTimer = cuckTimer - deltaTime
    else
        if (cuckTimer > -math.huge) then
            decayTimer = CurrentChainDecay[ChainProgress]
            cuckTimer = -math.huge
        end
    end
    
    if decayTimer > 0 then
        decayTimer = decayTimer - deltaTime
    else
        if (decayTimer > -math.huge) then
            ChainProgress = 1
            RandomizeChain(CurrentChain)
            decayTimer = -math.huge
        end
    end
    
    if CheckButtonPressed(BTN_CIRCLE) then
    
        RollInCurrentDirection()
    
    end
    
    if CheckButton(BTN_L1) then
        if CheckButton(BTN_R1) then
            if CheckButtonPressed(BTN_A) then ForcePlayAnimation(entityId, 3012) end
            if CheckButtonPressed(BTN_B) then ForcePlayAnimation(entityId, 3013) end
            if CheckButtonPressed(BTN_X) then ForcePlayAnimation(entityId, 3014) end
            if CheckButtonPressed(BTN_Y) then ForcePlayAnimation(entityId, 3000) end
        else
            if CheckButtonPressed(BTN_A) then ForcePlayAnimation(entityId, 3004) end
            if CheckButtonPressed(BTN_B) then ForcePlayAnimation(entityId, 3005) end
            if CheckButtonPressed(BTN_X) then ForcePlayAnimation(entityId, 3006) end
            if CheckButtonPressed(BTN_Y) then ForcePlayAnimation(entityId, 3007) end
        end
    elseif CheckButton(BTN_R1) then
        if CheckButtonPressed(BTN_A) then ForcePlayAnimation(entityId, 3008) end
        if CheckButtonPressed(BTN_B) then ForcePlayAnimation(entityId, 3009) end
        if CheckButtonPressed(BTN_X) then ForcePlayAnimation(entityId, 3010) end
        if CheckButtonPressed(BTN_Y) then ForcePlayAnimation(entityId, 3011) end
    else
        if CheckButtonPressed(BTN_A) then ForcePlayAnimation(entityId, 3000) end
        if CheckButtonPressed(BTN_B) then ForcePlayAnimation(entityId, 3001) end
        if CheckButtonPressed(BTN_X) then ForcePlayAnimation(entityId, 3002) end
        if CheckButtonPressed(BTN_Y) then ForcePlayAnimation(entityId, 3003) end
    end
    
    ArtoriasAnim = {
        BasicSlashLeft = 3000,
        BasicSlashRight = 3001,
        DownwardSlash = 3002,
        DownwardSlashFast = 3014,
        
        FrontflipSlam = 3003,
        FrontflipSlamFast = 3009,
        
        ForwardChargeStab = 3004,
        
        SuperJump = 3005,
        
        Roar = 3006,
        
        SlowWeightedSlash = 3007,
        
        FakeoutToBackflip = 3008,
        FakeoutToBackwardRoll = 3010,
        
        SpinMove = 3011,
        
        ThrowSludge = 3012,
        
        SuperSaiyan = 3013
        
    }
    
    if CheckButtonPressed(UP) then ForcePlayAnimation(entityId, 700)
    elseif CheckButtonPressed(DOWN) then ForcePlayAnimation(entityId, 701)
    elseif CheckButtonPressed(LEFT) then ForcePlayAnimation(entityId, 702)
    elseif CheckButtonPressed(RIGHT) then ForcePlayAnimation(entityId, 703) 
    end
    
    Wait(16)
    prevButtonBitmaskValue = buttonBitmaskValue
    
    prevClock = curClock
end
