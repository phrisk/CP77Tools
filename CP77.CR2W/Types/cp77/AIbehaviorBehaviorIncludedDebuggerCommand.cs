using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorBehaviorIncludedDebuggerCommand : AIbehaviorIDebuggerCommand
	{
		[Ordinal(0)]  [RED("entries")] public CArray<AIbehaviorBehaviorIncludedDebuggerCommandEntry> Entries { get; set; }

		public AIbehaviorBehaviorIncludedDebuggerCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}