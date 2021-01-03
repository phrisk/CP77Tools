using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class RootMotionCommandHandler : AICommandHandlerBase
	{
		[Ordinal(0)]  [RED("params")] public CHandle<AIArgumentMapping> Params { get; set; }

		public RootMotionCommandHandler(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}