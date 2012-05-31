using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MiracleDKP
{
    public partial class Members : MiracleDKP.MainForm
    {
        private MiracleDKP.DBEngine _aDB;

        private List<MiracleDKP.CharAttrib> _classes;
        private List<MiracleDKP.CharAttrib> _roles;
        private List<MiracleDKP.CharAttrib> _profs;
        private List<MiracleDKP.CharAttrib> _ranks;
        private List<MiracleDKP.CharAttrib> _mains;

        private BindingSource _bind_class;
        private BindingSource _bind_mains;
        private BindingSource _bind_role1;
        private BindingSource _bind_role2;
        private BindingSource _bind_prof1;
        private BindingSource _bind_prof2;
        private BindingSource _bind_grank;

        public Members(MiracleDKP.DBEngine _db)
        {
            InitializeComponent();
            
            _aDB = _db;
            _classes = _aDB.GetAttributes("classes");
            _roles = _aDB.GetAttributes("roles");
            _profs = _aDB.GetAttributes("professions");
            _ranks = _aDB.GetAttributes("ranks");

            BindToControl(classBox, _classes, out _bind_class);
            BindToControl(roleBox1, _roles, out _bind_role1);
            BindToControl(roleBox2, _roles, out _bind_role2);
            BindToControl(profBox1, _profs, out _bind_prof1);
            BindToControl(profBox2, _profs, out _bind_prof2);
            BindToControl(gRankBox, _ranks, out _bind_grank);

        }

        private void BindToControl(ComboBox _control, List<MiracleDKP.CharAttrib> _attribs, out BindingSource _bsource)
        {
            _bsource = new BindingSource();
            _bsource.DataSource = _attribs;
            
            _control.ValueMember = "ID";
            _control.DisplayMember = "Name";
            _control.DataSource = _bsource;
        }

        private void addNewsButton_Click(object sender, EventArgs e)
        {
            if (_aDB.AddNews(newsBox.Text))
            {
                MessageBox.Show("Hír hozzáadva!", "Siker!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                newsBox.Clear();
            }
            else
                MessageBox.Show("Nem sikerült a hírt felvenni!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void makeAdminButton_Click(object sender, EventArgs e)
        {
            if ((adminBox.TextLength > 0) && (passBox.TextLength > 0))
            {
                if (_aDB.AddAdmin(adminBox.Text, passBox.Text))
                {
                    MessageBox.Show("Admin hozzáadva!", "Siker!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    adminBox.Clear();
                    passBox.Clear();
                }
                else
                {
                    MessageBox.Show("Lehet, hogy az admin létezik?", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void remAdminButton_Click(object sender, EventArgs e)
        {
            if (adminBox.TextLength > 0)
            {
                if (_aDB.RemAdmin(adminBox.Text))
                {
                    MessageBox.Show("Admin törölve!", "Siker!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    adminBox.Clear();
                    passBox.Clear();
                }
                else
                {
                    MessageBox.Show("Nincs ilyen admin, vagy nem te adtad a rendszerhez!", "Hiba!",  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void mainCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (!mainCheck.Checked)
            {
                _mains = _aDB.GetMainCharacters();
                BindToControl(mainBox, _mains, out _bind_mains);
            }
            else
            {
                mainBox.DataSource = null;
                _bind_mains = null;
                _mains.Clear();
            }
        }

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            bool _success = _aDB.AddMember(nameBox.Text, classBox.SelectedValue,
                roleBox1.SelectedValue, roleBox2.SelectedValue, 
                profBox1.SelectedValue, profBox2.SelectedValue, 
                gRankBox.SelectedValue, mainCheck.Checked);
            if(_success && !mainCheck.Checked)
            {
                _success = _aDB.AddAltChar(nameBox.Text, mainBox.SelectedValue);
            }

            if(_success)
            {
                MessageBox.Show("Tag hozzáadva!", "Siker!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("A tag már a listában van?", "Hiba!",  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
