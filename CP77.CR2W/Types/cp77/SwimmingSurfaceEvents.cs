using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SwimmingSurfaceEvents : LocomotionSwimmingEvents
	{
		[Ordinal(0)]  [RED("lapsedTime")] public CFloat LapsedTime { get; set; }

		public SwimmingSurfaceEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}