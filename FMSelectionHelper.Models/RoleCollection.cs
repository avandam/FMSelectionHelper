// ReSharper disable IdentifierTypo
namespace FMSelectionHelper.Models
{
    public sealed class RoleCollection
    {
        public static RoleCollection Instance { get; } = new RoleCollection();

        private List<Role> roles = new List<Role>();

        static RoleCollection()
        {

        }

        private RoleCollection()
        {
            CreateRoles();
        }
        
        private void CreateRoles()
        {
            roles = new List<Role>();
            CreateGoalKeeperRoles();
            CreateSweeperKeeperRoles();
            CreateFullBackRoles();
            CreateNoNonsenseFullBackRoles();
            CreateWingBackRoles();
            CreateCompleteWingBackRoles();
            CreateInvertedWingBackRoles();
            CreateNoNonsenseCentreBackRoles();
            CreateCentralDefenderRoles();
            CreateBallPlayingDefenderRoles();
            CreateWideCentreBackRoles();
            CreateLiberoRoles();
            CreateAnchorRoles();
            CreateDefensiveMidfielderRoles();
            CreateHalfBackRoles();
            CreateBallWinningMidfielderRoles();
            CreateSegundoVolanteRoles();
            CreateDeepLyingPlaymakerRoles();
            CreateRegistaRoles();
            CreateRoamingPlaymakerRoles();
            CreateWingerRoles();
            CreateInvertedWingerRoles();
            CreateWidePlaymakerRoles();
            CreateDefensiveWingerRoles();
            CreateWideMidfielderRoles();
            CreateInsideForwardRoles();
            CreateAdvancedPlaymakerRoles();
            CreateTrequartistaRoles();
            CreateRaumdeuterRoles();
            CreateWideTargetForwardRoles();
            CreateMezzalaRoles();
            CreateCentralMidfielderRoles();
            CreateBoxToBoxMidfielderRoles();
            CreateCarrileroRoles();
            CreateShadowStrikerRoles();
            CreateAttackingMidfielderRoles();
            CreateEngancheRoles();
            CreateAdvancedForwardRoles();
            CreatePoacherRoles();
            CreateFalseNineRoles();
            CreateCompleteForwardRoles();
            CreateDeepLyingForwardRoles();
            CreatePressingForwardRoles();
            CreateTargetForwardRoles();
        }

        private void CreateGoalKeeperRoles()
        {
            var keyAttributes = new List<string> { "Aer", "Cmd", "Com", "Han", "Kic", "Ref", "Cnt", "Pos", "Agi" };
            var preferableAttributes = new List<string> { "1v1", "Thr", "Ant", "Dec" };

            roles.Add(new Role(RoleType.Goalkeeper, Duty.Defend, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));

        }

        private void CreateSweeperKeeperRoles()
        {
            var keyAttributes = new List<string> { "Aer", "Cmd", "Com", "Han", "Kic", "Ref", "Cnt", "Pos", "Agi" };
            var preferableAttributes = new List<string> { "1v1", "Thr", "Ant", "Dec" };

            roles.Add(new Role(RoleType.Goalkeeper, Duty.Defend, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));

            keyAttributes = new List<string> { "Cmd", "Kic", "1v1", "Ref", "Ant", "Cnt", "Pos", "Agi" };
            preferableAttributes = new List<string> { "Aer", "Com", "Fir", "Han", "Pas", "TRO", "Thr", "Cmp", "Dec", "Vis", "Acc" };

            roles.Add(new Role(RoleType.SweeperKeeper, Duty.Defend, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));

            keyAttributes = new List<string> { "Cmd", "Kic", "1v1", "Ref", "TRO", "Ant", "Cmp", "Cnt", "Pos", "Agi" };
            preferableAttributes = new List<string> { "Aer", "Com", "Fir", "Han", "Pas", "Thr", "Dec", "Vis", "Acc" };

            roles.Add(new Role(RoleType.SweeperKeeper, Duty.Support, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));

            keyAttributes = new List<string> { "Cmd", "Kic", "1v1", "Ref", "Ant", "Cnt", "Pos", "Agi" };
            preferableAttributes = new List<string> { "Aer", "Com", "Ecc", "Fir", "Han", "Pas", "TRO", "Thr", "Cmp", "Dec", "Vis", "Acc" };

            roles.Add(new Role(RoleType.SweeperKeeper, Duty.Attack, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));
        }
        
