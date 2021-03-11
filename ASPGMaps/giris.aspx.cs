using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ASPGMaps.model;

namespace ASPGMaps
{
    public partial class giris : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            lokasyonContext db = new lokasyonContext();
            lokasyon yenilokasyon = new lokasyon();
            yenilokasyon.bolge = TextBoxbolge.Text;
            yenilokasyon.mekan_ismi = TextBoxmekan.Text;

            yenilokasyon.enlem = TextBoxenlem.Text;

            yenilokasyon.boylam = TextBoxboylam.Text;

            yenilokasyon.siteye_git = TextBoxsite.Text;
            db.lokasyonlar.Add(yenilokasyon);
            db.SaveChanges();

        }
    }
}