using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TargetIndicatorEntry : CVariable
	{
		[Ordinal(0)]  [RED("indicator")] public wCHandle<inkWidget> Indicator { get; set; }
		[Ordinal(1)]  [RED("targetID")] public entEntityID TargetID { get; set; }

		public TargetIndicatorEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
