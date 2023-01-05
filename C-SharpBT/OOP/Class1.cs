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
        public string maNV;
        private string tenNV;
        private bool gtinh;
        private string sdt;
        private DateTime ngaySinh;
        private int tuoi;
         
        //default constructor 
        public Nhanvien()
        {
            this.maNV = "000";
            this.tenNV = "noName";
            this.gtinh = false;
            this.sdt = "000000000000001";
            this.ngaySinh = new DateTime(2000, 1, 1);
            this.tuoi = 0;

        }


        //b. xây dụng method set get
        //1.set
        public void setTuoi(int tuoi)
        {
            this.tuoi = tuoi;
        }

        public int getTuoi()
        {
            return this.tuoi;
        }
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

        public int TUOI
        {
            set { this.tuoi = value; }
            get { return this.tuoi; }
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
        public Nhanvien(string maNV, string tenNV, bool gtinh, string sdt, DateTime ngaySinh, int tuoi)
        {
            this.maNV = maNV;
            this.tenNV = tenNV;
            this.gtinh = gtinh;
            this.sdt = sdt;
            this.ngaySinh = ngaySinh;
            this.tuoi = tuoi;
        }

        
       
      


  
    }

    internal class dsNhanvien
    {
        int soluong;

        Nhanvien[] danhsach;
        
        //ham nhap ds nhan vien

        public void nhapDSnv()
        {
            Console.WriteLine("So luong nhan vien can nhap : ");
            int x;
            
            x = Convert.ToInt32(Console.ReadLine());
             danhsach = new Nhanvien[x];
            for (int i = 0; i < x; i++)
            {
                soluong++;
                Console.WriteLine("Nhap nhan vien thu i = " + i);
                danhsach[i] = new Nhanvien();

                Console.WriteLine("Nhap ma nv  :");
                danhsach[i].MANV = Console.ReadLine();

                Console.WriteLine("Nhap ten nv :");
                danhsach[i].TENNV = Console.ReadLine();

                Console.WriteLine("nhap gtinh nv :");
                danhsach[i].GIOITINH = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine("nhap sdt nv :");
                danhsach[i].SDT = Console.ReadLine();
                Console.WriteLine("Nhap ngay thang nam sinh nv : ");
                danhsach[i].NGAYSINH = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Tuoi nv : ");
                danhsach[i].TUOI = Convert.ToInt32(Console.ReadLine());


            }
        }

        //ham xuat ds nhan vien
        public void xuatDSnhanvien()
        {
            Console.WriteLine("Hay nhap so luong can xuat : ");
            int x;
            x = Convert.ToInt32(Console.ReadLine());

            
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("maNV : " + danhsach[i].MANV);
                Console.WriteLine("tenNV : " + danhsach[i].TENNV);
                if (danhsach[i].GIOITINH == true)
                {
                    Console.WriteLine("gTinh : Nam ");
                }
                else Console.WriteLine("gTinh : Nu ");

                Console.WriteLine(" SDT : " + danhsach[i].SDT);
                Console.WriteLine("Ngay sinh : " + danhsach[i].NGAYSINH);
            }

        }
        
        // ham tim so tuoi lon nhat 
        public int timmaxtuoi()
        {
            int max = danhsach[0].TUOI;
            
            for (int i =0; i < danhsach.Length; i++)
            {

                if (danhsach[i].TUOI > max)
                {
                    max = danhsach[i].TUOI;

                }
            }
                Console.WriteLine("so tuoi lon nhat la " + max);
               
            for (int i =0;i<danhsach.Length ;i++)
            {
                if (danhsach[i].TUOI == max)
                {
                    Console.WriteLine("Nguoi co so tuoi lon nhat ten la  " + danhsach[i].TENNV);
                }
            }

            
            return max;
        }

        //ham tim kiem theo ten
        public void timkiemtheoTen ()
        {
            Console.WriteLine("Vui long nhap ten can tim : ");
            string tencantim = Console.ReadLine();

            for (int i =0; i<danhsach.Length;i++)
            {
                if (danhsach[i].TENNV == tencantim)
                {
                    Console.WriteLine("maNV : " + danhsach[i].MANV);
                    Console.WriteLine("tenNV : " + danhsach[i].TENNV);
                    if (danhsach[i].GIOITINH == true)
                    {
                        Console.WriteLine("gTinh : Nam ");
                    }
                    else Console.WriteLine("gTinh : Nu ");

                    Console.WriteLine(" SDT : " + danhsach[i].SDT);
                    Console.WriteLine("Ngay sinh : " + danhsach[i].NGAYSINH);
                    break;

                }
                Console.WriteLine("Khong tim thay nguoi co ten la :" + tencantim);
            }
            
        }


    }
} 

