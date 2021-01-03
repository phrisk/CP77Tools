using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class MenuScenario_BaseMenu : inkMenuScenario
	{
		[Ordinal(0)]  [RED("currMenuName")] public CName CurrMenuName { get; set; }
		[Ordinal(1)]  [RED("currSubMenuName")] public CName CurrSubMenuName { get; set; }
		[Ordinal(2)]  [RED("currUserData")] public CHandle<IScriptable> CurrUserData { get; set; }
		[Ordinal(3)]  [RED("prevMenuName")] public CName PrevMenuName { get; set; }

		public MenuScenario_BaseMenu(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}