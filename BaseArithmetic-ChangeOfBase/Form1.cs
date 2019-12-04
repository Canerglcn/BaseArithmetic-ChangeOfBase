using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseArithmetic_ChangeOfBase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnChanceOfBase_Click(object sender, EventArgs e)
        {
            StackUsingLinkedList sList = new StackUsingLinkedList();

            try
            {

                int number = Convert.ToInt32(txtCurrentNumber.Text);
                int baseofnumber = Convert.ToInt32(txtCurrentBase.Text);
                int targetbase = Convert.ToInt32(txtTargetBase.Text);

                int _numberBaseOfTen = 0;

                int remainder = 0;

                int _counter = 0;
                int startNumber = Convert.ToInt32(txtCurrentNumber.Text);


                if (targetbase >= 2 && targetbase <= 10 && (baseofnumber >= 2 && baseofnumber <= 10))
                {
                    txtFinalBase.Text = Convert.ToString(targetbase);
                    if (baseofnumber != 10)
                    {
                        _numberBaseOfTen = ChangeToBaseOfTen(number, baseofnumber);
                        number = _numberBaseOfTen;
                    }
                    while (number >= targetbase)
                    {
                        _counter++;
                        remainder = (number % targetbase);
                        sList.Push(remainder);

                        number = (number / targetbase);

                    }
                }
                else
                {
                    MessageBox.Show("Current ant Target Base Must be 2<= x <=10 ");
                }
                string text = "";

                if (_numberBaseOfTen < targetbase || _counter != 0)
                {
                    text += number.ToString();
                }

                if (_counter > 0)
                {

                    for (int i = 0; i <= sList.Nodecount; i++)
                    {

                        //MessageBox.Show(sList.top.ToString());
                        text = "" + text + sList.top.ToString() + " ";
                        sList.Pop();
                        if (sList.Head == null)
                            break;

                    }

                    text = "(" + text + ")";


                }

                lblResult.Text = text;

            }
            catch (Exception)
            {

                MessageBox.Show("You must write to all inputs.{Number,Base,TargetBase}");
            }
            

        }

        public int ChangeToBaseOfTen(int number,int baseofnumber)
        {
            int _total = 0;

            int _quotient = 0;

            int _divisor = 10;

            int _remainder = 0;

            int _digit = 0;
            StackUsingLinkedList _sList = new StackUsingLinkedList();

            int _tempNumber = number;
            while (true)
            {

                _quotient = _tempNumber / _divisor;
                _tempNumber -= (_quotient) * _divisor;
                if(_quotient==0)
                {
                    _remainder = _tempNumber - ((_quotient) * _divisor);
                    _digit++;
                    break;
                }

                _digit++;        
            }

            if(_digit>2)
            {
                for (int i = 0; i < _digit - 1; i++)
                {
                    _divisor *= 10;
                }
            }
          

            for (int i = 0; i < _digit; i++)
            {
                _quotient = number / _divisor;
                _sList.Push(_quotient);

                number -= (_quotient * _divisor);
                _divisor /= 10;
            }
            if(_remainder!=0)
            {
                _sList.Push(_remainder);
            }

            int _multiplier;
            for (int i = 0; i <_digit; i++)
            {
                _multiplier = Convert.ToInt32(Math.Pow(baseofnumber, i));
                _total += (_sList.top * _multiplier);
                _sList.Pop();

            }


            return _total;
        }

    }
}
