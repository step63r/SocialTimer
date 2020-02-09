using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace SocialTimer
{
    public partial class CreateNewTimer : Form
    {
        public Main ParentForm;
        public bool NameValidity;

        public CreateNewTimer()
        {
            InitializeComponent();
        }

        private void inputName_Leave(object sender, EventArgs e)
        {
            if (inputName.Text == "")
            {
                NameValidity = false;
                inputName.ForeColor = Color.Gray;
                inputName.Text = "名前を入力";
            }
            else
            {
                NameValidity = true;
            }
        }

        private void inputName_Enter(object sender, EventArgs e)
        {
            if (inputName.Text == "名前を入力" && NameValidity == false)
            {
                inputName.ForeColor = Color.Black;
                inputName.Text = "";
            }
        }

        private void inputName_TextChanged(object sender, EventArgs e)
        {
            if (inputName.Text == "" || (inputName.Text == "名前を入力" && NameValidity == false))
            {
                buttonCreate.Enabled = false;
                buttonCreateAsDefault.Enabled = false;
            }
            else
            {
                NameValidity = true;
                buttonCreate.Enabled = true;
                buttonCreateAsDefault.Enabled = true;
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            string _tName = inputName.Text;
            int _tMaxLP, _tCurrentLP, _tRecoverCycle;
            TimeSet _TimeSet = new TimeSet();

            _tMaxLP = (int)inputMaxLP.Value;
            _tCurrentLP = (int)inputCurrentLP.Value;
            _tRecoverCycle = (int)inputRecoverCycle.Value;

            try
            {
                ParentForm.SetTimer(_tName, _tMaxLP, _tCurrentLP, _tRecoverCycle, out _TimeSet.tName, out _TimeSet.tHour, out _TimeSet.tMinute, out _TimeSet.tSecond, out _TimeSet.tDate);
                ParentForm.CreatetForm(_TimeSet);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Nortification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCreateAsDefault_Click(object sender, EventArgs e)
        {
            string _tName = inputName.Text;
            int _tMaxLP, _tCurrentLP, _tRecoverCycle;
            TimeSet _TimeSet = new TimeSet();
            LoadTimeSet _NewLoadTimeSet = new LoadTimeSet();

            _NewLoadTimeSet.tName = inputName.Text;
            _tMaxLP = (int)inputMaxLP.Value;
            _NewLoadTimeSet.tMaxLP = (int)inputMaxLP.Value;
            _tCurrentLP = (int)inputCurrentLP.Value;
            _NewLoadTimeSet.tCurrrentLP = (int)inputCurrentLP.Value;
            _tRecoverCycle = (int)inputRecoverCycle.Value;
            _NewLoadTimeSet.tRecoverCycle = (int)inputRecoverCycle.Value;

            try
            {
                XmlSerializer _serializer = new XmlSerializer(typeof(LoadTimeSet));
                System.IO.StreamWriter sw = new System.IO.StreamWriter(inputName.Text + ".xml", false, new System.Text.UTF8Encoding(false));
                _serializer.Serialize(sw, _NewLoadTimeSet);
                sw.Close();

                ParentForm.SetTimer(_tName, _tMaxLP, _tCurrentLP, _tRecoverCycle, out _TimeSet.tName, out _TimeSet.tHour, out _TimeSet.tMinute, out _TimeSet.tSecond, out _TimeSet.tDate);
                ParentForm.CreatetForm(_TimeSet);

                this.Close();
                
            }catch(Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Nortification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateNewTimer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Save();
        }
    }
}