        private void CreateFullBackRoles()
        {
            var keyAttributes = new List<string> { "Mar", "Tck", "Ant", "Cnt", "Pos" };
            var preferableAttributes = new List<string> { "Cro", "Pas", "Cmp", "Dec", "Tea", "Pac", "Sta" };

            roles.Add(new Role(RoleType.FullBack, Duty.Defend, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));

            keyAttributes = new List<string> { "Mar", "Tck", "Ant", "Cnt", "Pos", "Tea", "Wor" };
            preferableAttributes = new List<string> { "Cro", "Dri", "Pas", "Tec", "Cmp", "Dec", "Pac", "Sta" };

            roles.Add(new Role(RoleType.FullBack, Duty.Support, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));
            roles.Add(new Role(RoleType.FullBack, Duty.Automatic, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));

            keyAttributes = new List<string> { "Cro", "Tck", "Ant", "Pos", "Tea", "Wor", "Pac", "Sta" };
            preferableAttributes = new List<string> { "Dri", "Fir", "Mar", "Pas", "Tec", "Cmp", "Cnt", "Dec", "OtB", "Acc", "Agi" };

            roles.Add(new Role(RoleType.FullBack, Duty.Attack, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));
        }

        private void CreateNoNonsenseFullBackRoles()
        {
            var keyAttributes = new List<string> { "Mar", "Tck", "Ant", "Pos", "Str" };
            var preferableAttributes = new List<string> { "Hea", "Agg", "Bra", "Cnt", "Tea" };

            roles.Add(new Role(RoleType.NoNonsenseFullBack, Duty.Defend, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));
        }

        private void CreateWingBackRoles()
        {
            var keyAttributes = new List<string> { "Mar", "Tck", "Ant", "Pos", "Tea", "Wor", "Acc", "Sta" };
            var preferableAttributes = new List<string> { "Cro", "Dri", "Fir", "Pas", "Tec", "Cnt", "Dec", "OtB", "Agi", "Pac" };

            roles.Add(new Role(RoleType.WingBack, Duty.Defend, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));

            keyAttributes = new List<string> { "Cro", "Dri", "Mar", "Tck", "OtB", "Tea", "Wor", "Acc", "Sta" };
            preferableAttributes = new List<string> { "Fir", "Pas", "Tec", "Ant", "Cnt", "Dec", "Pos", "Agi", "Pac" };

            roles.Add(new Role(RoleType.WingBack, Duty.Support, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));
            roles.Add(new Role(RoleType.WingBack, Duty.Automatic, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));

            keyAttributes = new List<string> { "Cro", "Dri", "Mar", "Tck", "OtB", "Tea", "Wor", "Acc", "Sta" };
            preferableAttributes = new List<string> { "Fir", "Pas", "Tec", "Ant", "Cnt", "Dec", "Fla", "Pos", "Agi", "Pac" };

            roles.Add(new Role(RoleType.WingBack, Duty.Attack, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));
        }

        private void CreateCompleteWingBackRoles()
        {
            var keyAttributes = new List<string> { "Cro", "Dri", "Fir", "Pas", "Tec", "Dec", "OtB", "Tea", "Wor", "Acc", "Pac", "Sta" };
            var preferableAttributes = new List<string> { "Tck", "Ant", "Cmp", "Fla", "Agi", "Bal" };

            roles.Add(new Role(RoleType.CompleteWingBack, Duty.Support, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));

            keyAttributes = new List<string> { "Cro", "Dri", "Fir", "Pas", "Tec", "Dec", "Fla", "OtB", "Tea", "Wor", "Acc", "Pac", "Sta" };
            preferableAttributes = new List<string> { "Tck", "Ant", "Cmp", "Agi", "Bal" };

            roles.Add(new Role(RoleType.CompleteWingBack, Duty.Attack, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));
        }

        private void CreateInvertedWingBackRoles()
        {
            var keyAttributes = new List<string> { "Mar", "Pas", "Tck", "Ant", "Dec", "Pos", "Tea", "Wor" };
            var preferableAttributes = new List<string> { "Dri", "Fir", "Tec", "Cnt", "OtB", "Acc", "Agi", "Sta" };

            roles.Add(new Role(RoleType.InvertedWingBack, Duty.Defend, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));

            keyAttributes = new List<string> { "Mar", "Pas", "Tck", "Dec", "OtB", "Tea", "Wor", "Sta" };
            preferableAttributes = new List<string> { "Dri", "Fir", "Tec", "Ant", "Cmp", "Cnt", "Pos", "Acc", "Agi" };

            roles.Add(new Role(RoleType.InvertedWingBack, Duty.Support, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));
            roles.Add(new Role(RoleType.InvertedWingBack, Duty.Automatic, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));

            keyAttributes = new List<string> { "Dri", "Mar", "Pas", "Tck", "Tec", "Dec", "OtB", "Tea", "Wor", "Acc", "Sta" };
            preferableAttributes = new List<string> { "Fir", "Lon", "Ant", "Cmp", "Cnt", "Fla", "Pos", "Agi", "Pac" };

            roles.Add(new Role(RoleType.InvertedWingBack, Duty.Attack, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));
        }

