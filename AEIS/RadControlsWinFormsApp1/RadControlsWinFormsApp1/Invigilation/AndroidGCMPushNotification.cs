using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace AEIS.Invigilation
{
    class AndroidGCMPushNotification
    {
        public AndroidGCMPushNotification()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public string SendNotification(string deviceId, string message, String type)
        {
            string help = "";
            string cheat = "";

            if (type.Equals("H"))
            {
                help = "1";
                cheat = "0";
            }

            else if (type.Equals("S"))
            {
                cheat = "1";
                help = "0";
            }

            string GoogleAppID = "AIzaSyB4dOAfzmu-6GKYma6aSyG-crGoNRx8kW4";
            var SENDER_ID = "144947602532";
            var value = message;
            WebRequest tRequest;
            tRequest = WebRequest.Create("https://android.googleapis.com/gcm/send");
            tRequest.Method = "post";
            tRequest.ContentType = " application/x-www-form-urlencoded;charset=UTF-8";
            tRequest.Headers.Add(string.Format("Authorization: key={0}", GoogleAppID));
            tRequest.Headers.Add(string.Format("Sender: id={0}", SENDER_ID));
            string postData = "collapse_key=score_update&time_to_live=108&delay_while_idle=0&data.message=" + value + "&data.time=" + System.DateTime.Now.ToString() + "&registration_id=" + deviceId + "&data.help=" + help + "&data.cheat=" + cheat;
            Console.WriteLine(postData);
            Byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            tRequest.ContentLength = byteArray.Length;
            Stream dataStream = tRequest.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();
            WebResponse tResponse = tRequest.GetResponse();
            dataStream = tResponse.GetResponseStream();
            StreamReader tReader = new StreamReader(dataStream);
            String sResponseFromServer = tReader.ReadToEnd();
            tReader.Close();
            dataStream.Close();
            tResponse.Close();
            return sResponseFromServer;
        }
    }
}
