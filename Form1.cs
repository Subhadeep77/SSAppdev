using System.Collections.Generic;
using System.Security.Cryptography;
using System.Windows.Forms.VisualStyles;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Stack<double> st = new Stack<double>();
        Stack<double> prv = new Stack<double>();
        double p = 0.0;
        double pr = 0.0, s = 0.0,fp;
        int d = 0, r = 0, l = 1, rst = 0, f = 0;  double lf=10;
        System.Text.StringBuilder sbl = new System.Text.StringBuilder();
        public Form1()
        {
            InitializeComponent();
        }
        private void T1_TextChanged(object sender, EventArgs e)
        {
            T1.Text += ""; 
        }
        private void b0_Click(object sender, EventArgs e)
        {
            if (d == 1) 
            {
                if (T1.Text != "0" && rst==0) 
                { 
                    T1.Text += "0";
                    if (f == 1) { s +=0.0/lf;lf *= 10; }
                    else { s = s * 10 + 0.0; }
                    if (sbl.Length > 0)
                    {
                        if (sbl[l - 1] == '+') {  if (r == 0) { st.Push(s); r = 1; } else { st.Pop(); st.Push(s); } }
                        else if (sbl[l - 1] == '-') { if (r == 0) { st.Push(s *(-1) ); r = 1; } else { st.Pop(); st.Push(s*(-1)); } }
                        else if (sbl[l - 1] == 'x') { if (r == 0) { pr = st.Pop();fp = pr * s; st.Push(fp); r = 1; prv.Push(pr); } else { st.Pop();fp = pr * s; st.Push(fp); } }
                        else if (sbl[l - 1] == '/' && r == 1) { pr=st.Pop();fp = pr / s; st.Push(fp); prv.Push(pr); }
                        else { if (st.Count == 0) { st.Push(s); } else { st.Pop(); st.Push(s); } }
                    }
                    else { if (st.Count == 0) { st.Push(s); } else { st.Pop(); st.Push(s); } }
                }
                else { T1.Text = "0";while (st.Count > 0) { st.Pop(); } }
            }
        }

        private void b1_Click(object sender, EventArgs e)
        {
            if (d == 1) 
            { 
                if (T1.Text != "0" && rst==0) 
                { 
                    T1.Text += "1";
                    if (f == 1) { s += 1.0 / lf; lf *= 10; }
                    else { s = s * 10 + 1.0; }
                    if (sbl.Length > 0)
                    {
                        if (sbl[l - 1] == '+') { if (r == 0) { st.Push(s); r = 1; } else { st.Pop(); st.Push(s); } }
                        else if (sbl[l - 1] == '-') { if (r == 0) { st.Push(s * (-1)); r = 1; } else { st.Pop(); st.Push(s * (-1)); } }
                        else if (sbl[l - 1] == 'x') { if (r == 0) { pr = st.Pop(); fp = pr * s; st.Push(fp); r = 1; prv.Push(pr); } else { st.Pop(); fp = pr * s; st.Push(fp); } }
                        else if (sbl[l - 1] == '/') { if (r == 0) { pr = st.Pop(); fp = pr / s; st.Push(fp); r = 1; prv.Push(pr); } else { st.Pop(); fp = pr / s; st.Push(fp); } }
                        else { if (st.Count == 0) { st.Push(s); } else { st.Pop(); st.Push(s); } }
                    }
                    else { if (st.Count == 0) { st.Push(s); } else { st.Pop(); st.Push(s); } }
                } 
                else 
                { 
                    T1.Text = "1";
                    while(st.Count >0) { st.Pop(); }
                    s = 1.0; st.Push(s);
                } 
            }
        }

        private void b2_Click(object sender, EventArgs e)
        {
            if (d == 1)
            {
                if (T1.Text != "0" && rst == 0)
                {
                    T1.Text += "2";
                    if (f == 1) { s += 2.0 / lf; lf *= 10; }
                    else { s = s * 10 + 2.0; }
                    if (sbl.Length>0)
                    {
                        if (sbl[l - 1] == '+') { if (r == 0) { st.Push(s); r = 1; } else { st.Pop(); st.Push(s); } }
                        else if (sbl[l - 1] == '-') { if (r == 0) { st.Push(s * (-1)); r = 1; } else { st.Pop(); st.Push(s * (-1)); } }
                        else if (sbl[l - 1] == 'x') { if (r == 0) { pr = st.Pop(); fp = pr * s; st.Push(fp); r = 1; prv.Push(pr); } else { st.Pop(); fp = pr * s; st.Push(fp); } }
                        else if (sbl[l - 1] == '/') { if (r == 0) { pr = st.Pop(); fp = pr / s; st.Push(fp); r = 1; prv.Push(pr); } else { st.Pop(); fp = pr / s; st.Push(fp); } }
                        else { if (st.Count == 0) { st.Push(s); } else { st.Pop(); st.Push(s); } }
                    }
                    else { if (st.Count == 0) { st.Push(s); } else { st.Pop(); st.Push(s); } }
                }
                else
                {
                    T1.Text = "2";
                    while (st.Count > 0) { st.Pop(); }
                    s = 2.0; st.Push(s);
                }
            }
        }

        private void b3_Click(object sender, EventArgs e)
        {
            if (d == 1)
            {
                if (T1.Text != "0" && rst==0)
                {
                    T1.Text += "3";
                    if (f == 1) { s += 3.0 / lf; lf *= 10; }
                    else { s = s * 10 + 3.0; }
                    if (sbl.Length > 0)
                    {
                        if (sbl[l - 1] == '+') { if (r == 0) { st.Push(s); r = 1; } else { st.Pop(); st.Push(s); } }
                        else if (sbl[l - 1] == '-') { if (r == 0) { st.Push(s * (-1)); r = 1; } else { st.Pop(); st.Push(s * (-1)); } }
                        else if (sbl[l - 1] == 'x') { if (r == 0) { pr = st.Pop();  fp = pr * s; st.Push(fp); r = 1; prv.Push(pr); } else { st.Pop(); fp = pr * s; st.Push(fp); } }
                        else if (sbl[l - 1] == '/') { if (r == 0) { pr = st.Pop(); fp = pr / s; st.Push(fp); r = 1; prv.Push(pr); } else { st.Pop(); fp = pr / s; st.Push(fp); } }
                        else { if (st.Count == 0) { st.Push(s); } else { st.Pop(); st.Push(s); } }
                    }
                    else {  if (st.Count == 0) { st.Push(s); } else { st.Pop(); st.Push(s); } }
                }
                else
                {
                    T1.Text = "3";
                    while (st.Count > 0) { st.Pop(); }
                    s = 3.0; st.Push(s);
                }
            }
        }

        private void b4_Click(object sender, EventArgs e)
        {
            if (d == 1)
            {
                if (T1.Text != "0")
                {
                    T1.Text += "4";
                    if (f == 1) { s += 4.0 / lf; lf*= 10; }
                    else { s = s * 10 + 4.0; }
                    if (sbl.Length > 0 && rst==0)
                    {
                            if (sbl[l - 1] == '+') { if (r == 0) { st.Push(s); r = 1; } else { st.Pop(); st.Push(s); } }
                            else if (sbl[l - 1] == '-') { if (r == 0) { st.Push(s * (-1)); r = 1; } else { st.Pop(); st.Push(s * (-1)); } }
                            else if (sbl[l - 1] == 'x') { if (r == 0) { pr = st.Pop(); fp = pr * s; st.Push(fp); r = 1; prv.Push(pr); } else { st.Pop(); fp = pr * s; st.Push(fp); }  }
                            else if (sbl[l - 1] == '/') { if (r == 0) { pr = st.Pop(); fp = pr / s; st.Push(fp); r = 1; prv.Push(pr); } else { st.Pop(); fp = pr / s; st.Push(fp); }  }
                            else { if (st.Count == 0) { st.Push(s); } else { st.Pop(); st.Push(s); } }
                    }
                    else { if (st.Count == 0) { st.Push(s); } else { st.Pop(); st.Push(s); } }
                }
                else
                {
                    T1.Text = "4";
                    while (st.Count > 0) { st.Pop(); }
                    s = 4.0; st.Push(s);
                }
            }
        }

        private void b5_Click(object sender, EventArgs e)
        {
            if (d == 1)
            {
                if (T1.Text != "0" && rst == 0)
                {
                    T1.Text += "5";
                    if (f == 1) { s += 5.0 / lf; lf *= 10; }
                    else { s = s * 10 + 5.0; }
                    if (sbl.Length > 0)
                    {
                        if (sbl[l - 1] == '+') { if (r == 0) { st.Push(s); r = 1; } else { st.Pop(); st.Push(s); } }
                        else if (sbl[l - 1] == '-') { if (r == 0) { st.Push(s * (-1)); r = 1; } else { st.Pop(); st.Push(s * (-1)); } }
                        else if (sbl[l - 1] == 'x') { if (r == 0) { pr = st.Pop(); fp = pr * s; st.Push(fp); r = 1; prv.Push(pr); } else { st.Pop(); fp = pr * s; st.Push(fp); } }
                        else if (sbl[l - 1] == '/') { if (r == 0) { pr = st.Pop(); fp = pr / s; st.Push(fp); r = 1; prv.Push(pr); } else { st.Pop(); fp = pr / s; st.Push(fp); } }
                        else { if (st.Count == 0) { st.Push(s); } else { st.Pop(); st.Push(s); } }
                    }
                    else { if (st.Count == 0) { st.Push(s); } else { st.Pop(); st.Push(s); } }
                }
                else
                {
                    T1.Text = "5";
                    while (st.Count > 0) { st.Pop(); }
                    s = 5.0; st.Push(s);
                }
            }
        }

        private void b6_Click(object sender, EventArgs e)
        {
            if (d == 1)
            {
                if (T1.Text != "0" && rst == 0)
                {
                    T1.Text += "6";
                    if (f == 1) { s += 6.0 / lf; lf *= 10; }
                    else { s = s * 10 + 6.0; }
                    if (sbl.Length > 0)
                    {
                        if (sbl[l - 1] == '+') { if (r == 0) { st.Push(s); r = 1; } else { st.Pop(); st.Push(s); } }
                        else if (sbl[l - 1] == '-') { if (r == 0) { st.Push(s * (-1)); r = 1; } else { st.Pop(); st.Push(s * (-1)); } }
                        else if (sbl[l - 1] == 'x') { if (r == 0) { pr = st.Pop(); fp = pr * s; st.Push(fp); r = 1; prv.Push(pr); } else { st.Pop(); fp = pr * s; st.Push(fp); } }
                        else if (sbl[l - 1] == '/') { if (r == 0) { pr = st.Pop(); fp = pr / s; st.Push(fp); r = 1; prv.Push(pr); } else { st.Pop(); fp = pr / s; st.Push(fp); } }
                        else { if (st.Count == 0) { st.Push(s); } else { st.Pop(); st.Push(s); } }
                    }
                    else { if (st.Count == 0) { st.Push(s); } else { st.Pop(); st.Push(s); } }
                }
                else
                {
                    T1.Text = "6";
                    while (st.Count > 0) { st.Pop(); }
                    s = 6.0; st.Push(s);
                }
            }
        }

        private void b7_Click(object sender, EventArgs e)
        {
            if (d == 1)
            {
                if (T1.Text != "0" && rst == 0)
                {
                    T1.Text += "7";
                    if (f == 1) { s += 7.0 / lf; lf *= 10; }
                    else { s = s * 10 + 7.0; }
                    if (sbl.Length > 0)
                    {
                        if (sbl[l - 1] == '+') { if (r == 0) { st.Push(s); r = 1; } else { st.Pop(); st.Push(s); } }
                        else if (sbl[l - 1] == '-') { if (r == 0) { st.Push(s * (-1)); r = 1; } else { st.Pop(); st.Push(s * (-1)); } }
                        else if (sbl[l - 1] == 'x') { if (r == 0) { pr = st.Pop(); fp = pr * s; st.Push(fp); r = 1; prv.Push(pr); } else { st.Pop(); fp = pr * s; st.Push(fp); } }
                        else if (sbl[l - 1] == '/') { if (r == 0) { pr = st.Pop(); fp = pr / s; st.Push(fp); r = 1; prv.Push(pr); } else { st.Pop(); fp = pr / s; st.Push(fp); } }
                        else { if (st.Count == 0) { st.Push(s); } else { st.Pop(); st.Push(s); } }
                    }
                    else { if (st.Count == 0) { st.Push(s); } else { st.Pop(); st.Push(s); } }
                }
                else
                {
                    T1.Text = "7";
                    while (st.Count > 0) { st.Pop(); }
                    s = 7.0; st.Push(s);
                }
            }
        }

        private void b8_Click(object sender, EventArgs e)
        {
            if (d == 1)
            {
                if (T1.Text != "0" && rst == 0)
                {
                    T1.Text += "8";
                    if (f == 1) { s += 8.0 / lf; lf *= 10; }
                    else { s = s * 10 + 8.0; }
                    if (sbl.Length > 0)
                    {
                        if (sbl[l - 1] == '+') { if (r == 0) { st.Push(s); r = 1; } else { st.Pop(); st.Push(s); } }
                        else if (sbl[l - 1] == '-') { if (r == 0) { st.Push(s * (-1)); r = 1; } else { st.Pop(); st.Push(s * (-1)); } }
                        else if (sbl[l - 1] == 'x') { if (r == 0) { pr = st.Pop(); fp = pr * s; st.Push(fp); r = 1; prv.Push(pr); } else { st.Pop(); fp = pr * s; st.Push(fp); } }
                        else if (sbl[l - 1] == '/') { if (r == 0) { pr = st.Pop(); fp = pr / s; st.Push(fp); r = 1; prv.Push(pr); } else { st.Pop(); fp = pr / s; st.Push(fp); } }
                        else { if (st.Count == 0) { st.Push(s); } else { st.Pop(); st.Push(s); } }
                    }
                    else { if (st.Count == 0) { st.Push(s); } else { st.Pop(); st.Push(s); } }
                }
               
                else
                {
                    T1.Text = "8";
                    while (st.Count >0) { st.Pop(); }
                    s = 8.0; st.Push(s);
                }
            }
        }

        private void b9_Click(object sender, EventArgs e)
        {
            if (d == 1)
            {
                if (T1.Text != "0" && rst == 0)
                {
                    T1.Text += "9";
                    if (f == 1) { s += 9.0 / lf; lf *= 10; }
                    else { s = s * 10 + 9.0; }
                    if (sbl.Length > 0)
                    {
                        if (sbl[l - 1] == '+') { if (r == 0) { st.Push(s); r = 1; } else { st.Pop(); st.Push(s); } }
                        else if (sbl[l - 1] == '-') { if (r == 0) { st.Push(s * (-1)); r = 1; } else { st.Pop(); st.Push(s * (-1)); } }
                        else if (sbl[l - 1] == 'x') { if (r == 0) { pr = st.Pop(); fp = pr * s; st.Push(fp); r = 1;prv.Push(pr); } else { st.Pop(); fp = pr * s; st.Push(fp); }  }
                        else if (sbl[l - 1] == '/') { if (r == 0) { pr = st.Pop(); fp = pr / s; st.Push(fp); r = 1; prv.Push(pr); } else { st.Pop(); fp = pr / s; st.Push(fp); }  }
                        else { if (st.Count == 0) { st.Push(s); } else { st.Pop(); st.Push(s); } }
                    }
                    else { if (st.Count == 0) { st.Push(s); } else { st.Pop(); st.Push(s); } }
                }
                
                else
                {
                    T1.Text = "9";
                    while (st.Count > 0) { st.Pop(); }
                    s = 9.0; st.Push(s);
                }
            }
        }

        private void b_point_Click(object sender, EventArgs e)
        {
            if (d == 1)
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder(T1.Text);
                int ln = sb.Length;
                if (sb[ln - 1] != '/' && sb[ln - 1] != '+' && sb[ln - 1] != '-' && sb[ln - 1] != 'x' && f == 0)
                { T1.Text += "."; rst = 0;f = 1; }
            }
        }

        private void b_div_Click(object sender, EventArgs e)
        {
            if(d==1 && T1.Text!="0")
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder(T1.Text);
                int ln = sb.Length;
                if (sb[ln - 1] != '/' && sb[ln - 1] != '+' && sb[ln - 1] != '-' && sb[ln - 1] != 'x' && sb[ln - 1] != '.')
                { T1.Text += "/";r = 0;sbl=new System.Text.StringBuilder(T1.Text);l = sbl.Length;s = 0.0; rst = 0; f = 0; lf = 10; }
            }
        }

        private void b_mult_Click(object sender, EventArgs e)
        {
            if (d == 1 && T1.Text != "0")
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder(T1.Text);
                int ln = sb.Length;
                if (sb[ln - 1] != '/' && sb[ln - 1] != '+' && sb[ln - 1] != '-' && sb[ln- 1] != 'x' && sb[ln - 1] != '.')
                { T1.Text += "x";r = 0; sbl = new System.Text.StringBuilder(T1.Text); l = sbl.Length;s = 0.0; rst = 0;f = 0;lf = 10; }
            }
        }

        private void b_diff_Click(object sender, EventArgs e)
        {
            if (d == 1 && T1.Text != "0")
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder(T1.Text);
                int ln= sb.Length;
                if (sb[ln - 1] != '/' && sb[ln - 1] != '+' && sb[ln - 1] != '-' && sb[ln - 1] != 'x' && sb[ln - 1] != '.')
                { T1.Text += "-"; r = 0; sbl = new System.Text.StringBuilder(T1.Text); l = sbl.Length; s = 0.0; rst = 0; f = 0;lf = 10; }
            }
        }

        private void b_add_Click(object sender, EventArgs e)
        {
            if (d == 1 && T1.Text != "0")
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder(T1.Text);
                int ln = sb.Length;
                if (sb[ln - 1] != '/' && sb[ln - 1] != '+' && sb[ln - 1] != '-' && sb[ln - 1] != 'x' && sb[ln - 1] != '.')
                { T1.Text += "+";r = 0; sbl = new System.Text.StringBuilder(T1.Text); l = sbl.Length;s = 0.0; rst = 0;f = 0; lf = 10; }
            }
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            if (d == 1)
            {
                rst= 0;
                System.Text.StringBuilder sb = new System.Text.StringBuilder(T1.Text);
                int ln = sb.Length;
                l = sbl.Length;
                if (ln > 1)
                {
                    char c = sb[ln - 1],d='0'; sb[ln - 1] = '\0'; T1.Text = sb.ToString();
                    if (c == '+' || c == '-' || c == 'x' || c == '/' || c == '.' || (f==1 && c=='0')) { sbl = new System.Text.StringBuilder(T1.Text); l = sbl.Length; if (c == '.') { f = 0;lf = 10; } else if (r == 1) { st.Pop(); if (c == 'x' || c == '/') { st.Push(prv.Pop()); } } }
                    else { int len = s.ToString().Length;if (len > 1) { string r = s.ToString().Remove(len - 1); if (r.Last() == '.') { lf = 10; } } if (f == 1) { s = Double.Parse(s.ToString().Substring(0, len - 1)); } else { int a = (int)s / 10; s = a; } int i = l - 1; while (i >= 0) { d = sbl[i]; if (d == '+' || d == '-' || d == 'x' || d == '/') break; i--; } }
                    if (l>0)
                    {

                        if (d == '+') { st.Pop(); st.Push(s); }
                        else if (d == '-') { st.Pop(); st.Push((-1.0) * s); }
                        else if (d == 'x') { if (s != 0) { p = prv.Pop(); st.Push(p * s); } } 
                        else if (d == '/') { if (s != 0) { p = prv.Pop(); st.Push(p / s); } } 
                    }
                    else { if (st.Count > 0) { if (s == 0.0) { while (st.Count > 0) { st.Pop(); } } else { st.Pop(); st.Push(s); } } }
                }
                else { T1.Text = "0"; r = 0;s = 0.0; while (st.Count > 0) { st.Pop(); } }
            }
        }

        private void b_clear_Click(object sender, EventArgs e)
        {
            if (d == 1) { T1.Text = "0"; r = 0;s = 0.0;l = 1;sbl = new System.Text.StringBuilder(); while (st.Count > 0) { st.Pop(); } while (prv.Count > 0) { prv.Pop(); } rst = 0; f = 0;lf = 10; }
        }

        private void b_lock_Click(object sender, EventArgs e)
        {
            if (T1.Text != "") { T1.Text = ""; d = 0; r = 0; s = 0.0; l = 1; sbl = new System.Text.StringBuilder(); while (st.Count > 0) { st.Pop(); } while (prv.Count > 0) { prv.Pop(); } rst = 0; f = 0;lf = 10; }
            else { T1.Text += "0"; d = 1; }
        }

        private void b_braces_Click(object sender, EventArgs e)
        {

        }

        private void b_result_Click(object sender, EventArgs e)
        {
            if (T1.Text != "0")
            {
                double val = 0.0; while (st.Count != 0) { val += st.Pop(); } while (prv.Count > 0) { prv.Pop(); }
                T1.Text = val.ToString(); rst = 1; st.Push(val); s = val; pr = 0.0;
                if (s / (int)s > 1.0) { f = 1; } else { f = 0; } lf = 10;
                sbl= new System.Text.StringBuilder(T1.Text);l=sbl.Length;
            }
        }
    }
}