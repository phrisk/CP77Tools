using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ItemModeGridView : inkScriptableDataViewWrapper
	{
		[Ordinal(0)]  [RED("itemFilterType")] public CEnum<ItemFilterCategory> ItemFilterType { get; set; }
		[Ordinal(1)]  [RED("itemSortMode")] public CEnum<ItemSortMode> ItemSortMode { get; set; }
		[Ordinal(2)]  [RED("uiScriptableSystem")] public wCHandle<UIScriptableSystem> UiScriptableSystem { get; set; }

		public ItemModeGridView(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
