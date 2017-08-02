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

namespace CodingChallenge
{
  public partial class CodingChallenge : Form
  {
    public JsonFiles objJsonFiles = new JsonFiles();

    public CodingChallenge()
    {
      InitializeComponent();
    }

    private void CodingChallenge_Load(object sender, EventArgs e)
    {
      List<string> listURL = new List<string>()
        {
        "https://hacker-news.firebaseio.com/v0/item/8863.json",
        "https://hacker-news.firebaseio.com/v0/item/2921983.json",
        "https://hacker-news.firebaseio.com/v0/item/121003.json",
        "https://hacker-news.firebaseio.com/v0/item/192327.json",
        "https://hacker-news.firebaseio.com/v0/item/126809.json",
        "https://hacker-news.firebaseio.com/v0/item/160705.json"
      };

      objJsonFiles.ReadJsonFilesAsync(listURL, lstStories);
     
    }

    private void lstStories_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void lstStories_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
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
          {
            selectedItems.BackColor = Color.White;
            selectedItems.Selected = false;
          }

          ListViewItem lv = lstStories.FindItemWithText(txtSearch.Text);
          lv.BackColor = Color.LightBlue;
          lv.Selected = true;
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error message");
      }
    }

    private void txtSearch_TextChanged(object sender, EventArgs e)
    {
      ActiveForm.AcceptButton = btnSearch;
    }
  }
}
