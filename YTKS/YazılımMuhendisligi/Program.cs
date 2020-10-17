﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazılımMuhendisligi
{
   
    static class Program
    {
        private static void OnApplicationExit(object sender, EventArgs e)
        {
            Program.ses.exit();
        }
        public static uygarEntities1 ctx = new uygarEntities1();
        public static MySession ses = new MySession();
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
           

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.ApplicationExit += new EventHandler(OnApplicationExit);

            /* var ctx = new uygarEntities();

             var x = new transportationservice()
             {
                 Bill_id = 2,
                 Campaign_campaignID = 5,
                 transportationID = 5
             };
             var y = new transportationservice()
             {
                 Bill_id = 1,
                 Campaign_campaignID = 2,
                 transportationID = 3
             };
             ctx.transportationservice.Add(y);
             ctx.transportationservice.Add(x);
             ctx.SaveChanges();
             var a = (from p in ctx.transportationservice where p.Bill_id == 2 select p).SingleOrDefault();
             MessageBox.Show(a.Campaign_campaignID.ToString());
             ctx.transportationservice.Remove(a);
             ctx.SaveChanges();*/
            if (ses.getInstance())
            {
                MessageBox.Show("A Client already opened!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Environment.Exit(1);
            }

            //TODO: Test sonrası loginform acilacak
            Application.Run(new LoginForm());
            //Application.Run(new AG_Panel());
            //Application.Run(new YSP_Panel());
        }

    }
}
