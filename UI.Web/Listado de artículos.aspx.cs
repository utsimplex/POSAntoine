using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Data.Database;

public partial class Listado_de_artículos : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void odsArticulos_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
    {

    }
    protected void txtFiltro_TextChanged(object sender, EventArgs e)
    {
        if (txtFiltro.Text == "")
        {
            gvArticulos.DataSourceID = "odsArticulos";
        }
        else
        {
            gvArticulos.DataSourceID = "odsActualizar";
        }
    }
}
