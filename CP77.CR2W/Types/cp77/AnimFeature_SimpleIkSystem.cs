using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_SimpleIkSystem : animAnimFeature
	{
		[Ordinal(0)]  [RED("isEnable")] public CBool IsEnable { get; set; }
		[Ordinal(1)]  [RED("position")] public Vector4 Position { get; set; }
		[Ordinal(2)]  [RED("positionOffset")] public Vector4 PositionOffset { get; set; }
		[Ordinal(3)]  [RED("rotation")] public Quaternion Rotation { get; set; }
		[Ordinal(4)]  [RED("rotationOffset")] public Quaternion RotationOffset { get; set; }
		[Ordinal(5)]  [RED("setPosition")] public CBool SetPosition { get; set; }
		[Ordinal(6)]  [RED("setRotation")] public CBool SetRotation { get; set; }
		[Ordinal(7)]  [RED("weight")] public CFloat Weight { get; set; }

		public AnimFeature_SimpleIkSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}