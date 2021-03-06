using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AttributeUpgradePurchased : redEvent
	{
		[Ordinal(0)]  [RED("attributeData")] public CHandle<AttributeData> AttributeData { get; set; }
		[Ordinal(1)]  [RED("attributeType")] public CEnum<PerkMenuAttribute> AttributeType { get; set; }

		public AttributeUpgradePurchased(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
