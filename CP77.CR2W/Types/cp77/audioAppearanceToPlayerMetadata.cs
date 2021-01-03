using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioAppearanceToPlayerMetadata : CVariable
	{
		[Ordinal(0)]  [RED("appearances")] public CArray<CName> Appearances { get; set; }
		[Ordinal(1)]  [RED("foleyPlayerMetadata")] public CName FoleyPlayerMetadata { get; set; }
		[Ordinal(2)]  [RED("priority")] public CEnum<audioFoleyItemPriority> Priority { get; set; }

		public audioAppearanceToPlayerMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}