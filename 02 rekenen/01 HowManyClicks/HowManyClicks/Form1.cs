namespace HowManyClicks
{
    public partial class Form1 : Form
    {
        //1)
        private int clicks;

        public Form1()
        {
            InitializeComponent();
            clicks = 0; // Initialiseer clicks op 0
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            //2) tel hier 1 op bij clicks (zie boven in de klas)
            clicks++;
            clicksAmountText.Text = clicks.ToString();
        }
    }
}
