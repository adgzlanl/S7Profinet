using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using PROFINET_STEP_7.Profinet;
using S7.Net;
using S7.Net.Types;

namespace S7Profinet
{
    public partial class MainPage : Form
    {

        public Plc plc = null;

        public struct S7Struct
        {
            public bool StrInput;
            public bool StrOutput;
            public short StrInt;
            public double StrReal;
            public int StrDint;
            public uint StrDword;
            public ushort StrWord;
        }
   
        
        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            try
            {
                cBoxCPUType.DataSource = Enum.GetNames(typeof(CpuType)); 
            }
            catch (PlcException ex)
            {

                MessageBox.Show(this, ex.Message, "Verbindung Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                CpuType cpu = (CpuType)Enum.Parse(typeof(CpuType), cBoxCPUType.SelectedValue.ToString());
                string ip = txtIP.Text;
                short rack = short.Parse(txtRack.Text);
                short slot = short.Parse(txtSlot.Text);
                plc = new Plc(cpu, ip, rack, slot);
                plc.Open();

                if (plc.IsConnected)
                {
                    btnConnect.Enabled = false;
                    lblVerbindung.BackColor = Color.Green;
                }



            }
            catch (PlcException ex)
            {
                lblVerbindung.BackColor = Color.Red;
                MessageBox.Show(this, ex.Message, "Verbindung Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (plc != null)
                {
                    plc.Close();
                    lblVerbindung.BackColor = Color.Red;
                }
                btnConnect.Enabled = true;
            }
            catch (PlcException ex)
            {

                MessageBox.Show(this, ex.Message, "Verbindung Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MainPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                if(plc!=null)
                {
                    plc.Close();

                }
            }
            catch (PlcException ex)
            {

                MessageBox.Show(this, ex.Message, "Verbindung Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {

            try
            {
                var DB1bytes = plc.ReadBytes(DataType.DataBlock, 2, 0, 18);
                bool db1Bool1 = DB1bytes[0].SelectBit(0);
                bool db1Bool2 = DB1bytes[0].SelectBit(1);
                short db1IntVariable = S7.Net.Types.Int.FromByteArray(DB1bytes.Skip(2).Take(2).ToArray());
                double db1RealVariable = S7.Net.Types.Double.FromByteArray(DB1bytes.Skip(4).Take(4).ToArray());
                int db1DintVariable = S7.Net.Types.DInt.FromByteArray(DB1bytes.Skip(8).Take(4).ToArray());
                uint db1DwordVariable = S7.Net.Types.DWord.FromByteArray(DB1bytes.Skip(12).Take(4).ToArray());
                ushort db1WordVariable = S7.Net.Types.Word.FromByteArray(DB1bytes.Skip(16).Take(2).ToArray());
                txtInputRead.Text = db1Bool1.ToString();
                txtOutputRead.Text = db1Bool2.ToString();
                txtIntRead.Text = db1IntVariable.ToString();
                txtRealRead.Text = db1RealVariable.ToString();
                txtDintRead.Text = db1DintVariable.ToString();
                txtDwordRead.Text = db1DwordVariable.ToString();
                txtWordRead.Text = db1WordVariable.ToString();
            }
            catch (PlcException ex)
            {

                MessageBox.Show(this,ex.Message,"Parameter Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void tmrStart_Click(object sender, EventArgs e)
        {

            if (plc != null)
            {
                timer1.Enabled = true;
                timer1.Interval = 100;
            }

            else
            {
                MessageBox.Show("Keine Verbindung", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

     
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            try
            {
                plc.Write("DB2.DBX0.0", true);
            }
            catch (PlcException ex )
            {

                MessageBox.Show(this, ex.Message, "Parameter Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            
            try
            {
                plc.Write("DB2.DBX0.0", false);
            }
            catch (PlcException ex)
            {

                MessageBox.Show(this, ex.Message, "Parameter Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOutputFalse_Click(object sender, EventArgs e)
        {
            try
            {
                plc.Write("DB2.DBX0.1", false);
            }
            catch (PlcException ex)
            {

                MessageBox.Show(this, ex.Message, "Parameter Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btnOutputTrue_Click(object sender, EventArgs e)
        {
            try
            {
                plc.Write("DB2.DBX0.1", true);
            }
            catch (PlcException ex)
            {

                MessageBox.Show(this, ex.Message, "Parameter Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnInt_Click(object sender, EventArgs e)
        {
            try
            {
                short db1IntVariable = Convert.ToInt16(txtIntWrite.Text);
                plc.Write("DB2.DBW2.0", db1IntVariable.ConvertToUshort());
            }
            catch (PlcException ex)
            {

                MessageBox.Show(this, ex.Message, "Parameter Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnReal_Click(object sender, EventArgs e)
        {
            try
            {
                double db1RealVariable = Convert.ToDouble(txtRealWrite.Text);
                plc.Write("DB2.DBD4.0", db1RealVariable.ConvertToUInt());
            }
            catch (PlcException ex)
            {

                MessageBox.Show(this, ex.Message, "Parameter Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDint_Click(object sender, EventArgs e)
        {
            try
            {
                int db1DintVariable = Convert.ToInt32(txtDintWrite.Text);
                plc.Write("DB2.DBD8.0", db1DintVariable.ConvertToUInt());
            }
            catch (PlcException ex)
            {

                MessageBox.Show(this, ex.Message, "Parameter Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDword_Click(object sender, EventArgs e)
        {
            try
            {
                int db1DwordVariable = Convert.ToInt32(txtDwordWrite.Text); ;
                plc.Write("DB2.DBD12.0", db1DwordVariable.ConvertToUInt());
            }
            catch (PlcException ex)
            {

                MessageBox.Show(this, ex.Message, "Parameter Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnWord_Click(object sender, EventArgs e)
        {
            try
            {
                short db1WordVariable = Convert.ToInt16(txtWordWrite.Text);
                plc.Write("DB2.DBW16.0", db1WordVariable.ConvertToUshort());
            }
            catch (PlcException ex)
            {

                MessageBox.Show(this, ex.Message, "Parameter Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] db1Bytes = new byte[18];
                plc.WriteBytes(DataType.DataBlock, 2, 0, db1Bytes);
            }
            catch (PlcException ex)
            {

                MessageBox.Show(this, ex.Message, "Parameter Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnStruct_Click(object sender, EventArgs e)
        {
            S7Struct s7Struct = (S7Struct)plc.ReadStruct(typeof(S7Struct), 1);

            S7Struct test = s7Struct;
        }
    }
}
