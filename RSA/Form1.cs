using System.Numerics;

namespace RSA;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();

        //Zum Entschlüsseln: 102 341 418;
        //Privatekey(19, 481);
    }

    private void btn_Decrypt_Click(object sender, EventArgs e)
    {
        var n = Convert.ToInt32(txtPrivatKey1);
        var d = Convert.ToInt32(txtPrivatKey2);
        var vIntervall = n.ToString().Length;


        var el = Math.Sqrt((double)n);
        var vT = txtDecyrpt.Text;
        var splitvt = String.Split(vT, vIntervall);

        var rvListNum = new List<char>();
        var rvlist = new List<string>();

        foreach (var c in splitvt)
        {
            var cNum = Convert.ToInt32(c);
         
            rvListNum.Add((char)(BigInteger.ModPow(cNum, d, n) + 54));
        }
    }

    private void btn_Encrypt_Click(object sender, EventArgs e)
    {
    }
}