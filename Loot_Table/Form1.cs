using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.GData.Client;
using Google.GData.Extensions;
using Google.GData.Spreadsheets;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;




namespace Loot_Table
{


    public partial class Form1 : Form
    {
        // If modifying these scopes, delete your previously saved credentials
        // at ~/.credentials/sheets.googleapis.com-dotnet-quickstart.json
        static string[] Scopes = { SheetsService.Scope.SpreadsheetsReadonly };
        static string ApplicationName = "Google Sheets API .NET Quickstart";
        static string spreadsheetId = "1I8AXaHEa7fNfTG4Ctw5724NJyM4SfA-Jh0sf9GJE8SQ";

        //Consistently random numbers
        Random rnd = new Random();
        SheetsService service = null;

        public Form1()
        {
            InitializeComponent();
            Speed.SelectedIndex = 1;
            RewardType.SelectedIndex = 2;
            CreatureType.SelectedIndex = 0;
            TableA.SelectedIndex = 0;
            TableB.SelectedIndex = 0;
            TableC.SelectedIndex = 0;
            TableD.SelectedIndex = 0;
            TableE.SelectedIndex = 0;
            TableF.SelectedIndex = 0;
            TableG.SelectedIndex = 0;
            TableH.SelectedIndex = 0;
            TableI.SelectedIndex = 0;
            service = AuthorizeGoogleApp();
        }

        private static SheetsService AuthorizeGoogleApp()
        {
            UserCredential credential;

            using (var stream =
                new FileStream("client_id.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = System.Environment.GetFolderPath(
                    System.Environment.SpecialFolder.Personal);
                credPath = Path.Combine(credPath, ".credentials/sheets.googleapis.com-dotnet-quickstart.json");

                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                Console.WriteLine("Credential file saved to: " + credPath);
            }

            // Create Google Sheets API service.
            var service = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            return service;
        }

        public String CellGrab(string Table, String Column, int Row)
        {
            string cell = "error";

            String range = Table + "!" + Column + Row.ToString();
            SpreadsheetsResource.ValuesResource.GetRequest request =
                   service.Spreadsheets.Values.Get(spreadsheetId, range);
            ValueRange response = request.Execute();
            IList<IList<Object>> values = response.Values;

            cell = values[0][0].ToString();

            return cell;
        }

        private void Generate_Treasure_Budget_Click(object sender, EventArgs e)
        {
            //Get user input
            //Challenge Rating
            if (ChallengeRating.Value < 1)
                ChallengeRating.Value = 1;
            else if (ChallengeRating.Value > 20)
                ChallengeRating.Value = 20;
            int CR = Convert.ToInt32(ChallengeRating.Value) + 2;

            //Speed
            string sp = Speed.Text;
            if (sp == "Slow")
                sp = "B";
            else if (sp == "Medium")
                sp = "C";
            else if (sp == "Fast")
                sp = "D";

            //Reward Type
            double rType = 1;
            if (RewardType.Text == "None")
                rType = 0;
            else if (RewardType.Text == "Incidental")
                rType = 0.5;
            else if (RewardType.Text == "Standard")
                rType = 1;
            else if (RewardType.Text == "Double")
                rType = 2;
            else if (RewardType.Text == "Triple")
                rType = 3;

            //NPC Gear or not
            String table = "Per Encounter";
            if(RewardType.Text == "NPC Gear")
                table = "NPC Gear";



           
            //Calculate Treasure Budget
            string budget = CellGrab(table, sp, CR);
            budget = budget.Replace(",","");
            int modify = Convert.ToInt32(budget);
            modify = Convert.ToInt32(Convert.ToDouble(modify) * rType);
            TreasureBudget.Text = modify.ToString();
            RemaingBudget.Value = modify;

            //Treasure Types
            int tType = CreatureType.SelectedIndex + 2;
            TreasureTypes.Text = CellGrab("Treasure Types", "B", tType);

        }

        private void AddA_Click(object sender, EventArgs e)
        {
            if (TableA.SelectedIndex != 0)
            {
                RemaingBudget.Value -= Convert.ToInt32(TableA.SelectedItem);
                RollList.Items.Add(CellGrab("Type A", "B", TableA.SelectedIndex + 2));
            }
        }

        private void AddB_Click(object sender, EventArgs e)
        {
            if (TableB.SelectedIndex != 0)
            {
                RemaingBudget.Value -= Convert.ToInt32(TableB.SelectedItem);
                RollList.Items.Add(CellGrab("Type B", "B", TableB.SelectedIndex + 2));
            }
        }

        private void AddC_Click(object sender, EventArgs e)
        {
            if (TableC.SelectedIndex != 0)
            {
                RemaingBudget.Value -= Convert.ToInt32(TableC.SelectedItem);
                RollList.Items.Add(CellGrab("Type C", "B", TableC.SelectedIndex + 2));
            }

        }

        private void AddD_Click(object sender, EventArgs e)
        {
            if (TableD.SelectedIndex != 0)
            {
                RemaingBudget.Value -= Convert.ToInt32(TableD.SelectedItem);
                RollList.Items.Add(CellGrab("Type D", "B", TableD.SelectedIndex + 2));
            }

        }

