using System.Reflection;
using EFT.InputSystem;
using HarmonyLib;
using SPT.Reflection.Patching;

namespace SamSWAT.TimeWeatherChanger.Patches;

public class InputManagerCreatePatch : ModulePatch
{
    protected override MethodBase GetTargetMethod()
    {
        return AccessTools.Method(typeof(InputManager), nameof(InputManager.Create));
    }

    [PatchPostfix]
    public static void Postfix(ref InputManager __result)
    {
        TimeWeatherPlugin.Input = __result;
    }
}
