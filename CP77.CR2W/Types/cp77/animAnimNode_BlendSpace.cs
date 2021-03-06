using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_BlendSpace : animAnimNode_Base
	{
		[Ordinal(0)]  [RED("animEndEventName")] public CName AnimEndEventName { get; set; }
		[Ordinal(1)]  [RED("blendSpace")] public animAnimNode_BlendSpace_InternalsBlendSpace BlendSpace { get; set; }
		[Ordinal(2)]  [RED("fireAnimEndEvent")] public CBool FireAnimEndEvent { get; set; }
		[Ordinal(3)]  [RED("inputLinks")] public CArray<animFloatLink> InputLinks { get; set; }
		[Ordinal(4)]  [RED("isLooped")] public CBool IsLooped { get; set; }
		[Ordinal(5)]  [RED("progressLink")] public animFloatLink ProgressLink { get; set; }

		public animAnimNode_BlendSpace(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
