using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animLookAtLimits : CVariable
	{
		[Ordinal(0)]  [RED("backLimitDegrees")] public CFloat BackLimitDegrees { get; set; }
		[Ordinal(1)]  [RED("hardLimitDegrees")] public CFloat HardLimitDegrees { get; set; }
		[Ordinal(2)]  [RED("hardLimitDistance")] public CFloat HardLimitDistance { get; set; }
		[Ordinal(3)]  [RED("softLimitDegrees")] public CFloat SoftLimitDegrees { get; set; }

		public animLookAtLimits(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
