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
    public partial class ProfileControl : UserControl
    {
        const string content_color = "#141414";
        const string background_color = "#1F1F1F";
        DbController DbAccess = new DbController();
        List<Profile> profiles;
        string savingProfileBtnText = "Save";
        string updatingProfileBtnText = "Update";
        public ProfileControl()
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml(content_color);
            txtFirstName.BackColor = ColorTranslator.FromHtml(content_color);
            txtLastName.BackColor = ColorTranslator.FromHtml(content_color);
            txtAddress.BackColor = ColorTranslator.FromHtml(content_color);
            txtCity.BackColor = ColorTranslator.FromHtml(content_color);
            txtCode.BackColor = ColorTranslator.FromHtml(content_color);
            txtExpMonth.BackColor = ColorTranslator.FromHtml(content_color);
            txtExpYear.BackColor = ColorTranslator.FromHtml(content_color);
            txtCardNumber.BackColor = ColorTranslator.FromHtml(content_color);
            txtShippingCity.BackColor = ColorTranslator.FromHtml(content_color);
            txtShippingCode.BackColor = ColorTranslator.FromHtml(content_color);
            txtShippingFName.BackColor = ColorTranslator.FromHtml(content_color);
            txtShippingLName.BackColor = ColorTranslator.FromHtml(content_color);
            txtShippingStAddress.BackColor = ColorTranslator.FromHtml(content_color);
            txtShippingState.BackColor = ColorTranslator.FromHtml(content_color);
            txtState.BackColor = ColorTranslator.FromHtml(content_color);
            txtCVC.BackColor = ColorTranslator.FromHtml(content_color);
        }

        private void ProfileControl_Load(object sender, EventArgs e)
        {
            loadProfiles();
        }

        private void loadProfiles()
        {
            profiles = DbAccess.GetProfiles();
            dataGridView1.Rows.Clear();
            if (profiles != null)
            {

                dataGridView1.Rows.Add(profiles.Count);
                for (int i = 0; i < profiles.Count; i++)
                {

                    dataGridView1.Rows[i].Cells[0].Value = profiles[i].firstName + " " + profiles[i].lastName;
                    dataGridView1.Rows[i].Cells[1].Value = profiles[i].cardType;
                    dataGridView1.Rows[i].Cells[2].Value = profiles[i].cardNumber;
                    dataGridView1.Rows[i].Cells[3].Value = profiles[i].address;
                    dataGridView1.Rows[i].Cells[4].Value = profiles[i].city;
                    dataGridView1.Rows[i].Cells[5].Value = profiles[i].state;
                    dataGridView1.Rows[i].Cells[6].Value = profiles[i].code;
                    dataGridView1.Rows[i].Cells[7].Value = profiles[i].shipping_firstName + " " + profiles[i].shipping_lastName;
                    dataGridView1.Rows[i].Cells[8].Value = profiles[i].shipping_address;
                    dataGridView1.Rows[i].Cells[9].Value = profiles[i].id.ToString();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtAddress.Text != "" && txtCardNumber.Text != "" && txtCity.Text != "" && txtCode.Text != "" && txtCVC.Text != "" &&
                txtExpMonth.Text != "" && txtExpYear.Text != "" && txtFirstName.Text != "" && txtLastName.Text != "" &&
                txtShippingCity.Text != "" && txtShippingCode.Text != "" && txtShippingFName.Text != "" && txtShippingLName.Text != "" &&
                txtShippingStAddress.Text != "" && txtShippingState.Text != "" && txtState.Text != "" && cboCardType.SelectedIndex != -1)
            {
                int Id;
                if (btnSave.Text == savingProfileBtnText) { Id = getProfileId(profiles); } else { Id = int.Parse(dataGridView1.CurrentRow.Cells[9].Value.ToString()); }
                Profile profile = new Profile
                {
                    id = Id,
                    firstName = txtFirstName.Text,
                    lastName = txtLastName.Text,
                    address = txtAddress.Text,
                    code = txtCode.Text,
                    city = txtCity.Text,
                    state = txtState.Text,
                    cardType = cboCardType.SelectedItem.ToString(),
                    cardNumber = txtCardNumber.Text,
                    month = txtExpMonth.Text,
                    year = txtExpYear.Text,
                    cvc = txtCVC.Text,
                    shipping_address = txtShippingStAddress.Text,
                    shipping_city = txtShippingCity.Text,
                    shipping_code = txtShippingCode.Text,
                    shipping_firstName = txtShippingFName.Text,
                    shipping_lastName = txtShippingLName.Text,
                    shipping_state = txtShippingState.Text
                };

                if(btnSave.Text== savingProfileBtnText)
                {
                    DbAccess.SaveProfile(profile);
                    MessageBox.Show("Saved Successfully");
                }else if (btnSave.Text == updatingProfileBtnText)
                {
                    DbAccess.UpdateProfile(profile);
                    
                }
                loadProfiles();
                tabControl1.SelectedIndex = 1;
                btnSave.Text = savingProfileBtnText;
                clearBoxes();
                
            }
            else
            {
                MessageBox.Show("All fields must be filled");
            }
        }

        private int getProfileId(List<Profile> pf)
        {
            int Id;
            List<Profile> localProfile = pf;
            List<int> ids = new List<int>();
            foreach(var profile in localProfile)
            {
                ids.Add(profile.id);
            }
            Id = ids.Max() + 1;

            return Id;
        }
        private void clearBoxes()
        {
            txtFirstName.Text = "FirstName";
            txtLastName.Text = "LastName";
            txtAddress.Text = "Street Address";
            txtCode.Text = "Zip Code";
            txtCity.Text = "City";
            txtState.Text = "State";
            cboCardType.SelectedIndex = -1;
            txtCardNumber.Text = "Card Number";
            txtExpMonth.Text = "MM";
            txtExpYear.Text = "Year";
            txtCVC.Text = "CVC";
            txtShippingStAddress.Text = "Street Address";
            txtShippingCity.Text = "City";
            txtShippingCode.Text = "Zip Code";
            txtShippingFName.Text = "FirstName";
            txtShippingLName.Text = "LastName";
            txtShippingState.Text = "State";
            ckbShipping.CheckState = CheckState.Unchecked;
        }

        private void ckbShipping_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbShipping.Checked)
            {
                if (txtAddress.Text != "" && txtCardNumber.Text != "" && txtCity.Text != "" && txtCode.Text != "" && txtCVC.Text != "" &&
                txtExpMonth.Text != "" && txtExpYear.Text != "" && txtFirstName.Text != "" && txtLastName.Text != "")
                {
                    txtShippingCity.Enabled = false;
                    txtShippingCode.Enabled = false;
                    txtShippingFName.Enabled = false;
                    txtShippingLName.Enabled = false;
                    txtShippingStAddress.Enabled = false;
                    txtShippingState.Enabled = false;

                    txtShippingCity.Text = txtCity.Text;
                    txtShippingCode.Text = txtCode.Text;
                    txtShippingFName.Text = txtFirstName.Text;
                    txtShippingLName.Text = txtLastName.Text;
                    txtShippingStAddress.Text = txtAddress.Text;
                    txtShippingState.Text = txtState.Text;
                }
                else
                {
                    MessageBox.Show("All billing fields must be filled");
                }
            }
            else
            {
                txtShippingCity.Enabled = true;
                txtShippingCode.Enabled = true;
                txtShippingFName.Enabled = true;
                txtShippingLName.Enabled = true;
                txtShippingStAddress.Enabled = true;
                txtShippingState.Enabled = true;

            }
        }

        private void txtFirstName_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "FirstName") { txtFirstName.Clear(); }
        }

        private void txtFirstName_Leave(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "") { txtFirstName.Text = "FirstName"; }
        }

        private void txtLastName_Leave(object sender, EventArgs e)
        {
            if (txtLastName.Text == "") { txtLastName.Text = "LastName"; }
        }

        private void txtLastName_Click(object sender, EventArgs e)
        {
            if (txtLastName.Text == "LastName") { txtLastName.Clear(); }
        }

        private void txtAddress_Click(object sender, EventArgs e)
        {
            if (txtAddress.Text == "Street Address") { txtAddress.Clear(); }
        }

        private void txtAddress_Leave(object sender, EventArgs e)
        {
            if (txtAddress.Text == "") { txtAddress.Text = "Street Address"; }
        }

        private void txtCode_Click(object sender, EventArgs e)
        {
            if (txtCode.Text == "Zip Code") { txtCode.Clear(); }
        }

        private void txtCode_Leave(object sender, EventArgs e)
        {
            if (txtCode.Text == "") { txtCode.Text = "Zip Code"; }
        }

        private void txtCity_Click(object sender, EventArgs e)
        {
            if (txtCity.Text == "City") { txtCity.Clear(); }
        }

        private void txtCity_Leave(object sender, EventArgs e)
        {
            if (txtCity.Text == "") { txtCity.Text = "City"; }
        }

        private void txtState_Click(object sender, EventArgs e)
        {
            if (txtState.Text == "State") { txtState.Clear(); }
        }

        private void txtState_Leave(object sender, EventArgs e)
        {
            if (txtState.Text == "") { txtState.Text = "State"; }
        }

        private void txtCardNumber_Click(object sender, EventArgs e)
        {
            if (txtCardNumber.Text == "Card Number") { txtCardNumber.Clear(); }
        }

        private void txtCardNumber_Leave(object sender, EventArgs e)
        {
            if (txtCardNumber.Text == "") { txtCardNumber.Text = "Card Number"; }
        }

        private void txtExpMonth_Click(object sender, EventArgs e)
        {
            if (txtExpMonth.Text == "MM") { txtExpMonth.Clear(); }
        }

        private void txtExpMonth_Leave(object sender, EventArgs e)
        {
            if (txtExpMonth.Text == "") { txtExpMonth.Text = "MM"; }
        }

        private void txtExpYear_Click(object sender, EventArgs e)
        {
            if (txtExpYear.Text == "Year") { txtExpYear.Clear(); }
        }

        private void txtExpYear_Leave(object sender, EventArgs e)
        {
            if (txtExpYear.Text == "") { txtExpYear.Text = "Year"; }
        }

        private void txtCVC_Click(object sender, EventArgs e)
        {
            if (txtCVC.Text == "CVC") { txtCVC.Clear(); }
        }

        private void txtCVC_Leave(object sender, EventArgs e)
        {
            if (txtCVC.Text == "") { txtCVC.Text = "CVC"; }
        }

        private void txtShippingFName_Click(object sender, EventArgs e)
        {
            if (txtShippingFName.Text == "FirstName") { txtShippingFName.Clear(); }
        }

        private void txtShippingFName_Leave(object sender, EventArgs e)
        {
            if (txtShippingFName.Text == "") { txtShippingFName.Text = "FirstName"; }
        }

        private void txtShippingLName_Click(object sender, EventArgs e)
        {
            if (txtShippingLName.Text == "LastName") { txtShippingLName.Clear(); }
        }

        private void txtShippingLName_Leave(object sender, EventArgs e)
        {
            if (txtShippingLName.Text == "") { txtShippingLName.Text = "LastName"; }
        }

        private void txtShippingStAddress_Click(object sender, EventArgs e)
        {
            if (txtShippingStAddress.Text == "Street Address") { txtShippingStAddress.Clear(); }
        }

        private void txtShippingStAddress_Leave(object sender, EventArgs e)
        {
            if (txtShippingStAddress.Text == "") { txtShippingStAddress.Text = "Street Address"; }
        }

        private void txtShippingCode_Click(object sender, EventArgs e)
        {
            if (txtShippingCode.Text == "Zip Code") { txtShippingCode.Clear(); }
        }

        private void txtShippingCode_Leave(object sender, EventArgs e)
        {
            if (txtShippingCode.Text == "") { txtShippingCode.Text = "Zip Code"; }
        }

        private void txtShippingCity_Click(object sender, EventArgs e)
        {
            if (txtShippingCity.Text == "City") { txtShippingCity.Clear(); }
        }

        private void txtShippingCity_Leave(object sender, EventArgs e)
        {
            if (txtShippingCity.Text == "") { txtShippingCity.Text = "City"; }
        }

        private void txtShippingState_Click(object sender, EventArgs e)
        {
            if (txtShippingState.Text == "State") { txtShippingState.Clear(); }
        }

        private void txtShippingState_Leave(object sender, EventArgs e)
        {
            if (txtShippingState.Text == "") { txtShippingState.Text = "State"; }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        private void gridEditMenu_Click(object sender, EventArgs e)
        {
            
        }

        private void gridRemoveMenu_Click(object sender, EventArgs e)
        {
          
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Profile selectedProfile = getSelectedProfile(int.Parse(dataGridView1.CurrentRow.Cells[9].Value.ToString()), profiles);
            tabControl1.SelectedIndex = 0;
            btnSave.Text = updatingProfileBtnText;
            txtFirstName.Text = selectedProfile.firstName;
            txtLastName.Text = selectedProfile.lastName;
            txtAddress.Text = selectedProfile.address;
            txtCode.Text = selectedProfile.code;
            txtCity.Text = selectedProfile.city;
            txtState.Text = selectedProfile.state;
            cboCardType.SelectedItem = selectedProfile.cardType;
            txtCardNumber.Text = selectedProfile.cardNumber;
            txtExpMonth.Text = selectedProfile.month;
            txtExpYear.Text = selectedProfile.year;
            txtCVC.Text = selectedProfile.cvc;
            txtShippingStAddress.Text = selectedProfile.shipping_address;
            txtShippingCity.Text = selectedProfile.shipping_city;
            txtShippingCode.Text = selectedProfile.shipping_code;
            txtShippingFName.Text = selectedProfile.shipping_firstName;
            txtShippingLName.Text = selectedProfile.shipping_lastName;
            txtShippingState.Text = selectedProfile.shipping_state;

        }

        private Profile getSelectedProfile(int id,List<Profile> profiles)
        {
            Profile pf=new Profile();
            var obj = profiles;
            foreach(var item in obj)
            {
                if (id == item.id)
                {
                    pf = item;
                    break;
                }
            }

            return pf;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this profile?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                DbAccess.RemoveProfile(int.Parse(dataGridView1.CurrentRow.Cells[9].Value.ToString()));
                loadProfiles();
            }
        }
    }
}