        private void AddE_Click(object sender, EventArgs e)
        {
            if (TableE.SelectedIndex != 0)
            {
                RemaingBudget.Value -= Convert.ToInt32(TableE.SelectedItem);
                RollList.Items.Add(CellGrab("Type E", "B", TableE.SelectedIndex + 2));
            }
        }

        private void AddF_Click(object sender, EventArgs e)
        {
            if (TableF.SelectedIndex != 0)
            {
                RemaingBudget.Value -= Convert.ToInt32(TableF.SelectedItem);
                RollList.Items.Add(CellGrab("Type F", "B", TableF.SelectedIndex + 2));
            }
        }

        private void AddG_Click(object sender, EventArgs e)
        {
            if (TableG.SelectedIndex != 0)
            {
                RemaingBudget.Value -= Convert.ToInt32(TableG.SelectedItem);
                RollList.Items.Add(CellGrab("Type G", "B", TableG.SelectedIndex + 2));
            }

        }

        private void AddH_Click(object sender, EventArgs e)
        {
            if (TableH.SelectedIndex != 0)
            {
                RemaingBudget.Value -= Convert.ToInt32(TableH.SelectedItem);
                RollList.Items.Add(CellGrab("Type H", "B", TableH.SelectedIndex + 2));
            }

        }

        private void AddI_Click(object sender, EventArgs e)
        {
            if (TableI.SelectedIndex != 0)
            {
                RemaingBudget.Value -= Convert.ToInt32(TableI.SelectedItem);
                RollList.Items.Add(CellGrab("Type I", "B", TableI.SelectedIndex + 2));
            }
        }

        private void ResetBudget_Click(object sender, EventArgs e)
        {
            TableA.SelectedIndex = 0;
            TableB.SelectedIndex = 0;
            TableC.SelectedIndex = 0;
            TableD.SelectedIndex = 0;
            TableE.SelectedIndex = 0;
            TableF.SelectedIndex = 0;
            TableG.SelectedIndex = 0;
            TableH.SelectedIndex = 0;
            TableI.SelectedIndex = 0;
            RollList.Items.Clear();
            if (TreasureBudget.Text != "")
                RemaingBudget.Value = Convert.ToInt32(TreasureBudget.Text);
            else
                RemaingBudget.Value = 0;
        }

        private void RollLoot_Click(object sender, EventArgs e)
        {
            Loot.Clear();
            //Collate chosen table items into a list with an item for each roll
            var items = new List<String>();
            for (int i = 0; i < RollList.Items.Count; i++)
            {
                int position = 0;
                int start = 0;
                string line = RollList.Items[i].ToString();
                //Get items in front of commas
                do
                {
                    position = line.IndexOf(',', start);
                    if (position >= 0)
                    {
                        items.Add(line.Substring(start, position - start).Trim());
                        start = position + 1;
                    }
                    //Add final item after all commas
                    else
                        items.Add(line.Substring(start).Trim());
                } while (position > 0);

            }
            //Roll the items
            for(int i = 0; i < items.Count; i++)
            {
                items[i] = itemRoll(items[i]);
            }


            //Push rolled items into Loot list
            foreach(var item in items){
                Loot.Text += item + System.Environment.NewLine;
            }
        }

