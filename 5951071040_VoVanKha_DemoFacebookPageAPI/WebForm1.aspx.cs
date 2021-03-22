using _5951071040_VoVanKha_DemoFacebookPageAPI.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _5951071040_VoVanKha_DemoFacebookPageAPI
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String token = "EAAAAZAw4FxQIBAC6RBqA9EzL8eH79z757aif4m5Cooc8BZAmMZBhSJIfiRZC3ZCeC3pVxy4iTQvH1n2stuXnZBY9bvPt2YAaGthKOc7UFHvPWkfTJHsfvpTM9VX1oB7edgvzZCJHkTVemV5Oc5OJuoApqpScTZA9i4sCYpB6Yrzj3QZDZD";
            var request = WebRequest.Create("https://graph.facebook.com/utc2hcmc/posts?access_token="+token);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader streamReader = new StreamReader(stream);
            string responseString = streamReader.ReadToEnd();
            dynamic jsonData = JsonConvert.DeserializeObject(responseString);
            var results = new List<Post>();
            foreach(var item in jsonData.data)
            {
                results.Add(new Post
                {
                    Time = item.created_time,
                    Content = item.message,
                    Link = item.actions[0].link,
                });
            }
            String post = "";
            for(int i = 1; i <= 3; i++)
            {
                post += "Post: " +(i) + "</br>";
                post += "Time: " + results[i].Time + "</br>";
                post += "Content: " + results[i].Content + "</br>";
                post += "Link: " + results[i].Link + "</br>";
            }
            lbContent.Text = post;
        }
    }
}