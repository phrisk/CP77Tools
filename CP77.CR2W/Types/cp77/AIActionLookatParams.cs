using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIActionLookatParams : CVariable
	{
		[Ordinal(0)]  [RED("additionalParts")] public CArray<animLookAtPartRequest> AdditionalParts { get; set; }
		[Ordinal(1)]  [RED("attachLeftHandtoRightHand")] public CBool AttachLeftHandtoRightHand { get; set; }
		[Ordinal(2)]  [RED("attachRightHandtoLeftHand")] public CBool AttachRightHandtoLeftHand { get; set; }
		[Ordinal(3)]  [RED("backLimitDegrees")] public CEnum<animLookAtLimitDegreesType> BackLimitDegrees { get; set; }
		[Ordinal(4)]  [RED("hardLimitDegrees")] public CEnum<animLookAtLimitDegreesType> HardLimitDegrees { get; set; }
		[Ordinal(5)]  [RED("hardLimitDistance")] public CEnum<animLookAtLimitDistanceType> HardLimitDistance { get; set; }
		[Ordinal(6)]  [RED("hasOutTransition")] public CBool HasOutTransition { get; set; }
		[Ordinal(7)]  [RED("lookatStyle")] public CEnum<animLookAtStyle> LookatStyle { get; set; }
		[Ordinal(8)]  [RED("outTransitionStyle")] public CEnum<animLookAtStyle> OutTransitionStyle { get; set; }
		[Ordinal(9)]  [RED("slotName")] public CName SlotName { get; set; }
		[Ordinal(10)]  [RED("softLimitDegrees")] public CEnum<animLookAtLimitDegreesType> SoftLimitDegrees { get; set; }
		[Ordinal(11)]  [RED("useLeftHand")] public CBool UseLeftHand { get; set; }
		[Ordinal(12)]  [RED("useLookat")] public CBool UseLookat { get; set; }
		[Ordinal(13)]  [RED("useRightHand")] public CBool UseRightHand { get; set; }

		public AIActionLookatParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}