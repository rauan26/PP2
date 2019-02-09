using System;
using System.IO;

class Test
{
    public static void Main()
    {
        string file = "Rauan.txt";
        string path = @"C:\Users\HP\Desktop\C# test\week2\lab2.4" + file;
        string path1 = @"C:\Users\HP\Desktop\C# test\week2\lab2.4\lab2.4" + file;

        //CREATE
        FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
        //COPY
        fs.Close();
        File.Copy(path, path1);
        //DELETE
        File.Delete(path);
    }
}
