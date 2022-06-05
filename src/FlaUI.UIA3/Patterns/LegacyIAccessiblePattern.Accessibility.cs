#if NETFRAMEWORK
using Accessibility;
using FlaUI.Core.Tools;
using FlaUI.Core.Patterns;
using UIA = Interop.UIAutomationClient;

namespace FlaUI.UIA3.Patterns
{
    public partial class LegacyIAccessiblePattern : LegacyIAccessiblePatternBase<UIA.IUIAutomationLegacyIAccessiblePattern>
    {
        public override IAccessible GetIAccessible()
        {
            // ReSharper disable once SuspiciousTypeConversion.Global
            return Com.Call(() => (IAccessible)NativePattern.GetIAccessible());
        }
    }
}
#endif
