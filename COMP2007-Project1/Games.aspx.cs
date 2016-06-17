
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

// using statements that are required to connect to EF DB
using COMP2007_Project1.Models;
using System.Web.ModelBinding;
using System.Linq.Dynamic;

namespace COMP2007_Project1
{
    public partial class Games : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // if loading the page for the first time, populate the student grid
            if (!IsPostBack)
            {
                Session["SortColumn"] = "gameID";
                Session["SortDirection"] = "ASC";
                // Get the student data
                this.GetGames();
            }
        }

        /**
         * <summary>
         * This method gets the games data from the DB
         * </summary>
         * 
         * @method GetGames
         * @returns {void}
         */
        private void GetGames()
        {
            string sortString = Session["SortColumn"].ToString() + " " + Session["SortDirection"].ToString();

            // connect to EF
            using (DefaultConnection1 db = new DefaultConnection1())
            {
                // query the Games Table using EF and LINQ
                var Games = (from allGames in db.Games
                                select allGames);

                // bind the result to the GridView
                GamesGridView.DataSource = Games.AsQueryable().OrderBy(sortString).ToList();
                GamesGridView.DataBind();
            }
        }

        protected void PageSizeDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GamesGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void GamesGridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

        }

        protected void GamesGridView_Sorting(object sender, GridViewSortEventArgs e)
        {

        }

        protected void GamesGridView_RowDataBound(object sender, GridViewRowEventArgs e)
        {

        }
    }
}