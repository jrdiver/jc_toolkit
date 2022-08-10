using System;
using System.Windows.Forms;

namespace jcColor;

public partial class PresetNameDialog : Form
{
    public PresetNameDialog()
    {
        InitializeComponent();
        AcceptButton = m_btn_OK;
    }

    private void btn_OK_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.OK;
        Close();
    }

    private void btn_Cancel_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }

}