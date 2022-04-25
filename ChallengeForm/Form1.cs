using ChallengeForm.Controller;
using System;
using System.Windows.Forms;


namespace ChallengeForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     
        private void btnLoad_Click(object sender, EventArgs e)
        {
            Handlefile _handfile = new Handlefile();
            gridCSV.DataSource = _handfile.LoadCsv(textFile.Text);

        }

        private void bntBroswer_Click(object sender, EventArgs e)
        {

            Handlefile _handfile = new Handlefile();
            textFile.Text = _handfile.Broswer();
        }

        private void bntSave_Click(object sender, EventArgs e)
        {

            Handlefile _handfile = new Handlefile();
            _handfile.SaveFile(gridCSV, textFile.Text);

        }

        private void bntAlter_Click(object sender, EventArgs e)
        {
            Handlefile _handfile = new Handlefile();
            _handfile.AlterColumn(gridCSV);

        }

      
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnReturnId_Click(object sender, EventArgs e)
        {
           MessageBox.Show("The selected id was: " + comboName.SelectedValue);
        }

        private void comboName_SelectionChangeCommitted(object sender, EventArgs e)
        {

            btnReturnId.Text = comboName.SelectedValue.ToString();
        }
      
        private void btnBrowserComboBox_Click(object sender, EventArgs e)
        {
            Handlefile _handfile = new Handlefile();
            textFileComboBox.Text = _handfile.Broswer();

        }

        private void btnLoadComboBox_Click(object sender, EventArgs e)
        {
            Handlefile _handfile = new Handlefile();
            _handfile.LoadComboBox(textFileComboBox.Text, comboName);
            
           
        }

      
    }



}
