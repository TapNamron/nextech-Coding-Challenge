﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Diagnostics;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace CodingChallenge
{
  public class JsonFiles
  {
    public async void ReadJsonFilesAsync(List<string> URLs, ListView lstStories)
    {
      try
      {
        foreach (string ListURLs in URLs)
        {
          using (var httpClient = new HttpClient())
          {
            var json = await httpClient.GetStringAsync(ListURLs);

            dynamic data = JsonConvert.DeserializeObject<dynamic>(json);

            string strTitle = data.title;
            string strAuthor = data.by;

            string[] row = { strTitle, strAuthor };
            var listViewItem = new ListViewItem(row);
            lstStories.Items.Add(listViewItem);

          }
        }
      }
      catch(Exception ex)
      {
        MessageBox.Show(ex.Message, "Error message");
      }
    }
  }


}
