using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questEntityManagerSetMeshAppearance_NodeType : questIEntityManager_NodeType
	{
		[Ordinal(0)]  [RED("params")] public CArray<questEntityManagerSetMeshAppearance_NodeTypeParams> Params { get; set; }

		public questEntityManagerSetMeshAppearance_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
