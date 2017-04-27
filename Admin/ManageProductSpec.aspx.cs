using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_ManageProductSpec : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        GpuSpecsModel model = new GpuSpecsModel();
        ProductSpec pt = createProductSpec();
    }

    private ProductSpec createProductSpec()
    {
        ProductSpec p = new ProductSpec();
        p.GpuName = txtName.Text;

        return p;
    }
}