using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
   static int a=1;
    int s;

    protected void Page_Load(object sender, EventArgs e)
    {
       
           
        
    }
    public int n(int d)
    {

        a ++;
       
            return a;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        a = n(5);
       Response.Write(a);
    }
}