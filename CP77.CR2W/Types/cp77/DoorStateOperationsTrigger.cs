using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class DoorStateOperationsTrigger : DeviceOperationsTrigger
	{
		[Ordinal(0)]  [RED("cachedState")] public CEnum<EDoorStatus> CachedState { get; set; }
		[Ordinal(1)]  [RED("triggerData")] public CHandle<DoorStateOperationTriggerData> TriggerData { get; set; }
		[Ordinal(2)]  [RED("wasStateCached")] public CBool WasStateCached { get; set; }

		public DoorStateOperationsTrigger(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}