using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using FMSelectionHelper.Models;
using Microsoft.Win32;

namespace FMSelectionHelper
{
    /// <summary>
    /// Interaction logic for FormationManager.xaml
    /// </summary>
    public partial class FormationManager : Window
    {
        public FormationManager()
        {
            InitializeComponent();
            List<Position> positions = PositionCollection.Instance.GetPositions();
            for (int i = 0; i < 11; i++)
            {
                (FindName("Pos" + i) as ComboBox).ItemsSource = positions;
            }
        }

        private void position_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox source = sender as ComboBox;
            string position = source.Name;
            int positionNumber = Convert.ToInt32(position.Substring(3));

            ComboBox role = (ComboBox) FindName("Role" + positionNumber);
            role.ItemsSource = (source.SelectedItem as Position).PossibleRoles;
        }

        private void BtnSave_OnClick(object sender, RoutedEventArgs e)
        {
            if (TxtFormationName.Text == string.Empty)
            {
                MessageBox.Show("No formation name given.");
                return;
            }

            if (File.Exists(TxtFormationName.Text + ".for"))
            {
                MessageBox.Show($"File {TxtFormationName.Text}.for already exists. Formation not saved");
                return;
            }

            try
            {
                StringBuilder result = new StringBuilder();
                for (int i = 0; i < 11; i++)
                {
                    Position position = (FindName("Pos" + i) as ComboBox).SelectedItem as Position;
                    Role role = (FindName("Role" + i) as ComboBox).SelectedItem as Role;

                    result.AppendLine(position.PositionType + "|" + role.RoleType + "|" + role.Duty);
                }

                File.WriteAllText(TxtFormationName.Text + ".for", result.ToString());
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                MessageBox.Show("Could not save file");
            }
        }
    }
}
