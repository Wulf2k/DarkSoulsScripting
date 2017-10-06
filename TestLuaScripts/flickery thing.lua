timer = 0
prevOsClock = os.clock()
math.randomseed(os.time())

prevHp = 0

invincibleTimerMax = 3.0
invincibleTimerPadding = 0.25
invincibleTimer = -1

blinkPadding = 0.95

while true do

    curHp = Player.HP.Value
    
    curOsClock = os.clock()
    deltaTime = (curOsClock - prevOsClock)
    timer = timer + deltaTime
    
    blink = (math.cos(timer * math.pi * 8) * 0.5) + 0.5
    
    if invincibleTimer > 0 then
        if invincibleTimer > invincibleTimerPadding then
            ChrFadeIn(10000, 0.33, blink)
        else
            if blink < blinkPadding then
                ChrFadeIn(10000, 0.5, blink)
            end
        end
        EnableInvincible(int(10000), true)
        SetDeadMode(int(10000), true)
        DisableDamage(int(10000), true)
        SetColiEnable(int(10000), false)
        invincibleTimer = invincibleTimer - deltaTime
    else
        EnableInvincible(int(10000), false)
        SetDeadMode(int(10000), false)
        DisableDamage(int(10000), false)
        SetColiEnable(int(10000), true)
        if curHp < prevHp then
            invincibleTimer = invincibleTimerMax
            timer = 0
        end
    end
    
    prevOsClock = curOsClock
    prevHp = curHp
    
    Wait(16)
end