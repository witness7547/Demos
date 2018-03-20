using Dicom;
using Dicom.Imaging.Codec;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FodicomTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (FileStream s = File.Open(@"D:\Temp\1.dcm", FileMode.Open, FileAccess.ReadWrite, FileShare.Read))
            //{                
            //    var file = DicomFile.Open(s);
            //    file.Dataset.AddOrUpdate(DicomTag.PatientName, "jim");
            //    file.Save(@"D:\Temp\1.dcm");
            //}


            //FileStream s = File.Open(@"D:\Temp\1.dcm", FileMode.Open, FileAccess.Read, FileShare.Read);
            //var file = DicomFile.Open(s);
            //s.Close();
            //file.Dataset.AddOrUpdate(DicomTag.PatientName, "jim123");
            //file.Save(@"D:\Temp\1.dcm");


            //using (FileStream s = File.Open(@"D:\Temp\1.dcm", FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read))
            //{
            //    var file = DicomFile.Open(s);
            //    file.Dataset.AddOrUpdate(DicomTag.PatientName, "jim123");
            //    file.Save(@"D:\Temp\1.dcm");
            //}

            //var file = DicomFile.Open(@"D:\Temp\3.dcm"); 
            //file.Dataset.AddOrUpdate(DicomTag.PatientName, "jack");

            //file.Save(@"D:\Temp\3.dcm");  


            MemoryStream ms = new MemoryStream();
            using (FileStream fs = File.Open(@"D:\Temp\1.dcm", FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read))
            {
                fs.CopyTo(ms);
            }

            ms.Position = 0;
            var file = DicomFile.Open(ms);
            file.Dataset.AddOrUpdate(DicomTag.PatientName, "james");
            file.Save(@"D:\Temp\1.dcm");

            ms.Close();
        }

    }
}