        public String itemRoll(String item)
        {
            String result = "";
            int rolls = 1;
            int index = 0;
            int grade = 1;
            string greatness = "Lesser Minor";
            string abilityGreatness = "Lesser Minor";
            string rarity = "Common";
            string level = "0";
            string range = "A3:A4";
            String itemType = item.Substring(item.LastIndexOf(' ') + 1);
            

            if (itemType == "cp" || itemType == "sp" || itemType == "gp" || itemType == "pp")
            {
                int sides = 6;
                int multiply = 1;
                index = item.IndexOf('d');
                rolls = Convert.ToInt32(item.Substring(0, index));
                index += 1;
                sides = Convert.ToInt32(item.Substring(index, item.IndexOf(' ') - index));
                if (item.IndexOf('x') > 0)
                {
                    index = item.IndexOf("x") + 2;
                    multiply = Convert.ToInt32(item.Substring(index, item.LastIndexOf(" ") - index));
                }
                    
                int sum = 0;
                for (int i = 0; i < rolls; i++)
                    sum += diceRoll(sides);
                sum *= multiply;

                result = sum.ToString() + " " + itemType;
            }
            else if (itemType == "gemstone" || itemType == "gemstones")
            {
                index = item.IndexOf(' ');
                rolls = Convert.ToInt32(item.Substring(0, index));
                index += 7;
                grade = Convert.ToInt32(item.Substring(index, 1));
                switch(grade)
                {
                    case 1:
                        range = "A3:A16";
                        break;
                    case 2:
                        range = "A18:A31";
                        break;
                    case 3:
                        range = "A33:A42";
                        break;
                    case 4:
                        range = "A44:A47";
                        break;
                    case 5:
                        range = "A49:A52";
                        break;
                    case 6:
                        range = "A54:A57";
                        break;
                    default:
                        range = "A3:A16";
                        break;
                }
                
                for (int i = 0; i < rolls; i++)
                {
                    int worked = diceRoll(100);
                    result += percentageFind(worked, "Gems", range, new string[] { "B", "C" });

                    //Check if gem is worked or not
                    if (worked % 2 != 0)
                    {
                        result += "[Unworked]";
                    }

                    if (i + 1 < rolls)
                        result += ", ";
                }

            }
            else if (itemType == "object" || itemType == "objects")
            {
                index = item.IndexOf(' ');
                rolls = Convert.ToInt32(item.Substring(0, index));
                index += 7;
                grade = Convert.ToInt32(item.Substring(index, 1));
                switch (grade)
                {
                    case 1:
                        range = "A3:A32";
                        break;
                    case 2:
                        range = "A34:A63";
                        break;
                    case 3:
                        range = "A65:A84";
                        break;
                    case 4:
                        range = "A86:A105";
                        break;
                    case 5:
                        range = "A107:A121";
                        break;
                    case 6:
                        range = "A123:A137";
                        break;
                    default:
                        range = "A3:A32";
                        break;
                }

                for (int i = 0; i < rolls; i++)
                {
                    result += percentageFind(diceRoll(100), "Art Objects", range, new string[] { "B", "C" });

                    if (i + 1 < rolls)
                        result += ", ";
                }
            }
            else if (itemType == "scroll" || itemType == "scrolls")
            {
                index = item.IndexOf(' ');
                rolls = Convert.ToInt32(item.Substring(0, index));
                index++;
                greatness = item.Substring(index, item.LastIndexOf(' ') - index);

                switch (greatness)
                {
                    case "lesser minor":
                        greatness = "A3:A5";
                        break;
                    case "greater minor":
                        greatness = "B3:B6";
                        break;
                    case "lesser medium":
                        greatness = "C5:C7";
                        break;
                    case "greater medium":
                        greatness = "D6:D8";
                        break;
                    case "lesser major":
                        greatness = "E7:E10";
                        break;
                    case "greater major":
                        greatness = "F9:F12";
                        break;
                    default:
                        greatness = "A3:A5";
                        break;
                }
                for (int i = 0; i < rolls; i++)
                {
                    level = percentageFind(diceRoll(100), "Scrolls", greatness, new string[] { "G" });
                    rarity = percentageFind(diceRoll(100), "Scrolls", "J3:J6", new string[] { "K" });
                    index = rarity.IndexOf(' ');
                    string type = rarity.Substring(index + 1);
                    rarity = rarity.Substring(0, index);

                    if (type == "arcane")
                    {
                        if (rarity == "Common")
                        {
                            switch (level)
                            {
                                case "0":
                                    range = "A18:A29";
                                    break;
                                case "1st":
                                    range = "A45:A70";
                                    break;
                                case "2nd":
                                    range = "A108:A136";
                                    break;
                                case "3rd":
                                    range = "A179:A206";
                                    break;
                                case "4th":
                                    range = "A245:A272";
                                    break;
                                case "5th":
                                    range = "A308:A338";
                                    break;
                                case "6th":
                                    range = "A372:A402";
                                    break;
                                case "7th":
                                    range = "A433:A456";
                                    break;
                                case "8th":
                                    range = "A487:A507";
                                    break;
                                case "9th":
                                    range = "A535:A551";
                                    break;
                                default:
                                    range = "A18:A29";
                                    break;
                            }
                        }
                        else //Uncommon
                        {
                            switch (level)
                            {
                                case "0":
                                    range = "A30:A41";
                                    break;
                                case "1st":
                                    range = "A72:A104";
                                    break;
                                case "2nd":
                                    range = "A138:A175";
                                    break;
                                case "3rd":
                                    range = "A208:A241";
                                    break;
                                case "4th":
                                    range = "A275:304";
                                    break;
                                case "5th":
                                    range = "A336:A368";
                                    break;
                                case "6th":
                                    range = "A404:A429";
                                    break;
                                case "7th":
                                    range = "A458:A483";
                                    break;
                                case "8th":
                                    range = "A509:A531";
                                    break;
                                case "9th":
                                    range = "A553:A566";
                                    break;
                                default:
                                    range = "A30:A41";
                                    break;
                            }
                        }
                    }
                    else //divine
                    {
                        if (rarity == "Common")
                        {
                            switch (level)
                            {
                                case "0":
                                    range = "A570:A578";
                                    break;
                                case "1st":
                                    range = "A589:A615";
                                    break;
                                case "2nd":
                                    range = "A655:A686";
                                    break;
                                case "3rd":
                                    range = "A728:A757";
                                    break;
                                case "4th":
                                    range = "A791:A815";
                                    break;
                                case "5th":
                                    range = "A845:A870";
                                    break;
                                case "6th":
                                    range = "A905:A923";
                                    break;
                                case "7th":
                                    range = "A953:A971";
                                    break;
                                case "8th":
                                    range = "A990:A1004";
                                    break;
                                case "9th":
                                    range = "A1025:A1037";
                                    break;
                                default:
                                    range = "A570:A578";
                                    break;
                            }
                        }
                        else //Uncommon
                        {
                            switch (level)
                            {
                                case "0":
                                    range = "A580:A585";
                                    break;
                                case "1st":
                                    range = "A617:A615";
                                    break;
                                case "2nd":
                                    range = "A688:A724";
                                    break;
                                case "3rd":
                                    range = "A759:A787";
                                    break;
                                case "4th":
                                    range = "A817:A841";
                                    break;
                                case "5th":
                                    range = "A872:A901";
                                    break;
                                case "6th":
                                    range = "A925:A949";
                                    break;
                                case "7th":
                                    range = "A973:A986";
                                    break;
                                case "8th":
                                    range = "A1006:A1021";
                                    break;
                                case "9th":
                                    range = "A1039:A1051";
                                    break;
                                default:
                                    range = "A580:A585";
                                    break;
                            }
                        }
                    }

                    result += "Scroll of " + percentageFind(diceRoll(100), "Scrolls", range, new string[] { "B", "C" });

                    if (i + 1 < rolls)
                        result += ", ";
                }

            }
            else if (itemType == "potion" || itemType == "potions")
            {
                index = item.IndexOf(' ');
                rolls = Convert.ToInt32(item.Substring(0, index));
                index++;
                greatness = item.Substring(index, item.LastIndexOf(' ') - index);

                switch (greatness)
                {
                    case "lesser minor":
                        greatness = "A3:A4";
                        break;
                    case "greater minor":
                        greatness = "B3:B5";
                        break;
                    case "lesser medium":
                        greatness = "C4:C6";
                        break;
                    case "greater medium":
                        greatness = "D4:D6";
                        break;
                    case "lesser major":
                        greatness = "E5:E6";
                        break;
                    case "greater major":
                        greatness = "F5:F6";
                        break;
                    default:
                        greatness = "A3:A4";
                        break;
                }
                for (int i = 0; i < rolls; i++)
                {
                    level = percentageFind(diceRoll(100), "Potions & Oils", greatness, new string[] { "G" });
                    rarity = percentageFind(diceRoll(100), "Potions & Oils", "J3:J4", new string[] { "K" });

                    if (rarity == "Common")
                    {
                        switch (level)
                        {
                            case "0":
                                range = "A11:A17";
                                break;
                            case "1st":
                                range = "A21:A37";
                                break;
                            case "2nd":
                                range = "A60:A83";
                                break;
                            case "3rd":
                                range = "A105:A128";
                                break;
                            default:
                                range = "A11:A17";
                                break;
                        }
                    }
                    else //Uncommon
                    {
                        switch (level)
                        {
                            case "0":
                                range = "A11:A17";
                                break;
                            case "1st":
                                range = "A39:A56";
                                break;
                            case "2nd":
                                range = "A85:A101";
                                break;
                            case "3rd":
                                range = "A130:A138";
                                break;
                            default:
                                range = "A11:A17";
                                break;
                        }
                    }
                        


                    result += "Potion of " + percentageFind(diceRoll(100), "Potions & Oils", range, new string[] { "B", "C" });

                    if (i + 1 < rolls)
                        result += ", ";
                }

            }
            else if (itemType == "wand" || itemType == "wands")
            {
                index = item.IndexOf(' ');
                rolls = Convert.ToInt32(item.Substring(0, index));
                index++;
                greatness = item.Substring(index, item.LastIndexOf(' ') - index);

                switch (greatness)
                {
                    case "lesser minor":
                        greatness = "A3:A4";
                        break;
                    case "greater minor":
                        greatness = "B4:B5";
                        break;
                    case "lesser medium":
                        greatness = "C5:C6";
                        break;
                    case "greater medium":
                        greatness = "D5:D6";
                        break;
                    case "lesser major":
                        greatness = "E6:E7";
                        break;
                    case "greater major":
                        greatness = "F6:F7";
                        break;
                    default:
                        greatness = "A3:A4";
                        break;
                }
                for (int i = 0; i < rolls; i++)
                {
                    level = percentageFind(diceRoll(100), "Wands", greatness, new string[] { "G" });
                    rarity = percentageFind(diceRoll(100), "Wands", "J3:J4", new string[] { "K" });

                    if (rarity == "Common")
                    {
                        switch (level)
                        {
                            case "0":
                                range = "A13:A27";
                                break;
                            case "1st":
                                range = "A45:A88";
                                break;
                            case "2nd":
                                range = "A146:A193";
                                break;
                            case "3rd":
                                range = "A249:A294";
                                break;
                            case "4th":
                                range = "A345:A389";
                                break;
                            default:
                                range = "A13:A27";
                                break;
                        }
                    }
                    else //Uncommon
                    {
                        switch (level)
                        {
                            case "0":
                                range = "A29:A41";
                                break;
                            case "1st":
                                range = "A90:A142";
                                break;
                            case "2nd":
                                range = "A195:A245";
                                break;
                            case "3rd":
                                range = "A296:A341";
                                break;
                            case "4th":
                                range = "A91:A436";
                                break;
                            default:
                                range = "A29:A41";
                                break;
                        }
                    }



                    result += "Wand of " + percentageFind(diceRoll(100), "Wands", range, new string[] { "B", "C" });

                    if (i + 1 < rolls)
                        result += ", ";
                }
            }
            else if (itemType == "armor/shield")
            {
                result = "Masterwork Light Armor or Shield";
            }
            else if (itemType == "armor" || itemType == "armors")
            {
                index = item.IndexOf(' ');
                rolls = Convert.ToInt32(item.Substring(0, index));
                index++;

                //Masterwork armor does not need to reference the armor tables
                if (item.Substring(index, 6) == "Master")
                    result = item.Substring(index);
                else
                {
                    greatness = item.Substring(index, item.LastIndexOf(' ') - index);

                    switch (greatness)
                    {
                        case "lesser minor":
                            greatness = "A3:A4";
                            break;
                        case "greater minor":
                            greatness = "A6:A9";
                            break;
                        case "lesser medium":
                            greatness = "A11:A18";
                            break;
                        case "greater medium":
                            greatness = "A20:A27";
                            break;
                        case "lesser major":
                            greatness = "A29:A36";
                            break;
                        case "greater major":
                            greatness = "A38:A50";
                            break;
                        default:
                            greatness = "A3:A4";
                            break;
                    }

                    for (int i = 0; i < rolls; i++)
                    {
                        string armor = percentageFind(diceRoll(100), "Armor & Shields", greatness, new string[] {"B"});

                        //Specific armors
                        if (armor[0] != '+')
                        {
                            switch (greatness)
                            {
                                case "A3:A4"://Lesser Minor
                                    abilityGreatness = "D65:D66";
                                    break;
                                case "A6:A9"://Greater Minor
                                    abilityGreatness = "D68:D70";
                                    break;
                                case "A11:A18"://Lesser Medium
                                    abilityGreatness = "D72:D74";
                                    break;
                                case "A20:A27"://Greater Medium
                                    abilityGreatness = "D76:D83";
                                    break;
                                case "A29:A36"://Lesser Major
                                    abilityGreatness = "D85:D91";
                                    break;
                                case "A38:A50"://Greater Major
                                    abilityGreatness = "D93:D109";
                                    break;
                                default:
                                    abilityGreatness = "D65:D66";
                                    break;
                            }

                            armor = percentageFind(diceRoll(100), "Armor & Shields", abilityGreatness, new string[] { "E", "F" });
                            
                        }
                        else
                        {
                            //No special abilities
                            if (!armor.Contains('*'))
                            {
                                armor = armor.Substring(0, 2) + " Armor";
                            }
                            else
                            {
                                int abilityNum = 1;
                                if (armor.Contains("two"))
                                    abilityNum = 2;

                                string abilities = "";

                                for (int j = 0; j < abilityNum; j++)
                                {
                                    string abilityLevel = armor.Substring(29, 2);
                                    switch (abilityLevel)
                                    {
                                        case "+1":
                                            abilityLevel = "D3:D19";
                                            break;
                                        case "+2":
                                            abilityLevel = "D21:D28";
                                            break;
                                        case "+3":
                                            abilityLevel = "D30:D40";
                                            break;
                                        case "+4":
                                            abilityLevel = "D42:D47";
                                            break;
                                        case "+5":
                                            abilityLevel = "D49:D61";
                                            break;
                                        default:
                                            abilityLevel = "D3:D19";
                                            break;
                                    }

                                    abilities += percentageFind(diceRoll(100), "Armor & Shields", abilityLevel, new string[] { "E" }) + " ";
                                }

                                armor = armor.Substring(0, 2) + " " + abilities + "Armor";
                            }

                        }

                        result += armor;

                        if (i + 1 < rolls)
                            result += ", ";
                    }
                }

            }
            else if (itemType == "shield" || itemType == "shields")
            {
                //The random tables only produce non-magic shields
                //Will try and remedy this later
                result += "Masterwork Shield";
            }
            else if (itemType == "weapon" || itemType == "weapons")
            {
                index = item.IndexOf(' ');
                rolls = Convert.ToInt32(item.Substring(0, index));
                index++;

                string weaponType = percentageFind(diceRoll(100), "Weapons", "A3:A43", new string[] { "B" });

                //Masterwork weapons does not need to reference the magic weapon tables
                if (item.Substring(index, 6) == "Master")
                    result = "Masterwork " + weaponType;
                else
                {
                    greatness = item.Substring(index, item.LastIndexOf(' ') - index);

                    switch (greatness)
                    {
                        case "lesser minor":
                            greatness = "A47:A48";
                            break;
                        case "greater minor":
                            greatness = "A50:A53";
                            break;
                        case "lesser medium":
                            greatness = "A55:A62";
                            break;
                        case "greater medium":
                            greatness = "A64:A71";
                            break;
                        case "lesser major":
                            greatness = "A73:A80";
                            break;
                        case "greater major":
                            greatness = "A82:A94";
                            break;
                        default:
                            greatness = "A47:A48";
                            break;
                    }

                    for (int i = 0; i < rolls; i++)
                    {

                        string weapon = percentageFind(diceRoll(100), "Weapons", greatness, new string[] { "B" });

                        //Specific weapons
                        if (weapon[0] != '+')
                        {
                            switch (greatness)
                            {
                                case "A47:A48"://Lesser Minor
                                    abilityGreatness = "D86:D101";
                                    break;
                                case "A50:A53"://Greater Minor
                                    abilityGreatness = "D103:D108";
                                    break;
                                case "A55:A62"://Lesser Medium
                                    abilityGreatness = "D110:D127";
                                    break;
                                case "A64:A71"://Greater Medium
                                    abilityGreatness = "D129:D144";
                                    break;
                                case "A73:A80"://Lesser Major
                                    abilityGreatness = "D146:D152";
                                    break;
                                case "A82:A94"://Greater Major
                                    abilityGreatness = "D154:D183";
                                    break;
                                default:
                                    abilityGreatness = "D86:D101";
                                    break;
                            }

                            weapon = percentageFind(diceRoll(100), "Weapons", abilityGreatness, new string[] { "E", "F" });

                        }
                        else
                        {
                            //No special abilities
                            if (!weapon.Contains('*'))
                            {
                                weapon = weapon.Substring(0, 2) + " " + weaponType;
                            }
                            else
                            {
                                int abilityNum = 1;
                                if (weapon.Contains("two"))
                                    abilityNum = 2;


                                string abilities = "";

                                for (int j = 0; j < abilityNum; j++)
                                {
                                    string abilityLevel = weapon.Substring(15, 2);
                                    switch (abilityLevel)
                                    {
                                        case "+1":
                                            abilityLevel = "D3:D46";
                                            break;
                                        case "+2":
                                            abilityLevel = "D48:D71";
                                            break;
                                        case "+3":
                                            abilityLevel = "D73:D76";
                                            break;
                                        case "+4":
                                            abilityLevel = "D78:D82";
                                            break;
                                        default:
                                            abilityLevel = "D3:D46";
                                            break;
                                    }

                                    abilities += percentageFind(diceRoll(100), "Weapons", abilityLevel, new string[] { "E" }) + " ";
                                }
                                //Extra ability rolls for high roll Greater Major weapons
                                if(weapon.Contains("and"))
                                {

                                    if(weapon.Substring(15, 2) == "+4")
                                        abilities += percentageFind(diceRoll(100), "Weapons", "D3:D46", new string[] { "E" }) + " ";
                                    else
                                        abilities += percentageFind(diceRoll(100), "Weapons", "D48:D71", new string[] { "E" }) + " ";
                                }

                                weapon = weapon.Substring(0, 2) + " " + abilities + weaponType;
                            }

                        }

                        result += weapon;

                        //New weapon type for future rolls
                        if (i + 1 < rolls)
                        {
                            result += ", ";

                            weaponType = percentageFind(diceRoll(100), "Weapons", "A3:A43", new string[] { "B" });
                        }
                            
                    }
                }
            }
            else if (itemType == "item" || itemType == "items")
            {
                string itemSlot = percentageFind(diceRoll(100), "Wondrous Items", "A3:A14", new string[] { "B" });

                index = item.IndexOf(' ');
                rolls = Convert.ToInt32(item.Substring(0, index));
                index++;
                greatness = item.Substring(index, item.LastIndexOf(' ') - index);

                
                for (int i = 0; i < rolls; i++)
                {
                    switch (itemSlot)
                    {
                        case "Belts":
                            switch (greatness)
                            {
                                case "lesser minor":
                                    range = "A18:A24";
                                    break;
                                case "greater minor":
                                    range = "A26:A32";
                                    break;
                                case "lesser medium":
                                    range = "A34:A49";
                                    break;
                                case "greater medium":
                                    range = "A51:A57";
                                    break;
                                case "lesser major":
                                    range = "A59:A64";
                                    break;
                                case "greater major":
                                    range = "A66:A70";
                                    break;
                                default:
                                    range = "A18:A24";
                                    break;
                            }
                            break;
                        case "Body":
                            switch (greatness)
                            {
                                case "lesser minor":
                                    range = "A74:A79";
                                    break;
                                case "greater minor":
                                    range = "A81:A86";
                                    break;
                                case "lesser medium":
                                    range = "A88:A94";
                                    break;
                                case "greater medium":
                                    range = "A96:A99";
                                    break;
                                case "lesser major":
                                    range = "A101:A103";
                                    break;
                                case "greater major":
                                    range = "A105:A113";
                                    break;
                                default:
                                    range = "A74:A79";
                                    break;
                            }
                            break;
                        case "Chest":
                            switch (greatness)
                            {
                                case "lesser minor":
                                    range = "A117:A121";
                                    break;
                                case "greater minor":
                                    range = "A123:A132";
                                    break;
                                case "lesser medium":
                                    range = "A134:A139";
                                    break;
                                case "greater medium":
                                    range = "A141:A142";
                                    break;
                                case "lesser major":
                                    range = "A144:A145";
                                    break;
                                case "greater major":
                                    range = "A147:A149";
                                    break;
                                default:
                                    range = "A117:A121";
                                    break;
                            }
                            break;
                        case "Eyes":
                            switch (greatness)
                            {
                                case "lesser minor":
                                    range = "A153:A158";
                                    break;
                                case "greater minor":
                                    range = "A160:A164";
                                    break;
                                case "lesser medium":
                                    range = "A166:A171";
                                    break;
                                case "greater medium":
                                    range = "A173:A177";
                                    break;
                                case "lesser major":
                                    range = "A179:A180";
                                    break;
                                case "greater major":
                                    range = "A182:A188";
                                    break;
                                default:
                                    range = "A153:A158";
                                    break;
                            }
                            break;
                        case "Feet":
                            switch (greatness)
                            {
                                case "lesser minor":
                                    range = "A192:A201";
                                    break;
                                case "greater minor":
                                    range = "A203:A213";
                                    break;
                                case "lesser medium":
                                    range = "A215:A226";
                                    break;
                                case "greater medium":
                                    range = "A228:A230";
                                    break;
                                case "lesser major":
                                    range = "A232:A236";
                                    break;
                                case "greater major":
                                    range = "A238:A240";
                                    break;
                                default:
                                    range = "A192:A201";
                                    break;
                            }
                            break;
                        case "Hands":
                            switch (greatness)
                            {
                                case "lesser minor":
                                    range = "A244:A252";
                                    break;
                                case "greater minor":
                                    range = "A254:A261";
                                    break;
                                case "lesser medium":
                                    range = "A263:A273";
                                    break;
                                case "greater medium":
                                    range = "A275:A277";
                                    break;
                                case "lesser major":
                                    range = "A279:A280";
                                    break;
                                case "greater major":
                                    range = "A282:A283";
                                    break;
                                default:
                                    range = "A244:A252";
                                    break;
                            }
                            break;
                        case "Head":
                            switch (greatness)
                            {
                                case "lesser minor":
                                    range = "A287:A293";
                                    break;
                                case "greater minor":
                                    range = "A295:A302";
                                    break;
                                case "lesser medium":
                                    range = "A304:A309";
                                    break;
                                case "greater medium":
                                    range = "A311:A323";
                                    break;
                                case "lesser major":
                                    range = "A325:A330";
                                    break;
                                case "greater major":
                                    range = "A332:A338";
                                    break;
                                default:
                                    range = "A287:A293";
                                    break;
                            }
                            break;
                        case "Headband":
                            switch (greatness)
                            {
                                case "lesser minor":
                                    range = "A342:A343";
                                    break;
                                case "greater minor":
                                    range = "A345:A357";
                                    break;
                                case "lesser medium":
                                    range = "A359:A372";
                                    break;
                                case "greater medium":
                                    range = "A374:A376";
                                    break;
                                case "lesser major":
                                    range = "A378:A386";
                                    break;
                                case "greater major":
                                    range = "A388:A392";
                                    break;
                                default:
                                    range = "A342:A343";
                                    break;
                            }
                            break;
                        case "Neck":
                            switch (greatness)
                            {
                                case "lesser minor":
                                    range = "A396:A406";
                                    break;
                                case "greater minor":
                                    range = "A408:A418";
                                    break;
                                case "lesser medium":
                                    range = "A420:A442";
                                    break;
                                case "greater medium":
                                    range = "A444:A452";
                                    break;
                                case "lesser major":
                                    range = "A454:A459";
                                    break;
                                case "greater major":
                                    range = "A461:A464";
                                    break;
                                default:
                                    range = "A396:A406";
                                    break;
                            }
                            break;
                        case "Shoulders":
                            switch (greatness)
                            {
                                case "lesser minor":
                                    range = "A468:A481";
                                    break;
                                case "greater minor":
                                    range = "A483:A489";
                                    break;
                                case "lesser medium":
                                    range = "A491:A508";
                                    break;
                                case "greater medium":
                                    range = "A510:A517";
                                    break;
                                case "lesser major":
                                    range = "A519:A521";
                                    break;
                                case "greater major":
                                    range = "A523:A527";
                                    break;
                                default:
                                    range = "A468:A481";
                                    break;
                            }
                            break;
                        case "Wrists":
                            switch (greatness)
                            {
                                case "lesser minor":
                                    range = "A531:A537";
                                    break;
                                case "greater minor":
                                    range = "A539:A548";
                                    break;
                                case "lesser medium":
                                    range = "A550:A564";
                                    break;
                                case "greater medium":
                                    range = "A566:A572";
                                    break;
                                case "lesser major":
                                    range = "A574:A576";
                                    break;
                                case "greater major":
                                    range = "A578:A579";
                                    break;
                                default:
                                    range = "A531:A537";
                                    break;
                            }
                            break;
                        case "Slotless":
                            switch (greatness)
                            {
                                case "lesser minor":
                                    range = "A630:A689";
                                    break;
                                case "greater minor":
                                    range = "A691:A747";
                                    break;
                                case "lesser medium":
                                    range = "A749:A824";
                                    break;
                                case "greater medium":
                                    range = "A826:A856";
                                    break;
                                case "lesser major":
                                    range = "A858:A885";
                                    break;
                                case "greater major":
                                    range = "A887:A944";
                                    break;
                                default:
                                    range = "A630:A689";
                                    break;
                            }
                            break;
                        default:
                            switch (greatness)
                            {
                                case "lesser minor":
                                    range = "A18:A24";
                                    break;
                                case "greater minor":
                                    range = "A26:A32";
                                    break;
                                case "lesser medium":
                                    range = "A34:A49";
                                    break;
                                case "greater medium":
                                    range = "A51:A57";
                                    break;
                                case "lesser major":
                                    range = "A59:A64";
                                    break;
                                case "greater major":
                                    range = "A66:A70";
                                    break;
                                default:
                                    range = "A18:A24";
                                    break;
                            }
                            break;
                    }
                    //Roll for the least minor slotless item table if necessary
                    string tempResult = percentageFind(diceRoll(100), "Wondrous Items", range, new string[] { "B", "C" });
                    if (tempResult.Contains("Roll on the"))
                        tempResult = percentageFind(diceRoll(100), "Wondrous Items", "A583:A628", new string[] { "B", "C" });

                    result +=  tempResult;

                    if (i + 1 < rolls)
                        result += ", ";
                }
            }
            else if (itemType == "ring" || itemType == "rings")
            {
                index = item.IndexOf(' ');
                rolls = Convert.ToInt32(item.Substring(0, index));
                index++;
                greatness = item.Substring(index, item.LastIndexOf(' ') - index);

                switch (greatness)
                {
                    case "lesser minor":
                        range = "A3:A13";
                        break;
                    case "greater minor":
                        range = "A15:A21";
                        break;
                    case "lesser medium":
                        range = "A23:A53";
                        break;
                    case "greater medium":
                        range = "A55:A66";
                        break;
                    case "lesser major":
                        range = "A68:A76";
                        break;
                    case "greater major":
                        range = "A78:A93";
                        break;
                    default:
                        range = "A3:A13";
                        break;
                }

                for (int i = 0; i < rolls; i++)
                {
                    result += percentageFind(diceRoll(100), "Rings", range, new string[] { "B", "C" });

                    if (i + 1 < rolls)
                        result += ", ";
                }
            }
            else if (itemType == "staff")
            {
                index = item.IndexOf(' ');
                rolls = Convert.ToInt32(item.Substring(0, index));
                index++;
                greatness = item.Substring(index, item.LastIndexOf(' ') - index);

                switch (greatness)
                {
                    case "lesser medium":
                        range = "A3:A10";
                        break;
                    case "greater medium":
                        range = "A12:A21";
                        break;
                    case "lesser major":
                        range = "A23:A48";
                        break;
                    case "greater major":
                        range = "A50:A79";
                        break;
                    default:
                        range = "A3:A10";
                        break;
                }

                for (int i = 0; i < rolls; i++)
                {
                    result += percentageFind(diceRoll(100), "Staves", range, new string[] { "B", "C" });

                    if (i + 1 < rolls)
                        result += ", ";
                }
            }
            else if (itemType == "rod" || itemType == "rods")
            {
                index = item.IndexOf(' ');
                rolls = Convert.ToInt32(item.Substring(0, index));
                index++;
                greatness = item.Substring(index, item.LastIndexOf(' ') - index);

                switch (greatness)
                {
                    case "lesser medium":
                        range = "A3:A12";
                        break;
                    case "greater medium":
                        range = "A14:A29";
                        break;
                    case "lesser major":
                        range = "A31:A44";
                        break;
                    case "greater major":
                        range = "A46:A60";
                        break;
                    default:
                        range = "A3:A12";
                        break;
                }

                for (int i = 0; i < rolls; i++)
                {
                    result += percentageFind(diceRoll(100), "Rods", range, new string[] { "B", "C" });

                    if (i + 1 < rolls)
                        result += ", ";
                }
            }
            else
            {
                result = "Error";
            }

            return result;
        }

