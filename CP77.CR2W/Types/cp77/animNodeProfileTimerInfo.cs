using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animNodeProfileTimerInfo : CVariable
	{
		[Ordinal(0)]  [RED("mode")] public CEnum<animNodeProfileTimerMode> Mode { get; set; }
		[Ordinal(1)]  [RED("name")] public CName Name { get; set; }

		public animNodeProfileTimerInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
