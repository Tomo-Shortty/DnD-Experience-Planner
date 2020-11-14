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
        private static EncounterList encounterList;

        public MainWindow()
        {
            InitializeComponent();
            characterList = new CharacterList();
            monsterList = new MonsterList();
            encounterList = new EncounterList();
        }

        /// <summary>
        /// Checks if the character list and monster list are empty.
        /// </summary>
        /// <param name="characterList"></param>
        /// <param name="monsterList"></param>
        /// <returns></returns>
        private bool AllListsAreNotEmpty(CharacterList characterList, MonsterList monsterList)
        {
            if (characterList.GetCharacterListCount() <= 0 && monsterList.GetMonsterListCount() <= 0)
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
            CharacterListBox.Items.Clear();
            MonsterListBox.Items.Clear();
            RemoveCharacterButton.IsEnabled = false;
            RemoveMonsterButton.IsEnabled = false;
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
            CharacterListBox.Items.Clear();
            RemoveCharacterButton.IsEnabled = false;
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
            MonsterListBox.Items.Clear();
            RemoveMonsterButton.IsEnabled = false;
        }

        private void AddCharacterButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Character newCharacter = new Character(CharacterLevelSelector.Text, Convert.ToInt32(NumCharactersTextBox.Text));
                characterList.AddToCharacterList(newCharacter);
                
                //add entry to the character listbox and determine the output string based on number of characters
                ListBoxItem item = new ListBoxItem();
                if (newCharacter.GetNumberOfCharacters() > 1)
                {
                    item.Content = Convert.ToString(newCharacter.GetNumberOfCharacters()) + " Level " + newCharacter.GetCharacterLevel() + " characters";
                }
                else
                {
                    item.Content = Convert.ToString(newCharacter.GetNumberOfCharacters()) + " Level " + newCharacter.GetCharacterLevel() + " character";
                }
                CharacterListBox.Items.Add(item);

                CalculateXPThresholdsButton.IsEnabled = true;

                //determine if CalculateXPButton should be enabled
                if (AllListsAreNotEmpty(characterList, monsterList))
                {
                    CalculateXPButton.IsEnabled = true;
                    AddToEncounterListButton.IsEnabled = true;
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

                //add entry to the monster listbox and determine the output string based on number of monsters
                ListBoxItem item = new ListBoxItem();
                if (newMonster.GetNumberOfMonsters() > 1)
                {
                    item.Content = Convert.ToString(newMonster.GetNumberOfMonsters()) + " monsters with a CR of " + newMonster.GetChallengeRating();
                }
                else
                {
                    item.Content = Convert.ToString(newMonster.GetNumberOfMonsters()) + " monster with a CR of " + newMonster.GetChallengeRating();
                }                
                MonsterListBox.Items.Add(item);

                //determine if CalculateXPButton should be enabled
                if (AllListsAreNotEmpty(characterList, monsterList))
                {
                    CalculateXPButton.IsEnabled = true;
                    AddToEncounterListButton.IsEnabled = true;
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

        private void CharacterListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            RemoveCharacterButton.IsEnabled = true;
        }

        private void MonsterListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            RemoveMonsterButton.IsEnabled = true;
        }

        private void RemoveCharacterButton_Click(object sender, RoutedEventArgs e)
        {
            characterList.RemoveCharacterFromList(CharacterListBox.SelectedIndex);
            CharacterListBox.Items.RemoveAt(CharacterListBox.SelectedIndex);
            RemoveCharacterButton.IsEnabled = false;
        }

        private void RemoveMonsterButton_Click(object sender, RoutedEventArgs e)
        {
            monsterList.RemoveMonsterFromList(MonsterListBox.SelectedIndex);
            MonsterListBox.Items.RemoveAt(MonsterListBox.SelectedIndex);
            RemoveMonsterButton.IsEnabled = false;
        }

        private void AddToEncounterListButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Encounter encounter = new Encounter(monsterList);
                encounterList.AddToEncounterList(encounter);

                ListBoxItem item = new ListBoxItem();
                item.Content = encounter.GetMonsterDetails() + Convert.ToString(encounter.GetTotalEncounterXP()) + " XP, " + encounter.GetDifficulty();
                EncounterListBox.Items.Add(item);
                TotalEncounterXPTextBlock.Text = Convert.ToString(encounterList.GetTotalXP()) + " XP";
                EncounterTotalXPAwardTextBlock.Text = Convert.ToString(encounterList.GetTotalXPAward()) + " XP";

                MonsterListBox.Items.Clear();
                monsterList.ClearMonsterList();
                RemoveMonsterButton.IsEnabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        private void RemoveEncounterButton_Click(object sender, RoutedEventArgs e)
        {
            encounterList.RemoveFromEncounterList(EncounterListBox.SelectedIndex);
            EncounterListBox.Items.RemoveAt(EncounterListBox.SelectedIndex);
            TotalEncounterXPTextBlock.Text = Convert.ToString(encounterList.GetTotalXP()) + " XP";
            EncounterTotalXPAwardTextBlock.Text = Convert.ToString(encounterList.GetTotalXPAward()) + " XP";
            RemoveEncounterButton.IsEnabled = false;
            EditEncounterButton.IsEnabled = false;
        }

        private void EditEncounterButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                /*Monster monster = new Monster(MonsterCRSelector.Text, Convert.ToInt32(NumMonstersTextBox.Text));
                monsterList.AddtoMonsterList(monster);*/

                encounterList.RemoveFromEncounterList(EncounterListBox.SelectedIndex);
                EncounterListBox.Items.RemoveAt(EncounterListBox.SelectedIndex);
                TotalEncounterXPTextBlock.Text = Convert.ToString(encounterList.GetTotalXP()) + " XP";
                EncounterTotalXPAwardTextBlock.Text = Convert.ToString(encounterList.GetTotalXPAward()) + " XP";
                RemoveEncounterButton.IsEnabled = false;
                EditEncounterButton.IsEnabled = false;
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ResetEncounterButton_Click(object sender, RoutedEventArgs e)
        {
            EncounterListBox.Items.Clear();
            encounterList.ClearEncounterList();
            TotalEncounterXPTextBlock.Text = "";
            EncounterTotalXPAwardTextBlock.Text = "";
            RemoveEncounterButton.IsEnabled = false;
            EditEncounterButton.IsEnabled = false;
        }

        private void EncounterListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            RemoveEncounterButton.IsEnabled = true;
            EditEncounterButton.IsEnabled = true;
        }
    }
}
