using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorFindLaneTaskDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(0)]  [RED("filter")] public CEnum<worldFindLaneFilter> Filter { get; set; }
		[Ordinal(1)]  [RED("pointOnLane")] public CHandle<AIArgumentMapping> PointOnLane { get; set; }

		public AIbehaviorFindLaneTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}