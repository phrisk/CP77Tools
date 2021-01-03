using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldSpeedSplineNodeSpeedRestriction : CVariable
	{
		[Ordinal(0)]  [RED("adjustTime")] public CFloat AdjustTime { get; set; }
		[Ordinal(1)]  [RED("from")] public CFloat From { get; set; }
		[Ordinal(2)]  [RED("speed")] public CFloat Speed { get; set; }

		public worldSpeedSplineNodeSpeedRestriction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}