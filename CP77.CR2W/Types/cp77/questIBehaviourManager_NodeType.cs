using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questIBehaviourManager_NodeType : questIRetNodeType
	{
		[Ordinal(0)]  [RED("puppetRef")] public gameEntityReference PuppetRef { get; set; }

		public questIBehaviourManager_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}