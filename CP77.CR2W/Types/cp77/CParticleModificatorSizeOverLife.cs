using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CParticleModificatorSizeOverLife : IParticleModificator
	{
		[Ordinal(0)]  [RED("modulate")] public CBool Modulate { get; set; }
		[Ordinal(1)]  [RED("scale")] public CFloat Scale { get; set; }
		[Ordinal(2)]  [RED("size")] public CHandle<IEvaluatorVector> Size { get; set; }

		public CParticleModificatorSizeOverLife(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}