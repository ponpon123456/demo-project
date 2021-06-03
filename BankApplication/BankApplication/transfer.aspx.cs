using System;
using System.Linq;
using System.Web.UI.WebControls;

namespace BankApplication
{
    public partial class transfer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblIBAN.Text = Request["IBAN"];
                BindAccountTo();
            }
        }


        private void BindAccountTo()
        {
            using (var db = new BankDbDataContext())
            {
                ddlAccountTo.DataSource = db.Accounts.Where(z => z.IBAN != lblIBAN.Text).ToList();
                ddlAccountTo.DataBind();
                ddlAccountTo.Items.Insert(0, new ListItem() { Text = "Please select", Value = "" });
            }
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            decimal amountCredit = decimal.Parse(hidAmount.Value);
            double amountDebit = (double)amountCredit;

            if (amountDebit > 0)
            {
                amountDebit = amountDebit - ((amountDebit * 0.1) / 100);
            }

            using (var db = new BankDbDataContext())
            {
                var entityDbCredit = db.Accounts.FirstOrDefault(z => z.IBAN == Request["IBAN"]);
                var entityDbDebit = db.Accounts.FirstOrDefault(z => z.IBAN == ddlAccountTo.SelectedValue);

                var entityTransaction = new TransactionAccount()
                {
                    FromIBAN = lblIBAN.Text,
                    ToIBAN = ddlAccountTo.SelectedValue,
                    Amount = amountCredit,
                    TransactionTypeCode = "3",
                    TransactionDate = DateTime.Now
                };

                db.TransactionAccounts.InsertOnSubmit(entityTransaction);
                entityDbCredit.Balance = entityDbCredit.Balance - amountCredit;
                entityDbDebit.Balance = entityDbDebit.Balance + (decimal)amountDebit;
                db.SubmitChanges();
            }

            Response.Redirect("home.aspx");
        }




    }
}