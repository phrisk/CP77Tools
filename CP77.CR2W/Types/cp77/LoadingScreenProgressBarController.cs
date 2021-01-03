using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class LoadingScreenProgressBarController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("progressBarFill")] public inkWidgetReference ProgressBarFill { get; set; }
		[Ordinal(1)]  [RED("progressBarRoot")] public inkWidgetReference ProgressBarRoot { get; set; }
		[Ordinal(2)]  [RED("progressSpinerRoot")] public inkWidgetReference ProgressSpinerRoot { get; set; }
		[Ordinal(3)]  [RED("rotationAnimation")] public CHandle<inkanimDefinition> RotationAnimation { get; set; }
		[Ordinal(4)]  [RED("rotationAnimationProxy")] public CHandle<inkanimProxy> RotationAnimationProxy { get; set; }
		[Ordinal(5)]  [RED("rotationInterpolator")] public CHandle<inkanimRotationInterpolator> RotationInterpolator { get; set; }

		public LoadingScreenProgressBarController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}