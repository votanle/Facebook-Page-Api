using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace API_FB
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var req = WebRequest.Create("https://graph.facebook.com/utc2hcmc/posts?access_token=EAAAAZAw4FxQIBAGmKentnEWvEqAtY6ZBzi1oF0BD5zzQeAToFGZBzh26PIGnPUyrZBOb7QrZCXKuCkdwQFMpmUOzjdZBuUsApV6mqMWXdAuBzcg6g83c9GzwVXjoV1l7qdhtEx6DEbfMk8kMZA61ZAxZCm2sQ05fKOsHKOK3nsX0dfwZDZD" + "");
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();

            Stream stream = res.GetResponseStream();
            StreamReader reader = new StreamReader(stream);

            string responseString = reader.ReadToEnd();
            dynamic data = JsonConvert.DeserializeObject(responseString);

            var result = new List<content>();

            foreach (var i in data.data)
            {
                result.Add(new content
                {
                    Time = i.created_time,
                    Message = i.message,
                    Link = i.actions[0].link
                });
            }

            string contentString = "<h2>3 Bài đăng gần nhất</h2></br>";
            for (int i = 0; i < 3; i++)
            {
                contentString += "<b></br>Bài thứ </b>" + (i + 1) + " : </br></br>";
                contentString += "<b>Ngày đăng : </b>" + result[i].Time + "</br>";
                contentString += "<b>Nội dung : </b>" + result[i].Message + "</br>";
                contentString += "<b>Link bài : </b>" + result[i].Link + "</br></br>";
                contentString += "---------------------------------------------------------";
            }

            lbContent.Text = contentString;
        }
    }
}