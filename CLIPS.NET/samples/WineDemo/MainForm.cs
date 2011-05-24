using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Mommosoft.ExpertSystem;

namespace WineDemo {
    public partial class MainForm : Form {
        private class WineRecommendation {
            public string WineName { get; set; }
            public int Certainty { get; set; }
        }

        string[] preferredColorChoices = { "Don't Care", "Red", "White" };
        string[] preferredBodyChoices = { "Don't Care", "Light", "Medium", "Full" };
        string[] preferredSweetnessChoices = { "Don't Care", "Dry", "Medium", "Sweet" };

        string[] mainCourseChoices = { "Don't Know", "Beef", "Pork", "Lamb", "Turkey", "Chicken", "Duck", "Fish", "Other" };
        string[] sauceChoices = { "Don't Know", "None", "Spicy", "Sweet", "Cream", "Other" };
        string[] flavorChoices = { "Don't Know", "Delicate", "Average", "Strong" };

        private Mommosoft.ExpertSystem.Environment enviroment;
        private bool ready = false;

        public MainForm() {
            InitializeComponent();

            dataGridView.AutoGenerateColumns = false;

            colorComboBox.DataSource = preferredColorChoices;
            bodyComboBox.DataSource = preferredBodyChoices;
            sweetnessComboBox.DataSource = preferredSweetnessChoices;

            mainCourceComboBox.DataSource = mainCourseChoices;
            sauceComboBox.DataSource = sauceChoices;
            flavorComboBox.DataSource = flavorChoices;

            enviroment = new Mommosoft.ExpertSystem.Environment();
            enviroment.Load("winedemo.clp");
        }

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);

            RunWine();

            ready = true;
        }
        private void RunWine() {
            enviroment.Reset();

            string item = (string)colorComboBox.SelectedValue;

            if (item.Equals("Red")) {
                enviroment.AssertString("(attribute (name preferred-color) (value red))");
            } else if (item.Equals("White")) {
                enviroment.AssertString("(attribute (name preferred-color) (value white))");
            } else {
                enviroment.AssertString("(attribute (name preferred-color) (value unknown))");
            }

            item = (string)bodyComboBox.SelectedValue;

            if (item.Equals("Light")) {
                enviroment.AssertString("(attribute (name preferred-body) (value light))");
            } else if (item.Equals("Medium")) {
                enviroment.AssertString("(attribute (name preferred-body) (value medium))");
            } else if (item.Equals("Full")) {
                enviroment.AssertString("(attribute (name preferred-body) (value full))");
            } else {
                enviroment.AssertString("(attribute (name preferred-body) (value unknown))");
            }


            item = (string)sweetnessComboBox.SelectedValue;
            if (item.Equals("Dry")) { enviroment.AssertString("(attribute (name preferred-sweetness) (value dry))"); } else if (item.Equals("Medium")) { enviroment.AssertString("(attribute (name preferred-sweetness) (value medium))"); } else if (item.Equals("Sweet")) { enviroment.AssertString("(attribute (name preferred-sweetness) (value sweet))"); } else { enviroment.AssertString("(attribute (name preferred-sweetness) (value unknown))"); }

            item = (string)mainCourceComboBox.SelectedValue;

            if (item.Equals("Beef") ||
                item.Equals("Pork") ||
                item.Equals("Lamb")) {
                enviroment.AssertString("(attribute (name main-component) (value meat))");
                enviroment.AssertString("(attribute (name has-turkey) (value no))");
            } else if (item.Equals("Turkey")) {
                enviroment.AssertString("(attribute (name main-component) (value poultry))");
                enviroment.AssertString("(attribute (name has-turkey) (value yes))");
            } else if (item.Equals("Chicken") ||
                       item.Equals("Duck")) {
                enviroment.AssertString("(attribute (name main-component) (value poultry))");
                enviroment.AssertString("(attribute (name has-turkey) (value no))");
            } else if (item.Equals("Fish")) {
                enviroment.AssertString("(attribute (name main-component) (value fish))");
                enviroment.AssertString("(attribute (name has-turkey) (value no))");
            } else if (item.Equals("Other")) {
                enviroment.AssertString("(attribute (name main-component) (value unknown))");
                enviroment.AssertString("(attribute (name has-turkey) (value no))");
            } else {
                enviroment.AssertString("(attribute (name main-component) (value unknown))");
                enviroment.AssertString("(attribute (name has-turkey) (value unknown))");
            }

            item = (string)sauceComboBox.SelectedValue;

            if (item.Equals("None")) { enviroment.AssertString("(attribute (name has-sauce) (value no))"); } else if (item.Equals("Spicy")) {
                enviroment.AssertString("(attribute (name has-sauce) (value yes))");
                enviroment.AssertString("(attribute (name sauce) (value spicy))");
            } else if (item.Equals("Sweet")) {
                enviroment.AssertString("(attribute (name has-sauce) (value yes))");
                enviroment.AssertString("(attribute (name sauce) (value sweet))");
            } else if (item.Equals("Cream")) {
                enviroment.AssertString("(attribute (name has-sauce) (value yes))");
                enviroment.AssertString("(attribute (name sauce) (value cream))");
            } else if (item.Equals("Other")) {
                enviroment.AssertString("(attribute (name has-sauce) (value yes))");
                enviroment.AssertString("(attribute (name sauce) (value unknown))");
            } else {
                enviroment.AssertString("(attribute (name has-sauce) (value unknown))");
                enviroment.AssertString("(attribute (name sauce) (value unknown))");
            }

            item = (string)flavorComboBox.SelectedValue;
            if (item.Equals("Delicate")) { enviroment.AssertString("(attribute (name tastiness) (value delicate))"); } else if (item.Equals("Average")) { enviroment.AssertString("(attribute (name tastiness) (value average))"); } else if (item.Equals("Strong")) { enviroment.AssertString("(attribute (name tastiness) (value strong))"); } else { enviroment.AssertString("(attribute (name tastiness) (value unknown))"); }

            enviroment.Run();

            UpdateWines();
        }

        private void UpdateWines() {
            string evalStr = "(WINES::get-wine-list)";

            MultifieldValue mv = (MultifieldValue)enviroment.Eval(evalStr);

            List<WineRecommendation> wineRecList = new List<WineRecommendation>();

            for (int i = 0; i < mv.Count; i++) {
                FactAddressValue fv = (FactAddressValue)mv[i];

                int certainty = (int)((FloatValue)fv.GetFactSlot("certainty"));

                String wineName = ((StringValue)fv.GetFactSlot("value"));

                wineRecList.Add(new WineRecommendation() { WineName = wineName, Certainty = certainty });
            }

            dataGridView.DataSource = wineRecList;
        }

        private void OnChange(object sender, EventArgs e) {
            if (ready) {
                RunWine();
            }
        }
    }
}
