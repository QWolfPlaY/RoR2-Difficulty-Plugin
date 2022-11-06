using System.Collections.Generic;
using UnityEngine;

namespace ArtifactDifficulty {
    
    internal class ArtifactDifficulty : DiffTemplate {

        internal static ArtifactDifficulty def;
        
        public ArtifactDifficulty() {

            Name = "Artifact";
            BaseToken = "ARTIFACT_DIFFICULTY";
            //rgb(55%,45%,73%)
            Color = new Color(0.55f, 0.45f, 0.73f);
            ScalingValue = 4f;
            HealthRegenMod = -0.4f;
            Tag = "ART";
            IconPath = "artifact-" + DifficultyPlugin.artifactArtist.Value + ".png";
            StartMessages = new string[] { "Start praying for your CPU", "Welcome to my Powerpoint presentation", "Say goodbye to your framerate", "Your eyes will hurt", "Better call yopur doctor in case of epilepsy" };
            MonsterRegenMod = 0.0f;
            EliteModifier = 0.65f;
            Description = buildDescription();
        }

        public override Dictionary<string, string> Language => ArtifactDictionray.DictionaryToUse;

        public override void ApplyHooks()
        {
            
        }
        
        public override void UndoHooks()
        {
            
        }

        private string buildDescription()
        {
            string desc = "For those who want to enjoy <style=cArtifact>artifact of sacrifice</style>.\n";
            desc = string.Join("\n", desc, $">Difficulty Scaling: <style=cDeath>{ScalingValue * 50 - 100}%</style>",
                $">Player Health Regen: <style=cHealing>{(int)(HealthRegenMod * 100)}%</style>",
                $">Elites: <style=cShrine>35%</style> Cheaper",
                $">LAG: <style=cArtifact>Guaranteed</style>",
                $">CPU USAGE: <style=cMono>100%</style>"
                );
            desc += "</style>";
            return desc;
        }
}