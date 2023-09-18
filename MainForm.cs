/// loosely following https://www.youtube.com/playlist?list=PLBLPjjQlnVXVLh8nQWR9M5ADH1iZ6cX5D
/// 09/14/2023 yelir
/// also, https://www.youtube.com/watch?v=0zLZQesgV5o


namespace econtact
{
    public partial class MainForm : Form
    {
        // constructor: calling this function initializes the instance
        public MainForm()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            /// button clicks cause events

            /// create message box on click
            MessageBox.Show($"Hello {tbFirst.Text} {tbLast.Text}");

            /// you can also change properties of objects within the events
            btnAdd.Text = "holy moly";
        }


        /// event for when the mouse leaves the add button
        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            // changing properties of instance
            btnAdd.Text += "z";
            ///MessageBox.Show($"don leav me don leav");
        }

        private void toolAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"here's my about, created by yelir");
        }

        private void toolExit_Click(object sender, EventArgs e)
        {
            // close on press
            this.Close();
        }


        // testing the open form button
        private void openForm1Button_Click(object sender, EventArgs e)
        {
            // make the new instance and show it
            // this constructor will call "InitializeComponent()" in the other form
            Form1 frm = new("opened from the main form");
            frm.Show();
        }
    }
}