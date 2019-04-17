using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChuckNorrisAPI;

namespace ChuckNorrisForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PopulateCategories();
        }

        private async void PopulateCategories()
        {
            ddlCategories.Items.Add("Any");
            IEnumerable<string> categories = await ChuckNorrisClient.GetCategories();
            foreach(string str in categories)
            {
                ddlCategories.Items.Add(str);
            }
            ddlCategories.SelectedIndex = 0;
        }

        private async void btnGetJoke_Click(object sender, EventArgs e)
        {
            Joke joke = await ChuckNorrisClient.GetRandomJoke();
            tbxJokeText.Text = joke.JokeText;
        }

        private void ddlCategories_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
