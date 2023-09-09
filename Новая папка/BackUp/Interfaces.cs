using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BackUp
{

    interface IStorage
    {
        void MediaType();
        void CopyMethod();
        void FreeMemory();
        void PrintDeviceInfo();

    }

    public abstract class Storage
    {
        protected Storage(string mediaName, string model)
        {
            MediaName = mediaName;
            Model = model;
        }

        //public string MedianName { get; set; }
        public  string Model { get; set; }
        public string MediaName { get; }
    }


    class Flash:Storage,IStorage
    {
        

        public double USB3Srt { get; set; }
        public double Memory { get; set; }  

        public Flash(string mediaName,string model,double USB3SRt,double memory)
            :base(mediaName,model)
        {
            USB3Srt = USB3SRt;
            Memory = memory;


        }



        public  void CopyMethod()
        {
            Console.WriteLine("Copy Method");
        }

        public void FreeMemory()
        {
            Console.WriteLine("Free Memory");
        }

        public void MediaType()
        {
            Console.WriteLine("Media Type");


        }

        public void PrintDeviceInfo()
        {
            Console.WriteLine($"Media: {MediaName}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Media Size: {Memory}");
            Console.WriteLine($"Free Memory: {FreeMemory}");
        }
    }

    class DVD : Storage, IStorage
    {
        public double ReadSpeed { get; set; }
        public double WriteSpeed { get; set; }
        public bool IsDoubleSided { get; set; }


        public DVD(string mediaName, string model,double readSpeed, double writeSpeed, bool isDoubleSided)
            :base(mediaName,model)
        {
            ReadSpeed = readSpeed;
            WriteSpeed = writeSpeed;
            IsDoubleSided = isDoubleSided;
        }

        public void CopyMethod()
        {
            Console.WriteLine("Copy Method");
        }

        public void FreeMemory()
        {
            Console.WriteLine("Free Memory");
        }

        public double MediaType()
        {
            return IsDoubleSided ? 9.0 : 4.7;
        }

       public void PrintDeviceInfo()
        {
            Console.WriteLine($"Media: {MediaName}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Media Size: {(IsDoubleSided ? 9.0 : 4.7)} GB");
            Console.WriteLine($"Free Memory: {FreeMemory}"); ;
        }

        void IStorage.MediaType()
        {
            throw new NotImplementedException();
        }
    }

    class HDD : Storage, IStorage
    {

        public double USB2Srt { get; set; }
        public double TotalSize { get; set; }



        public HDD(string mediaName, string model, double uSB2Srt, double totalSize)
            : base(mediaName, model) 
        {
            USB2Srt = uSB2Srt;
            TotalSize = totalSize;
        }

        public void CopyMethod()
        {
            Console.WriteLine("Copy Method");
        }

        public void FreeMemory()
        {
            Console.WriteLine("Free Memory");
        }

        public void MediaType()
        {
            Console.WriteLine("Media Type");
        }

        public void PrintDeviceInfo()
        {
            Console.WriteLine($"Media: {MediaName}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Media Size: {TotalSize} GB");
            Console.WriteLine($"Free Memory: {FreeMemory} GB");
        }
    }


}
