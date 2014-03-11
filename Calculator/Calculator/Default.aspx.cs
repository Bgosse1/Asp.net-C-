using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Calculator
{
    public partial class Default : System.Web.UI.Page
    {
        static char operators;
        static double num1;
        static double num2;
        int dotcount = 0;
        static int excount = 1;
        static double result;
        static double parsedvalue;
        //int count = 1;
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "+") || (TextBox1.Text == "-") || (TextBox1.Text == "*") || (TextBox1.Text == "/") || (TextBox1.Text == "%")) //checks to see if operstor was clicked to clear the text box
            {
                TextBox1.Text = "";
                TextBox1.Text = TextBox1.Text + Button1.Text;
                Dot.Enabled = true;
            }
            else 
            {
                TextBox1.Text = TextBox1.Text + Button1.Text;
            }
        }

        protected void btn2_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "+") || (TextBox1.Text == "-") || (TextBox1.Text == "*") || (TextBox1.Text == "/") || (TextBox1.Text == "%"))
            {
                TextBox1.Text = "";
                TextBox1.Text = TextBox1.Text + Button2.Text;
                Dot.Enabled = true;
            }
            else 
            {
                TextBox1.Text = TextBox1.Text + Button2.Text;
            }
        }
        protected void btn3_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "+") || (TextBox1.Text == "-") || (TextBox1.Text == "*") || (TextBox1.Text == "/") || (TextBox1.Text == "%"))
            {
                TextBox1.Text = "";
                TextBox1.Text = TextBox1.Text + Button3.Text;
                Dot.Enabled = true;
            }
            else 
            {
                TextBox1.Text = TextBox1.Text + Button3.Text;
            }
        }
        protected void btn4_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "+") || (TextBox1.Text == "-") || (TextBox1.Text == "*") || (TextBox1.Text == "/") || (TextBox1.Text == "%"))
            {
                TextBox1.Text = "";
                TextBox1.Text = TextBox1.Text + Button4.Text;
                Dot.Enabled = true;
            }
            else
            {
                TextBox1.Text = TextBox1.Text + Button4.Text;
            }
        }

        protected void btn5_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "+") || (TextBox1.Text == "-") || (TextBox1.Text == "*") || (TextBox1.Text == "/") || (TextBox1.Text == "%"))
            {
                TextBox1.Text = "";
                TextBox1.Text = TextBox1.Text + Button5.Text;
                Dot.Enabled = true;
            }
            else
            {
                TextBox1.Text = TextBox1.Text + Button5.Text;
            }
        }

        protected void btn6_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "+") || (TextBox1.Text == "-") || (TextBox1.Text == "*") || (TextBox1.Text == "/") || (TextBox1.Text == "%"))
            {
                TextBox1.Text = "";
                TextBox1.Text = TextBox1.Text + Button6.Text;
                Dot.Enabled = true;
            }
            else
            {
                TextBox1.Text = TextBox1.Text + Button6.Text;
            }
        }

        protected void btn7_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "+") || (TextBox1.Text == "-") || (TextBox1.Text == "*") || (TextBox1.Text == "/") || (TextBox1.Text == "%"))
            {
                TextBox1.Text = "";
                TextBox1.Text = TextBox1.Text + Button7.Text;
                Dot.Enabled = true;
            }
            else
            {
                TextBox1.Text = TextBox1.Text + Button7.Text;
            }
        }

        protected void btn8_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "+") || (TextBox1.Text == "-") || (TextBox1.Text == "*") || (TextBox1.Text == "/") || (TextBox1.Text == "%"))
            {
                TextBox1.Text = "";
                TextBox1.Text = TextBox1.Text + Button8.Text;
                Dot.Enabled = true;
            }
            else
            {
                TextBox1.Text = TextBox1.Text + Button8.Text;
            }
        }

        protected void btn9_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "+") || (TextBox1.Text == "-") || (TextBox1.Text == "*") || (TextBox1.Text == "/") || (TextBox1.Text == "%"))
            {
                TextBox1.Text = "";
                TextBox1.Text = TextBox1.Text + Button9.Text;
                Dot.Enabled = true;
            }
            else
            {
                TextBox1.Text = TextBox1.Text + Button9.Text;
            }
        }

        protected void btn0_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "+") || (TextBox1.Text == "-") || (TextBox1.Text == "*") || (TextBox1.Text == "/") || (TextBox1.Text == "%"))
            {
                TextBox1.Text = "";
                TextBox1.Text = TextBox1.Text + Button0.Text;
                Dot.Enabled = true;
            }
            else
            {
                TextBox1.Text = TextBox1.Text + Button0.Text;
            }
        }

        protected void btnequal_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(TextBox1.Text);
            TextBox1.Text = "";
            //Session["Solution"] = result;
            if (operators == '+')
            {
                result = num1 + num2; 
                TextBox1.Text = TextBox1.Text + result.ToString();
                Session["Solution"] = result;
                Label1.Text = Session["Solution"].ToString();
                num1 = (double)Session["Solution"];
                
            }
            else if (operators == '-')
            {
                result = num1 - num2;
                TextBox1.Text = result.ToString();
                Session["Solution"] = result;
                Label1.Text = Session["Solution"].ToString();
                num1 = (double)Session["Solution"];
            }
            else if (operators == '*')
            {
                result = num1 * num2;
                TextBox1.Text = result.ToString();
                Session["Solution"] = result;
                Label1.Text = Session["Solution"].ToString();
                num1 = (double)Session["Solution"];
            }
            else if (operators == '/')
            {
                result = num1 / num2;
                TextBox1.Text = result.ToString();
                Session["Solution"] = result;
                Label1.Text = Session["Solution"].ToString();
                num1 = (double)Session["Solution"];
            }
            else if (operators == '%')
            {
                result = num1 % num2;
                TextBox1.Text = result.ToString();
                Session["Solution"] = result;
                Label1.Text = Session["Solution"].ToString();
                num1 = (double)Session["Solution"];
            }

        }

        protected void btnplus_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(TextBox1.Text, out parsedvalue))//validate the number entered is a double and not a char. if char entered textbox goes blank.
            {
                TextBox1.Text = "";
                
            }
            else
            {
                num1 = double.Parse(TextBox1.Text);
                TextBox1.Text = "";
                operators = '+';
                TextBox1.Text = TextBox1.Text + operators;
            }
        }

        protected void btnminus_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(TextBox1.Text, out parsedvalue))
            {
                TextBox1.Text = "";
            }
            else
            {
                num1 = double.Parse(TextBox1.Text);
                TextBox1.Text = "";
                operators = '-';
                TextBox1.Text = TextBox1.Text + operators;
            }
        }

        protected void btnmult_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(TextBox1.Text, out parsedvalue))
            {
                TextBox1.Text = "";
            }
            else
            {
                num1 = double.Parse(TextBox1.Text);
                TextBox1.Text = "";
                operators = '*';
                TextBox1.Text = TextBox1.Text + operators;
            }
        }

        protected void btndiv_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(TextBox1.Text, out parsedvalue))
            {
                TextBox1.Text = "";
            }
            else
            {
                num1 = double.Parse(TextBox1.Text);
                TextBox1.Text = "";
                operators = '/';
                TextBox1.Text = TextBox1.Text + operators;
            }
        }

        protected void btnclear_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            
            Dot.Enabled = true;
        }

        protected void btndot_Click(object sender, EventArgs e)
        {
            dotcount++;
            TextBox1.Text = TextBox1.Text + Dot.Text;
            if (dotcount == 0) // check the decimal count if theres one decimal it becomes disabled.
            {
                Dot.Enabled = true;
            }
            else
            {
                Dot.Enabled = false;
            }
        }

        protected void btnextend_Click(object sender, EventArgs e)
        {
            ++excount;
            if (excount % 2 == 0) // shows and hides teh extend tab.
            {
                btnsin.Visible = true;
                btntan.Visible = true;
                btncos.Visible = true;
                btnmod.Visible = true;
            }
            else
            {
                btnsin.Visible = false;
                btntan.Visible = false;
                btncos.Visible = false;
                btnmod.Visible = false;
            }

        }

        protected void btnsin_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(TextBox1.Text, out parsedvalue))
            {
                TextBox1.Text = "";
            }
            else
            {
                num1 = double.Parse(TextBox1.Text);
                TextBox1.Text = Math.Sin(num1).ToString();
            }
        }

        protected void btncos_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(TextBox1.Text, out parsedvalue))
            {
                TextBox1.Text = "";
            }
            else
            {
                num1 = double.Parse(TextBox1.Text);
                TextBox1.Text = Math.Cos(num1).ToString();
            }
        }

        protected void btntan_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(TextBox1.Text, out parsedvalue))
            {
                TextBox1.Text = "";
            }
            else
            {
                num1 = double.Parse(TextBox1.Text);
                TextBox1.Text = Math.Tan(num1).ToString();
            }
        }

        protected void btnmod_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(TextBox1.Text, out parsedvalue))
            {
                TextBox1.Text = "";
            }
            else
            {
                num1 = double.Parse(TextBox1.Text);
                TextBox1.Text = "";
                operators = '%';
                TextBox1.Text = TextBox1.Text + operators;
            }
        }

        protected void subsol_Click(object sender, EventArgs e)
        {
            Session["Solution"] = Label1.Text;
            Response.Redirect("Answer.aspx");
        }

        protected void clearsv_Click(object sender, EventArgs e)
        {
            Label1.Text = "";
            Session["Solution"] = string.Empty;
        }

       

        

    }
}