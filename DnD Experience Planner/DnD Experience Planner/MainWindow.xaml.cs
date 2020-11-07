using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DnD_Experience_Planner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static CharacterList characterList;
        private static MonsterList monsterList;

        public MainWindow()
        {
            InitializeComponent();
            characterList = new CharacterList();
            monsterList = new MonsterList();
        }

        private bool AllListsAreNotEmpty(CharacterList characterList, MonsterList monsterList)
        {
            if (characterList.GetTotalNumberOfCharacters() <= 0 && monsterList.GetTotalNumberOfMonsters() <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void ResetAllButton_Click(object sender, RoutedEventArgs e)
        {
            characterList.ClearCharacterList();
            monsterList.ClearMonsterList();
            CalculateXPButton.IsEnabled = false;
            CalculateXPThresholdsButton.IsEnabled = false;
            EasyXPTextBlock.Text = "";
            MediumXPTextBlock.Text = "";
            HardXPTextBlock.Text = "";
            DeadlyXPTextBlock.Text = "";
            AdventuringDayXPTextBlock.Text = "";
            CharactersTextBlock.Text = "";
            MonstersTextBlock.Text = "";
            TotalXPTextBlock.Text = "";
            XPToAwardTextBlock.Text = "";
            AdjustedXPTextBlock.Text = "";
            EncounterDifficultyTextBlock.Text = "";
        }

        private void ResetCharacterButton_Click(object sender, RoutedEventArgs e)
        {
            characterList.ClearCharacterList();
            CalculateXPButton.IsEnabled = false;
            CalculateXPThresholdsButton.IsEnabled = false;
            EasyXPTextBlock.Text = "";
            MediumXPTextBlock.Text = "";
            HardXPTextBlock.Text = "";
            DeadlyXPTextBlock.Text = "";
            AdventuringDayXPTextBlock.Text = "";
        }

        private void ResetMonsterButton_Click(object sender, RoutedEventArgs e)
        {
            monsterList.ClearMonsterList();
            CalculateXPButton.IsEnabled = false;
            CharactersTextBlock.Text = "";
            MonstersTextBlock.Text = "";
            TotalXPTextBlock.Text = "";
            XPToAwardTextBlock.Text = "";
            AdjustedXPTextBlock.Text = "";
            EncounterDifficultyTextBlock.Text = "";
        }

        private void AddCharacterButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Character newCharacter = new Character(CharacterLevelSelector.Text, Convert.ToInt32(NumCharactersTextBox.Text));
                characterList.AddToCharacterList(newCharacter);
                CalculateXPThresholdsButton.IsEnabled = true;

                if (AllListsAreNotEmpty(characterList, monsterList))
                {
                    CalculateXPButton.IsEnabled = true;
                }
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddMonsterButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Monster newMonster = new Monster(MonsterCRSelector.Text, Convert.ToInt32(NumMonstersTextBox.Text));
                monsterList.AddtoMonsterList(newMonster);

                if (AllListsAreNotEmpty(characterList, monsterList))
                {
                    CalculateXPButton.IsEnabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CalculateXPThresholdsButton_Click(object sender, RoutedEventArgs e)
        {
            characterList.CalculateCharacterTotals();
            EasyXPTextBlock.Text = Convert.ToString(characterList.GetTotalEasyXP()) + " XP";
            MediumXPTextBlock.Text = Convert.ToString(characterList.GetTotalMediumXP()) + " XP";
            HardXPTextBlock.Text = Convert.ToString(characterList.GetTotalHardXP()) + " XP";
            DeadlyXPTextBlock.Text = Convert.ToString(characterList.GetTotalDeadlyXP()) + " XP";
            AdventuringDayXPTextBlock.Text = Convert.ToString(characterList.GetTotalAdventuringDayXP()) + " XP";
        }

        private void CalculateXPButton_Click(object sender, RoutedEventArgs e)
        {
            characterList.CalculateCharacterTotals();
            monsterList.CalculateMonsterTotals(characterList);
            EasyXPTextBlock.Text = Convert.ToString(characterList.GetTotalEasyXP()) + " XP";
            MediumXPTextBlock.Text = Convert.ToString(characterList.GetTotalMediumXP()) + " XP";
            HardXPTextBlock.Text = Convert.ToString(characterList.GetTotalHardXP()) + " XP";
            DeadlyXPTextBlock.Text = Convert.ToString(characterList.GetTotalDeadlyXP()) + " XP";
            AdventuringDayXPTextBlock.Text = Convert.ToString(characterList.GetTotalAdventuringDayXP()) + " XP";
            CharactersTextBlock.Text = Convert.ToString(characterList.GetTotalNumberOfCharacters());
            MonstersTextBlock.Text = Convert.ToString(monsterList.GetTotalNumberOfMonsters());
            TotalXPTextBlock.Text = Convert.ToString(monsterList.GetTotalMonsterXP()) + " XP";
            XPToAwardTextBlock.Text = Convert.ToString(monsterList.GetXPAward()) + " XP";
            AdjustedXPTextBlock.Text = Convert.ToString(monsterList.GetAdjustedMonsterXP()) + " XP";
            EncounterDifficultyTextBlock.Text = Convert.ToString(monsterList.GetEncounterDifficulty());
        }
    }
}
