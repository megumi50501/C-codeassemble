using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronPython.Hosting;

namespace chap11_SampleDLR
{
    internal class SampleDLR
    {
        static void Main()
        {
            var py = Python.CreateRuntime();
            dynamic sample = py.UseFile("sample.py");

            // Pythonのクラスのインスタンス生成
            var p = sample.PythonSample();

            Console.WriteLine(p.getMessage("C#"));
            // 出力：Hello Python + C#
        }
    }
}
