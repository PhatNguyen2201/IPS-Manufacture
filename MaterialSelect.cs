using DatabaseFunctions.DataAccess;
using DatabaseFunctions.DataTransferObject;
using DatabaseFunctions.Enumarable;
using System;
using System.Windows.Forms;

namespace ExoSendTo3DPrint
{
    public partial class MaterialSelect : Form
    {
        private bool _selected = false;
        public bool Selected
        {
            get { return _selected; }
        }
        private int _labOutsource = -1;
        public int LabOutsource
        {
            get { return _labOutsource; }
        }
        private string _noteReason;
        public string NoteReason
        {
            get { return _noteReason; }
        }
        private EMaterial _MaterialName;
        public EMaterial MaterialName
        {
            get { return _MaterialName; }
        }
        private EManufactureStatus _ManuStatus;
        public EManufactureStatus ManuStatus
        {
            get { return _ManuStatus; }
        }
        public MaterialSelect()
        {
            InitializeComponent();
            ComboboxLab.DataSource = LabsDAO.Instance.GetAllLabs();
            ComboboxLab.DisplayMember = "Name";
            comboBoxManuStatus.DataSource = DatabaseFunctions.DataAccess.ManufactureListStatus.Instance.GetListManufactureStatus();
            comboBoxManuStatus.DisplayMember = "StatusName";
        }

        private void buttonTemporary_Click(object sender, EventArgs e)
        {
            OkClick(EMaterial.Temporary);
        }

        private void buttonSurgicalGuide_Click(object sender, EventArgs e)
        {
            OkClick(EMaterial.SurgicalGuide);
        }

        private void comboBoxManuStatus_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxManuStatus.SelectedIndex != 1)
            {
                EManufactureStatus manufactureStatus = ((ManufactureStatus_EnumListModel)comboBoxManuStatus.SelectedItem).EStatus;
                if (manufactureStatus == EManufactureStatus.InternalRedo || manufactureStatus == EManufactureStatus.Redo)
                {
                    textBoxReason.Visible = true;
                }
                else
                {
                    textBoxReason.Visible = false;
                }
            }
        }

        private void buttonCrCo_Click(object sender, EventArgs e)
        {
            OkClick(EMaterial.CoCr);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ComboboxLab.SelectedIndex = -1;
        }
        private void OkClick(DatabaseFunctions.Enumarable.EMaterial material)
        {
            if (comboBoxManuStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Vuil lòng chọn trạng thái", "Lỗi");
                return;
            }
            _MaterialName = material;
            _labOutsource = ((ModelLabs)ComboboxLab.SelectedItem).ID;
            _selected = true;
            _ManuStatus = ((ManufactureStatus_EnumListModel)comboBoxManuStatus.SelectedItem).EStatus;
            _noteReason = textBoxReason.Text;
            Close();
        }
    }
}
