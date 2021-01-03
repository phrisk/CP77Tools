using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class curveSingleChannelCurve : CVariable
	{
		[Ordinal(0)]  [RED("data")] public DataBuffer Data { get; set; }
		[Ordinal(1)]  [RED("interpolationType")] public CEnum<curveEInterpolationType> InterpolationType { get; set; }
		[Ordinal(2)]  [RED("linkType")] public CEnum<curveESegmentsLinkType> LinkType { get; set; }

		public curveSingleChannelCurve(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}