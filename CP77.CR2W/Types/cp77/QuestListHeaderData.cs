using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class QuestListHeaderData : IScriptable
	{
		[Ordinal(0)]  [RED("nameLocKey")] public CName NameLocKey { get; set; }
		[Ordinal(1)]  [RED("type")] public CInt32 Type { get; set; }

		public QuestListHeaderData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}