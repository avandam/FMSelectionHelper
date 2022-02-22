using System.ComponentModel;
// ReSharper disable IdentifierTypo

namespace FMSelectionHelper.Models
{
    public enum RoleType
    {
        [Description("Goalkeeper")] Goalkeeper,
        [Description("Sweeper Keeper")] SweeperKeeper,
        [Description("Full-Back")] FullBack,
        [Description("No-Nonsense Full-Back")] NoNonsenseFullBack,
        [Description("Wing-Back")] WingBack,
        [Description("Complete Wing-Back")] CompleteWingBack,
        [Description("Inverted Wing-Back")] InvertedWingBack,
        [Description("No-Nonsense Centre-Back")] NoNonsenseCentreBack,
        [Description("Central Defender")] CentralDefender,
        [Description("Ball Playing Defender")] BallPlayingDefender,
        [Description("Wide Centre-Back")] WideCentreBack,
        [Description("Libero")] Libero,
        [Description("Anchor")] Anchor,
        [Description("Defensive Midfielder")] DefensiveMidfielder,
        [Description("Half-Back")] HalfBack,
        [Description("Ball Winning Midfielder")] BallWinningMidfielder,
        [Description("Segundo Volante")] SegundoVolante,
        [Description("Deep Lying Playmaker")] DeepLyingPlaymaker,
        [Description("Regista")] Regista,
        [Description("Roaming Playmaker")] RoamingPlaymaker,
        [Description("Winger")] Winger,
        [Description("Inverted Winger")] InvertedWinger,
        [Description("Wide Playmaker")] WidePlaymaker,
        [Description("Defensive Winger")] DefensiveWinger,
        [Description("Wide Midfielder")] WideMidfielder,
        [Description("Inside Forward")] InsideForward,
        [Description("Advanced Playmaker")] AdvancedPlaymaker,
        [Description("Trequartista")] Trequartista,
        [Description("Raumdeuter")] Raumdeuter,
        [Description("WideTargetForward")] WideTargetForward,
        [Description("Mezzala")] Mezzala,
        [Description("CentralMidfielder")] CentralMidfielder,
        [Description("Box To Box Midfielder")] BoxToBoxMidfielder,
        [Description("Carrilero")] Carrilero,
        [Description("Shadow Striker")] ShadowStriker,
        [Description("Attacking Midfielder")] AttackingMidfielder,
        [Description("Enganche")] Enganche,
        [Description("Advanced Forward")] AdvancedForward,
        [Description("Poacher")] Poacher,
        [Description("Flase Nine")] FalseNine,
        [Description("Complete Forward")] CompleteForward,
        [Description("Deep Lying Forward")] DeepLyingForward,
        [Description("Pressing Forward")] PressingForward,
        [Description("Target Forward")] TargetForward
    }

    public static class RoleTypeExtensions
    {
        public static string ToDescriptionString(this RoleType val)
        {
            DescriptionAttribute[] attributes = (DescriptionAttribute[])val
                .GetType()
                .GetField(val.ToString())
                ?.GetCustomAttributes(typeof(DescriptionAttribute), false)!;
            return attributes.Length > 0 ? attributes[0].Description : string.Empty;
        }
    }

}
