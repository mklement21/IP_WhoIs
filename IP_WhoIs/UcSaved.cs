using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IP_WhoIs {
    public partial class UcSaved : UserControl {
        private IPService iPService = new IPService();

        public UcSaved() {
            InitializeComponent();
            LoadAdresses();
        }

        private void LoadAdresses() {
            dgvSavedAddresses.DataSource = iPService.GetAddresses().ToList();
            dgvSavedAddresses.Update();
            dgvSavedAddresses.Refresh();
        }

        public void RefreshData() {
            LoadAdresses();
        }
    }
}
