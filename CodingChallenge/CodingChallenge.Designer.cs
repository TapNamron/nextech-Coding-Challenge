namespace CodingChallenge
{
  partial class CodingChallenge
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.lstStories = new System.Windows.Forms.ListView();
      this.clmTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.clmAuthor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.btnSearch = new System.Windows.Forms.Button();
      this.txtSearch = new System.Windows.Forms.TextBox();
      this.btnExit = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // lstStories
      // 
      this.lstStories.BackColor = System.Drawing.SystemColors.Window;
      this.lstStories.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmTitle,
            this.clmAuthor});
      this.lstStories.ForeColor = System.Drawing.SystemColors.WindowText;
      this.lstStories.FullRowSelect = true;
      this.lstStories.Location = new System.Drawing.Point(21, 25);
      this.lstStories.Name = "lstStories";
      this.lstStories.OwnerDraw = true;
      this.lstStories.Size = new System.Drawing.Size(463, 178);
      this.lstStories.TabIndex = 0;
      this.lstStories.UseCompatibleStateImageBehavior = false;
      this.lstStories.View = System.Windows.Forms.View.Details;
      this.lstStories.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.lstStories_DrawColumnHeader);
      this.lstStories.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.lstStories_DrawItem);
      this.lstStories.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.lstStories_DrawSubItem);
      // 
      // clmTitle
      // 
      this.clmTitle.Text = "Title";
      this.clmTitle.Width = 350;
      // 
      // clmAuthor
      // 
      this.clmAuthor.Text = "Author";
      this.clmAuthor.Width = 90;
      // 
      // btnSearch
      // 
      this.btnSearch.Location = new System.Drawing.Point(192, 219);
      this.btnSearch.Name = "btnSearch";
      this.btnSearch.Size = new System.Drawing.Size(75, 23);
      this.btnSearch.TabIndex = 1;
      this.btnSearch.Text = "Search";
      this.btnSearch.UseVisualStyleBackColor = true;
      this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
      // 
      // txtSearch
      // 
      this.txtSearch.Location = new System.Drawing.Point(21, 221);
      this.txtSearch.Name = "txtSearch";
      this.txtSearch.Size = new System.Drawing.Size(154, 20);
      this.txtSearch.TabIndex = 2;
      this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
      // 
      // btnExit
      // 
      this.btnExit.Location = new System.Drawing.Point(408, 219);
      this.btnExit.Name = "btnExit";
      this.btnExit.Size = new System.Drawing.Size(75, 23);
      this.btnExit.TabIndex = 3;
      this.btnExit.Text = "Exit";
      this.btnExit.UseVisualStyleBackColor = true;
      this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
      // 
      // CodingChallenge
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(506, 268);
      this.Controls.Add(this.btnExit);
      this.Controls.Add(this.txtSearch);
      this.Controls.Add(this.btnSearch);
      this.Controls.Add(this.lstStories);
      this.Name = "CodingChallenge";
      this.Text = "Coding Challenge";
      this.Load += new System.EventHandler(this.CodingChallenge_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListView lstStories;
    private System.Windows.Forms.ColumnHeader clmTitle;
    private System.Windows.Forms.ColumnHeader clmAuthor;
    private System.Windows.Forms.Button btnSearch;
    private System.Windows.Forms.TextBox txtSearch;
    private System.Windows.Forms.Button btnExit;
  }
}

