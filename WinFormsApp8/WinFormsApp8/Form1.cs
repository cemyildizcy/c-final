using System.Security.AccessControl;
using matbil;
using matbil.orn;
using gorsel;
using o1 = gorsel.bil;
using o2 = matbil.bil;
using o3 = matbil.mat;


namespace WinFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            o1 n = new o1();
            o3 n2 = new o3();

            // namespace (isimuzayý-isimalaný)
            mat m = new mat();
            m.matmetot2(78);
            //bil b = new bil();

            gorsel.bil bb = new gorsel.bil();            
            bb.metot(95);

            matbil.bil bbb = new matbil.bil();
            bbb.bilmetot1(23);


            matbil.orn.toplama t = new matbil.orn.toplama();
            t.topla(23);
            toplama tt = new toplama();
            tt.topla(45);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

namespace matbil
{
    namespace orn
    {
        class toplama
        {
            public int topla(int a)
            {
                return a + a;
            }
        }
    }
    class mat
    {
        public int matmetot1(int a)
        {
            return a * a;
        }
        public int matmetot2(int a)
        {
            return a * a * a;
        }
    }
    class bil
    {
        public int bilmetot1(int a)
        {
            return a + 10;
        }
        public int bilmetot2(int a)
        {
            return a + 100;
        }
    }
}

namespace gorsel
{
class bil
    {
        public int metot(int a)
        {
            return a * 100;
        }
    }
}