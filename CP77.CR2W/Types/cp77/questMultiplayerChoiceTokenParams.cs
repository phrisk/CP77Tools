using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questMultiplayerChoiceTokenParams : CVariable
	{
		[Ordinal(0)]  [RED("compatibleDeviceName")] public CName CompatibleDeviceName { get; set; }
		[Ordinal(1)]  [RED("timeout")] public CUInt32 Timeout { get; set; }

		public questMultiplayerChoiceTokenParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
