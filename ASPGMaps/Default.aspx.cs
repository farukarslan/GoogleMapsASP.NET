using Subgurim.Controles;
using Subgurim.Controles.GoogleChartIconMaker;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ASPGMaps.Account;
using System.Data.Entity;
using ASPGMaps.model;

namespace ASPGMaps
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Here I used Degha Location as Main Location and Lat Long is : 21.622564, 87.523417
                GLatLng mainLocation = new GLatLng(40.813445, 29.307283);
                GMap1.setCenter(mainLocation, 15);

                XPinLetter xpinLetter = new XPinLetter(PinShapes.pin_star, "H", Color.Blue, Color.White, Color.Chocolate);
                GMap1.Add(new GMarker(mainLocation, new GMarkerOptions(new GIcon(xpinLetter.ToString(), xpinLetter.Shadow()))));

                List<lokasyon> lokasyonlar = new List<lokasyon>();
                using (lokasyonContext dc = new lokasyonContext())
                {
                    lokasyonlar = dc.lokasyonlar.ToList();
                    //lokasyonlar = dc.HotelMasters.Where(a => a.HotelArea.Equals("Digha")).ToList();
                }

                PinIcon p;
                GMarker gm;
                GInfoWindow win;
                foreach (var i in lokasyonlar)
                {
                    p = new PinIcon(PinIcons.home, Color.Cyan);
                    gm = new GMarker(new GLatLng(Convert.ToDouble(i.enlem), Convert.ToDouble(i.boylam)),
                        new GMarkerOptions(new GIcon(p.ToString(), p.Shadow())));

                    win = new GInfoWindow(gm, i.mekan_ismi + " <a href='"+i.siteye_git+"'>Read more...</a>", false, GListener.Event.mouseover);
                    GMap1.Add(win);
                }
            }
        }
    }
}