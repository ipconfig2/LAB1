﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab1
{
    public partial class HelloWorld : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.lblHello2.Text = "Hello World!";
            this.lblHello2.Font.Bold = true;
            this.lblHello2.Font.Italic = true;
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            this.litName.Text = "Hello " + this.txtName.Text.Trim();
            Response.Write(this.txtName.Text.Trim());
        }
    }
}