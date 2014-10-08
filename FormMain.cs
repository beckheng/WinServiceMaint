using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.ServiceProcess;

namespace WinServiceMaint
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("name", typeof(string));
            dt.Columns.Add("disp_name", typeof(string));

            ServiceController[] services = ServiceController.GetServices();

            int defaultIndex = 0;
            foreach (ServiceController service in services)
            {
                if (service.DisplayName.StartsWith("SQL Server"))
                {
                    DataRow dr = dt.NewRow();
                    dr["name"] = service.ServiceName;
                    dr["disp_name"] = service.DisplayName;

                    dt.Rows.Add(dr.ItemArray);

                    if (service.ServiceName == "MSSQLSERVER")
                    {
                        defaultIndex = dt.Rows.Count - 1;
                    }
                }
            }

            comboBox_services.Items.Clear();
            comboBox_services.DataSource = dt;
            comboBox_services.ValueMember = "name";
            comboBox_services.DisplayMember = "disp_name";

            if (defaultIndex >= 0)
            {
                comboBox_services.SelectedIndex = defaultIndex;
            }
        }

        private void button_viewStatus_Click(object sender, EventArgs e)
        {
            ServiceController sc = getServiceController();
            label_status.Text = sc.Status.ToString();

            if (sc.Status == ServiceControllerStatus.Running)
            {
                MessageBox.Show("服务当前运行良好");
            }
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            ServiceController sc = getServiceController();
            switch (sc.Status)
            {
                case ServiceControllerStatus.Stopped:
                    sc.Start();
                    break;
                case ServiceControllerStatus.Paused:
                    sc.Continue();
                    break;
                case ServiceControllerStatus.Running:
                    MessageBox.Show("服务当前运行良好，无需重复启动");
                    return;
            }

            MessageBox.Show("操作已经完成，请重新查看状态");
        }

        private ServiceController getServiceController()
        {
            string serviceName = comboBox_services.SelectedValue.ToString();
            ServiceController sc = new ServiceController(serviceName);

            return sc;
        }
    }
}
