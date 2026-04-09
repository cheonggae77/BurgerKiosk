namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        int totalCost = 0;
        private readonly Control[] tabCycleControls;

        public Form1()
        {
            InitializeComponent();
            tabCycleControls = [btnOrder, btnClear, rdoHamBurger, chkPotato];
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Tab)
            {
                int index = Array.FindIndex(tabCycleControls, c => c.Focused);
                if (index >= 0)
                {
                    int next = (index + 1) % tabCycleControls.Length;
                    tabCycleControls[next].Focus();
                    return true;
                }
            }
            if (keyData == Keys.Enter)
            {
                if (ActiveControl is CheckBox chk)
                {
                    chk.Checked = !chk.Checked;
                    return true;
                }
                if (ActiveControl is RadioButton rdo)
                {
                    rdo.Checked = true;
                    return true;
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {


            if (rdoHamBurger.Checked)
            {
                lstOrder.Items.Add("햄버거 5,000원");
                totalCost += 5000;
            }
            else if (rdoBulgogiBurger.Checked)
            {
                lstOrder.Items.Add("불고기버거 4,000원");
                totalCost += 4000;
            }
            else if (rdoChickenBurger.Checked)
            {
                lstOrder.Items.Add("치킨버거 3,000원");
                totalCost += 3000;
            }
            if (chkPotato.Checked)
            {
                lstOrder.Items.Add("감자튀김 3,500원");
                totalCost += 3500;
            }
            if (chkCola.Checked)
            {
                lstOrder.Items.Add("콜라 2,500원");
                totalCost += 2500;
            }
            if (chkCheese.Checked)
            {
                lstOrder.Items.Add("치즈 1,500원");
                totalCost += 1500;
            }
            if (chkSause.Checked)
            {
                lstOrder.Items.Add("소스 500원");
                totalCost += 500;
            }
            if (!rdoHamBurger.Checked && !rdoBulgogiBurger.Checked && !rdoChickenBurger.Checked && !chkPotato.Checked && !chkCola.Checked && !chkCheese.Checked && !chkSause.Checked)
            {
                lblTotalCost.Text = "메뉴를 선택해주세요.";

            }
            else
            {
                lblTotalCost.Text = $"총 금액 : {totalCost.ToString("N0")}원";
            }
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            rdoHamBurger.Checked = false;
            rdoBulgogiBurger.Checked = false;
            rdoChickenBurger.Checked = false;
            chkPotato.Checked = false;
            chkCola.Checked = false;
            chkCheese.Checked = false;
            chkSause.Checked = false;
            lblTotalCost.Text = "총 금액 : 0원";
            lstOrder.Items.Clear();
            totalCost = 0;
        }
    }
}
