using System;
using System.Linq;

namespace BankApplication
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetAccountList();
            }
        }

        protected string GetAccountType(object obj)
        {
            string accountTypeCode = obj as string;
            if (accountTypeCode != null)
            {
                if (accountTypeCode == "1")
                {
                    return "Saving Deposit";
                }
                else if (accountTypeCode == "2")
                {
                    return "Current Deposit";
                }
                else if (accountTypeCode == "3")
                {
                    return "Fixed Deposit";
                }
            }

            return string.Empty;
        }



        private void GetAccountList()
        {
            using (var db = new BankDbDataContext())
            {
                gvList.DataSource = db.Accounts.Where(z => z.IBAN.Contains(txtAccount.Text.Trim()));
                gvList.DataBind();
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            GetAccountList();
        }
    }
}