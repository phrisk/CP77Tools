using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class interopStringWithID : CVariable
	{
		[Ordinal(0)]  [RED("id")] public CUInt64 Id { get; set; }
		[Ordinal(1)]  [RED("text")] public CString Text { get; set; }

		public interopStringWithID(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}