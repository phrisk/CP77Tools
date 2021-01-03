using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldNodeTransform : CVariable
	{
		[Ordinal(0)]  [RED("rotation")] public Quaternion Rotation { get; set; }
		[Ordinal(1)]  [RED("scale")] public Vector3 Scale { get; set; }
		[Ordinal(2)]  [RED("translation")] public Vector3 Translation { get; set; }

		public worldNodeTransform(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}