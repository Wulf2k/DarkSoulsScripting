FixCameraSpeedForCustomFramerate(fps)
    WFloat(RInt32(RInt32(RInt32(0x137D6DC) + 0x3c) + 0x60) + 0x190, 0.1 / (fps / 30.0))
end

while true do
    Utils:WaitForGame()
    FixCameraSpeedForCustomFramerate(60)
    --The game 
    Wait(1000)
end