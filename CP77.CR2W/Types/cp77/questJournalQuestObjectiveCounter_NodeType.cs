using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questJournalQuestObjectiveCounter_NodeType : questIJournal_NodeType
	{
		[Ordinal(0)]  [RED("path")] public CHandle<gameJournalPath> Path { get; set; }

		public questJournalQuestObjectiveCounter_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}