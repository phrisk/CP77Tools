using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class MeleeDeflectAttackEvents : MeleeAttackGenericEvents
	{
		[Ordinal(0)]  [RED("slowMoSet")] public CBool SlowMoSet { get; set; }

		public MeleeDeflectAttackEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
