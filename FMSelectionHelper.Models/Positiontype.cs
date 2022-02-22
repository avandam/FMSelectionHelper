using System.ComponentModel;

// ReSharper disable InconsistentNaming

namespace FMSelectionHelper.Models
{
    public enum PositionType
    {
        [Description("GK")] GK,
        [Description("DL")] DL,
        [Description("DC")] DC,
        [Description("DCL")] DCL,
        [Description("DCR")] DCR,
        [Description("DR")] DR,
        [Description("WBL")] WBL,
        [Description("WBR")] WBR,
        [Description("DM")] DM,
        [Description("ML")] ML,
        [Description("MC")] MC,
        [Description("MCL")] MCL,
        [Description("MCR")] MCR,
        [Description("MR")] MR,
        [Description("AML")] AML,
        [Description("AMC")] AMC,
        [Description("AMR")] AMR,
        [Description("ST")] ST
    }

    public static class PositionTypeExtensions
    {
        public static string ToDescriptionString(this PositionType val)
        {
            DescriptionAttribute[] attributes = (DescriptionAttribute[])val
                .GetType()
                .GetField(val.ToString())
                ?.GetCustomAttributes(typeof(DescriptionAttribute), false)!;
            return attributes.Length > 0 ? attributes[0].Description : string.Empty;
        }
    }

}
