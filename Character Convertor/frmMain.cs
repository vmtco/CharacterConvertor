namespace Character_Convertor
{
    public partial class frmMain : System.Windows.Forms.Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnParse_OnClick(object sender, System.EventArgs e)
        {
            txtOuput.Text = string.Empty;

            foreach ( var c in txtInput.Text )
            {
                switch (cmbConvertType.SelectedItem.ToString())
                {
                    case "Decimal":
                        txtOuput.Text += (@"#" + (System.Convert.ToInt32(c).ToString()));
                        break;
                    case "Hex":
                        var value = System.Convert.ToInt32( c );
                        var hexOutput = string.Format( "{0:X}" ,
                                                       value );
                        txtOuput.Text += @"\u0" + string.Format( "{0:X}" ,
                                                                 hexOutput );
                        break;
                }
            }
        }

        private void frmMain_OnLoad(object sender, System.EventArgs e)
        {
            cmbConvertType.SelectedIndex = 0;
        }

        private void cmbConvertType_OnSelectedIndexChanged(object sender, System.EventArgs e)
        {
            btnParse_OnClick( sender ,
                              e );
        }
    }
}
