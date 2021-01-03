using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class LibTreeDefFloat : CVariable
	{
		[Ordinal(0)]  [RED("treeVariable")] public CName TreeVariable { get; set; }
		[Ordinal(1)]  [RED("v")] public CFloat V { get; set; }
		[Ordinal(2)]  [RED("variableId")] public CUInt16 VariableId { get; set; }

		public LibTreeDefFloat(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}