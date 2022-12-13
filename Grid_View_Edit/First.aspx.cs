using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Grid_View_Edit
{
    public partial class First : System.Web.UI.Page
    {
        DataTable dw=new DataTable();
        Command cm = new Command();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!this.IsPostBack)
            {
                Get_data();
            }
        }

        protected void delete_action(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row=grid_list.Rows[e.RowIndex];
            int id = int.Parse(row.Cells[0].Text);
            cm.Delete_Row(id);
            Get_data();
        }

        protected void update_action(object sender, GridViewUpdateEventArgs e)
        {
            TextBox id = (TextBox)grid_list.Rows[e.RowIndex].Cells[0].Controls[0] ;
            TextBox category_name = (TextBox)grid_list.Rows[e.RowIndex].Cells[1].Controls[0] ;
            TextBox city = (TextBox)grid_list.Rows[e.RowIndex].Cells[2].Controls[0] ;
            TextBox address = (TextBox)grid_list.Rows[e.RowIndex].Cells[3].Controls[0] ;


            cm.Update_Row(id.Text,category_name.Text,address.Text,city.Text);
            grid_list.EditIndex = -1;
            Get_data();

        }

        protected void edit_action(object sender, GridViewEditEventArgs e)
        {
            grid_list.EditIndex = e.NewEditIndex;
            Get_data();
        }

        protected void edit_cancel(object sender, GridViewCancelEditEventArgs e)
        {
           grid_list.EditIndex = -1;
            Get_data();

        }
        protected void Get_data()
        {
            cm.GetData().Fill(dw);
            grid_list.DataSource = dw;
            grid_list.DataBind();
        }
    }
}