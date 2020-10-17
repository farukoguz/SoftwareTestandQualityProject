﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazılımMuhendisligi
{
    public class MySession
    {
        public MySession() {}
        public void exit()
        {
            try
            {
                var res = Program.ctx.session.SingleOrDefault(b => b.id == 0);
                res.isActive = false;
                Program.ctx.SaveChanges();
            }
            catch (Exception) {
              
            }
        }
        public bool getInstance()
        {
            var qry = from r in Program.ctx.session where r.id == 0 select r;
            session res = null;
            bool ret = false;
            try
            {
                res = qry.FirstOrDefault();
                ret = res.isActive;
            }
           catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Couldn't connect-- database! "+e.Message, "Warning!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
                Environment.Exit(1);
            }
            if (!res.isActive)
            {
                res.isActive = true;
                Program.ctx.SaveChanges();
            }
            return ret;
        }
    }
}