        private void CreateNoNonsenseCentreBackRoles()
        {
            var keyAttributes = new List<string> { "Hea", "Mar", "Tck", "Pos", "Jum", "Str" };
            var preferableAttributes = new List<string> { "Agg", "Ant", "Bra", "Cnt", "Pac" };

            roles.Add(new Role(RoleType.NoNonsenseCentreBack, Duty.Defend, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));

            keyAttributes = new List<string> { "Hea", "Tck", "Agg", "Bra", "Pos", "Jum", "Str" };
            preferableAttributes = new List<string> { "Mar", "Ant", "Cnt" };

            roles.Add(new Role(RoleType.NoNonsenseCentreBack, Duty.Stopper, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));

            keyAttributes = new List<string> { "Mar", "Tck", "Ant", "Cnt", "Pos", "Pac" };
            preferableAttributes = new List<string> { "Hea", "Bra", "Jum", "Str" };

            roles.Add(new Role(RoleType.NoNonsenseCentreBack, Duty.Cover, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));
        }

        private void CreateCentralDefenderRoles()
        {
            var keyAttributes = new List<string> { "Hea", "Mar", "Tck", "Pos", "Jum", "Str" };
            var preferableAttributes = new List<string> { "Agg", "Ant", "Bra", "Cmp", "Cnt", "Dec", "Pac" };

            roles.Add(new Role(RoleType.CentralDefender, Duty.Defend, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));

            keyAttributes = new List<string> { "Hea", "Tck", "Agg", "Bra", "Dec", "Pos", "Jum", "Str" };
            preferableAttributes = new List<string> { "Mar", "Ant", "Cmp", "Cnt" };

            roles.Add(new Role(RoleType.CentralDefender, Duty.Stopper, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));

            keyAttributes = new List<string> { "Mar", "Tck", "Ant", "Cnt", "Dec", "Pos", "Pac" };
            preferableAttributes = new List<string> { "Hea", "Bra", "Cmp", "Jum", "Str" };

            roles.Add(new Role(RoleType.CentralDefender, Duty.Cover, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));
        }

        private void CreateBallPlayingDefenderRoles()
        {
            var keyAttributes = new List<string> { "Hea", "Mar", "Pas", "Tck", "Cmp", "Pos", "Jum", "Str" };
            var preferableAttributes = new List<string> { "Fir", "Tec", "Agg", "Ant", "Bra", "Cnt", "Dec", "Vis", "Pac" };

            roles.Add(new Role(RoleType.BallPlayingDefender, Duty.Defend, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));

            keyAttributes = new List<string> { "Hea", "Pas", "Tck", "Agg", "Bra", "Cmp", "Dec", "Pos", "Jum", "Str" };
            preferableAttributes = new List<string> { "Fir", "Mar", "Tec", "Ant", "Cnt", "Vis" };

            roles.Add(new Role(RoleType.BallPlayingDefender, Duty.Stopper, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));

            keyAttributes = new List<string> { "Mar", "Pas", "Tck", "Ant", "Cmp", "Cnt", "Dec", "Pos", "Pac" };
            preferableAttributes = new List<string> { "Fir", "Mar", "Tec", "Bra", "Vis", "Jum", "Str" };

            roles.Add(new Role(RoleType.BallPlayingDefender, Duty.Cover, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));
        }

        private void CreateWideCentreBackRoles()
        {
            var keyAttributes = new List<string> { "Cro", "Hea", "Mar", "Tck", "Pos", "Jum", "Sta", "Str" };
            var preferableAttributes = new List<string> { "Dri", "Agg", "Ant", "Bra", "Cmp", "Cnt", "Dec", "Wor", "Pac" };

            roles.Add(new Role(RoleType.WideCentreBack, Duty.Defend, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));

            keyAttributes = new List<string> { "Cro", "Dri", "Hea", "Mar", "Tck", "Pos", "Jum", "Pac", "Sta", "Str" };
            preferableAttributes = new List<string> { "Agg", "Ant", "Bra", "Cmp", "Cnt", "Dec", "OtB", "Wor", };

            roles.Add(new Role(RoleType.WideCentreBack, Duty.Support, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));

            keyAttributes = new List<string> { "Cro", "Dri", "Hea", "Mar", "Tck", "OtB", "Jum", "Pac", "Sta", "Str" };
            preferableAttributes = new List<string> { "Agg", "Ant", "Bra", "Cmp", "Cnt", "Dec", "Pos", "Wor", };

            roles.Add(new Role(RoleType.WideCentreBack, Duty.Attack, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));
        }

