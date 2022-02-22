using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMSelectionHelper.Models
{
    public enum Duty
    {
        [Description("(De)")] Defend,
        [Description("(Su)")] Support,
        [Description("(At)")] Attack,
        [Description("(Au)")] Automatic,
        [Description("(Co)")] Cover,
        [Description("(St)")] Stopper
    }

    public static class DutyExtensions
    {
        public static string ToDescriptionString(this Duty val)
        {
            DescriptionAttribute[] attributes = (DescriptionAttribute[])val
                .GetType()
                .GetField(val.ToString())
                ?.GetCustomAttributes(typeof(DescriptionAttribute), false)!;
            return attributes.Length > 0 ? attributes[0].Description : string.Empty;
        }
    }

}
