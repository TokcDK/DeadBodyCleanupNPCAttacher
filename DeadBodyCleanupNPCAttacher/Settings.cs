using Mutagen.Bethesda.Synthesis.Settings;

namespace DeadBodyCleanupNPCAttacher
{
    public class Settings
    {
        [SynthesisSettingName("Unofficial patch name")]
        [SynthesisTooltip("Name of Unofficial patch where from get the script")]
        public string UnofficialPatchName { get; set; } = "Unofficial Skyrim Legendary Edition Patch.esp";

        [SynthesisTooltip("Only forward deadbodycleanup script drom Unofficial patch if it was rewrited somewhere and skip script add to npc")]
        public bool OnlyScriptForward = false;
    }
}