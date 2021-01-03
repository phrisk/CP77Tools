using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIArgumentOverrideWrapper : CVariable
	{
		[Ordinal(0)]  [RED("definition")] public CHandle<AIArgumentDefinition> Definition { get; set; }
		[Ordinal(1)]  [RED("name")] public CName Name { get; set; }
		[Ordinal(2)]  [RED("type")] public CEnum<AIArgumentType> Type { get; set; }

		public AIArgumentOverrideWrapper(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}