using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ProgressBarButton : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("ButtonController")] public wCHandle<inkButtonController> ButtonController { get; set; }
		[Ordinal(1)]  [RED("available")] public CBool Available { get; set; }
		[Ordinal(2)]  [RED("craftingFill")] public inkWidgetReference CraftingFill { get; set; }
		[Ordinal(3)]  [RED("craftingLabel")] public inkTextWidgetReference CraftingLabel { get; set; }
		[Ordinal(4)]  [RED("progressController")] public wCHandle<ProgressBarsController> ProgressController { get; set; }

		public ProgressBarButton(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
