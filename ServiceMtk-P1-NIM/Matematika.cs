﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceMtk_P1_NIM
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    /// <summary>
    /// main class
    /// <remarks>class Matematika dapat membuat operasi pembagian (bagi), perkalian (kali), pengurangan (kurang), penjumlahan (Tambah)</remarks>
    /// </summary>
    public class Matematika : IMatematika
    {
        /// <summary>
        /// operasi pembagian
        /// </summary>
        /// <param name="a">angka pertama dalam operasi pembagian</param>
        /// <param name="b">angka kedua yang akan dibagi dengan angka pertama</param>
        /// <returns>hasil pembagian dari angka pertama dan kedua</returns>
        public int Bagi(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //Secara default
                //Throw new Exception(ex.Message) Pesan error secara default
                //Throw new FaultException("Pesan Salah"); Untuk meloloskan pesan eror yang dikirim ke client

                MathFault mf = new MathFault();
                mf.Kode = "Inputan yang anda masukkan salah";
                mf.Pesan = "Masukkan input yang benar";
                throw new FaultException<MathFault>(mf);
            }
        }
        public int Kali(int a, int b)
        {
            try
            {
                return a * b;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //Secara default
                //Throw new Exception(ex.Message) Pesan error secara default
                //Throw new FaultException("Pesan Salah"); Untuk meloloskan pesan eror yang dikirim ke client

                MathFault mf = new MathFault();
                mf.Kode = "Inputan yang anda masukkan salah";
                mf.Pesan = "Masukkan input yang benar";
                throw new FaultException<MathFault>(mf);
            }
        }
        /// <summary>
        /// Operasi Perkalian
        /// </summary>
        /// <param name="a">angka pertama dalam operasi perkalian</param>
        /// <param name="b">angka kedua yang akan dikali dengan angka pertama</param>
        /// <returns>hasil perkalian dari angka pertama dan kedua</returns>
        public int Kurang(int a, int b)
        {
            try
            {
                return a - b;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //Secara default
                //Throw new Exception(ex.Message) Pesan error secara default
                //Throw new FaultException("Pesan Salah"); Untuk meloloskan pesan eror yang dikirim ke client

                MathFault mf = new MathFault();
                mf.Kode = "Inputan yang anda masukkan salah";
                mf.Pesan = "Masukkan input yang benar";
                throw new FaultException<MathFault>(mf);
            }
        }
        /// <summary>
        /// Operasi pengurangan
        /// </summary>
        /// <param name="a">angka pertama dalam operasi pengurangan</param>
        /// <param name="b">angka kedua yang akan dikurangi dengan angka pertama</param>
        /// <returns>hasil pengurangan dari angka pertama dan kedua</returns>
        public int Tambah(int a, int b)
        {
            try
            {
                return a + b;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //Secara default
                //Throw new Exception(ex.Message) Pesan error secara default
                //Throw new FaultException("Pesan Salah"); Untuk meloloskan pesan eror yang dikirim ke client

                MathFault mf = new MathFault();
                mf.Kode = "Inputan yang anda masukkan salah";
                mf.Pesan = "Masukkan input yang benar";
                throw new FaultException<MathFault>(mf);
            }
        }
        /// <summary>
        /// Operasi Penjumlahan
        /// </summary>
        /// <param name="a">angka pertama dalam operasi penjumlahan</param>
        /// <param name="b">angka kedua yang akan dijumlahkan dengan angka pertama</param>
        /// <returns>hasil penjumlahan dari angka pertama dan kedua</returns>
        //TKoordinat:nama methodnya, a,b = input seperti int.
        //Membuat koordinat hasil lalu menjumlahkan xa dengan xb, ya dengan yb lalu dimasukkan ke hasil
        /// <summary>
        /// Operasi Penjumlahan
        /// </summary>
        /// <param name="a">angka pertama xa dan xb dalam operasi koordinat</param>
        /// <param name="b">angka kedua yang akan dikoordinatkan dengan angka pertama<
        /// <returns>hasil koordinat dari angka pertama dan kedua</returns>
        public Koordinat TKoordinat(Koordinat a, Koordinat b)
        {
            Koordinat hasil = new Koordinat();
            hasil.X = a.X + b.X;
            hasil.Y = a.Y + b.Y;
            return hasil;
        }
    }
}
