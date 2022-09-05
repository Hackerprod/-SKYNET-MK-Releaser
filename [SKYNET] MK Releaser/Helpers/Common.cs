using System;
using System.Text;
using System.Windows.Forms;

public class Common
{
    public static void Show(object msg)
    {
        MessageBox.Show(msg.ToString());
    }

    public static string LongToMbytes(long lBytes)
    {
        StringBuilder stringBuilder = new StringBuilder();
        string str1 = "Bytes";
        if (lBytes > 1024L)
        {
            string str2;
            float num;
            if (lBytes < 1048576L)
            {
                str2 = "KB";
                num = Convert.ToSingle(lBytes) / 1024f;
            }
            else
            {
                str2 = "MB";
                num = Convert.ToSingle(lBytes) / 1048576f;
            }
            stringBuilder.AppendFormat("{0:0.0} {1}", (object)num, (object)str2);
        }
        else
        {
            float num = Convert.ToSingle(lBytes);
            stringBuilder.AppendFormat("{0:0} {1}", (object)num, (object)str1);
        }
        return stringBuilder.ToString();
    }

}