using System;
using System.Linq;

namespace BankApplication
{
    public partial class deposit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblIBAN.Text = Request["IBAN"];
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            double amount = double.Parse(hidAmount.Value);

            if (amount > 0)
            {
                amount = amount - ((amount * 0.1) / 100);
            }

            using (var db = new BankDbDataContext())
            {
                var entityDb = db.Accounts.FirstOrDefault(z => z.IBAN == Request["IBAN"]);

                var entity = new TransactionAccount()
                {
                    FromIBAN = lblIBAN.Text,
                    ToIBAN = lblIBAN.Text,
                    Amount = (decimal)amount,
                    TransactionTypeCode = "1",
                    TransactionDate = DateTime.Now
                };

                db.TransactionAccounts.InsertOnSubmit(entity);
                entityDb.Balance = entityDb.Balance + (decimal)amount;
                db.SubmitChanges();
            }

            Response.Redirect("home.aspx");
        }




    }
}