        private void CreateLiberoRoles()
        {
            var keyAttributes = new List<string> { "Fir", "Mar", "Pas", "Tck", "Ant", "Cmp", "Cnt", "Dec", "Pos", "Tea", "Vis", "Pac" };
            var preferableAttributes = new List<string> { "Dri", "Hea", "Tec", "Bra", "Fla", "Agi", "Bal", "Jum", "Sta", "Str" };

            roles.Add(new Role(RoleType.Libero, Duty.Support, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));

            keyAttributes = new List<string> { "Dri", "Fir", "Mar", "Pas", "Tck", "Ant", "Cmp", "Cnt", "Dec", "Fla", "Pos", "Tea", "Vis", "Pac" };
            preferableAttributes = new List<string> { "Hea", "Lon", "Tec", "Bra", "Acc", "Agi", "Bal", "Jum", "Sta", "Str" };

            roles.Add(new Role(RoleType.Libero, Duty.Attack, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));
        }

        private void CreateAnchorRoles()
        {
            var keyAttributes = new List<string> { "Mar", "Tck", "Ant", "Cnt", "Dec", "Pos" };
            var preferableAttributes = new List<string> { "Cmp", "Tea", "Str" };

            roles.Add(new Role(RoleType.Anchor, Duty.Defend, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));
        }

        private void CreateDefensiveMidfielderRoles()
        {
            var keyAttributes = new List<string> { "Tck", "Ant", "Cnt", "Pos", "Tea" };
            var preferableAttributes = new List<string> { "Mar", "Pas", "Ant", "Cmp", "Dec", "Wor", "Sta", "Str" };

            roles.Add(new Role(RoleType.DefensiveMidfielder, Duty.Defend, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));

            keyAttributes = new List<string> { "Tck", "Ant", "Cnt", "Pos", "Tea" };
            preferableAttributes = new List<string> { "Fir", "Mar", "Pas", "Ant", "Cmp", "Dec", "Wor", "Sta", "Str" };

            roles.Add(new Role(RoleType.DefensiveMidfielder, Duty.Support, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));
        }
        
        private void CreateHalfBackRoles()
        {
            var keyAttributes = new List<string> { "Mar", "Tck", "Ant", "Cmp", "Cnt", "Dec", "Pos", "Tea" };
            var preferableAttributes = new List<string> { "Fir", "Pas", "Agg", "Bra", "Wor", "Jum", "Sta", "Str" };

            roles.Add(new Role(RoleType.HalfBack, Duty.Defend, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));
        }

        private void CreateBallWinningMidfielderRoles()
        {
            var keyAttributes = new List<string> { "Fir", "Agg", "Ant", "Tea", "Wor", "Sta" };
            var preferableAttributes = new List<string> { "Mar", "Bra", "Cnt", "Pos", "Agi", "Pac", "Str" };

            roles.Add(new Role(RoleType.BallWinningMidfielder, Duty.Defend, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));

            keyAttributes = new List<string> { "Tck", "Agg", "Ant", "Tea", "Wor", "Sta" };
            preferableAttributes = new List<string> { "Mar", "Pas", "Bra", "Cnt", "Agi", "Pac", "Str" };

            roles.Add(new Role(RoleType.BallWinningMidfielder, Duty.Support, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));
        }

        private void CreateSegundoVolanteRoles()
        {
            var keyAttributes = new List<string> { "Mar", "Pas", "Tck", "OtB", "Pos", "Wor", "Pac", "Sta" };
            var preferableAttributes = new List<string> { "Fin", "Fir", "Lon", "Ant", "Cmp", "Cnt", "Dec", "Acc", "Bal", "Str" };

            roles.Add(new Role(RoleType.SegundoVolante, Duty.Support, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));

            keyAttributes = new List<string> { "Fin", "Lon", "Pas", "Tck", "Ant", "OtB", "Pos", "Wor", "Pac", "Sta" };
            preferableAttributes = new List<string> { "Fir", "Mar", "Cmp", "Cnt", "Dec", "Acc", "Bal", "Str" };

            roles.Add(new Role(RoleType.SegundoVolante, Duty.Attack, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));
        }

