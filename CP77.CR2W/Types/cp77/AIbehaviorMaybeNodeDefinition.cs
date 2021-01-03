using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorMaybeNodeDefinition : AIbehaviorDecoratorNodeDefinition
	{
		[Ordinal(0)]  [RED("onChildFailure")] public CEnum<AIbehaviorMaybeNodeAction> OnChildFailure { get; set; }
		[Ordinal(1)]  [RED("onChildSuccess")] public CEnum<AIbehaviorMaybeNodeAction> OnChildSuccess { get; set; }

		public AIbehaviorMaybeNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}