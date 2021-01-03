using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class HitIsTheSameTargetPrereq : GenericHitPrereq
	{
		[Ordinal(0)]  [RED("invert")] public CBool Invert { get; set; }
		[Ordinal(1)]  [RED("isMoving")] public CBool IsMoving { get; set; }
		[Ordinal(2)]  [RED("object")] public CString Object { get; set; }

		public HitIsTheSameTargetPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}