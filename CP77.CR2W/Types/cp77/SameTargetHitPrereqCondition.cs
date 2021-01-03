using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SameTargetHitPrereqCondition : BaseHitPrereqCondition
	{
		[Ordinal(0)]  [RED("previousSource")] public wCHandle<gameObject> PreviousSource { get; set; }
		[Ordinal(1)]  [RED("previousTarget")] public wCHandle<gameObject> PreviousTarget { get; set; }
		[Ordinal(2)]  [RED("previousWeapon")] public wCHandle<gameweaponObject> PreviousWeapon { get; set; }

		public SameTargetHitPrereqCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}