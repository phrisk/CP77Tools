using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class UnregisterTrafficRunner : AIbehaviortaskScript
	{
		[Ordinal(0)]  [RED("onDeactivation")] public CBool OnDeactivation { get; set; }

		public UnregisterTrafficRunner(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}