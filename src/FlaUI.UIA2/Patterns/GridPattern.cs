﻿using FlaUI.Core;
using FlaUI.Core.AutomationElements.Infrastructure;
using FlaUI.Core.Identifiers;
using FlaUI.Core.Patterns;
using FlaUI.UIA2.Converters;
using FlaUI.UIA2.Identifiers;
using UIA = System.Windows.Automation;

namespace FlaUI.UIA2.Patterns
{
    public class GridPattern : GridPatternBase<UIA.GridPattern>
    {
        public static readonly PatternId Pattern = PatternId.Register(AutomationType.UIA2, UIA.GridPattern.Pattern.Id, "Grid", AutomationObjectIds.IsGridPatternAvailableProperty);
        public static readonly PropertyId ColumnCountProperty = PropertyId.Register(AutomationType.UIA2, UIA.GridPattern.ColumnCountProperty.Id, "ColumnCount");
        public static readonly PropertyId RowCountProperty = PropertyId.Register(AutomationType.UIA2, UIA.GridPattern.RowCountProperty.Id, "RowCount");

        public GridPattern(BasicAutomationElementBase basicAutomationElement, UIA.GridPattern nativePattern) : base(basicAutomationElement, nativePattern)
        {
        }

        public override AutomationElement GetItem(int row, int column)
        {
            var nativeItem = NativePattern.GetItem(row, column);
            return AutomationElementConverter.NativeToManaged((UIA2Automation)BasicAutomationElement.Automation, nativeItem);
        }
    }

    public class GridPatternProperties : IGridPatternProperties
    {
        public PropertyId ColumnCountProperty => GridPattern.ColumnCountProperty;

        public PropertyId RowCountProperty => GridPattern.RowCountProperty;
    }
}
