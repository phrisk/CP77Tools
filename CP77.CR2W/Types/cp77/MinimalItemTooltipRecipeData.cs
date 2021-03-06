using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class MinimalItemTooltipRecipeData : IScriptable
	{
		[Ordinal(0)]  [RED("damageTypes")] public CArray<InventoryTooltipData_StatData> DamageTypes { get; set; }
		[Ordinal(1)]  [RED("recipeStats")] public CArray<InventoryTooltipData_StatData> RecipeStats { get; set; }
		[Ordinal(2)]  [RED("statsNumber")] public CInt32 StatsNumber { get; set; }

		public MinimalItemTooltipRecipeData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