        private void CreateDeepLyingPlaymakerRoles()
        {
            var keyAttributes = new List<string> { "Fir", "Pas", "Tec", "Cmp", "Dec", "Tea", "Vis" };
            var preferableAttributes = new List<string> { "Tck", "Ant", "Pos", "Bal" };

            roles.Add(new Role(RoleType.DeepLyingPlaymaker, Duty.Defend, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));

            keyAttributes = new List<string> { "Fir", "Pas", "Tec", "Cmp", "Dec", "Tea", "Vis" };
            preferableAttributes = new List<string> { "Ant", "OtB", "Pos", "Bal" };

            roles.Add(new Role(RoleType.DeepLyingPlaymaker, Duty.Support, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));
        }

        private void CreateRegistaRoles()
        {
            var keyAttributes = new List<string> { "Fir", "Pas", "Tec", "Cmp", "Dec", "Fla", "OtB", "Tea", "Vis" };
            var preferableAttributes = new List<string> { "Dri", "Lon", "Ant", "Bal" };

            roles.Add(new Role(RoleType.Regista, Duty.Support, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));
        }

        private void CreateRoamingPlaymakerRoles()
        {
            var keyAttributes = new List<string> { "Fir", "Pas", "Tec", "Ant", "Cmp", "Dec", "OtB", "Tea", "Vis", "Wor", "Acc", "Sta" };
            var preferableAttributes = new List<string> { "Dri", "Lon", "Cnt", "Pos", "Agi", "Bal", "Pac" };

            roles.Add(new Role(RoleType.RoamingPlaymaker, Duty.Support, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));
        }

        private void CreateWingerRoles()
        {
            var keyAttributes = new List<string> { "Cro", "Dri", "Tec", "OtB", "Acc", "Pac" };
            var preferableAttributes = new List<string> { "Fir", "Pas", "Wor", "Agi", "Sta" };

            roles.Add(new Role(RoleType.Winger, Duty.Support, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));

            keyAttributes = new List<string> { "Cro", "Dri", "Tec", "OtB", "Acc", "Pac" };
            preferableAttributes = new List<string> { "Fir", "Pas", "Ant", "Fla", "Agi" };

            roles.Add(new Role(RoleType.Winger, Duty.Attack, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));
        }

        private void CreateInvertedWingerRoles()
        {
            var keyAttributes = new List<string> { "Dri", "Pas", "Tec", "OtB", "Acc" };
            var preferableAttributes = new List<string> { "Cro", "Fir", "Lon", "Cmp", "Dec", "Vis", "Wor", "Agi", "Pac", "Sta" };

            roles.Add(new Role(RoleType.InvertedWinger, Duty.Support, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));

            keyAttributes = new List<string> { "Dri", "Pas", "Tec", "OtB", "Acc", "Agi" };
            preferableAttributes = new List<string> { "Cro", "Fir", "Lon", "Ant", "Cmp", "Dec", "Fla", "Vis", "Pac" };

            roles.Add(new Role(RoleType.InvertedWinger, Duty.Attack, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));
        }

        private void CreateWidePlaymakerRoles()
        {
            var keyAttributes = new List<string> { "Fir", "Pas", "Tec", "Cmp", "Dec", "Tea", "Vis" };
            var preferableAttributes = new List<string> { "Dri", "OtB", "Agi" };

            roles.Add(new Role(RoleType.WidePlaymaker, Duty.Support, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));

            keyAttributes = new List<string> { "Dri", "Fir", "Pas", "Tec", "Cmp", "Dec", "OtB", "Tea", "Vis" };
            preferableAttributes = new List<string> { "Ant", "Fla", "Acc", "Agi" };

            roles.Add(new Role(RoleType.WidePlaymaker, Duty.Attack, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));
        }

        private void CreateDefensiveWingerRoles()
        {
            var keyAttributes = new List<string> { "Tec", "Ant", "OtB", "Pos", "Tea", "Wor", "Sta" };
            var preferableAttributes = new List<string> { "Cro", "Dri", "Fir", "Mar", "Tck", "Agg", "Cnt", "Dec", "Acc" };

            roles.Add(new Role(RoleType.DefensiveWinger, Duty.Defend, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));

            keyAttributes = new List<string> { "Cro", "Tec", "OtB", "Tea", "Wor", "Sta" };
            preferableAttributes = new List<string> { "Dri", "Fir", "Mar", "Pas", "Tck", "Agg", "Ant", "Cmp", "Cnt", "Dec", "Pos", "Acc" };

            roles.Add(new Role(RoleType.DefensiveWinger, Duty.Support, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));
        }

