using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class GetRandomThreat : AIRandomTasks
	{
		[Ordinal(0)]  [RED("outThreatArgument")] public CHandle<AIArgumentMapping> OutThreatArgument { get; set; }

		public GetRandomThreat(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}