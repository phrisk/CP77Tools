using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class StealthStimThresholdEvent : redEvent
	{
		[Ordinal(0)]  [RED("reset")] public CBool Reset { get; set; }
		[Ordinal(1)]  [RED("timeThreshold")] public CFloat TimeThreshold { get; set; }

		public StealthStimThresholdEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}