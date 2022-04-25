using ChallengeForm.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace ChallengeForm.Controller
{
    internal class Handlefile
    {
        public DataTable dt;
        public Handlefile()
        {
            dt = new DataTable();
        }

        public DataTable LoadCsv(string csvFile)
        {
            try
            {
                bool loadRecord = false;
                string[] lines = File.ReadAllLines(csvFile);
                if (lines.Length > 0)
                {
                    //first line to create header
                    string firstLine = lines[0];
                    string[] headerLabels = firstLine.Split(',');
                    foreach (string headerWord in headerLabels)
                    {
                        dt.Columns.Add(new DataColumn(headerWord));
                    }
                    //For Data
                    for (int i = 1; i < lines.Length; i++)
                    {
                        string[] dataWords = lines[i].Split(',');
                        DataRow dr = dt.NewRow();
                        int columnIndex = 0;
                        loadRecord = false;

                        foreach (string headerWord in headerLabels)
                        {

                            dr[headerWord] = dataWords[columnIndex++];

                            if (dr[headerWord].ToString() != "")
                            {

                                loadRecord = true;

                            }
                        }
                        if (loadRecord)
                        {
                            dt.Rows.Add(dr);

                        }
                    }
                }
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("For some reason we could not load the file. " + ex.Message);
                return null;
            }
        }


        public string Broswer()
        {

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();
            return dlg.FileName;

        }

        public void AlterColumn(DataGridView gridCSV)
        {
            try
            {
                int columnSelected = gridCSV.SelectedCells[0].ColumnIndex;

                for (int i = 0; i < gridCSV.Rows.Count - 1; i++)
                {
                    string temp = gridCSV.Rows[i].Cells[columnSelected].Value.ToString();

                    if (temp.Length != 0)
                    {
                        string newValue = temp.Replace("a", "@");
                        gridCSV.Rows[i].Cells[columnSelected].Value = newValue;
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("For some reason we were unable to alter column. " + ex.Message);

            }
        }

        public void SaveFile(DataGridView gridCSV, string csvFile)
        {
            try
            {
                string separator;
                string File = "new_" + DateTime.Now.ToString("yyyyMMddhhmmss") + "_" + Path.GetFileName(csvFile);
                string nameDirectory = Path.GetDirectoryName(csvFile);
                string pathFile = nameDirectory + "/" + File;
                string lineDetail = "";
                                
                using (FileStream fs = new FileStream(pathFile, FileMode.Append, FileAccess.Write))
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    for (int i = 0; i < gridCSV.Rows.Count - 1; i++)

                    {
                        separator = "";
                        lineDetail = "";
                        for (int j = 0; j < gridCSV.ColumnCount - 1; j++)
                        {
                            lineDetail = lineDetail + separator + gridCSV.Rows[i].Cells[j].Value.ToString();
                            separator = ",";

                        }
                        sw.WriteLine(lineDetail);
                    }
                    sw.Close();
                    fs.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("For some reason we were unable to save the file. " + ex.Message);

            }
        }

        public void LoadComboBox(string CsvFile, ComboBox comboName)
        {

            try
            {
                List<clsCombo> listCombo = new List<clsCombo>();

                string[] lineOfContents = File.ReadAllLines(CsvFile);

                foreach (var line in lineOfContents)
                {

                    clsCombo _clsCombo = new clsCombo();
                    string[] names = line.Split(',');


                    if (names.Length >= 2 & names[0].ToUpper() != "ID")
                    {

                        _clsCombo.id = names[0];
                        _clsCombo.name = names[1];

                        listCombo.Add(_clsCombo);

                    }
                    else if (names[0].ToUpper() == "ID")
                    {

                        _clsCombo.id = "";
                        _clsCombo.name = "Select a user";

                        listCombo.Add(_clsCombo);

                    }
                }



                comboName.DataSource = listCombo;
                comboName.DisplayMember = "name";
                comboName.ValueMember = "id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("For some reason we could not load the file. " + ex.Message);

            }

        }
    }

}
