using System;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ResumeCustomizer
{
    public partial class Form1 : Form
    {
        private readonly string deepseekApiKey = "API";  // <-- Put your   API Key here

        public Form1()
        {
            InitializeComponent();
        }

       

        private void btnLoadJobDesc_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtJobDesc.Text = File.ReadAllText(ofd.FileName);
            }
        }

        private async void btnGenerate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtResume.Text) || string.IsNullOrWhiteSpace(txtJobDesc.Text))
            {
                MessageBox.Show("Please load both Resume and Job Description.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string prompt = $"Given this Resume:\n{txtResume.Text}\n\nAnd this Job Description:\n{txtJobDesc.Text}\n\n" +
                           "Customize the Resume to better fit the Job Description and write a professional Cover Letter.";

            btnGenerate.Enabled = false;
            btnGenerate.Text = "Generating...";

            try
            {
                string result = await CallDeepSeekAPI(prompt);
                txtOutput.Text = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"API Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnGenerate.Enabled = true;
                btnGenerate.Text = "Generate Resume & Cover Letter";
            }
        }

        private async Task<string> CallDeepSeekAPI(string prompt)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {deepseekApiKey}");

                var requestBody = new
                {
                    model = "deepseek-chat", // Confirm model name in DeepSeek's docs
                    messages = new[]
                    {
                        new { role = "user", content = prompt }
                    },
                    temperature = 0.7,  // Optional: Controls creativity (0-2)
                    max_tokens = 2000   // Optional: Limits response length
                };

                var content = new StringContent(
                    JsonConvert.SerializeObject(requestBody),
                    Encoding.UTF8,
                    "application/json"
                );

                HttpResponseMessage response = await client.PostAsync(
                    "https://api.deepseek.com/v1/chat/completions", // Check DeepSeek's actual API URL
                    content
                );

                string responseString = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception($"API Error: {response.StatusCode}\n{responseString}");
                }

                dynamic jsonResponse = JsonConvert.DeserializeObject(responseString);

                if (jsonResponse?.choices == null || jsonResponse.choices.Count == 0)
                {
                    throw new Exception("No valid response from DeepSeek API.");
                }

                return jsonResponse.choices[0].message.content.ToString().Trim();
            }
        }


        private void BtnLoadResume_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtResume.Text = File.ReadAllText(ofd.FileName);
            }
        }

        private void btnSaveOutput_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text Files|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, txtOutput.Text);
                MessageBox.Show("File saved successfully.");
            }
        }
    }
}
