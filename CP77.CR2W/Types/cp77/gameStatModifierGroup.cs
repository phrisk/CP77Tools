using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameStatModifierGroup : CVariable
	{
		[Ordinal(0)]  [RED("drawBasedOnStatType")] public CBool DrawBasedOnStatType { get; set; }
		[Ordinal(1)]  [RED("statModifierArray")] public CArray<CHandle<gameStatModifierData>> StatModifierArray { get; set; }
		[Ordinal(2)]  [RED("statModifiersLimit")] public CInt32 StatModifiersLimit { get; set; }
		[Ordinal(3)]  [RED("statModifiersLimitModifier")] public TweakDBID StatModifiersLimitModifier { get; set; }

		public gameStatModifierGroup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}