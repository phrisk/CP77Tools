using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class PSODescRasterizerModeDesc : CVariable
	{
		[Ordinal(0)]  [RED("allowMSAA")] public CBool AllowMSAA { get; set; }
		[Ordinal(1)]  [RED("conservativeRasterization")] public CBool ConservativeRasterization { get; set; }
		[Ordinal(2)]  [RED("cullMode")] public CEnum<PSODescRasterizerModeCullMode> CullMode { get; set; }
		[Ordinal(3)]  [RED("frontWinding")] public CEnum<PSODescRasterizerModeFrontFaceWinding> FrontWinding { get; set; }
		[Ordinal(4)]  [RED("offsetMode")] public CEnum<PSODescRasterizerModeOffsetMode> OffsetMode { get; set; }
		[Ordinal(5)]  [RED("scissors")] public CBool Scissors { get; set; }
		[Ordinal(6)]  [RED("valid")] public CBool Valid { get; set; }
		[Ordinal(7)]  [RED("wireframe")] public CBool Wireframe { get; set; }

		public PSODescRasterizerModeDesc(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}