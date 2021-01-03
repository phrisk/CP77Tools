using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class localizationPersistenceSubtitleMapEntry : CVariable
	{
		[Ordinal(0)]  [RED("subtitleFile")] public raRef<JsonResource> SubtitleFile { get; set; }
		[Ordinal(1)]  [RED("subtitleGroup")] public CName SubtitleGroup { get; set; }

		public localizationPersistenceSubtitleMapEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}