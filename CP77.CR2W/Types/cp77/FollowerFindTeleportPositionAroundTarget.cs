using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class FollowerFindTeleportPositionAroundTarget : AIbehaviortaskScript
	{
		[Ordinal(0)]  [RED("lastResultTimestamp")] public CFloat LastResultTimestamp { get; set; }
		[Ordinal(1)]  [RED("outPositionArgument")] public CHandle<AIArgumentMapping> OutPositionArgument { get; set; }
		[Ordinal(2)]  [RED("target")] public CHandle<AIArgumentMapping> Target { get; set; }

		public FollowerFindTeleportPositionAroundTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
