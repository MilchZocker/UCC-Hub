using UnityEditor;
using UnityEngine;

namespace ABI.MODS.Editor
{
    [InitializeOnLoad]
    public static class CVRTranslatableTmpAdjustments
    {
        static CVRTranslatableTmpAdjustments()
        {
            string cckSymbol = "CCK_ADDIN_TRANSLATABLE_TMP";
            string defines = PlayerSettings.GetScriptingDefineSymbolsForGroup(EditorUserBuildSettings.selectedBuildTargetGroup);
            if (!defines.Contains(cckSymbol))
            {
                PlayerSettings.SetScriptingDefineSymbolsForGroup(EditorUserBuildSettings.selectedBuildTargetGroup, (defines + ";" + cckSymbol));
                Debug.Log("[CCK] [Module => CVRTranslatable.TextMeshPro] Added CCK_ADDIN_TRANSLATABLE_TMP Scripting Symbol.");
            }
        }
    }
}