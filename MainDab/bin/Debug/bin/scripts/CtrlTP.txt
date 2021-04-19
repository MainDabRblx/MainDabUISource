-- Hold left ctrl and click on where you want to TP to
-- https://github.com/MainDabRblx/ProjectDab/blob/master/roblox.png?raw=true
local Plr = game:GetService("Players").LocalPlayer
local Mouse = Plr:GetMouse()

Mouse.Button1Down:connect(function()
if not game:GetService("UserInputService"):IsKeyDown(Enum.KeyCode.LeftControl) then return end
if not Mouse.Target then return end
Plr.Character:MoveTo(Mouse.Hit.p)
end)