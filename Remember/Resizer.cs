using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/**
 * Credit to this user from CodeProject: https://www.codeproject.com/script/Membership/View.aspx?mid=8649340
 * From Post: https://www.codeproject.com/Tips/749619/Csharp-Resize-ALL-Controls-at-Runtime
 */
public class Resizer
{
    readonly List<System.Drawing.Rectangle> _arr_control_storage = new List<System.Drawing.Rectangle>();
    readonly private bool showRowHeader = false;
    public Resizer(Form form)
    {
        Form = form; //the calling form
        FormSize = form.ClientSize; //Save initial form size
        Fontsize = form.Font.Size; //Font size
    }

    private float Fontsize { get; set; }

    private System.Drawing.SizeF FormSize { get; set; }

    private Form Form { get; set; }

    public void GetInitialSize() //get initial size//
    {
        var _controls = GetAllControls(Form);//call the enumerator
        foreach (Control control in _controls) //Loop through the controls
        {
            _arr_control_storage.Add(control.Bounds); //saves control bounds/dimension            
            //If you have datagridview
            if (control.GetType() == typeof(DataGridView))
                DgvColumnAdjust(((DataGridView)control), showRowHeader);
        }
    }

    public void Resize() //Set the resize
    {
        try
        {
            double _form_ratio_width = (double)Form.ClientSize.Width / (double)FormSize.Width; //ratio could be greater or less than 1
            double _form_ratio_height = (double)Form.ClientSize.Height / (double)FormSize.Height; // this one too
            var _controls = GetAllControls(Form); //reenumerate the control collection
            int _pos = -1;//do not change this value unless you know what you are doing
            foreach (Control control in _controls)
            {
                // do some math calc
                _pos += 1;//increment by 1;
                System.Drawing.Size _controlSize = new System.Drawing.Size((int)(_arr_control_storage[_pos].Width * _form_ratio_width),
                    (int)(_arr_control_storage[_pos].Height * _form_ratio_height)); //use for sizing

                System.Drawing.Point _controlposition = new System.Drawing.Point((int)
                (_arr_control_storage[_pos].X * _form_ratio_width), (int)(_arr_control_storage[_pos].Y * _form_ratio_height));//use for location

                //set bounds
                control.Bounds = new System.Drawing.Rectangle(_controlposition, _controlSize); //Put together

                //Assuming you have a datagridview inside a form()
                //if you want to show the row header, replace the false statement of 
                //showRowHeader on top/public declaration to true;
                if (control.GetType() == typeof(DataGridView))
                    DgvColumnAdjust(((DataGridView)control), showRowHeader);

            }
        }
        catch (Exception)
        {

        }
    }

    private void DgvColumnAdjust(DataGridView dgv, bool _showRowHeader) //if you have Datagridview 
    //and want to resize the column base on its dimension.
    {
        int intRowHeader = 0;
        const int Hscrollbarwidth = 5;
        if (_showRowHeader)
            intRowHeader = dgv.RowHeadersWidth;
        else
            dgv.RowHeadersVisible = false;

        for (int i = 0; i < dgv.ColumnCount; i++)
        {
            if (dgv.Dock == DockStyle.Fill) //in case the datagridview is docked
                dgv.Columns[i].Width = ((dgv.Width - intRowHeader) / dgv.ColumnCount);
            else
                dgv.Columns[i].Width = ((dgv.Width - intRowHeader - Hscrollbarwidth) / dgv.ColumnCount);
        }
    }

    private static IEnumerable<Control> GetAllControls(Control c)
    {
        return c.Controls.Cast<Control>().SelectMany(item =>
            GetAllControls(item)).Concat(c.Controls.Cast<Control>()).Where(control =>
            control.Name != string.Empty);
    }
}
