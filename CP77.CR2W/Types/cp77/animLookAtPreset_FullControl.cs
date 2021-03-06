using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animLookAtPreset_FullControl : animLookAtPreset
	{
		[Ordinal(0)]  [RED("chestMode")] public CInt32 ChestMode { get; set; }
		[Ordinal(1)]  [RED("chestSquareScale")] public CFloat ChestSquareScale { get; set; }
		[Ordinal(2)]  [RED("chestSuppress")] public CFloat ChestSuppress { get; set; }
		[Ordinal(3)]  [RED("eyesMode")] public CInt32 EyesMode { get; set; }
		[Ordinal(4)]  [RED("eyesSuppress")] public CFloat EyesSuppress { get; set; }
		[Ordinal(5)]  [RED("headMode")] public CInt32 HeadMode { get; set; }
		[Ordinal(6)]  [RED("headSquareScale")] public CFloat HeadSquareScale { get; set; }
		[Ordinal(7)]  [RED("headSuppress")] public CFloat HeadSuppress { get; set; }
		[Ordinal(8)]  [RED("limits")] public animLookAtLimits Limits { get; set; }

		public animLookAtPreset_FullControl(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
