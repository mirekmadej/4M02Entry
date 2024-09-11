namespace _4M02Entry
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void onPacnijClicked(object sender, EventArgs e)
        {
            lblWynik.Text = entTest.Text;
        }
        private void onTextChanged(object sender, EventArgs e)
        {
            lblText.Text = entTest.Text;

        }
        private void onGrzesClicked(object sender, EventArgs e)
        {
            entTest.Text = "Idzie Grześ przez wieś";
        }
        private void btnObliczClicked(object sender, EventArgs e)
        {
            int n1 = int.Parse(enLiczba1.Text);
            int n2 = int.Parse(enLiczba2.Text);
            lblSuma.Text = (n1+n2).ToString();
        }
        private void onSprawdzClicked(object sender, EventArgs e)
        {
            if (enHaslo1.Text == enHaslo2.Text)
                lblHaslo.Text = "hasła zgodne";
            else
                lblHaslo.Text = "hasła niezgodne";
        }

    }

}
