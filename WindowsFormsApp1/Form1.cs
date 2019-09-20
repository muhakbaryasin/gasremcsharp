using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Car MyCar;
        public Form1()
        {

            InitializeComponent();
            MyCar = new Car(20);
            MyCar.OnVariableChange += MyCar_OnVariableChange;
        }

        private void MyCar_OnVariableChange(int newVal)
        {
            Console.WriteLine(newVal);
            RefreshIndicator();
        }

        private void btn_gas_Click(object sender, EventArgs e)
        {
            MyCar.NgeGas();
        }

        private void btn_rem_Click(object sender, EventArgs e)
        {
            MyCar.NgeRem();
        }

        private void RefreshIndicator()
        {
            if (!MyCar.isSafeSpeed())
            {
                btn_indicator.BackColor = Color.Red;
                MessageBox.Show("Bahaya cuy, jangan terlalu laju.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (MyCar.getVelocity() == 0)
                btn_indicator.BackColor = Color.Transparent;
            else btn_indicator.BackColor = Color.Green;
        }
    }

    class Car
    {
        private int Velocity;
        private int MaxVelocity;
        // public enum ColorIndicator { Red, Green, None };

        public delegate void OnVariableChangeDelegate(int newVal);
        public event OnVariableChangeDelegate OnVariableChange;

        public Car(int maxVelocity)
        {
            Velocity = 0;
            MaxVelocity = maxVelocity;
        }

        public int getVelocity()
        {
            return Velocity;
        }

        public void setVelocity(int velocity)
        {
            if (velocity == Velocity) return;

            Velocity = velocity;

            OnVariableChange?.Invoke(velocity);

            // if (OnVariableChange != null)
            //    OnVariableChange(velocity);
        }

        public void NgeGas()
        {
            Velocity = Velocity + 5;
            setVelocity(getVelocity() + 5);
        }

        public void NgeRem()
        {
            int currentVelocity = getVelocity();

            if (currentVelocity > 0 )
                setVelocity(currentVelocity - 5);
            
            // if (currentVelocity < 0)
            //     setVelocity(0);
        }

        public bool isSafeSpeed()
        {
            if (Velocity <= MaxVelocity)
                return true;
            else return false;
        }

        /*public ColorIndicator getColorIndicator()
        {
            if (Velocity <= MaxVelocity)
                return ColorIndicator.Green;
            else if (Velocity == 0)
                return ColorIndicator.None;
            else return ColorIndicator.Red;
        }*/
    }
}