        private void CreateWideMidfielderRoles()
        {
            var keyAttributes = new List<string> { "Pas", "Tck", "Cnt", "Dec", "Pos", "Tea", "Wor" };
            var preferableAttributes = new List<string> { "Cro", "Fir", "Mar", "Tec", "Ant", "Cmp", "Sta" };

            roles.Add(new Role(RoleType.WideMidfielder, Duty.Defend, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));

            keyAttributes = new List<string> { "Pas", "Tck", "Dec", "Tea", "Wor", "Sta" };
            preferableAttributes = new List<string> { "Cro", "Fir", "Tec", "Ant", "Cmp", "Cnt", "OtB", "Pos", "Vis" };

            roles.Add(new Role(RoleType.WideMidfielder, Duty.Support, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));
            roles.Add(new Role(RoleType.WideMidfielder, Duty.Automatic, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));

            keyAttributes = new List<string> { "Cro", "Fir", "Pas", "Dec", "Tea", "Wor", "Sta" };
            preferableAttributes = new List<string> { "Tck", "Tec", "Ant", "Cmp", "OtB", "Vis" };

            roles.Add(new Role(RoleType.WideMidfielder, Duty.Attack, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));
        }

        private void CreateInsideForwardRoles()
        {
            var keyAttributes = new List<string> { "Dri", "Fir", "Pas", "Tec", "OtB", "Acc", "Agi", "Bal" };
            var preferableAttributes = new List<string> { "Fin", "Lon", "Ant", "Cmp", "Fla", "Vis", "Pac" };

            roles.Add(new Role(RoleType.InsideForward, Duty.Support, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));

            keyAttributes = new List<string> { "Dri", "Fin", "Fir", "Tec", "OtB", "Acc", "Agi", "Bal" };
            preferableAttributes = new List<string> { "Lon", "Pas", "Ant", "Cmp", "Fla", "Pac" };

            roles.Add(new Role(RoleType.InsideForward, Duty.Attack, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));
        }

        private void CreateAdvancedPlaymakerRoles()
        {
            var keyAttributes = new List<string> { "Fir", "Pas", "Tec", "Cmp", "Dec", "OtB", "Tea", "Vis" };
            var preferableAttributes = new List<string> { "Dri", "Ant", "Fla", "Agi" };

            roles.Add(new Role(RoleType.AdvancedPlaymaker, Duty.Support, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));

            keyAttributes = new List<string> { "Dri", "Fir", "Pas", "Tec", "Cmp", "Dec", "OtB", "Tea", "Vis" };
            preferableAttributes = new List<string> { "Ant", "Fla", "Acc", "Agi" };

            roles.Add(new Role(RoleType.AdvancedPlaymaker, Duty.Attack, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));
        }

        private void CreateTrequartistaRoles()
        {
            var keyAttributes = new List<string> { "Dri", "Fir", "Pas", "Tec", "Cmp", "Dec", "Fla", "OtB", "Vis", "Acc" };
            var preferableAttributes = new List<string> { "Fin", "Ant", "Agi", "Bal" };

            roles.Add(new Role(RoleType.Trequartista, Duty.Attack, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));
        }

        private void CreateRaumdeuterRoles()
        {
            var keyAttributes = new List<string> { "Fin", "Ant", "Cmp", "Cnt", "Dec", "OtB", "Bal" };
            var preferableAttributes = new List<string> { "Fir", "Tec", "Wor", "Acc", "Sta" };

            roles.Add(new Role(RoleType.Raumdeuter, Duty.Attack, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));
        }

        private void CreateWideTargetForwardRoles()
        {
            var keyAttributes = new List<string> { "Hea", "Bra", "Tea", "Jum", "Str" };
            var preferableAttributes = new List<string> { "Cro", "Fir", "Ant", "OtB", "Wor", "Bal", "Sta" };

            roles.Add(new Role(RoleType.WideTargetForward, Duty.Support, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));

            keyAttributes = new List<string> { "Hea", "Bra", "OtB", "Jum", "Str" };
            preferableAttributes = new List<string> { "Cro", "Fin", "Fir", "Ant", "Tea", "Wor", "Bal", "Sta" };

            roles.Add(new Role(RoleType.WideTargetForward, Duty.Attack, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));
        }

        private void CreateMezzalaRoles()
        {
            var keyAttributes = new List<string> { "Pas", "Tec", "Dec", "OtB", "Wor", "Acc" };
            var preferableAttributes = new List<string> { "Dri", "Fir", "Lon", "Tec", "Ant", "Cmp", "Vis", "Bal", "Sta" };

            roles.Add(new Role(RoleType.Mezzala, Duty.Support, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));

            keyAttributes = new List<string> { "Dri", "Pas", "Tec", "Dec", "OtB", "Vis", "Wor", "Acc" };
            preferableAttributes = new List<string> { "Fin", "Fir", "Lon", "Ant", "Cmp", "Fla", "Bal", "Sta" };

            roles.Add(new Role(RoleType.Mezzala, Duty.Attack, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));
        }

