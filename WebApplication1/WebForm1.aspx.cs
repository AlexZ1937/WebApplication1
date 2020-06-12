using System;
using System.Web.ModelBinding;


namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                Anketa rsvp = new Anketa();
                if (TryUpdateModel(rsvp, new FormValueProvider(ModelBindingExecutionContext)))
                {
                    ResponseRepository.GetRepository().AddResponse(rsvp);
                    if (rsvp.Info==null || rsvp.Teleph == null || rsvp.Mark == null || rsvp.Model == null || rsvp.Numbrg == null || rsvp.Name == null)
                    {
                        Response.Redirect("NoPage1.html");
                    }
                    else
                    {
                        bool onecheck = false;
                        try
                        {
                            int h=Convert.ToInt32(rsvp.Teleph);
                        }
                        catch(Exception ex)
                        {
                            onecheck = true;
                            Response.Redirect("NotNumPage1.html");
                        }
                        if (onecheck == false)
                        {
                            if (rsvp.Teleph.Length != 10)
                            {
                                Response.Redirect("LenPage1.html");
                            }
                            else
                            {
                                Response.Redirect("OkPage1.html");
                            }
                        }
                    }
                }
            }
        }
    }
}