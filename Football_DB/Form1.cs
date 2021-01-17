using System;
using System.Windows.Forms;

namespace Football_DB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'footballDataSet.Enroll' table. You can move, or remove it, as needed.
            this.enrollTableAdapter.Fill(this.footballDataSet.Enroll);
            // TODO: This line of code loads data into the 'footballDataSet.Parents' table. You can move, or remove it, as needed.
            this.parentsTableAdapter.Fill(this.footballDataSet.Parents);
            // TODO: This line of code loads data into the 'footballDataSet.Coach' table. You can move, or remove it, as needed.
            this.coachTableAdapter.Fill(this.footballDataSet.Coach);
            // TODO: This line of code loads data into the 'footballDataSet.Player' table. You can move, or remove it, as needed.
            this.playerTableAdapter.Fill(this.footballDataSet.Player);
            // TODO: This line of code loads data into the 'footballDataSet.Team' table. You can move, or remove it, as needed.
            this.teamTableAdapter.Fill(this.footballDataSet.Team);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.teamTableAdapter.InsertQuery(textBox1.Text, textBox2.Text);
            this.teamTableAdapter.Fill(this.footballDataSet.Team);     //////TEAM ADD

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int PL_ID, T_ID;

            int.TryParse(textBox5.Text, out PL_ID);
            int.TryParse(comboBox1.SelectedValue.ToString(), out T_ID);


            this.playerTableAdapter.InsertQuery(textBox3.Text, textBox4.Text, PL_ID, T_ID);
            this.playerTableAdapter.Fill(this.footballDataSet.Player);      ///////PLAYER ADD


        }

        private void button3_Click(object sender, EventArgs e)
        {
            int C_ID, T_ID;

            int.TryParse(textBox8.Text, out C_ID);
            int.TryParse(comboBox2.SelectedValue.ToString(), out T_ID);


            this.coachTableAdapter.InsertQuery(textBox6.Text, textBox7.Text, C_ID, T_ID);
            this.coachTableAdapter.Fill(this.footballDataSet.Coach);   //////COACH ADD
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int PR_ID;
            int.TryParse(textBox11.Text, out PR_ID);
            this.parentsTableAdapter.InsertQuery(textBox9.Text, textBox10.Text, PR_ID, textBox12.Text);
            this.parentsTableAdapter.Fill(this.footballDataSet.Parents);   ////// PARENT ADD

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int PL_ID, PR_ID;
            int.TryParse(comboBox3.SelectedValue.ToString(), out PL_ID);
            int.TryParse(comboBox4.SelectedValue.ToString(), out PR_ID);
            this.enrollTableAdapter.InsertQuery(PL_ID, PR_ID);
            this.enrollTableAdapter.Fill(this.footballDataSet.Enroll);    ////// ENROLL ADD

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int ID;
            int.TryParse(textBox13.Text, out ID);
            textBox14.Text = this.teamTableAdapter.ScalarQuery1(ID);
            textBox15.Text = this.teamTableAdapter.ScalarQuery2(ID);   ///////SEARCH -TEAM
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int ID;
            int.TryParse(textBox13.Text, out ID);
            this.teamTableAdapter.UpdateQuery(textBox14.Text, textBox15.Text, ID);
            this.teamTableAdapter.Fill(this.footballDataSet.Team);  ///////UPDATE

        }

        private void button8_Click(object sender, EventArgs e)
        {
            int ID;
            int.TryParse(textBox13.Text, out ID);
            this.teamTableAdapter.DeleteQuery(ID);
            this.teamTableAdapter.Fill(this.footballDataSet.Team);

            this.playerTableAdapter.UpdateQuery_Delete_Team(ID);
            this.playerTableAdapter.Fill(this.footballDataSet.Player);

            this.coachTableAdapter.UpdateQuery_Delete_Team(ID);
            this.coachTableAdapter.Fill(this.footballDataSet.Coach); ///////DELETE

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            int ID;
            int.TryParse(textBox16.Text, out ID);
            textBox17.Text = this.playerTableAdapter.ScalarQuery1(ID);
            textBox18.Text = this.playerTableAdapter.ScalarQuery2(ID);
            textBox19.Text = this.playerTableAdapter.ScalarQuery3(ID).ToString();
            comboBox5.SelectedValue = this.playerTableAdapter.ScalarQuery4(ID); //////SEARCH - PLAYER
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int PL_ID, PL_Age, T_ID;
            int.TryParse(textBox16.Text, out PL_ID);
            int.TryParse(textBox19.Text, out PL_Age);
            int.TryParse(comboBox5.SelectedValue.ToString(), out T_ID);

            this.playerTableAdapter.UpdateQuery(textBox17.Text, textBox18.Text, PL_Age, T_ID, PL_ID);
            this.playerTableAdapter.Fill(this.footballDataSet.Player); //////UPDATE

        }

        private void button9_Click(object sender, EventArgs e)
        {
            int ID;
            int.TryParse(textBox16.Text, out ID);
            this.playerTableAdapter.DeleteQuery(ID);
            this.playerTableAdapter.Fill(this.footballDataSet.Player);

            this.enrollTableAdapter.UpdateQuery_Delete_Player(ID);
            this.enrollTableAdapter.Fill(this.footballDataSet.Enroll); /////DELETE

        }

        private void button14_Click(object sender, EventArgs e)
        {
            int ID;
            int.TryParse(textBox20.Text, out ID);
            textBox21.Text = this.coachTableAdapter.ScalarQuery1(ID);
            textBox22.Text = this.coachTableAdapter.ScalarQuery2(ID);
            textBox23.Text = this.coachTableAdapter.ScalarQuery3(ID).ToString();
            comboBox6.SelectedValue = this.coachTableAdapter.ScalarQuery4(ID); //////SEARCH -COACH
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int C_ID, Phone, T_ID;
            int.TryParse(textBox20.Text, out C_ID);
            int.TryParse(textBox23.Text, out Phone);
            int.TryParse(comboBox6.SelectedValue.ToString(), out T_ID);
            this.coachTableAdapter.UpdateQuery(textBox21.Text, textBox22.Text, Phone, T_ID, C_ID);
            this.coachTableAdapter.Fill(this.footballDataSet.Coach); //////UPDATE




        }

        private void button12_Click(object sender, EventArgs e)
        {
            int ID;
            int.TryParse(textBox20.Text, out ID);
            this.coachTableAdapter.DeleteQuery(ID);
            this.coachTableAdapter.Fill(this.footballDataSet.Coach); /////DELETE

        }

        private void button17_Click(object sender, EventArgs e)
        {
            int ID;
            int.TryParse(textBox24.Text, out ID);
            textBox25.Text = this.parentsTableAdapter.ScalarQuery1(ID);
            textBox26.Text = this.parentsTableAdapter.ScalarQuery2(ID);
            textBox27.Text = this.parentsTableAdapter.ScalarQuery3(ID).ToString();
            textBox28.Text = this.parentsTableAdapter.ScalarQuery4(ID);  //////SEARCH-PARENT

        }

        private void button16_Click(object sender, EventArgs e)
        {
            int ID, Phone;
            int.TryParse(textBox24.Text, out ID);
            int.TryParse(textBox27.Text, out Phone);
            this.parentsTableAdapter.UpdateQuery(textBox25.Text, textBox26.Text, Phone, textBox28.Text, ID);
            this.parentsTableAdapter.Fill(this.footballDataSet.Parents);  ///////UPDATE
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int ID;
            int.TryParse(textBox24.Text, out ID);
            this.parentsTableAdapter.DeleteQuery(ID);
            this.parentsTableAdapter.Fill(this.footballDataSet.Parents);

            this.enrollTableAdapter.UpdateQuery_Delete_Parents(ID);
            this.enrollTableAdapter.Fill(this.footballDataSet.Enroll); /////DELETE

        }

        
    }
}