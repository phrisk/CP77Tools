using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ItemCompareBuilder : IScriptable
	{
		[Ordinal(0)]  [RED("compareBuilder")] public CHandle<CompareBuilder> CompareBuilder { get; set; }
		[Ordinal(1)]  [RED("item1")] public InventoryItemData Item1 { get; set; }
		[Ordinal(2)]  [RED("item2")] public InventoryItemData Item2 { get; set; }

		public ItemCompareBuilder(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}