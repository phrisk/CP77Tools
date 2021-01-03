using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class StatProvider : IScriptable
	{
		[Ordinal(0)]  [RED("GameItemData")] public wCHandle<gameItemData> GameItemData { get; set; }
		[Ordinal(1)]  [RED("InventoryItemData")] public InventoryItemData InventoryItemData { get; set; }
		[Ordinal(2)]  [RED("PartData")] public gameInnerItemData PartData { get; set; }
		[Ordinal(3)]  [RED("dataSource")] public CEnum<gameEStatProviderDataSource> DataSource { get; set; }

		public StatProvider(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}