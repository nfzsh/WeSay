using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    //static List<Massage>
       // msg = new List<Massage>();
    protected void Page_Load(object sender, EventArgs e)
    {
        TextBoxName.Attributes.Add("onMouseOver", "this.focus();this.select();");

        /*using (DatabaseEntities dataEntity = new DatabaseEntities())
        {
            var all = from info in dataEntity.Tables
                      select info;
            if(all!=null)
            {
                foreach (Table info in all)
                {
                    TextM.Text += info.name.Trim() + "：\r\n" + info.message.Trim()+"\r\n";
                }
            }
        }*/
        Refresh();
        Label1.Text = Application["onLine"].ToString();
    }
    void Refresh()
    {
        if (MsgList.msg!= null)
        {
            TextM.Text = null;
            foreach (Massage info in MsgList.msg)
            {
                
                TextM.Text += info.Username + "：\r\n" + info.Content + "\r\n";
            }
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Massage msg1 = new Massage();
        if (TextBoxName.Text == "" || TextBoxName.Text == "点此改名")
            msg1.Username = "匿名用户";
        else
            msg1.Username = TextBoxName.Text;
        if (TextBox2.Text != "")
        {
            msg1.Content = TextBox2.Text;
            MsgList.msg.Add(msg1);
            MsgList.Test();
            Refresh();
        }
    }

    protected void ButtonName_Click(object sender, EventArgs e)
    {
        ButtonName.Visible = false;
        TextBoxName.Visible = true;
        Button3.Visible = true;
        Button4.Visible = true;
        
    }

    protected void TextBoxName_TextChanged(object sender, EventArgs e)
    {
        
    }

    protected void TextM_TextChanged(object sender, EventArgs e)
    {
        
    }

    protected void Timer1_Tick(object sender, EventArgs e)
    {
        Refresh();
        Label1.Text = Application["onLine"].ToString();
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        if (TextBoxName.Text == "" || TextBoxName.Text == "点此改名") 
            ButtonName.Text = "匿名用户";
        else
            ButtonName.Text = TextBoxName.Text;
        TextBoxName.Visible = false;
        ButtonName.Visible = true;
        Button3.Visible = false;
        Button4.Visible = false;
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        //ButtonName.Text = TextBoxName.Text;
        TextBoxName.Visible = false;
        ButtonName.Visible = true;
        Button3.Visible = false;
        Button4.Visible = false;
    }
}