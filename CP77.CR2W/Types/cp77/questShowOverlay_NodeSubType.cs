using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questShowOverlay_NodeSubType : questITutorial_NodeSubType
	{
		[Ordinal(0)]  [RED("hideOnInput")] public CBool HideOnInput { get; set; }
		[Ordinal(1)]  [RED("libraryItemName")] public CName LibraryItemName { get; set; }
		[Ordinal(2)]  [RED("lockPlayerMovement")] public CBool LockPlayerMovement { get; set; }
		[Ordinal(3)]  [RED("overlayLibrary")] public raRef<inkWidgetLibraryResource> OverlayLibrary { get; set; }
		[Ordinal(4)]  [RED("pauseGame")] public CBool PauseGame { get; set; }
		[Ordinal(5)]  [RED("visible")] public CBool Visible { get; set; }

		public questShowOverlay_NodeSubType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
