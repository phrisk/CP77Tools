using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class TVDeviceBlackboardDef : DeviceBaseBlackboardDef
	{
		[Ordinal(0)]  [RED("CurrentChannel")] public gamebbScriptID_Int32 CurrentChannel { get; set; }
		[Ordinal(1)]  [RED("PreviousChannel")] public gamebbScriptID_Int32 PreviousChannel { get; set; }

		public TVDeviceBlackboardDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}