using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C_SharpBT.OOP
{
    internal class Nhanvien
    {
        private string maNV;
        private string tenNV;
        private bool gtinh;
        private string sdt;
        private DateTime ngaySinh;
         
        //default constructor 
        public Nhanvien()
        {
            this.maNV = "000";
            this.tenNV = "noName";
            this.gtinh = false;
            this.sdt = "000000000000001";
            this.ngaySinh = new DateTime(2000, 1, 1);

        }


        //b. xây dụng method set get
        //1.set
        public void setmaNV(string maNV)
        {
            this.maNV = maNV;
        }

        public void settenNV(string tenNV)
        {
            this.tenNV = tenNV;
        }

        public void setgtinh(bool gtinh)
        {
            this.gtinh = gtinh;
        }

        public void setsDT(string sdt)
        {
            this.sdt = sdt;
        }

        public void setngaySinh(DateTime ngaySinh)
        {
            this.ngaySinh = ngaySinh;
        }

        //2.get
        public string getmaNV()
        {
            return this.maNV;
        }

        public string gettenNV()
        {
            return this.tenNV;
        }

        public bool getgTinh()
        {
            return this.gtinh;
        }

        public string getsDT()
        {
            return this.sdt;
        }

        public DateTime getngaySinh()
        {
            return this.ngaySinh;
        }

        //c. xây dụng thuộc tính setget

        public string MANV
        {
            set { this.maNV = value; }
            get { return this.maNV; }
        }

        public string TENNV
        {
            set { this.tenNV = value; }
            get { return this.tenNV; }
        }

        public bool GIOITINH
        {
            set { this.gtinh = value; }
            get { return this.gtinh; }
        }

        public string SDT
        {
            set { this.sdt = value; }
            get { return this.sdt; }
        }

        public DateTime NGAYSINH
        {
            set { this.ngaySinh = value; }
            get { return this.ngaySinh; }
        }

        // d. Ham xuat dl
        public void Xuatdl()
        {
            Console.WriteLine("maNV : " + maNV);
            Console.WriteLine("tenNV : " + tenNV);
            if (gtinh == true)
            {
                Console.WriteLine("gTinh : Nam ");
            }
            else Console.WriteLine("gTinh : Nu ");

            Console.WriteLine(" SDT : " + SDT);
            Console.WriteLine("Ngay sinh : " + ngaySinh);
        }

        //e.XD hàm tostring để xuất tt đối tượng 
        public override string? ToString()
        {
            if (gtinh == true)
            {
                string s = "maNV :" + maNV + "\ntenNV:" + tenNV + "\ngTinh :Nam " + "\nSDT : " + sdt + "\nNgaySinh :" + ngaySinh;
                return s;
            } else
            {
                string x = "maNV :" + maNV + "\ntenNV:" + tenNV + "\ngTinh : Nu" + "\nSDT : " + sdt + "\nNgaySinh :" + ngaySinh;
                return x;
            }


        }

        //f.ham nhap doi tuong nv;
        public Nhanvien(string maNV, string tenNV, bool gtinh, string sdt, DateTime ngaySinh)
        {
            this.maNV = maNV;
            this.tenNV = tenNV;
            this.gtinh = gtinh;
            this.sdt = sdt;
            this.ngaySinh = ngaySinh;
        }

        //h.Nhap va xuat danh sach cac nhan vien
       
        public void nhapxuatDSnhanvien()
        {
            Console.WriteLine("Hay nhap so luong nhan vien :");
            int x;
            x = Convert.ToInt32(Console.ReadLine());
            Nhanvien[] dsnhanvien = new Nhanvien[x];
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("Nhap nhan vien thu i = " + i);
                dsnhanvien[i] = new Nhanvien();

                Console.WriteLine("Nhap ma nv  :");
                dsnhanvien[i].maNV = Console.ReadLine();

                Console.WriteLine("Nhap ten nv :");
                dsnhanvien[i].tenNV = Console.ReadLine();

                Console.WriteLine("nhap gtinh nv :");
                dsnhanvien[i].gtinh = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine("nhap sdt nv :");
                dsnhanvien[i].sdt = Console.ReadLine();

                Console.WriteLine("Nhap ngay thang nam sinh nv : ");
                dsnhanvien[i].ngaySinh = Convert.ToDateTime(Console.ReadLine());


            }
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("Xuat nhan vien thu i = " + i);
                Console.WriteLine("maNV : " + dsnhanvien[i].maNV);
                Console.WriteLine("tenNV : " + dsnhanvien[i].tenNV);
                if (dsnhanvien[i].gtinh == true)
                {
                    Console.WriteLine("gTinh : Nam ");
                }
                else Console.WriteLine("gTinh : Nu ");

                Console.WriteLine(" SDT : " + dsnhanvien[i].SDT);
                Console.WriteLine("Ngay sinh : " + dsnhanvien[i].ngaySinh);
            }

        }

        
       /* public void xuatDSnhanvien()
        {
            Console.WriteLine("Hay nhap so luong can xuat : ");
            int x;
            x = Convert.ToInt32(Console.ReadLine());

            Nhanvien[] dsnhanvien = new Nhanvien[x];
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("maNV : " + dsnhanvien[i].maNV);
                Console.WriteLine("tenNV : " + dsnhanvien[i].tenNV);
                if (dsnhanvien[i].gtinh == true)
                {
                    Console.WriteLine("gTinh : Nam ");
                }
                else Console.WriteLine("gTinh : Nu ");

                Console.WriteLine(" SDT : " + dsnhanvien[i].SDT);
                Console.WriteLine("Ngay sinh : " + dsnhanvien[i].ngaySinh);
            }

        }
*/


    }
} 

