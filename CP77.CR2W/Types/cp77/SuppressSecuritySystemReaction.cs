using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SuppressSecuritySystemReaction : redEvent
	{
		[Ordinal(0)]  [RED("enableProtection")] public CBool EnableProtection { get; set; }
		[Ordinal(1)]  [RED("entered")] public CBool Entered { get; set; }
		[Ordinal(2)]  [RED("hasEntityWithdrawn")] public CBool HasEntityWithdrawn { get; set; }
		[Ordinal(3)]  [RED("protectedEntityID")] public entEntityID ProtectedEntityID { get; set; }

		public SuppressSecuritySystemReaction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}