using Loqui;
using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Plugins.Binary.Streams;
using Mutagen.Bethesda.Plugins.Binary.Translations;
using Mutagen.Bethesda.Skyrim;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeadBodyCleanupNPCAttacher
{
    internal class WIDeadBodyCleanupScript : IScriptEntryGetter
    {
        public string Name => "WIDeadBodyCleanupScript";

        public ScriptEntry.Flag Flags => ScriptEntry.Flag.Local;

        public IReadOnlyList<IScriptPropertyGetter> Properties => throw new NotImplementedException();

        public object BinaryWriteTranslator => throw new NotImplementedException();

        public IEnumerable<IFormLinkGetter> ContainedFormLinks => throw new NotImplementedException();

        public ILoquiRegistration Registration => throw new NotImplementedException();

        public object CommonInstance()
        {
            throw new NotImplementedException();
        }

        public object? CommonSetterInstance()
        {
            throw new NotImplementedException();
        }

        public object CommonSetterTranslationInstance()
        {
            throw new NotImplementedException();
        }

        public void ToString(FileGeneration fg, string? name = null)
        {
            throw new NotImplementedException();
        }

        public void WriteToBinary(MutagenWriter writer, TypedWriteParams? translationParams = null)
        {
            throw new NotImplementedException();
        }
    }
}
