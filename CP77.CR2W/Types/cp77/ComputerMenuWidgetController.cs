using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ComputerMenuWidgetController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("contentWidget")] public inkWidgetReference ContentWidget { get; set; }
		[Ordinal(1)]  [RED("fileThumbnailWidgetsData")] public CArray<SDocumentThumbnailWidgetPackage> FileThumbnailWidgetsData { get; set; }
		[Ordinal(2)]  [RED("fileWidgetsData")] public CArray<SDocumentWidgetPackage> FileWidgetsData { get; set; }
		[Ordinal(3)]  [RED("isInitialized")] public CBool IsInitialized { get; set; }
		[Ordinal(4)]  [RED("thumbnailsListWidget")] public inkWidgetReference ThumbnailsListWidget { get; set; }

		public ComputerMenuWidgetController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}