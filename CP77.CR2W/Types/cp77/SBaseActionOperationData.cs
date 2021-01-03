using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SBaseActionOperationData : CVariable
	{
		[Ordinal(0)]  [RED("action")] public CHandle<ScriptableDeviceAction> Action { get; set; }
		[Ordinal(1)]  [RED("operation")] public SBaseDeviceOperationData Operation { get; set; }

		public SBaseActionOperationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}