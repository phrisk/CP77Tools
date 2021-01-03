using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class OpenWorldMapNotificationAction : GenericNotificationBaseAction
	{
		[Ordinal(0)]  [RED("eventDispatcher")] public wCHandle<worlduiIWidgetGameController> EventDispatcher { get; set; }

		public OpenWorldMapNotificationAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}