        private void CreateCentralMidfielderRoles()
        {
            var keyAttributes = new List<string> { "Tck", "Cnt", "Dec", "Pos", "Tea" };
            var preferableAttributes = new List<string> { "Fir", "Mar", "Pas", "Tec", "Agg", "Ant", "Cmp", "Wor", "Sta" };

            roles.Add(new Role(RoleType.CentralMidfielder, Duty.Defend, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));

            keyAttributes = new List<string> { "Fir", "Pas", "Tck", "Dec", "Tea" };
            preferableAttributes = new List<string> { "Tec", "Ant", "Cmp", "Cnt", "OtB", "Vis", "Wor", "Sta" };

            roles.Add(new Role(RoleType.CentralMidfielder, Duty.Support, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));
            roles.Add(new Role(RoleType.CentralMidfielder, Duty.Automatic, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));

            keyAttributes = new List<string> { "Fir", "Pas", "Dec", "OtB" };
            preferableAttributes = new List<string> { "Lon", "Tck", "Tec", "Ant", "Cmp", "Tea", "Vis", "Wor", "Acc", "Sta" };

            roles.Add(new Role(RoleType.CentralMidfielder, Duty.Attack, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));
        }

        private void CreateBoxToBoxMidfielderRoles()
        {
            var keyAttributes = new List<string> { "Pas", "Tck", "OtB", "Tea", "Wor", "Sta" };
            var preferableAttributes = new List<string> { "Dri", "Fin", "Fir", "Lon", "Tec", "Agg", "Ant", "Cmp", "Dec", "Pos", "Acc", "Bal", "Pac", "Sta" };

            roles.Add(new Role(RoleType.BoxToBoxMidfielder, Duty.Support, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));
        }

        private void CreateCarrileroRoles()
        {
            var keyAttributes = new List<string> { "Fir", "Pas", "Tck", "Dec", "Pos", "Tea", "Sta" };
            var preferableAttributes = new List<string> { "Tec", "Ant", "Cmp", "Cnt", "OtB", "Vis", "Wor" };

            roles.Add(new Role(RoleType.Carrilero, Duty.Support, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));
        }

        private void CreateShadowStrikerRoles()
        {
            var keyAttributes = new List<string> { "Dri", "Fin", "Fir", "Ant", "Cmp", "OtB", "Acc" };
            var preferableAttributes = new List<string> { "Pas", "Tec", "Cnt", "Dec", "Wor", "Agi", "Bal", "Pac", "Sta" };

            roles.Add(new Role(RoleType.ShadowStriker, Duty.Attack, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));
        }

        private void CreateAttackingMidfielderRoles()
        {
            var keyAttributes = new List<string> { "Fir", "Lon", "Pas", "Tec", "Ant", "Dec", "Fla", "OtB" };
            var preferableAttributes = new List<string> { "Dri", "Cmp", "Vis", "Agi" };

            roles.Add(new Role(RoleType.AttackingMidfielder, Duty.Support, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));

            keyAttributes = new List<string> { "Dri", "Fir", "Lon", "Pas", "Tec", "Ant", "Dec", "Fla", "OtB" };
            preferableAttributes = new List<string> { "Fin", "Cmp", "Vis", "Agi" };

            roles.Add(new Role(RoleType.AttackingMidfielder, Duty.Attack, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));
        }

        private void CreateEngancheRoles()
        {
            var keyAttributes = new List<string> { "Fir", "Pas", "Tec", "Cmp", "Dec", "Vis" };
            var preferableAttributes = new List<string> { "Dri", "Ant", "Fla", "OtB", "Tea", "Agi" };

            roles.Add(new Role(RoleType.Enganche, Duty.Support, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));
        }

        private void CreateAdvancedForwardRoles()
        {
            var keyAttributes = new List<string> { "Dri", "Fin", "Fir", "Tec", "Cmp", "OtB", "Acc" };
            var preferableAttributes = new List<string> { "Pas", "Ant", "Dec", "Wor", "Agi", "Bal", "Pac", "Sta" };

            roles.Add(new Role(RoleType.AdvancedForward, Duty.Attack, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));
        }

        private void CreatePoacherRoles()
        {
            var keyAttributes = new List<string> { "Fin", "Ant", "Cmp", "OtB" };
            var preferableAttributes = new List<string> { "Fir", "Hea", "Tec", "Dec", "Acc" };

            roles.Add(new Role(RoleType.Poacher, Duty.Attack, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));
        }

