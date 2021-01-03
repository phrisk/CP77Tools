using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldHeatmapSetup : CVariable
	{
		[Ordinal(0)]  [RED("horizontalResolution")] public CUInt32 HorizontalResolution { get; set; }
		[Ordinal(1)]  [RED("verticalResolution")] public CUInt32 VerticalResolution { get; set; }
		[Ordinal(2)]  [RED("volumeBox")] public Box VolumeBox { get; set; }

		public worldHeatmapSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}