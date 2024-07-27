using System.Reflection;
using EFT.Weather;
using HarmonyLib;

namespace SamSWAT.TimeWeatherChanger.Utils;

public static class Reflection
{
    public static FieldInfo FogField;
    public static FieldInfo LighteningThunderField;
    public static FieldInfo RainField;
    public static FieldInfo TemperatureField;

    public static void GetFieldInfos()
    {
        FogField = AccessTools.Field(typeof(WeatherDebug), "Fog");
        LighteningThunderField = AccessTools.Field(typeof(WeatherDebug), "LightningThunderProbability");
        RainField = AccessTools.Field(typeof(WeatherDebug), "Rain");
        TemperatureField = AccessTools.Field(typeof(WeatherDebug), "Temperature");
    }
}