using Gma.System.MouseKeyHook;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Átalakító
{
    public partial class Form1 : Form
    {
        private IKeyboardMouseEvents _globalHook;

        List<string> lista_mentés = new List<string>();
        string filePath = "";
        public static int sor = 0;
        string hiba = "";
        string copy_hiba = "";
        bool mentve = false;
        string mikor_mentve = "";
        bool top_is_opened = false;
        bool showed;

        Top_Form tf;
        public static Form1 form_1;
        
        private void Figyeles_ON()
        {
            try
            {
                if (_globalHook == null)
                {
                    _globalHook = Hook.GlobalEvents();
                    _globalHook.KeyUp += GlobalHookOnKeyUp;
                }
            }
            catch (Exception figy_err)
            {
                MessageBox.Show(figy_err.Message);
            }
        }

        private void Automata_Mentés()
        {
            if (!String.IsNullOrWhiteSpace(filePath) && sor % 30 == 0)
            {
                file_iras();
            }
        }

        private void Telekom()
        {
            if (Clipboard.ContainsText(TextDataFormat.Text))
            {
                string clipboardText = Clipboard.GetText(TextDataFormat.Text);
                if (!String.IsNullOrWhiteSpace(clipboardText))
                {
                    string split_str_név = "";
                    string split_str_cím = "";
                    string split_str_phone1 = "";

                    string[] tömb_név = clipboardText.ToString().Split('+');
                    split_str_név = tömb_név[0].Trim();

                    string név_után = tömb_név[1];
                    string első_betű = new String(név_után.Where(Char.IsUpper).ToArray());
                    string város_elsőbetű = első_betű[0].ToString();

                    string[] tömb_telefon = tömb_név[1].Split(new string[] { város_elsőbetű }, StringSplitOptions.None);
                    split_str_phone1 = tömb_telefon[0].Trim();

                    int telefon_számláló = split_str_phone1.Count();
                    string telefon1 = "";
                    string irsz = "";

                    if (telefon_számláló == 19)
                    {
                        telefon1 = split_str_phone1.Substring(0, 14);
                        irsz = split_str_phone1.Substring(15, 4);
                    }
                    else if (telefon_számláló == 20)
                    {
                        telefon1 = split_str_phone1.Substring(0, 15);
                        irsz = split_str_phone1.Substring(16, 4);
                    }

                    if (tömb_telefon.Length > 2)
                    {
                        split_str_cím = irsz + " " + város_elsőbetű.ToString() + tömb_telefon[2].Trim();
                    }
                    else
                    {
                        split_str_cím = irsz + " " + város_elsőbetű.ToString() + tömb_telefon[1];
                    }
                    listBox1.Items.Add(split_str_név + " // " + split_str_cím + " // " + telefon1);
                    if (!String.IsNullOrWhiteSpace(split_str_név) && !String.IsNullOrWhiteSpace(split_str_cím) && !String.IsNullOrWhiteSpace(split_str_phone1))
                    {
                        Clipboard.Clear();
                    }
                    lbl_sor.Text = listBox1.Items.Count.ToString() + " sor";
                    Automata_Mentés();
                }
            }
        }

        private void Telenor()
        {
            if (Clipboard.ContainsText(TextDataFormat.Text))
            {
                string clipboardText = Clipboard.GetText(TextDataFormat.Text);
                if (!String.IsNullOrWhiteSpace(clipboardText))
                {
                    string split_str_név = "";
                    string split_str_phone1 = "";
                    string telefon = "";

                    string[] tömb = clipboardText.ToString().Split('+');
                    split_str_név = tömb[0].Trim();
                    split_str_phone1 = tömb[1].Trim();

                    //if (split_str_phone1.Length == 12)
                    //{
                    //    telefon = split_str_phone1[0] + split_str_phone1[1] +split_str_phone1[3] + split_str_phone1[4] + split_str_phone1[5] + split_str_phone1[6] + split_str_phone1[7] + split_str_phone1[8] + split_str_phone1[9] + split_str_phone1[10] + split_str_phone1[11]+" ";
                    //}

                    if (!String.IsNullOrWhiteSpace(txt_telenor_cim.Text))
                    {
                        string split_str_cím = txt_telenor_cim.Text.Trim() + " utca";
                        if (!String.IsNullOrWhiteSpace(split_str_név) && !String.IsNullOrWhiteSpace(split_str_cím) && !String.IsNullOrWhiteSpace(split_str_phone1))
                        {
                            listBox1.Items.Add(split_str_név + " // " + split_str_cím + " // " + split_str_phone1);
                            Clipboard.Clear();
                        }
                    }
                    else
                    {
                        if (!String.IsNullOrWhiteSpace(split_str_név) && !String.IsNullOrWhiteSpace(split_str_phone1))
                        {
                            listBox1.Items.Add(split_str_név + " // " + split_str_phone1);
                            Clipboard.Clear();
                        }
                    }
                    lbl_sor.Text = listBox1.Items.Count.ToString() + " sor";
                    Automata_Mentés();
                }
            }
        }

        private void Vodafone()
        {
            if (Clipboard.ContainsText(TextDataFormat.Text))
            {
                string clipboardText = Clipboard.GetText(TextDataFormat.Text);
                if (!String.IsNullOrWhiteSpace(clipboardText))
                {
                    string split_str_név = "";
                    string split_irsz = "";
                    string split_város = "";
                    string split_utca = "";
                    string split_str_phone1 = "";

                    string telefon = "";

                    string[]tömb_sorok= clipboardText.ToString().Split('\n');

                    for (int i = 0; i < tömb_sorok.Length; i++)
                    {
                        string[] tömb = tömb_sorok[i].Split('\t');
                        split_str_név = tömb[0].Trim();
                        split_str_phone1 = tömb[1].Trim();
                        split_irsz = tömb[2].Trim();
                        split_város = tömb[3].Trim();
                        split_utca = tömb[4].Trim();
                        if (split_str_phone1.Length == 9)
                        {
                            telefon = "36" + split_str_phone1[0] + split_str_phone1[1] + split_str_phone1[2] + split_str_phone1[3] + split_str_phone1[4] + split_str_phone1[5] + split_str_phone1[6] + split_str_phone1[7] + split_str_phone1[8];
                        }
                        if (!String.IsNullOrWhiteSpace(split_str_név) && !String.IsNullOrWhiteSpace(split_irsz) && !String.IsNullOrWhiteSpace(split_város) && !String.IsNullOrWhiteSpace(split_utca) && !String.IsNullOrWhiteSpace(telefon))
                        {
                            listBox1.Items.Add(split_str_név + " // " + split_irsz + " " + split_város + " " + split_utca + " // " + telefon);
                            Clipboard.Clear();
                        }
                        lbl_sor.Text = listBox1.Items.Count.ToString() + " sor";
                        Automata_Mentés();
                    }
                }
            }
        }

        private void Digi()
        {
            if (Clipboard.ContainsText(TextDataFormat.Text))
            {
                string clipboardText = Clipboard.GetText(TextDataFormat.Text);
                if (!String.IsNullOrWhiteSpace(clipboardText))
                {
                    string split_str_név = "";
                    string split_irsz = "";
                    string split_város = "";
                    string split_utca = "";

                    string telefon = "";

                    string[] tömb_név = clipboardText.ToString().Split('-');
                    
                    if (tömb_név.Length==3)
                    {
                        split_str_név = tömb_név[0].Trim();
                        telefon = "3652" + tömb_név[2].Trim();
                        string[] tömb_város = tömb_név[1].Split('\n');
                        split_város = tömb_város[0].Replace("Település:", "");
                        string[] tömb_város2 = split_város.Split(' ');
                        split_város = tömb_város2[1].Trim();

                        string[] tömb_irsz = tömb_város[0].Split('(');
                        split_irsz = tömb_irsz[1].Replace(")", "").Trim();

                        string[] tömb_utca = clipboardText.ToString().Split(new string[] { "Cím:" }, StringSplitOptions.None);
                        string[] tömb_utca2 = tömb_utca[1].Split(new string[] { "Telefonszám:" }, StringSplitOptions.None);
                        split_utca = tömb_utca2[0].Trim();
                    }
                    else if(tömb_név.Length==4)
                    {
                        split_str_név = tömb_név[0].Trim()+"-"+tömb_név[1].Trim();
                        telefon = "3652" + tömb_név[3].Trim();
                        string[] tömb_város = tömb_név[2].Split('\n');
                        split_város = tömb_város[0].Replace("Település:", "");
                        string[] tömb_város2 = split_város.Split(' ');
                        split_város = tömb_város2[1].Trim();

                        string[] tömb_irsz = tömb_város[0].Split('(');
                        split_irsz = tömb_irsz[1].Replace(")", "").Trim();

                        string[] tömb_utca = clipboardText.ToString().Split(new string[] { "Cím:" }, StringSplitOptions.None);
                        string[] tömb_utca2 = tömb_utca[1].Split(new string[] { "Telefonszám:" }, StringSplitOptions.None);
                        split_utca = tömb_utca2[0].Trim();
                    }
                    if (!String.IsNullOrWhiteSpace(split_str_név) && !String.IsNullOrWhiteSpace(split_irsz) && !String.IsNullOrWhiteSpace(split_város) && !String.IsNullOrWhiteSpace(split_utca) && !String.IsNullOrWhiteSpace(telefon))
                    {
                        listBox1.Items.Add(split_str_név + " // " + split_irsz + " " + split_város + ", " + split_utca + " // " + telefon);
                        Clipboard.Clear();
                    }
                    //listBox1.Items.Add(clipboardText);
                    lbl_sor.Text = listBox1.Items.Count.ToString() + " sor";
                    Automata_Mentés();
                }
            }
        }

        private void Invitel()
        {
            if (Clipboard.ContainsText(TextDataFormat.Text))
            {
                string clipboardText = Clipboard.GetText(TextDataFormat.Text);
                if (!String.IsNullOrWhiteSpace(clipboardText))
                {
                    string[] tömb_sorok = clipboardText.ToString().Split('\n');

                    for (int i = 0; i < tömb_sorok.Length; i++)
                    {
                        string[] tömb = tömb_sorok[i].ToString().Split('\t');
                        string split_str_név = tömb[0].Trim();
                        string split_foglalkozás = tömb[1].Trim();
                        string split_str_phone1 = tömb[2].Trim();
                        string split_cím = tömb[3].Trim();
                        string telefon = "";
                        string marketing = "";
                        if (tömb.Length>4)
                        {
                            marketing = tömb[4];
                        }

                        if (split_str_phone1.Length == 11)
                        {
                            telefon = "36" + split_str_phone1[1] + split_str_phone1[2] + split_str_phone1[5] + split_str_phone1[6] + split_str_phone1[7] + split_str_phone1[8] + split_str_phone1[9] + split_str_phone1[10];
                        }
                        if (!String.IsNullOrWhiteSpace(split_str_név) && !String.IsNullOrWhiteSpace(split_cím) && !String.IsNullOrWhiteSpace(telefon))
                        {
                            listBox1.Items.Add(split_str_név + " // " + split_cím + " // " + telefon + " // " + marketing);
                            Clipboard.Clear();
                        }
                        lbl_sor.Text = listBox1.Items.Count.ToString() + " sor";
                        Automata_Mentés();
                    }
                }
            }
        }

        private void GlobalHookOnKeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                timer1.Stop();
                if (e.KeyCode == Keys.C && figyeles_BE.Checked && rb_telekom.Checked)
                {
                    Telekom();
                }
                else if (e.KeyCode == Keys.C && figyeles_BE.Checked && rb_telenor.Checked)
                {
                    Telenor();
                }
                else if (e.KeyCode == Keys.C && figyeles_BE.Checked && rb_vodafone.Checked)
                {
                    Vodafone();
                }
                else if (e.KeyCode == Keys.C && figyeles_BE.Checked && rb_digi.Checked)
                {
                    Digi();
                }
                else if (e.KeyCode == Keys.C && figyeles_BE.Checked && rb_invitel.Checked)
                {
                    Invitel();
                }
                timer1.Start();
            }
            catch (Exception copy_err)
            {
                copy_hiba = copy_err.Message;
            }
            //catch (IndexOutOfRangeException copy_err)
            //{
            //    if (!String.IsNullOrWhiteSpace(copy_err.Message) && !showed)
            //    {
            //        showed = true;
            //        DialogResult result = MessageBox.Show("Ellenőrizze, hogy jó szolgáltató van-e kiválasztva!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //        if (result == DialogResult.OK)
            //        {
            //            showed=false;
            //        }
            //    }
            //}
        }

        private void Figyeles_OFF()
        {
            if (_globalHook != null)
            {
                _globalHook.KeyUp -= GlobalHookOnKeyUp;
                _globalHook.Dispose();
            }
        }

        public Form1()
        {
            InitializeComponent();
            try
            {
                form_1 = this;
                tf = new Top_Form();
                tf.Show();
                tf.TopMost = true;
                this.KeyPreview = true;
                Figyeles_ON();
                pic_red.Visible = false;
                pic_green.Visible = true;
                pic_tcom.Visible = true;
                pic_telenor.Visible = false;
                pic_voda.Visible = false;
                pic_invitel.Visible = false;
                pic_digi.Visible = false;
                lbl_segedablak.BackColor = Color.ForestGreen;
                lbl_segedablak.ForeColor = Color.White;

                mentve = false;
                showed = false;

                rb_xls.Checked = true;
                figyeles_BE.Checked = true;
                rb_telekom.Checked = true;
                lbl_sor.Text = listBox1.Items.Count.ToString()+" sor";

                if (figyeles_BE.Checked)
                {
                    lbl_gombfigyel.Text = "";
                }

                if (String.IsNullOrWhiteSpace(filePath))
                {
                    lbl_file.ForeColor = System.Drawing.Color.Red;
                    lbl_file.BackColor = System.Drawing.Color.White;
                    lbl_file.Text = "Nincs kiválasztva fájl!";
                }
                if (!mentve)
                {
                    lbl_mentve.ForeColor = System.Drawing.Color.Red;
                    lbl_mentve.BackColor = System.Drawing.Color.White;
                    lbl_mentve.Text = "Nincs mentve";
                }

                if (figyeles_BE.Checked && rb_telenor.Checked)
                {
                    lbl_telenor_cim.Visible = true;
                    txt_telenor_cim.Visible = true;
                }
                else
                {
                    lbl_telenor_cim.Visible = false;
                    txt_telenor_cim.Visible = false;
                }
            }
            catch (Exception load_err)
            {
                MessageBox.Show(load_err.Message);
            }
        }

        private void BTN_file_valaszt_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();

                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    filePath = ofd.FileName;
                    if (!String.IsNullOrWhiteSpace(filePath))
                    {
                        lbl_file.ForeColor = System.Drawing.Color.Black;
                        lbl_file.BackColor = System.Drawing.Color.Transparent;
                        lbl_file.Text = "Fájl kiválasztva.";
                    }
                    else if (String.IsNullOrWhiteSpace(filePath))
                    {
                        lbl_file.ForeColor = System.Drawing.Color.Red;
                        lbl_file.BackColor = System.Drawing.Color.White;
                        lbl_file.Text = "Nincs kiválasztva fájl!";
                    }
                }
            }
            catch (Exception file_err)
            {
                MessageBox.Show(file_err.Message);
            }
        }

        private void file_iras()
        {
            try
            {
                hiba = "";
                string change_xls = Path.ChangeExtension(filePath,".xls");
                string change_xlsx = Path.ChangeExtension(filePath, ".xlsx");
                string change_odt = Path.ChangeExtension(filePath, ".odt");

                DataTable dt = new DataTable();
                dt.Columns.Add("Név");
                dt.Columns.Add("Cím");
                dt.Columns.Add("Phone_1");
                dt.Columns.Add("Phone_2");
                dt.Columns.Add("Phone_3");

                string str_név = "";
                string str_cím = "";
                string str_phone1 = "";
                string str_phone2 = "";
                string str_phone3 = "";

                DataRow dr = null;
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    dr = dt.NewRow();
                    string currentItem = listBox1.Items[i].ToString();

                    string[] lista_tömb = currentItem.ToString().Split(new string[] { " // " }, StringSplitOptions.None);

                    if (lista_tömb.Length == 1)
                    {
                        str_név = lista_tömb[0].Trim();
                    }
                    else if (lista_tömb.Length == 2)
                    {
                        str_név = lista_tömb[0].Trim();
                        str_cím = lista_tömb[1].Trim();
                    }
                    else if (lista_tömb.Length == 3)
                    {
                        str_név = lista_tömb[0].Trim();
                        str_cím = lista_tömb[1].Trim();
                        str_phone1 = lista_tömb[2].Trim();
                    }
                    else if (lista_tömb.Length == 4)
                    {
                        str_név = lista_tömb[0].Trim();
                        str_cím = lista_tömb[1].Trim();
                        str_phone1 = lista_tömb[2].Trim();
                        str_phone2 = lista_tömb[3].Trim();
                    }
                    else if (lista_tömb.Length == 5)
                    {
                        str_név = lista_tömb[0].Trim();
                        str_cím = lista_tömb[1].Trim();
                        str_phone1 = lista_tömb[2].Trim();
                        str_phone2 = lista_tömb[3].Trim();
                        str_phone3 = lista_tömb[4].Trim();
                    }

                    dr["Név"] = str_név;
                    dr["Cím"] = str_cím;
                    dr["Phone_1"] = str_phone1;
                    dr["Phone_2"] = str_phone2;
                    dr["Phone_3"] = str_phone3;

                    dt.Rows.Add(dr);
                }
                DataSet ds = new DataSet();
                ds.Tables.Add(dt);
                if (String.IsNullOrWhiteSpace(filePath))
                {
                    hiba+= "Válasszon ki egy fájlt!"+Environment.NewLine;
                    
                }
                else
                {
                    if (rb_xls.Checked)
                    {
                        ExcelLibrary.DataSetHelper.CreateWorkbook(change_xls, ds);
                    }
                    else if (rb_xlsx.Checked)
                    {
                        ExcelLibrary.DataSetHelper.CreateWorkbook(change_xlsx, ds);
                    }
                    else if (rb_odt.Checked)
                    {
                        ExcelLibrary.DataSetHelper.CreateWorkbook(change_odt, ds);
                    }
                }
            }
            catch (Exception err)
            {
                hiba += err.Message + Environment.NewLine;
            }
            if (String.IsNullOrWhiteSpace(hiba))
            {
                mentve = true;
                mikor_mentve = DateTime.Now.ToString();
                if (mentve && !String.IsNullOrWhiteSpace(mikor_mentve) && !String.IsNullOrWhiteSpace(filePath))
                {
                    lbl_mentve.ForeColor = System.Drawing.Color.Black;
                    lbl_mentve.BackColor = System.Drawing.Color.Transparent;
                    lbl_mentve.Text = "Mentve: "+Environment.NewLine + mikor_mentve;
                }
            }
            else if (!String.IsNullOrWhiteSpace(hiba))
            {
                MessageBox.Show(hiba, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void BTN_file_iras_Click(object sender, EventArgs e)
        {
            file_iras();
            if (mentve && !String.IsNullOrWhiteSpace(mikor_mentve) && !String.IsNullOrWhiteSpace(filePath))
            {
                MessageBox.Show("Sikeres mentés!", "Mentve",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BTN_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.SelectedIndex != -1)
                {
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                    lbl_sor.Text = listBox1.Items.Count.ToString() + " sor";
                    Top_Form.top_form_1.lbl_szam.Text = listBox1.Items.Count.ToString();
                }
                else if (listBox1.SelectedIndex == -1)
                {
                    MessageBox.Show("Válasszon ki egy sort a listából!");
                }
            }
            catch (Exception delete_err)
            {
                MessageBox.Show(delete_err.Message);
            }
        }

        public void Vágólapra()
        {
            string clipboardText = "";
            string név = "";
            string cím = "";
            string tel1 = "";
            string tel2 = "";
            string tel3 = "";

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                név = "";
                cím = "";
                tel1 = "";
                tel2 = "";
                tel3 = "";

                bool marketing = false;
                string currentItem = listBox1.Items[i].ToString();
                if (currentItem.Contains("Direkt marketing tiltás!"))
                {
                    marketing = false;
                }
                else
                {
                    marketing = true;
                }
                if (marketing)
                {
                    string[] tömb = currentItem.Split(new string[] { " // " }, StringSplitOptions.None);
                    if (tömb.Length == 1)
                    {
                        név = tömb[0].Trim();
                    }
                    else if (tömb.Length == 2)
                    {
                        név = tömb[0].Trim();
                        cím = tömb[1].Trim();
                    }
                    else if (tömb.Length == 3)
                    {
                        név = tömb[0].Trim();
                        cím = tömb[1].Trim();
                        tel1 = tömb[2].Trim();
                    }
                    else if (tömb.Length == 4)
                    {
                        név = tömb[0].Trim();
                        cím = tömb[1].Trim();
                        tel1 = tömb[2].Trim();
                        if (!String.IsNullOrWhiteSpace(tömb[3])) 
                        {
                            tel2 = tömb[3].Trim();
                        }
                    }
                    else if (tömb.Length == 5)
                    {
                        név = tömb[0].Trim();
                        cím = tömb[1].Trim();
                        tel1 = tömb[2].Trim();
                        if (!String.IsNullOrWhiteSpace(tömb[3]))
                        {
                            tel2 = tömb[3].Trim();
                        }
                        if (!String.IsNullOrWhiteSpace(tömb[4]))
                        {
                            tel3 = tömb[4].Trim();
                        }
                    }
                    clipboardText += név + "\t" + cím + "\t" + tel1 + "\t" + tel2 + "\t" + tel3 + "\t\n";
                    Clipboard.SetText(clipboardText.ToString(), TextDataFormat.Text);
                    //Clipboard.GetText(TextDataFormat.Text) = clipboardText;
                }
                
            }
            
        }

        private void BTN_lista_clip_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count>0)
            {
                Vágólapra();
                Lista_Törlés();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string split_str_név = "";
                string split_str_cím = "";
                string split_str_phone1 = "";
                string split_str_phone2 = "";
                string split_str_phone3 = "";

                if (listBox1.SelectedItem != null)
                {
                    string[] lista_tömb = listBox1.SelectedItem.ToString().Split(new string[] { " // " }, StringSplitOptions.None);
                    if (lista_tömb.Length == 1)
                    {
                        split_str_név = lista_tömb[0].Trim();
                    }
                    else if (lista_tömb.Length == 2)
                    {
                        split_str_név = lista_tömb[0].Trim();
                        split_str_cím = lista_tömb[1].Trim();
                    }
                    else if (lista_tömb.Length == 3)
                    {
                        split_str_név = lista_tömb[0].Trim();
                        split_str_cím = lista_tömb[1].Trim();
                        split_str_phone1 = lista_tömb[2].Trim();
                    }
                    else if (lista_tömb.Length == 4)
                    {
                        split_str_név = lista_tömb[0].Trim();
                        split_str_cím = lista_tömb[1].Trim();
                        split_str_phone1 = lista_tömb[2].Trim();
                        if (!String.IsNullOrWhiteSpace(lista_tömb[3]))
                        {
                            split_str_phone2 = lista_tömb[3].Trim();
                        }
                        
                    }
                    else if (lista_tömb.Length == 5)
                    {
                        split_str_név = lista_tömb[0].Trim();
                        split_str_cím = lista_tömb[1].Trim();
                        split_str_phone1 = lista_tömb[2].Trim();
                        if (!String.IsNullOrWhiteSpace(lista_tömb[3]))
                        {
                            split_str_phone2 = lista_tömb[3].Trim();
                        }
                        if (!String.IsNullOrWhiteSpace(lista_tömb[4]))
                        {
                            split_str_phone3 = lista_tömb[3].Trim();
                        }
                    }

                    txt_nev.Text = split_str_név;
                    txt_cim.Text = split_str_cím;
                    txt_telefon1.Text = split_str_phone1;
                    txt_telefon2.Text = split_str_phone2;
                    txt_telefon3.Text = split_str_phone3;
                }
            }
            catch (Exception select_err)
            {
                MessageBox.Show(select_err.Message);
            }

        }

        private void BTN_modosit_Click(object sender, EventArgs e)
        {
            try
            {
                string összes = "";
                if (listBox1.SelectedIndex != -1)
                {
                    int index = listBox1.SelectedIndex;
                    listBox1.Items.RemoveAt(index);
                    if (!String.IsNullOrWhiteSpace(txt_nev.Text))
                    {
                        összes += txt_nev.Text;
                        if (!String.IsNullOrWhiteSpace(txt_cim.Text))
                        {
                            összes += " // ";
                        }
                    }
                    if (!String.IsNullOrWhiteSpace(txt_cim.Text))
                    {
                        összes += txt_cim.Text;
                        if (!String.IsNullOrWhiteSpace(txt_telefon1.Text))
                        {
                            összes += " // ";
                        }
                    }
                    if (!String.IsNullOrWhiteSpace(txt_telefon1.Text))
                    {
                        összes += txt_telefon1.Text;
                        if (!String.IsNullOrWhiteSpace(txt_telefon2.Text))
                        {
                            összes += " // ";
                        }
                    }
                    if (!String.IsNullOrWhiteSpace(txt_telefon2.Text) && !String.IsNullOrWhiteSpace(txt_telefon1.Text))
                    {
                        összes += txt_telefon2.Text;
                        if (!String.IsNullOrWhiteSpace(txt_telefon3.Text))
                        {
                            összes += " // ";
                        }
                    }
                    if (!String.IsNullOrWhiteSpace(txt_telefon3.Text) && !String.IsNullOrWhiteSpace(txt_telefon2.Text))
                    {
                        összes += txt_telefon3.Text;
                    }
                    if (!String.IsNullOrWhiteSpace(txt_nev.Text) && !String.IsNullOrWhiteSpace(txt_cim.Text))
                    {
                        listBox1.Items.Insert(index, összes);
                    }
                    txt_nev.Text = "";
                    txt_cim.Text = "";
                    txt_telefon1.Text = "";
                    txt_telefon2.Text = "";
                    txt_telefon3.Text = "";
                }
                else if (listBox1.SelectedIndex == -1)
                {
                    MessageBox.Show("Válasszon ki egy sort a listából!");
                }
            }
            catch (Exception modosit_err)
            {
                MessageBox.Show(modosit_err.Message);
            }
        }

        public void Lista_Törlés()
        {
            try
            {
                listBox1.Items.Clear();
                sor = listBox1.Items.Count;
                lbl_sor.Text = sor.ToString() + " sor";
            }
            catch (Exception list_delete_err)
            {
                MessageBox.Show(list_delete_err.Message);
            }
        }

        private void BTN_delete_list_Click(object sender, EventArgs e)
        {
            Lista_Törlés();
        }

        private void figyeles_BE_CheckedChanged(object sender, EventArgs e)
        {
            if (figyeles_KI.Checked)
            {
                lbl_gombfigyel.ForeColor = System.Drawing.Color.Red;
                lbl_gombfigyel.BackColor = System.Drawing.Color.Yellow;
                lbl_gombfigyel.Text = "Gomb figyelés KIKAPCSOLVA!";
                lbl_szolgaltato.Text = "";
                lbl_telenor_cim.Visible = false;
                txt_telenor_cim.Visible = false;
                pic_red.Visible = true;
                pic_green.Visible = false;
                Top_Form.top_form_1.pic_tcom.Visible = false;
                Top_Form.top_form_1.pic_telenor.Visible = false;
                Top_Form.top_form_1.pic_voda.Visible = false;
                Top_Form.top_form_1.pic_invitel.Visible = false;
                Top_Form.top_form_1.pic_digi.Visible = false;
                pic_tcom.Visible = false;
                pic_telenor.Visible = false;
                pic_voda.Visible = false;
                pic_invitel.Visible = false;
                pic_digi.Visible = false;
            }
        }

        private void figyeles_KI_CheckedChanged(object sender, EventArgs e)
        {
            if (figyeles_BE.Checked)
            {
                lbl_gombfigyel.Text = "";
                pic_red.Visible = false;
                pic_green.Visible = true;
                if (rb_telekom.Checked)
                {
                    lbl_szolgaltato.Text = "Telekom";
                    Top_Form.top_form_1.pic_tcom.Visible = true;
                    Top_Form.top_form_1.pic_telenor.Visible = false;
                    Top_Form.top_form_1.pic_voda.Visible = false;
                    Top_Form.top_form_1.pic_invitel.Visible = false;
                    Top_Form.top_form_1.pic_digi.Visible = false;
                    pic_tcom.Visible = true;
                    pic_telenor.Visible = false;
                    pic_voda.Visible = false;
                    pic_invitel.Visible = false;
                    pic_digi.Visible = false;
                }
                else if (rb_telenor.Checked)
                {
                    lbl_szolgaltato.Text = "Telenor";
                    lbl_telenor_cim.Visible = true;
                    txt_telenor_cim.Visible = true;
                    Top_Form.top_form_1.pic_tcom.Visible = false;
                    Top_Form.top_form_1.pic_telenor.Visible = true;
                    Top_Form.top_form_1.pic_voda.Visible = false;
                    Top_Form.top_form_1.pic_invitel.Visible = false;
                    Top_Form.top_form_1.pic_digi.Visible = false;
                    pic_tcom.Visible = false;
                    pic_telenor.Visible = true;
                    pic_voda.Visible = false;
                    pic_invitel.Visible = false;
                    pic_digi.Visible = false;
                }
                else if (rb_vodafone.Checked)
                {
                    lbl_szolgaltato.Text = "Vodafone";
                    Top_Form.top_form_1.pic_tcom.Visible = false;
                    Top_Form.top_form_1.pic_telenor.Visible = false;
                    Top_Form.top_form_1.pic_voda.Visible = true;
                    Top_Form.top_form_1.pic_invitel.Visible = false;
                    Top_Form.top_form_1.pic_digi.Visible = false;
                    pic_tcom.Visible = false;
                    pic_telenor.Visible = false;
                    pic_voda.Visible = true;
                    pic_invitel.Visible = false;
                    pic_digi.Visible = false;
                }
                else if (rb_invitel.Checked)
                {
                    lbl_szolgaltato.Text = "Invitel";
                    Top_Form.top_form_1.pic_tcom.Visible = false;
                    Top_Form.top_form_1.pic_telenor.Visible = false;
                    Top_Form.top_form_1.pic_voda.Visible = false;
                    Top_Form.top_form_1.pic_invitel.Visible = true;
                    Top_Form.top_form_1.pic_digi.Visible = false;
                    pic_tcom.Visible = false;
                    pic_telenor.Visible = false;
                    pic_voda.Visible = false;
                    pic_invitel.Visible = true;
                    pic_digi.Visible = false;
                }
                else if (rb_digi.Checked)
                {
                    lbl_szolgaltato.Text = "Digi";
                    Top_Form.top_form_1.pic_tcom.Visible = false;
                    Top_Form.top_form_1.pic_telenor.Visible = false;
                    Top_Form.top_form_1.pic_voda.Visible = false;
                    Top_Form.top_form_1.pic_invitel.Visible = false;
                    Top_Form.top_form_1.pic_digi.Visible = true;
                    pic_tcom.Visible = false;
                    pic_telenor.Visible = false;
                    pic_voda.Visible = false;
                    pic_invitel.Visible = false;
                    pic_digi.Visible = true;
                }
            }
        }

        public void Lista_Mentés()
        {
            try
            {
                if (listBox1.Items.Count != 0)
                {
                    lista_mentés.Clear();
                    for (int i = 0; i < listBox1.Items.Count; i++)
                    {
                        string currentItem = listBox1.Items[i].ToString();
                        lista_mentés.Add(currentItem);
                    }
                }
            }
            catch (Exception lista_delete_err)
            {
                MessageBox.Show(lista_delete_err.Message);
            }
        }

        private void BTN_lista_delete_Click(object sender, EventArgs e)
        {
            Lista_Mentés();
            if (listBox1.Items.Count != 0)
            {
                listBox1.Items.Clear();
                Top_Form.top_form_1.lbl_szam.Text = listBox1.Items.Count.ToString();
                lbl_sor.Text = listBox1.Items.Count.ToString() + " sor";
            }
        }

        private void rb_telekom_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_telekom.Checked && figyeles_BE.Checked)
            {
                lbl_szolgaltato.Text = "Telekom";
                lbl_telenor_cim.Visible = false;
                txt_telenor_cim.Visible = false;
                //lbl_szolgaltato.BackColor = Color.White;
                //lbl_szolgaltato.ForeColor = Color.Magenta;
                Top_Form.top_form_1.pic_tcom.Visible = true;
                Top_Form.top_form_1.pic_telenor.Visible = false;
                Top_Form.top_form_1.pic_voda.Visible = false;
                Top_Form.top_form_1.pic_invitel.Visible = false;
                Top_Form.top_form_1.pic_digi.Visible = false;
                pic_tcom.Visible = true;
                pic_telenor.Visible = false;
                pic_voda.Visible = false;
                pic_invitel.Visible = false;
                pic_digi.Visible = false;
            }
        }

        private void rb_telenor_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_telenor.Checked && figyeles_BE.Checked)
            {
                lbl_szolgaltato.Text = "Telenor";
                lbl_telenor_cim.Visible = true;
                txt_telenor_cim.Visible = true;
                //lbl_szolgaltato.BackColor = Color.White;
                //lbl_szolgaltato.ForeColor = Color.LightSkyBlue;
                Top_Form.top_form_1.pic_tcom.Visible = false;
                Top_Form.top_form_1.pic_telenor.Visible = true;
                Top_Form.top_form_1.pic_voda.Visible = false;
                Top_Form.top_form_1.pic_invitel.Visible = false;
                Top_Form.top_form_1.pic_digi.Visible = false;
                pic_tcom.Visible = false;
                pic_telenor.Visible = true;
                pic_voda.Visible = false;
                pic_invitel.Visible = false;
                pic_digi.Visible = false;
            }
        }

        private void rb_vodafone_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_vodafone.Checked && figyeles_BE.Checked)
            {
                lbl_szolgaltato.Text = "Vodafone";
                lbl_telenor_cim.Visible = false;
                txt_telenor_cim.Visible = false;
                //lbl_szolgaltato.BackColor = Color.White;
                //lbl_szolgaltato.ForeColor = Color.Red;
                Top_Form.top_form_1.pic_tcom.Visible = false;
                Top_Form.top_form_1.pic_telenor.Visible = false;
                Top_Form.top_form_1.pic_voda.Visible = true;
                Top_Form.top_form_1.pic_invitel.Visible = false;
                Top_Form.top_form_1.pic_digi.Visible = false;
                pic_tcom.Visible = false;
                pic_telenor.Visible = false;
                pic_voda.Visible = true;
                pic_invitel.Visible = false;
                pic_digi.Visible = false;
            }
        }

        private void rb_digi_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_digi.Checked && figyeles_BE.Checked)
            {
                lbl_szolgaltato.Text = "Digi";
                lbl_telenor_cim.Visible = false;
                txt_telenor_cim.Visible = false;
                //lbl_szolgaltato.BackColor = Color.White;
                //lbl_szolgaltato.ForeColor = Color.Red;
                Top_Form.top_form_1.pic_tcom.Visible = false;
                Top_Form.top_form_1.pic_telenor.Visible = false;
                Top_Form.top_form_1.pic_voda.Visible = false;
                Top_Form.top_form_1.pic_invitel.Visible = false;
                Top_Form.top_form_1.pic_digi.Visible = true;
                pic_tcom.Visible = false;
                pic_telenor.Visible = false;
                pic_voda.Visible = false;
                pic_invitel.Visible = false;
                pic_digi.Visible = true;
            }
        }

        private void rb_invitel_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_invitel.Checked && figyeles_BE.Checked)
            {
                lbl_szolgaltato.Text = "Invitel";
                lbl_telenor_cim.Visible = false;
                txt_telenor_cim.Visible = false;
                //lbl_szolgaltato.BackColor = Color.White;
                //lbl_szolgaltato.ForeColor = Color.Red;
                Top_Form.top_form_1.pic_tcom.Visible = false;
                Top_Form.top_form_1.pic_telenor.Visible = false;
                Top_Form.top_form_1.pic_voda.Visible = false;
                Top_Form.top_form_1.pic_invitel.Visible = true;
                Top_Form.top_form_1.pic_digi.Visible = false;
                pic_tcom.Visible = false;
                pic_telenor.Visible = false;
                pic_voda.Visible = false;
                pic_invitel.Visible = true;
                pic_digi.Visible = false;
            }
        }

        private void check_topform_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (check_topform.Checked)
                {
                    tf = new Top_Form();
                    tf.Show();
                    tf.TopMost =true;
                    lbl_segedablak.BackColor = Color.ForestGreen;
                    lbl_segedablak.ForeColor = Color.White;
                }
                else if (!check_topform.Checked)
                {
                    lbl_segedablak.BackColor = Color.Red;
                    lbl_segedablak.ForeColor = Color.White;
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name == "Top_Form")
                        {
                            f.Close();
                        }
                    }
                    Top_Form.top_form_1.Hide();
                }
            }
            catch (Exception check_err)
            {

            }
        }

        private void back_arrow_Click(object sender, EventArgs e)
        {
            foreach (var item in lista_mentés)
            {
                listBox1.Items.Add(item);
            }
            lbl_sor.Text = listBox1.Items.Count.ToString() + " sor";
            lista_mentés.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Top_Form.top_form_1.lbl_szam.Text = listBox1.Items.Count.ToString();
        }
    }
}
