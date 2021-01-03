using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class DestructibleMasterDeviceControllerPS : MasterControllerPS
	{
		[Ordinal(0)]  [RED("isDestroyed")] public CBool IsDestroyed { get; set; }

		public DestructibleMasterDeviceControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}