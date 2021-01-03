using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ScannerAttitude : ScannerChunk
	{
		[Ordinal(0)]  [RED("attitude")] public CEnum<EAIAttitude> Attitude { get; set; }

		public ScannerAttitude(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}