using System.Windows.Forms;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Text;
namespace IndirimHesaplayici
{
    public partial class Form1 : Form
    {
        private const string RoomInfo = "rooms.txt";
        private const string DiscountInfo = "discounts.txt";
        int selectedIndex_lstDiscounts = 0;
        int selectedIndex_lstRooms = 0;
        int mod = 0;
        float usd = 0;
        float lira = 0;
        public Form1()
        {
            InitializeComponent();
            LoadRoomsFromFile();
            LoadExchangeFromFile();
            LoadDiscountsFromFile();
            UpdateListBoxes();
            dataGridView1.Columns[2].DefaultCellStyle.BackColor = Color.LightBlue; // Highlight 2nd column


        }

        // ODA AYARLARI KISMI 
        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            string roomName = oda_ayarlari_isim_tb.Text.Trim();
            string roomPrice = "";

            if (string.IsNullOrWhiteSpace(roomName))
            {
                MessageBox.Show("Oda adı giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dataGridView1.Rows.Add(roomName, roomPrice);
            oda_ayarlari_isim_tb.Clear();
            SaveRoomsToFile();
        }

        private void btnDeleteRoom_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.Remove(row);
                }
                SaveRoomsToFile();
            }
            else
            {
                MessageBox.Show("Silinecek Satırı Seçiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SaveRoomsToFile()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(RoomInfo))
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            string roomName = row.Cells[0].Value?.ToString() ?? "";
                            string roomPrice = row.Cells[1].Value?.ToString() ?? "";
                            string ReqPrice = row.Cells[2].Value?.ToString() ?? "";
                            writer.WriteLine($"{roomName},{roomPrice},{ReqPrice}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving to file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadRoomsFromFile()
        {
            if (File.Exists(RoomInfo))
            {
                try
                {
                    string[] lines = File.ReadAllLines(RoomInfo);
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 3)
                        {
                            dataGridView1.Rows.Add(parts[0], parts[1], parts[2]);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading from file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        // ODA AYARLARI KISMI 

        // İNDİRİM AYARLARI KISMI
        private void SaveDiscountsToFile()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("discounts.txt"))
                {
                    foreach (DataGridViewRow row in dataGridViewDiscounts.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            string discountName = row.Cells[0].Value?.ToString() ?? "";
                            string discountChain = row.Cells[1].Value?.ToString() ?? "";
                            string totalDiscount = row.Cells[2].Value?.ToString() ?? "";
                            writer.WriteLine($"{discountName}|{discountChain}|{totalDiscount}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving discounts: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveExchangeRatesToFile()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("exchangerates.txt"))
                {
                    writer.WriteLine($"{usd}|{lira}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving discounts: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadDiscountsFromFile()
        {
            dataGridViewDiscounts.Rows.Clear();

            if (File.Exists("discounts.txt"))
            {
                try
                {
                    string[] lines = File.ReadAllLines("discounts.txt");
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split('|');
                        if (parts.Length == 3)
                        {
                            string discountName = parts[0];
                            string discountChain = parts[1];
                            string totalDiscount = parts[2];
                            dataGridViewDiscounts.Rows.Add(discountName, discountChain, totalDiscount);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading discounts: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void LoadExchangeFromFile()
        {

            if (File.Exists("exchangerates.txt"))
            {
                try
                {
                    string[] lines = File.ReadAllLines("exchangerates.txt");
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split('|');
                        if (parts.Length == 2)
                        {
                            usd = Convert.ToSingle(parts[0]);
                            lira = Convert.ToSingle(parts[1]);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading exchangerates: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                usd_Textbox.Text = Convert.ToString(usd);
                try_Textbox.Text = Convert.ToString(lira);
            }
        }
        private void btnRemoveDiscount_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if a row is selected
                if (dataGridViewDiscounts.SelectedRows.Count > 0)
                {
                    // Get the selected row index
                    int selectedIndex = dataGridViewDiscounts.SelectedRows[0].Index;

                    // Remove the row from DataGridView
                    dataGridViewDiscounts.Rows.RemoveAt(selectedIndex);

                    // After removing, update the discounts file
                    SaveDiscountsToFile();
                }
                else
                {
                    MessageBox.Show("Please select a discount to remove.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error removing discount: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnAddDiscount_Click(object sender, EventArgs e)
        {
            try
            {
                // Read the discount name
                string discountName = txtDiscountName.Text.Trim();
                if (string.IsNullOrWhiteSpace(discountName))
                {
                    MessageBox.Show("Please enter a name for the discount.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Ensure no textbox is empty by setting its value to "0"
                if (string.IsNullOrWhiteSpace(txtDiscount1.Text)) txtDiscount1.Text = "0";
                if (string.IsNullOrWhiteSpace(txtDiscount2.Text)) txtDiscount2.Text = "0";
                if (string.IsNullOrWhiteSpace(txtDiscount3.Text)) txtDiscount3.Text = "0";
                if (string.IsNullOrWhiteSpace(txtDiscount4.Text)) txtDiscount4.Text = "0";
                if (string.IsNullOrWhiteSpace(txtDiscount5.Text)) txtDiscount5.Text = "0";

                // Read discounts from textboxes
                double[] discounts = new double[5];
                discounts[0] = double.Parse(txtDiscount1.Text) / 100.0;
                discounts[1] = double.Parse(txtDiscount2.Text) / 100.0;
                discounts[2] = double.Parse(txtDiscount3.Text) / 100.0;
                discounts[3] = double.Parse(txtDiscount4.Text) / 100.0;
                discounts[4] = double.Parse(txtDiscount5.Text) / 100.0;

                // Calculate the total effective discount
                double totalEffectiveDiscount = 1.0;
                foreach (double discount in discounts)
                {
                    totalEffectiveDiscount *= (1 - discount); // Apply each discount
                }

                // Calculate the total discount percentage
                totalEffectiveDiscount = 100 - ((1 - totalEffectiveDiscount) * 100);

                // Add to DataGridView (including discount name)
                string discountChain = string.Join(" + ", discounts.Select(d => $"{d * 100:0.##}%"));
                dataGridViewDiscounts.Rows.Add(discountName, discountChain, $"{totalEffectiveDiscount:0.##}%");

                // Save to file
                SaveDiscountsToFile();
                LoadDiscountsFromFile();

                // Clear inputs
                txtDiscountName.Clear();
                txtDiscount1.Clear();
                txtDiscount2.Clear();
                txtDiscount3.Clear();
                txtDiscount4.Clear();
                txtDiscount5.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // İNDİRİM AYARLARI KISMI

        // HESAPLAMA KISMI





        private void UpdateListBoxes()
        {
            try
            {
                lstDiscounts.Items.Clear();

                // Update the ListBox for discounts by getting data from DataGridViewDiscounts
                foreach (DataGridViewRow row in dataGridViewDiscounts.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[1].Value != null)
                    {
                        string discountName = row.Cells[0].Value.ToString(); // Assuming discount name is in the first column
                        string discountPercentage = row.Cells[1].Value.ToString(); // Assuming discount percentage is in the second column

                        lstDiscounts.Items.Add($"{discountName} | {discountPercentage}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating ListBoxes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalculateBasePrices()
        {
            if (mod == 0)
            {
                try
                {
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        float desiredPrice = Convert.ToSingle(dataGridView1.Rows[i].Cells[2].Value);
                        float percentage = Convert.ToSingle(Convert.ToString(dataGridViewDiscounts.Rows[selectedIndex_lstDiscounts].Cells[2].Value).TrimEnd('%'));
                        float answer = (desiredPrice * 100) / Convert.ToSingle(percentage);
                        dataGridView1.Rows[i].Cells[1].Value = answer;


                    }
                }
                catch
                {

                }
            }

            if (mod == 1)
            {
                try
                {
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        float baseprice = Convert.ToSingle(dataGridView1.Rows[i].Cells[1].Value);
                        float percentage = Convert.ToSingle(Convert.ToString(dataGridViewDiscounts.Rows[selectedIndex_lstDiscounts].Cells[2].Value).TrimEnd('%'));
                        float answer = (baseprice * Convert.ToSingle(percentage) / 100);
                        dataGridView1.Rows[i].Cells[2].Value = answer;
                    }
                }
                catch
                {

                }
            }

        }

        private void CalculateExchanges()
        {

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                dataGridView1.Rows[i].Cells[3].Value = Convert.ToSingle(dataGridView1.Rows[i].Cells[1].Value) * usd;
                dataGridView1.Rows[i].Cells[4].Value = Convert.ToSingle(dataGridView1.Rows[i].Cells[2].Value) * usd;
                dataGridView1.Rows[i].Cells[5].Value = Convert.ToSingle(dataGridView1.Rows[i].Cells[1].Value) * lira;
                dataGridView1.Rows[i].Cells[6].Value = Convert.ToSingle(dataGridView1.Rows[i].Cells[2].Value) * lira;

            }

        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateListBoxes();
        }

        private void lstDiscounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedIndex_lstDiscounts = lstDiscounts.SelectedIndex;
            CalculateBasePrices();
            SaveRoomsToFile();

        }

        private void ExportDataGridViewToPDF(DataGridView dgv, string filePath)
        {
            System.Text.EncodingProvider ppp = System.Text.CodePagesEncodingProvider.Instance;
            Encoding.RegisterProvider(ppp);
            try
            {
                // Create a PDF document with margins
                Document document = new Document(PageSize.A4, 10f, 10f, 20f, 20f);
                PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
                document.Open();

                // Load Roboto fonts
                string robotoRegularPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Roboto-Regular.ttf");
                BaseFont robotoRegular = BaseFont.CreateFont(robotoRegularPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                iTextSharp.text.Font fontRegular = new iTextSharp.text.Font(robotoRegular, 11);

                // Define softer colors
                BaseColor headerBackgroundColor = new BaseColor(220, 220, 220);
                BaseColor dataBackgroundColor = new BaseColor(245, 245, 245);

                // Add a title above the table for each row group
                for (int i = 0; i < dataGridViewDiscounts.Rows.Count - 1; i++)
                {
                    selectedIndex_lstDiscounts = i;
                    CalculateBasePrices();
                    CalculateExchanges();
                    SaveRoomsToFile();

                    // Add a title above the table
                    string tableTitleText = $"{Convert.ToString(dataGridViewDiscounts.Rows[i].Cells[0].Value)}";
                    Paragraph tableTitle = new Paragraph(tableTitleText, fontRegular)
                    {
                        Alignment = Element.ALIGN_CENTER,
                        SpacingAfter = 10f // Space after the title
                    };
                    document.Add(tableTitle);

                    // Create a table
                    PdfPTable pdfTable = new PdfPTable(dgv.ColumnCount)
                    {
                        WidthPercentage = 100,
                        SpacingBefore = 10f, // Space before the table
                        SpacingAfter = 10f  // Space after the table
                    };

                    // Add headers
                    foreach (DataGridViewColumn column in dgv.Columns)
                    {
                        PdfPCell headerCell = new PdfPCell(new Phrase(column.HeaderText, fontRegular))
                        {
                            BackgroundColor = headerBackgroundColor,
                            HorizontalAlignment = Element.ALIGN_CENTER,
                            Padding = 5
                        };
                        pdfTable.AddCell(headerCell);
                    }

                    // Add rows with alternating softer colors
                    bool alternateRow = false;
                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        if (row.IsNewRow) continue;

                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            string cellValue = cell.Value?.ToString() ?? "";

                            // Apply currency formatting based on the column index
                            if (cell.ColumnIndex == 1 || cell.ColumnIndex == 2) // € for columns 1-2
                            {
                                if (decimal.TryParse(cellValue, out decimal numericValue))
                                    cellValue = $"€ {numericValue:N2}";
                            }
                            else if (cell.ColumnIndex == 3 || cell.ColumnIndex == 4) // $ for columns 3-4
                            {
                                if (decimal.TryParse(cellValue, out decimal numericValue))
                                    cellValue = $"$ {numericValue:N2}";
                            }
                            else if (cell.ColumnIndex == 5 || cell.ColumnIndex == 6) // ₺ for columns 5-6
                            {
                                if (decimal.TryParse(cellValue, out decimal numericValue))
                                    cellValue = $"₺ {numericValue:N2}";
                            }

                            PdfPCell dataCell = new PdfPCell(new Phrase(cellValue, fontRegular))
                            {
                                BackgroundColor = alternateRow ? dataBackgroundColor : BaseColor.WHITE,
                                HorizontalAlignment = Element.ALIGN_CENTER,
                                Padding = 5
                            };
                            pdfTable.AddCell(dataCell);
                        }
                        alternateRow = !alternateRow; // Toggle row color
                    }

                    // Add the table to the PDF document
                    document.Add(pdfTable);
                }

                document.Close();

                MessageBox.Show("PDF'e kaydedildi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PDF çıkarılırken hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }







        private void button3_Click(object sender, EventArgs e)
        {
            CalculateBasePrices();
            CalculateExchanges();

            // Save File Dialog to specify output location
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF Dosyası (*.pdf)|*.pdf",
                Title = "PDF Olarak Kaydet"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportDataGridViewToPDF(dataGridView1, saveFileDialog.FileName);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Toggle `mod` and update button text
            if (mod == 0)
            {
                mod = 1;
                button4.Text = "Mod: İndirimli Fiyat Hesapla";
            }
            else if (mod == 1)
            {
                mod = 0;
                button4.Text = "Mod: Temel Fiyatı Hesapla";
            }

            // Clear data in columns 1-6
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int col = 1; col <= 6; col++)
                {
                    dataGridView1.Rows[i].Cells[col].Value = null;
                }
            }

            // Reset all column styles to default
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.DefaultCellStyle.BackColor = Color.White; // Reset background color to default
            }

            // Highlight the specific column based on `mod`
            if (mod == 0)
            {
                dataGridView1.Columns[2].DefaultCellStyle.BackColor = Color.LightBlue; // Highlight 2nd column
            }
            else if (mod == 1)
            {
                dataGridView1.Columns[1].DefaultCellStyle.BackColor = Color.LightBlue; // Highlight 3rd column
            }
        }

        private void usd_Textbox_TextChanged(object sender, EventArgs e)
        {
            usd = Convert.ToSingle(usd_Textbox.Text);
            SaveExchangeRatesToFile();

        }

        private void try_Textbox_TextChanged(object sender, EventArgs e)
        {
            lira = Convert.ToSingle(try_Textbox.Text);
            SaveExchangeRatesToFile();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Check if the row index is valid and the cell value is not null or DBNull
            if (e.RowIndex >= 0 && e.Value != null && e.Value != DBNull.Value)
            {
                // Try to parse the value as a number
                if (decimal.TryParse(e.Value.ToString(), out decimal numericValue))
                {
                    // Format columns 1-2 with €
                    if (e.ColumnIndex == 1 || e.ColumnIndex == 2)
                    {
                        e.Value = $"€ {numericValue:N2}"; // Formats with 2 decimal places
                        e.FormattingApplied = true;
                    }
                    // Format columns 3-4 with $
                    else if (e.ColumnIndex == 3 || e.ColumnIndex == 4)
                    {
                        e.Value = $"$ {numericValue:N2}";
                        e.FormattingApplied = true;
                    }
                    // Format columns 5-6 with ₺
                    else if (e.ColumnIndex == 5 || e.ColumnIndex == 6)
                    {
                        e.Value = $"₺ {numericValue:N2}";
                        e.FormattingApplied = true;
                    }
                }
            }
        }


    }

    // HESAPLAMA KISMI


    // PDF
}
