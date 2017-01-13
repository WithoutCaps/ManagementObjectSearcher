using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementObjectSearcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void output_BTN_Click(object sender, EventArgs e)
        {
            try
            {
                output_ET.Clear();
                foreach (
                ManagementObject queryObj in
                new System.Management.ManagementObjectSearcher("root\\CIMV2", "Select * from " + class_ET.Text).Get())
                    foreach (PropertyData property in queryObj.Properties)
                        if (property.Value != null || !notNull_CB.Checked)
                            output_ET.AppendText((arrayFormat_CB.Checked ? "\"" : "") +
                                                 property.Name +
                                                 (arrayFormat_CB.Checked ? (namesOnly_CB.Checked ? "" : ": " + property.Value) + "\"," : (namesOnly_CB.Checked ? "" : ": " + property.Value)) +
                                                       (newLine_CB.Checked ? Environment.NewLine : "")
                                                       ); // If you are reading this line, DONT!! If you do- you may decide to kill yourself... But now when i think about it, u probobly dont have a life since u are reading it....

                        
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
