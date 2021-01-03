using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class FailedActionEvent : redEvent
	{
		[Ordinal(0)]  [RED("action")] public CHandle<gamedeviceAction> Action { get; set; }
		[Ordinal(1)]  [RED("whoFailed")] public gamePersistentID WhoFailed { get; set; }

		public FailedActionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}