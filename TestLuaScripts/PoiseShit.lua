entityList = {}
GetAllApparentEntities(entityList)

for i,j in ipairs(entityList) do
    entityList[i].AnimationSpeed = 0.01
end

while true do
    SetKeyGuideText(string.format("%.8f", player.PoiseRecoverTimer))
    --player.PoiseRecoverTimer = 0
    player.PoiseCurrent = 0
end