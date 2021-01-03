using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class TestNPCOutsideNavmeshEvent : redEvent
	{
		[Ordinal(0)]  [RED("activator")] public wCHandle<gameObject> Activator { get; set; }
		[Ordinal(1)]  [RED("enable")] public CBool Enable { get; set; }
		[Ordinal(2)]  [RED("target")] public wCHandle<gameObject> Target { get; set; }

		public TestNPCOutsideNavmeshEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}