using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkLightSweepEffect : inkIEffect
	{
		[Ordinal(0)]  [RED("angle")] public CFloat Angle { get; set; }
		[Ordinal(1)]  [RED("intensity")] public CFloat Intensity { get; set; }
		[Ordinal(2)]  [RED("positionX")] public CFloat PositionX { get; set; }
		[Ordinal(3)]  [RED("positionY")] public CFloat PositionY { get; set; }
		[Ordinal(4)]  [RED("width")] public CFloat Width { get; set; }

		public inkLightSweepEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}