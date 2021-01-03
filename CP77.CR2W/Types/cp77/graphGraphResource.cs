using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class graphGraphResource : CResource
	{
		[Ordinal(0)]  [RED("graph")] public CHandle<graphGraphDefinition> Graph { get; set; }

		public graphGraphResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}