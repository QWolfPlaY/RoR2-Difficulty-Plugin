using BepInEx;
using R2API;
using R2API.Utils;
using RoR2;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace ArtifactDifficulty {

[BepInDependency(R2API.R2API.PluginGUID)]
[BepInPlugin(PluginGUID, PluginName, PluginVersion)]
[R2APISubmoduleDependency("DifficultyAPI")]

public class DifficultyPlugin : BaseUnityPlugin
{
    public const string PluginGUID = PluginAuthor + "." + PluginName;
    public const string PluginAuthor = "AuthorName";
    public const string PluginName = "ExamplePlugin";
    public const string PluginVersion = "1.0.0";
    
    private DifficultyIndex myIndex;
    private void Awake() {
            
    }
}
