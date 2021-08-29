using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace WindowsFormsApplication1
    
{
    
    public partial class scoreBoard : Form
    {
        string dataSource = "Data Source = (LocalDB)\\MSSQLLocalDB; Integrated Security=SSPI; AttachDbFilename=E:\\Homework for C#\\Final Project\\WindowsFormsApplication1\\Scores.mdf";
        public scoreBoard()
        {
            InitializeComponent();// I integrated the score board into my project
            tableDataGridView.Refresh();
            showAllScoresButton.Visible = false;// makes most of the score board buttons, text boxes and label invisible till needed
            showUserScoresButton.Visible = false;
            fNameLabel2.Visible = false;
            lNameLabel2.Visible = false;
            fNameTextBox2.Visible = false;
            lNameTextBox2.Visible = false;
            firstNameLabel.Visible = false;
            lastNameLabel.Visible = false;
            fNameTextBox.Visible = false;
            lNameTextBox.Visible = false;
            enterButton.Visible = false;
            updateLabel.Visible = false;
            idNumberLabel.Visible = false;
            updateIDEntry.Visible = false;
            deleteIDEntry.Visible = false;
            deleteLabel.Visible = false;
            deleteButton.Visible = false;
            tableDataGridView.Visible = false;
            newEntryLabel.Visible = false;
            updateButton.Visible = false;
        }
        public void data(int a)
        {

            string scoreString = a.ToString();// posts the final score in the final score text mox
            finalScore.Text = scoreString;
            

        }
        

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.scoreDataSet);

        }

        private void scoreBoard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'scoreDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.scoreDataSet.Table);

        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            string fName = Convert.ToString(fNameTextBox.Text);// converst the text in the text boxes to string
            string lName = Convert.ToString(lNameTextBox.Text);     // and assinged them to the respective variables
            int score =Int32.Parse(finalScore.Text) ;// just used as a test case score, will use the players score when I attach this to the game
            SqlConnection sqlconn = new SqlConnection(dataSource);// creates an instance of SqlConnect class
            using (sqlconn)
            {
                sqlconn.Open();// opens the connection to the database
                try             //this block of code below creates a SQL query that inserts a new row into our databse
                {
                    string comandText = "INSERT INTO [dbo].[Table] ([fName], [lName], [score]) VALUES(@value1,@value2,@value3)";// this uses the insert
                    using (SqlCommand sqldata = new SqlCommand(comandText, sqlconn))
                    {

                        sqldata.Parameters.AddWithValue("@value1", fName);// this assignd the textbox values into the variables in the commandtext string
                        sqldata.Parameters.AddWithValue("@value2", lName);
                        sqldata.Parameters.AddWithValue("@value3", score);
                        int result = sqldata.ExecuteNonQuery();// this execute the update to the databse
                        MessageBox.Show("completed");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error on insert");// shows the error message if the databse doesn't udpate

                }

                tableDataGridView.Refresh();// refreshes the table grid and makes it visible
                tableDataGridView.Visible = true;

                //  sqlconn.Close();// closes the connection to the databse
                //  Application.Exit();// exits the application
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            int enteredID = Int32.Parse(updateIDEntry.Text);

            SqlConnection sqCon = new SqlConnection(dataSource);// most of the code is the same as the delete function
            sqCon.Open();                                       // except that the random nmber generator is a place holder for 
            Random r1 = new Random();                           // a new score in the finished final project
            int newScore = r1.Next(1, 500);



            string comandText = "Update [dbo].[Table] SET [Score]= @value1 WHERE [id]=@value2";


            try
            {
                using (SqlCommand sqldata = new SqlCommand(comandText, sqCon))
                {
                    sqldata.Parameters.AddWithValue("@value2", enteredID);// replaces commandText string variable 1 with user ID
                    sqldata.Parameters.AddWithValue("@value1", newScore);// replaces value 2 with the new score
                    sqldata.ExecuteNonQuery();// runs the update to the server

                }
            }
            catch (Exception)// exception 
            {

                MessageBox.Show("Update failed");
            }
            MessageBox.Show("Updated");
            tableDataGridView.Refresh();// refreshes the table grid and makes it visible
            tableDataGridView.Visible = true;
            //    sqCon.Close();
            //    Application.Exit();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int enteredID = Int32.Parse(deleteIDEntry.Text);// converts the inputed ID value to an int

         SqlConnection sqCon = new SqlConnection(dataSource);// creates and instance of the SQLconnection class
           sqCon.Open();// opens a connection to the databe


            string comandText = "DELETE FROM [dbo].[Table] WHERE ID = @value1";// the string for deleting 


            try
            {
                using (SqlCommand sqldata = new SqlCommand(comandText, sqCon))
                {
                    sqldata.Parameters.AddWithValue("@value1", enteredID);// assinges the user id value to the variable in the string
                    sqldata.ExecuteNonQuery();// executes the delete function

                }
            }
            catch (Exception)
            {

                MessageBox.Show("failure in deleting");// shows 
            }
            MessageBox.Show("Deleted");
            tableDataGridView.Refresh();
            tableDataGridView.Visible = true;
            //   sqCon.Close();

            // Application.Exit();
        }

        private void lNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void deleteIDEntry_TextChanged(object sender, EventArgs e)
        {

        }

        private void showAllScoresButton_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext Query = new DataClasses1DataContext();// makes an instance of our LINQ class for using stored proccedures
            tableDataGridView.DataSource = Query.FindAllScores();// calls the find all scores stored proccedure
            tableDataGridView.Refresh();// refreshes the table and makes it visible
            tableDataGridView.Visible = true;

        }

        private void showUserScoresButton_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext Query = new DataClasses1DataContext();// makes an instance of our LINQ class for using stored proccedures
            tableDataGridView.IsAccessible = true;
            tableDataGridView.DataSource = Query.FindScores(fNameTextBox2.Text, lNameTextBox2.Text);// calls the Find Scores Sored proccedure
            tableDataGridView.Refresh();
            tableDataGridView.Visible = true;// makes the data grid visible
        }

        private void saveYourScoreRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            firstNameLabel.Visible = true;lastNameLabel.Visible = true;// these radial buttons hide unneeded buttons, boxes and labels
            fNameTextBox.Visible = true;                                // and make visible to ones needed for each group of functions
            lNameTextBox.Visible = true;
            enterButton.Visible = true;
            updateLabel.Visible = true;
            idNumberLabel.Visible = true;
            updateIDEntry.Visible = true;
            updateButton.Visible = true;
            newEntryLabel.Visible = true;

            finaScoreLabel.Visible = true;
            finalScore.Visible = true;


            showAllScoresButton.Visible = false;
            showUserScoresButton.Visible = false;
            fNameLabel2.Visible = false;
            lNameLabel2.Visible = false;
            fNameTextBox2.Visible = false;
            lNameTextBox2.Visible = false;
            deleteIDEntry.Visible = false;
            deleteLabel.Visible = false;
            deleteButton.Visible = false;
            tableDataGridView.Visible = false;
        }

        private void viewScoresRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            showAllScoresButton.Visible = true;
            showUserScoresButton.Visible = true;
            fNameLabel2.Visible = true;
            lNameLabel2.Visible = true;
            fNameTextBox2.Visible = true;
            lNameTextBox2.Visible = true;
            finaScoreLabel.Visible = false;
            finalScore.Visible = false;

            firstNameLabel.Visible = false;
            lastNameLabel.Visible = false;
            fNameTextBox.Visible = false;
            lNameTextBox.Visible = false;
            enterButton.Visible = false;
            updateLabel.Visible = false;
            idNumberLabel.Visible = false;
            updateIDEntry.Visible = false;
            deleteIDEntry.Visible = false;
            deleteLabel.Visible = false;
            deleteButton.Visible = false;
            updateButton.Visible = false;
            newEntryLabel.Visible = false;
            tableDataGridView.Visible = false;
        }

        private void manageDataBaseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            deleteIDEntry.Visible = true;
            deleteLabel.Visible = true;
            deleteButton.Visible = true;
            finaScoreLabel.Visible = false;
            finalScore.Visible = false;
            tableDataGridView.Visible = true;

            showAllScoresButton.Visible = false;
            showUserScoresButton.Visible = false;
            fNameLabel2.Visible = false;
            lNameLabel2.Visible = false;
            fNameTextBox2.Visible = false;
            lNameTextBox2.Visible = false;
            firstNameLabel.Visible = false;
            lastNameLabel.Visible = false;
            fNameTextBox.Visible = false;
            lNameTextBox.Visible = false;
            enterButton.Visible = false;
            updateLabel.Visible = false;
            idNumberLabel.Visible = false;
            updateIDEntry.Visible = false;
            updateButton.Visible = false;
            newEntryLabel.Visible = false;
        }

        private void tableDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
