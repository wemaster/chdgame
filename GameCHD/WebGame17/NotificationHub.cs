using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace WebGame17
{
     [HubName("notificationHub")]
    public class NotificationHub : Hub
    {
         //public int IDAcc;
        public string TestContent;
        public string TestA;
        public string TestB;
        public string TestC;
        public string TestD;
        public string TestCorrect;
        [HubMethodName("sendNotifications")]
        public string SendNotifications()
        {

            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["chuoiketnoi"].ConnectionString))
            {

                string query = "SELECT TOP 1 TestContent,TestA,TestB,TestC,TestD,TestCorrect FROM wartest ORDER BY NEWID()";

                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Notification = null;

                    DataTable dt = new DataTable();
                    SqlDependency.Start(ConfigurationManager.ConnectionStrings["chuoiketnoi"].ConnectionString);
                    SqlDependency dependency = new SqlDependency(command);

                    dependency.OnChange += new OnChangeEventHandler(dependency_OnChange);

                    if (connection.State == ConnectionState.Closed)

                        connection.Open();
                    var reader = command.ExecuteReader();

                    dt.Load(reader);

                    if (dt.Rows.Count > 0)
                    {

                        TestContent = dt.Rows[0]["TestContent"].ToString();

                        TestA = dt.Rows[0]["TestA"].ToString();

                        TestB = dt.Rows[0]["TestB"].ToString();

                        TestC = dt.Rows[0]["TestC"].ToString();

                        TestD = dt.Rows[0]["TestD"].ToString();

                        TestCorrect = dt.Rows[0]["TestCorrect"].ToString();

                    }

                }

            }

            IHubContext context = GlobalHost.ConnectionManager.GetHubContext<NotificationHub>();

            return (string)context.Clients.All.RecieveNotification(TestContent, TestA, TestB, TestC, TestD, TestCorrect).Result;
        }
        private void dependency_OnChange(object sender, SqlNotificationEventArgs e)
        {

            if (e.Type == SqlNotificationType.Change)
            {

                NotificationHub nHub = new NotificationHub();

                nHub.SendNotifications();

            }

        }
    }
}