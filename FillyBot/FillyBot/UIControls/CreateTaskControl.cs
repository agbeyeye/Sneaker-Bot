using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FillyBot.Controller;
using FillyBot.Models;

namespace FillyBot.UIControls
{
    public partial class CreateTaskControl : UserControl
    {
        DbController DbAccess = new DbController();
        List<Store> stores = new List<Store>();
        List<Profile> profiles = new List<Profile>();
        const string content_color = "#141414";
        const string background_color = "#1F1F1F";
        public CreateTaskControl()
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml(content_color);
            txtProductName.BackColor = ColorTranslator.FromHtml(background_color);
            txtQuantity.BackColor = ColorTranslator.FromHtml(background_color);
            txtSize.BackColor = ColorTranslator.FromHtml(background_color);
            cboBillingInfo.BackColor= ColorTranslator.FromHtml(background_color);
            txtProductID.BackColor = ColorTranslator.FromHtml(background_color);
            cboStore.BackColor = ColorTranslator.FromHtml(background_color);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CreateTaskControl_Load(object sender, EventArgs e)
        {
            //get list of stores
            stores = DbAccess.GetStores();
            loadStores(stores);
            //get list of profiles
            profiles = DbAccess.GetProfiles();
            loadProfiles(profiles);
            
        }

        //Get stores
        private void loadStores(List<Store> sto)
        {
            var localStores = sto;
            foreach(var store in localStores)
            {
                cboStore.Items.Add(store.name);
            }
        }

        //Get profiles
        private void loadProfiles(List<Profile> pfs)
        {
            var profls = pfs;
            foreach (var profile in profls)
            {
                cboBillingInfo.Items.Add(profile.cardType+"-"+profile.cardNumber+" "+ profile.shipping_address);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(txtProductID.Text!=""&&txtProductName.Text!=""&& txtQuantity.Text != "" && txtSize.Text != "" && cboBillingInfo.SelectedIndex != -1 && cboStore.SelectedIndex != -1)
            {
                Models.Task task = new Models.Task
                {
                    id = createTaskId(DbAccess.GetTasks()),
                    product = txtProductName.Text,
                    productId = txtProductID.Text,
                    url = GetProductUrl(stores[cboStore.SelectedIndex].name, txtProductID.Text),
                    proxy = GetProxy(),
                    quantity = int.Parse(txtQuantity.Text),
                    size = txtSize.Text,
                    store = stores[cboStore.SelectedIndex],
                    profile = profiles[cboBillingInfo.SelectedIndex]
                };

                DbAccess.NewTask(task);
                refreshControls();
            }
            else { MessageBox.Show("All fields must be filled"); }
        }

        private string GetProxy()
        {
            //throw new NotImplementedException();
            return "Yet to be implemented";
        }

        private string GetProductUrl(string name, string text)
        {
            //throw new NotImplementedException();
            return "Url yet to be implemented";
        }

        //Generate ID for task
        private string createTaskId(List<Models.Task> pf)
        {
            int Id=1;
            List<Models.Task> tasks = pf;
            if (tasks != null) {
                List<int> ids = new List<int>();
                foreach (var tk in tasks)
                {
                    ids.Add(int.Parse(tk.id));
                }
                Id = ids.Max() + 1;
            }
            

            return Id.ToString();
        }

        private void refreshControls()
        {
            txtProductID.Clear();
            txtProductName.Clear();
            txtQuantity.Clear();
            txtSize.Clear();
            cboBillingInfo.SelectedIndex = -1;
            cboStore.SelectedIndex = -1;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cboStore.Items.Clear();
            cboBillingInfo.Items.Clear();
            //get list of stores
            stores = DbAccess.GetStores();
            loadStores(stores);
            //get list of profiles
            profiles = DbAccess.GetProfiles();
            loadProfiles(profiles);

        }
    }
}
