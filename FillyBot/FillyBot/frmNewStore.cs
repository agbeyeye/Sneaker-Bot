using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FillyBot.Controller;
using FillyBot.Models;

namespace FillyBot
{
    public partial class frmNewStore : Form
    {
        DbController DbAccess;
        Store store;
        public frmNewStore()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DbAccess = new DbController();
            store = new Store
            {
                name=txtname.Text,

                url=txtUrl.Text
            };

            DbAccess.NewStore(store);
            this.Close();

        }
    }
}
