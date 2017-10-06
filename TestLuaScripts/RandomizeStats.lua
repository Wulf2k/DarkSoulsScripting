function RandomizeStats()
    player.END = 1 + math.random() * 98
    SetKeyGuideText(""..(player.Pointer))
end

math.randomseed(os.time())

while true do
    RandomizeStats()
    Wait(16)
end