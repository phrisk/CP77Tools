using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questInjectLoot_NodeTypeParams_OperationData : CVariable
	{
		[Ordinal(0)]  [RED("itemTDBID")] public TweakDBID ItemTDBID { get; set; }
		[Ordinal(1)]  [RED("operationType")] public CEnum<questInjectLootOperationType> OperationType { get; set; }
		[Ordinal(2)]  [RED("quantity")] public CInt32 Quantity { get; set; }

		public questInjectLoot_NodeTypeParams_OperationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}