using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ShaftsAreaSettings : CVariable
	{
		[Ordinal(0)]  [RED("shaftsIntensity")] public CFloat ShaftsIntensity { get; set; }
		[Ordinal(1)]  [RED("shaftsLevelIndex")] public CUInt32 ShaftsLevelIndex { get; set; }
		[Ordinal(2)]  [RED("shaftsThresholdsScale")] public CFloat ShaftsThresholdsScale { get; set; }

		public ShaftsAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}