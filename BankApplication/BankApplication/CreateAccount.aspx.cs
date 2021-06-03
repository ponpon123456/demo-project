using System;

namespace BankApplication
{
    public partial class CreateAccount : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            using (var db = new BankDbDataContext())
            {
                var entity = new Account()
                {
                    IBAN = hidIBAN.Value,
                    AccountTypeCode = ddlAccountType.SelectedValue,
                    Firstname = txtFirstname.Text.Trim(),
                    Lastname = txtLastname.Text.Trim(),
                    Address = txtAddress.Text.Trim(),
                    Mobile = txtMobile.Text.Trim(),
                    TransactionDate = DateTime.Now
                };
                db.Accounts.InsertOnSubmit(entity);
                db.SubmitChanges();
            }

            Response.Redirect("home.aspx");
        }




    }
}