using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryV2._0
{
    public partial class InformationForm : Form
    {

        Library _library;
        public InformationForm(Library library)
        {
            InitializeComponent();
            _library = library;
        }

        private void FillListBox(BookFieldSelector fieldSelector, string info)
        {
            InforomationLb.Items.Clear();
            _library.AcceptMore(this.AddToListbox, fieldSelector, info);
        }

        public void AddToListbox(string field)
        {
            if (field != "")
            {
                InforomationLb.Items.Add(field);
            }
        }

        private void MoreYearBtn_Click(object sender, EventArgs e)
        {
            FillListBox(BookFieldSelectors.MoreYear, YearPublicTb.Text.ToString());
        }

        private void LessYearBtn_Click(object sender, EventArgs e)
        {
            FillListBox(BookFieldSelectors.LessYear, YearPublicTb.Text.ToString());
        }

        private void AuthorElemBtn_Click(object sender, EventArgs e)
        {
            FillListBox(BookFieldSelectors.ContainsInAuthor, AuthorElemTb.Text.ToString());
        }

        private void TitleElemBtn_Click(object sender, EventArgs e)
        {
            FillListBox(BookFieldSelectors.ContainsInTitle, TitleElemTb.Text.ToString());
        }
    }
}
