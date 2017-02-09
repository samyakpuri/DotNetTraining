using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DllDisplay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Assembly _assembly;
        Type _selectedType;
        MethodInfo _selectedMethod;
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FileDialog fileDailog = new OpenFileDialog();
            if(fileDailog.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = fileDailog.FileName;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            lstTypes.Items.Clear();
            _assembly = Assembly.LoadFrom(txtPath.Text);
            FillListBoxes(lstTypes, _assembly.GetTypes().Select(t=>t.FullName).ToList());
        }

        private void lstTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearListBox();
            _selectedType = _assembly.GetType(lstTypes.SelectedItem.ToString());
            
            FillListBoxes(lstMethods, _selectedType.GetMethods().Select(m=>m.Name).ToList());
            FillListBoxes(lstProperties, _selectedType.GetProperties().Select(p=>p.Name).ToList());
            FillListBoxes(lstFields, _selectedType.GetFields().Select(f=>f.Name).ToList());
            FillListBoxes(lstEvents, _selectedType.GetEvents().Select(ev=>ev.Name).ToList());
            FillListBoxes(lstConstructors, _selectedType.GetConstructors().Select(c => c.Name).ToList());
        }

        private void FillListBoxes(ListBox listBox, List<string> list)
        {
            list.ForEach(item => listBox.Items.Add(item));
        }

        private void ClearListBox()
        {
            lstMethods.Items.Clear();
            lstProperties.Items.Clear();
            lstFields.Items.Clear();
            lstConstructors.Items.Clear();
            lstEvents.Items.Clear();
        }

        private void lstMethods_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_selectedType == null)
                return;
            pnlParameterControls.Controls.Clear();
            _selectedMethod = _selectedType.GetMethod(lstMethods.SelectedItem.ToString());
            ParameterInfo[] parameter = _selectedMethod.GetParameters();
            pnlParameterControls.Controls.Clear();
            int count = 1;
            foreach (ParameterInfo item in parameter)
            {
                ParameterControl control = new ParameterControl(item.Name,item.ParameterType.FullName.ToString());
                control.Location = new Point(30, count * 30);
                pnlParameterControls.Controls.Add(control);
                count++;
            }
        }

        private void btnInvoke_Click(object sender, EventArgs e)
        {
            if (_selectedType == null) return;
            object instance = Activator.CreateInstance(_selectedType);
            List<object> parameterList = new List<object>();
            foreach (Control control in pnlParameterControls.Controls)
            {
                if(control is ParameterControl)
                {
                    var obj = control as ParameterControl;
                    object parameter  = Convert.ChangeType(obj.ParameterValue,Type.GetType(obj.ParameterType));
                    parameterList.Add(parameter);
                }
            }
            var result = _selectedMethod.Invoke(instance,parameterList.ToArray());
            MessageBox.Show(result.ToString());
        }

    }
}
