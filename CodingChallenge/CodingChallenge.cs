using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;

namespace CodingChallenge
{
  public partial class CodingChallenge : Form
  {
    private JsonFiles objJsonFiles = new JsonFiles();

    public CodingChallenge()
    {
      InitializeComponent();
    }

    private void CodingChallenge_Load(object sender, EventArgs e)
    {
      // store json links in List. These should probably be kept in a text file or DB 
      // but I did it this way due to time constraints.
      List<string> listURL = new List<string>()
      {
        "https://hacker-news.firebaseio.com/v0/item/8863.json",
        "https://hacker-news.firebaseio.com/v0/item/2921983.json",
        "https://hacker-news.firebaseio.com/v0/item/121003.json",
        "https://hacker-news.firebaseio.com/v0/item/192327.json",
        "https://hacker-news.firebaseio.com/v0/item/126809.json",
        "https://hacker-news.firebaseio.com/v0/item/160705.json"
      };

      // call class to read json data
      objJsonFiles.ReadJsonFilesAsync(listURL, lstStories);     
    }

    private void lstStories_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
    {
      // Build ListView control layout.
      try
      {
        using (var sf = new StringFormat())
        {
          sf.Alignment = StringAlignment.Center;

          using (var headerFont = new Font("Microsoft Sans Serif", 9, FontStyle.Bold))
          {
            e.Graphics.FillRectangle(Brushes.LightGray, e.Bounds);
            e.Graphics.DrawString(e.Header.Text, headerFont,
                Brushes.Black, e.Bounds, sf);
          }
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show("Exception occurred in the " + MethodBase.GetCurrentMethod().Name + " method. \n\n" + ex.Message, "Coding Challenge Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
     }

    private void lstStories_DrawItem(object sender, DrawListViewItemEventArgs e)
    {
      e.DrawDefault = true;
    }

    private void lstStories_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
    {
      e.DrawDefault = true;
    }

    private void btnSearch_Click(object sender, EventArgs e)
    {
      string strSearch = txtSearch.Text.Trim();
      try
      {
        if (strSearch.Length > 0)
        {
          foreach (ListViewItem selectedItems in lstStories.SelectedItems)
          { // Get rid of previous selected item.
            selectedItems.BackColor = Color.White;
            selectedItems.Selected = false;
          }

          ListViewItem lv = lstStories.FindItemWithText(txtSearch.Text);
          // Have search item highlighted in different color than regular select to verify it found in a search.
          lv.BackColor = Color.LightBlue;
          lv.Selected = true;
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show("Exception occurred in the " + MethodBase.GetCurrentMethod().Name + " method. \n\n" + ex.Message, "Coding Challenge Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
    }

    private void txtSearch_TextChanged(object sender, EventArgs e)
    {
      ActiveForm.AcceptButton = btnSearch;
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }
  }
}
