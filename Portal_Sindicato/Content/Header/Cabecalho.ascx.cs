﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Content_Header_Cabecalho : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblData.Text = DateTime.Now.ToString("dd/MM/yyyy");
    }
}