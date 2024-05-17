using UnityEditor;
using UnityEditor.AssetImporters;
using UnityEngine;

[ScriptedImporter(1, "foo")]
public class MyScriptedImporter : ScriptedImporter
{
    const string CustomDependencyName = "MyCustomDependency";

    [MenuItem("Bug/Update Custom Dependency")]
    public static void UpdateCustomDependency()
    {
        var hash = Hash128.Compute(GUID.Generate().ToString());
        AssetDatabase.RegisterCustomDependency(CustomDependencyName, hash);
        AssetDatabase.Refresh();
    }
    
    public override void OnImportAsset(AssetImportContext ctx)
    {
        Debug.Log("OnImportAsset: " + ctx.assetPath);
        ctx.DependsOnCustomDependency(CustomDependencyName);
    }
}
