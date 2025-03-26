using System;
using TinyWizard.Utilities;
using UnityEditor;

namespace TinyWizard.Core
{
    public static class EditorBuild
    {
        public static void BuildIOS()
        {
            var args = new Args(Environment.GetCommandLineArgs());

            BuildPipeline.BuildPlayer(new BuildPlayerOptions()
            {
                locationPathName = args.Get("buildPath"),
                options = BuildOptions.Development,
                scenes = new string[] { "Assets/Scenes/CharacterPlayground.unity" },
                target = args.Get<BuildTarget>("buildTarget"),
            });
        }
    }
}