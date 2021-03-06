using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gamePrereqDefinition : CVariable
	{
		[Ordinal(0)]  [RED("prereq")] public CHandle<gameIPrereq> Prereq { get; set; }
		[Ordinal(1)]  [RED("prereqName")] public CName PrereqName { get; set; }

		public gamePrereqDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
