using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class Agent : CVariable
	{
		[Ordinal(0)]  [RED("areas")] public CArray<DeviceLink> Areas { get; set; }
		[Ordinal(1)]  [RED("cachedDelayDuration")] public CFloat CachedDelayDuration { get; set; }
		[Ordinal(2)]  [RED("incomingFilter")] public CEnum<EFilterType> IncomingFilter { get; set; }
		[Ordinal(3)]  [RED("link")] public DeviceLink Link { get; set; }
		[Ordinal(4)]  [RED("reprimands")] public CArray<ReprimandData> Reprimands { get; set; }
		[Ordinal(5)]  [RED("supportingAgents")] public CArray<gamePersistentID> SupportingAgents { get; set; }

		public Agent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}