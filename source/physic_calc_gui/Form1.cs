using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;

namespace physic_calc_gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*File.WriteAllText(Environment.CurrentDirectory + @"\int\temp.py", "from modules import *\n" + python_int.Text + "\nspecialsys(\"pause\")");
            ProcessStartInfo psi;
            psi = new ProcessStartInfo("python.exe", Environment.CurrentDirectory + @"\int\temp.py");
            Process.Start(psi);*/
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //name.Text = name.Text.Replace(" ", "");
            //File.WriteAllText(Environment.CurrentDirectory + @"\" + name.Text + ".py", "from modules import *\n" + python_int.Text + "\nspecialsys(\"pause\")");
        }

        public void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void tabControl1_Leave(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*FileStream file1 = new FileStream(Environment.CurrentDirectory + @"\" + name.Text + ".py", FileMode.Open);
            StreamReader reader = new StreamReader(file1);
            python_int.Text = reader.ReadToEnd();
            python_int.Text = python_int.Text.Replace("from modules import *\n", "");
            python_int.Text = python_int.Text.Replace("\nspecialsys(\"pause\")", "");
            reader.Close();*/
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                grav.Text = Convert.ToString(Convert.ToDouble(grav_mas.Text) * Convert.ToDouble(g.Text));
            }
            catch (FormatException)
            {

            }
            catch (OverflowException)
            {

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                weight.Text = Convert.ToString(Convert.ToDouble(weight_mass.Text) * Convert.ToDouble(g.Text));
            }
            catch (FormatException)
            {

            }
            catch (OverflowException)
            {

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                trn.Text = Convert.ToString(Convert.ToDouble(trn_mas.Text) * Convert.ToDouble(g.Text) * Convert.ToDouble(mu.Text));
            }
            catch(FormatException)
            {
                
            }
            catch (OverflowException)
            {

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                upr.Text = Convert.ToString(Convert.ToDouble(upr_jst.Text) * Convert.ToDouble(upr_def.Text));
            }
            catch (FormatException)
            {

            }
            catch (OverflowException)
            {

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                arh.Text = Convert.ToString(Convert.ToDouble(arh_p.Text) * Convert.ToDouble(g.Text) * Convert.ToDouble(arh_v.Text));
            }
            catch (FormatException)
            {

            }
            catch (OverflowException)
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                sp.Text = Convert.ToString(Convert.ToDouble(sp_s.Text) / Convert.ToDouble(sp_t.Text));
            }
            catch (FormatException)
            {

            }
            catch (OverflowException)
            {

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                t.Text = Convert.ToString(Convert.ToDouble(t_s.Text) / Convert.ToDouble(t_v.Text));
            }
            catch (FormatException)
            {

            }
            catch (OverflowException)
            {

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                s.Text = Convert.ToString(Convert.ToDouble(s_v.Text) * Convert.ToDouble(s_t.Text));
            }
            catch (FormatException)
            {

            }
            catch (OverflowException)
            {

            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                p.Text = Convert.ToString(Convert.ToDouble(p_f.Text) / Convert.ToDouble(p_s.Text));
            }
            catch (FormatException)
            {

            }
            catch (OverflowException)
            {

            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                pl.Text = Convert.ToString(Convert.ToDouble(p_d.Text) * 9.8 * Convert.ToDouble(p_h.Text));
            }
            catch (FormatException)
            {

            }
            catch (OverflowException)
            {

            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                d.Text = Convert.ToString(Convert.ToDouble(d_m.Text) / Convert.ToDouble(d_v.Text));
            }
            catch (FormatException)
            {

            }
            catch (OverflowException)
            {

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                md.Text = Convert.ToString(Convert.ToDouble(m_d.Text) * Convert.ToDouble(m_v.Text));
            }
            catch (FormatException)
            {

            }
            catch (OverflowException)
            {

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                vd.Text = Convert.ToString(Convert.ToDouble(v_m.Text) / Convert.ToDouble(v_d.Text));
            }
            catch (FormatException)
            {

            }
            catch (OverflowException)
            {

            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            try
            {
                h.Text = Convert.ToString(Convert.ToDouble(h_dv.Text) * Convert.ToDouble(h_ds.Text) * 100);
            }
            catch (FormatException)
            {

            }
            catch (OverflowException)
            {

            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                ta.Text = Convert.ToString(Math.Abs(Convert.ToDouble(t_t1.Text) - Convert.ToDouble(t_t2.Text)) * Convert.ToDouble(t_tc.Text) * Convert.ToDouble(t_m.Text));
            }
            catch (FormatException)
            {

            }
            catch (OverflowException)
            {

            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                c.Text = Convert.ToString(Convert.ToDouble(c_q.Text) / (Math.Abs(Convert.ToDouble(c_t1.Text) - Convert.ToDouble(c_t2.Text)) * Convert.ToDouble(c_m.Text)));
            }
            catch (FormatException)
            {

            }
            catch (OverflowException)
            {

            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
                tm.Text = Convert.ToString(Convert.ToDouble(tm_h.Text) * Convert.ToDouble(tm_m.Text));
            }
            catch (FormatException)
            {

            }
            catch (OverflowException)
            {

            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                tc.Text = Convert.ToString(Convert.ToDouble(tc_a.Text) * Convert.ToDouble(tc_m.Text));
            }
            catch (FormatException)
            {

            }
            catch (OverflowException)
            {

            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            try
            {
                ts.Text = Convert.ToString(Convert.ToDouble(ts_l.Text) * Convert.ToDouble(ts_m.Text));
            }
            catch (FormatException)
            {

            }
            catch (OverflowException)
            {

            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            try
            {
                ScriptEngine engine = Python.CreateEngine();
                ScriptScope scope = engine.CreateScope();
                engine.ExecuteFile("convert.py", scope);


                dynamic convert = scope.GetVariable("convert");

                cres.Text = Convert.ToString(convert(Convert.ToString(cto.Text), Convert.ToDouble(cval.Text)));
            }
            catch (FormatException)
            {

            }
            catch (OverflowException)
            {

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {
            try
            {
                ScriptEngine engine = Python.CreateEngine();
                ScriptScope scope = engine.CreateScope();
                engine.ExecuteFile("convert.py", scope);


                dynamic convert = scope.GetVariable("length");

                lres.Text = Convert.ToString(convert(Convert.ToString(lfrom.Text), Convert.ToString(lto.Text), Convert.ToDouble(lval.Text)));
            }
            catch (FormatException)
            {

            }
            catch (OverflowException)
            {

            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            try
            {
                ScriptEngine engine = Python.CreateEngine();
                ScriptScope scope = engine.CreateScope();
                engine.ExecuteFile("convert.py", scope);


                dynamic convert = scope.GetVariable("area");

                ares.Text = Convert.ToString(convert(Convert.ToString(afrom.Text), Convert.ToString(ato.Text), Convert.ToDouble(aval.Text)));
            }
            catch (FormatException)
            {

            }
            catch (OverflowException)
            {

            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            try
            {
                ScriptEngine engine = Python.CreateEngine();
                ScriptScope scope = engine.CreateScope();
                engine.ExecuteFile("convert.py", scope);


                dynamic convert = scope.GetVariable("volume");

                vres.Text = Convert.ToString(convert(Convert.ToString(vfrom.Text), Convert.ToString(vto.Text), Convert.ToDouble(vval.Text)));
            }
            catch (FormatException)
            {

            }
            catch (OverflowException)
            {

            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void ta_m_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
