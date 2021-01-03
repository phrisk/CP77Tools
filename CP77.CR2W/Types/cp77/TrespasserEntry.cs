using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class TrespasserEntry : CVariable
	{
		[Ordinal(0)]  [RED("areaStack")] public CArray<CName> AreaStack { get; set; }
		[Ordinal(1)]  [RED("isInsideA")] public CBool IsInsideA { get; set; }
		[Ordinal(2)]  [RED("isInsideB")] public CBool IsInsideB { get; set; }
		[Ordinal(3)]  [RED("isInsideScanner")] public CBool IsInsideScanner { get; set; }
		[Ordinal(4)]  [RED("isScanned")] public CBool IsScanned { get; set; }
		[Ordinal(5)]  [RED("trespasser")] public wCHandle<gameObject> Trespasser { get; set; }

		public TrespasserEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}