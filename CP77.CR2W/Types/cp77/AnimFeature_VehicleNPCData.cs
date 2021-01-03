using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_VehicleNPCData : animAnimFeature
	{
		[Ordinal(0)]  [RED("isDriver")] public CBool IsDriver { get; set; }
		[Ordinal(1)]  [RED("side")] public CInt32 Side { get; set; }

		public AnimFeature_VehicleNPCData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}