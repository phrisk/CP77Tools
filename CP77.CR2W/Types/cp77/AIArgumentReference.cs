using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIArgumentReference : AIArgumentDefinition
	{
		[Ordinal(0)]  [RED("defaultValue")] public CVariant DefaultValue { get; set; }
		[Ordinal(1)]  [RED("rttiClassName")] public CName RttiClassName { get; set; }
		[Ordinal(2)]  [RED("type")] public CEnum<AIArgumentType> Type { get; set; }

		public AIArgumentReference(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