        public int diceRoll(int sides)
        {
            int result;
            result = rnd.Next(1, sides + 1);
            return result;
        }

        public String percentageFind(int roll, string sheet, string range, string[] dataColumns)
        {
            string data = "";

            SpreadsheetsResource.ValuesResource.GetRequest request =
                   service.Spreadsheets.Values.Get(spreadsheetId, sheet + "!" +  range);
            ValueRange response = request.Execute();
            IList<IList<Object>> values = response.Values;

            string temp = "";
            int row = 0;
            while(row < values.Count)
            {
                //1% Chances only have a single number
                if (values[row][0].ToString().Length < 3)
                    temp = values[row][0].ToString();
                else //Range chances
                    temp = values[row][0].ToString().Substring(3);

                if (roll <= Convert.ToInt32(temp))
                {
                    break;
                }
                row++;     
            }

            temp = range.Substring(1, range.IndexOf(":") - 1);
            row = Convert.ToInt32(temp) + row;

            for(int i = 0; i < dataColumns.Length; i++)
            {
                

                if (i < 1)
                {
                    data = CellGrab(sheet, dataColumns[i], row);
                }
                else
                {
                    data = data + " (" + CellGrab(sheet, dataColumns[i], row) + ")";
                }
            }


           return data;
        }

    }
}
