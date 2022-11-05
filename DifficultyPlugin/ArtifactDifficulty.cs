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
            HealthRegenMod = 0.0f;
            Tag = "ART";
            IconPath = "artifact-" + DifficultyPlugin.
            
        }
}