-- lol fling spark_vip on roblox pls
-- https://raw.githubusercontent.com/MainDabRblx/ProjectDab/master/roblox.png
for i,v in pairs(game.Players.LocalPlayer.Character:GetChildren()) do
if v.ClassName == "Accessory" then v.Parent = workspace
end
end
gh = game.Players.LocalPlayer.Name
game.Workspace[gh]:Destroy()
wait(2)
   spawn(function()
   while wait() do
       sethiddenproperty(game.Players.LocalPlayer, "SimulationRadius", math.huge)
       sethiddenproperty(game.Players.LocalPlayer, "MaximumSimulationRadius", math.huge)
   end
end)
   for i,d in pairs(workspace:GetChildren()) do
     if d:IsA("Accessory") then 
local temp = Instance.new("BodyPosition")
temp.MaxForce = Vector3.new(math.huge,math.huge,math.huge)
temp.Parent = d.Handle
 spawn(function()
   while wait() do
       sethiddenproperty(game.Players.LocalPlayer, "SimulationRadius", math.huge)
       sethiddenproperty(game.Players.LocalPlayer, "MaximumSimulationRadius", math.huge)
   end
end)
local temp1 = Instance.new("BodyThrust")
temp1.Location = Vector3.new(5,0,0)
temp1.Force = Vector3.new(10000,10000,10000)
temp1.Parent = d.Handle
d.Handle.CanCollide = false
game:GetService("RunService").RenderStepped:Connect(function()
d.Handle.Position = game.Players.LocalPlayer:GetMouse().Hit.p + Vector3.new(0,2,0)
temp.Position = game.Players.LocalPlayer:GetMouse().Hit.p + Vector3.new(0,2,0)
end)
end
end