        private void CreateFalseNineRoles()
        {
            var keyAttributes = new List<string> { "Dri", "Fir", "Pas", "Tec", "Cmp", "Dec", "OtB", "Vis", "Acc", "Agi" };
            var preferableAttributes = new List<string> { "Fin", "Ant", "Fla", "Tea", "Bal" };

            roles.Add(new Role(RoleType.FalseNine, Duty.Support, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));
        }

        private void CreateCompleteForwardRoles()
        {
            var keyAttributes = new List<string> { "Dri", "Fir", "Hea", "Lon", "Pas", "Tec", "Ant", "Cmp", "Dec", "OtB", "Vis", "Acc", "Agi", "Str" };
            var preferableAttributes = new List<string> { "Fin", "Tea", "Wor", "Bal", "Jum", "Pac", "Sta" };

            roles.Add(new Role(RoleType.CompleteForward, Duty.Support, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));

            keyAttributes = new List<string> { "Dri", "Fin", "Fir", "Hea", "Tec", "Ant", "Cmp", "OtB", "Acc", "Agi", "Str" };
            preferableAttributes = new List<string> { "Lon", "Pas", "Dec", "Tea", "Vis", "Wor", "Bal", "Jum", "Pac", "Sta" };

            roles.Add(new Role(RoleType.CompleteForward, Duty.Attack, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));
        }

        private void CreateDeepLyingForwardRoles()
        {
            var keyAttributes = new List<string> { "Fir", "Pas", "Tec", "Cmp", "Dec", "OtB", "Tea" };
            var preferableAttributes = new List<string> { "Fin", "Ant", "Fla", "Vis", "Bal", "Str" };

            roles.Add(new Role(RoleType.DeepLyingForward, Duty.Support, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));

            keyAttributes = new List<string> { "Fir", "Pas", "Tec", "Cmp", "Dec", "OtB", "Tea" };
            preferableAttributes = new List<string> { "Dri", "Fin", "Ant", "Fla", "Vis", "Bal", "Str" };

            roles.Add(new Role(RoleType.DeepLyingForward, Duty.Attack, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));
        }

        private void CreatePressingForwardRoles()
        {
            var keyAttributes = new List<string> { "Agg", "Ant", "Bra", "Dec", "Tea", "Wor", "Acc", "Pac", "Str" };
            var preferableAttributes = new List<string> { "Fir", "Cmp", "Cnt", "Agi", "Bal", "Str" };

            roles.Add(new Role(RoleType.PressingForward, Duty.Defend, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));

            keyAttributes = new List<string> { "Agg", "Ant", "Bra", "Dec", "Tea", "Wor", "Acc", "Pac", "Str" };
            preferableAttributes = new List<string> { "Fir", "Pas", "Cmp", "Cnt", "OtB", "Agi", "Bal", "Str" };

            roles.Add(new Role(RoleType.PressingForward, Duty.Support, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));

            keyAttributes = new List<string> { "Agg", "Ant", "Bra", "OtB", "Tea", "Wor", "Acc", "Pac", "Str" };
            preferableAttributes = new List<string> { "Fin", "Fir", "Cmp", "Cnt", "Dec", "Agi", "Bal", "Str" };

            roles.Add(new Role(RoleType.PressingForward, Duty.Attack, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));
        }

        private void CreateTargetForwardRoles()
        {
            var keyAttributes = new List<string> { "Hea", "Bra", "Tea", "Bal", "Jum", "Str" };
            var preferableAttributes = new List<string> { "Fin", "Fir", "Agg", "Ant", "Cmp", "Dec", "OtB" };

            roles.Add(new Role(RoleType.TargetForward, Duty.Support, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));

            keyAttributes = new List<string> { "Fin", "Hea", "Bra", "Cmp", "OtB", "Bal", "Jum", "Str" };
            preferableAttributes = new List<string> { "Fir", "Agg", "Ant", "Dec", "Tea" };

            roles.Add(new Role(RoleType.TargetForward, Duty.Attack, CreateAttributes(keyAttributes), CreateAttributes(preferableAttributes)));
        }

        private List<Attribute> CreateAttributes(List<string> attributes)
        {
            return attributes.Select(attribute => AttributeCollection.Instance.GetAttribute(attribute)).ToList();
        }
        public IReadOnlyCollection<Role> GetAllRoles()
        {
            return roles.AsReadOnly();
        }

        public List<Role> GetRoles(RoleType roleType)
        {
            return roles.Where(role => role.RoleType == roleType).ToList();
        }

        public Role GetRole(RoleType roleType, Duty duty)
        {
            return roles.First(role => role.RoleType == roleType && role.Duty == duty);
        }
    }
}
