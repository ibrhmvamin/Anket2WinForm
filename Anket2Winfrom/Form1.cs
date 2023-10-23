using System.Text.Json;

namespace Anket2Winfrom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Worker> workers = new List<Worker>();

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < workers.Count; i++)
            {
                if (workers[i].Mail == mailtb.Text)
                {
                    MessageBox.Show("This mail already exists");
                }
            }
            if (nameTextBox.Text != "" && surnametb.Text != "" && mailtb.Text != ""
                && phonetb.Text != "" )
            {
                Worker w = new Worker(nameTextBox.Text, surnametb.Text, mailtb.Text, phonetb.Text, dateTimePicker1.Value);
                workers.Add(w);
                listBox1.DataSource = null;
                listBox1.DataSource = workers;
                MessageBox.Show("Worker added successfully");
                nameTextBox.ResetText();
                surnametb.ResetText();
                mailtb.ResetText();
                phonetb.ResetText();               

            }
            else
            {
                MessageBox.Show("All datas must be entered");
            }

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (fileNameTextBox.Text.EndsWith("json"))
            {
                string fileName=fileNameTextBox.Text;
                var options = new JsonSerializerOptions { WriteIndented = true };
                string writeTo = JsonSerializer.Serialize(workers, options);
                File.WriteAllText(fileName, writeTo);
                MessageBox.Show($"Worker saved at {fileNameTextBox.Text} successfully");
                nameTextBox.ResetText();
                surnametb.ResetText();
                mailtb.ResetText();
                phonetb.ResetText();
                fileNameTextBox.ResetText();
            }
            else
            {
                MessageBox.Show("Valid file format", "Error", (MessageBoxButtons)DialogResult.OK);
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            if (fileNameTextBox.Text.EndsWith(".json"))
            {
                string fileName= fileNameTextBox.Text;
                string dataFromJson = File.ReadAllText(fileName);
                workers = JsonSerializer.Deserialize<List<Worker>>(dataFromJson)!;

                if (listBox1.DataSource != null)
                    listBox1.DataSource = null;
                    listBox1.DataSource = workers;
            }

            else
            {
                MessageBox.Show("Valid format");
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "" && surnametb.Text != "" && mailtb.Text != ""
                && phonetb.Text != "" && fileNameTextBox.Text != "")
            {
                for (int i = 0; i < workers.Count; i++)
                {
                    if (workers[i].Mail == mailtb.Text)
                    {
                        workers[i].Name=nameTextBox.Text;
                        workers[i].Surname=surnametb.Text;
                        workers[i].Phone=phonetb.Text;
                        workers[i].Date=dateTimePicker1.Value;

                        listBox1.DataSource = null;
                        listBox1.DataSource = workers;
                        MessageBox.Show("Data updated succesfullly");
                    }
                }

            }
        }
    }
}