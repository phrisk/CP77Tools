using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entAnimatedComponent : entISkinableComponent
	{
		[Ordinal(0)]  [RED("animParameters")] public CArray<entAnimTrackParameter> AnimParameters { get; set; }
		[Ordinal(1)]  [RED("animTags")] public redTagList AnimTags { get; set; }
		[Ordinal(2)]  [RED("animations")] public animAnimSetup Animations { get; set; }
		[Ordinal(3)]  [RED("audioAltName")] public CName AudioAltName { get; set; }
		[Ordinal(4)]  [RED("calculateAccelerationWs")] public CBool CalculateAccelerationWs { get; set; }
		[Ordinal(5)]  [RED("clientForcedLod")] public CInt32 ClientForcedLod { get; set; }
		[Ordinal(6)]  [RED("clientForcedVisibility")] public CBool ClientForcedVisibility { get; set; }
		[Ordinal(7)]  [RED("controlBinding")] public CHandle<entAnimationControlBinding> ControlBinding { get; set; }
		[Ordinal(8)]  [RED("facialSetup")] public raRef<animFacialSetup> FacialSetup { get; set; }
		[Ordinal(9)]  [RED("graph")] public rRef<animAnimGraph> Graph { get; set; }
		[Ordinal(10)]  [RED("rig")] public rRef<animRig> Rig { get; set; }
		[Ordinal(11)]  [RED("serverForcedLod")] public CInt32 ServerForcedLod { get; set; }
		[Ordinal(12)]  [RED("serverForcedVisibility")] public CBool ServerForcedVisibility { get; set; }
		[Ordinal(13)]  [RED("useLongRangeVisibility")] public CBool UseLongRangeVisibility { get; set; }

		public entAnimatedComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
