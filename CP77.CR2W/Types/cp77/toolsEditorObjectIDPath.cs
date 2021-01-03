using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class toolsEditorObjectIDPath : CVariable
	{
		[Ordinal(0)]  [RED("elements")] public CArray<EditorObjectID> Elements { get; set; }

		public toolsEditorObjectIDPath(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}