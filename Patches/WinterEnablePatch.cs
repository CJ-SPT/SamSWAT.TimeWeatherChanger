using Aki.Reflection.Patching;
using System.Reflection;
using static Class263;

namespace SamSWAT.TimeWeatherChanger.Patches
{
    internal class WinterEnablePatch : ModulePatch
    {
        protected override MethodBase GetTargetMethod() =>
            typeof(Class1292).GetMethod("method_0", BindingFlags.Public | BindingFlags.Instance);

        [PatchPostfix]
        public static void Postfix(Class1292 __instance)
        {
            __instance.class263_0.IsWinter = TimeWeatherPlugin.IsWinterEnabled.Value;
        }
    }
}