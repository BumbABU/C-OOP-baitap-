using C_SharpBT.OOP;

internal class Program
{
    private static void Main(string[] args)
    {
        Nhanvien nhanvienx = new Nhanvien();
        dsNhanvien dsnhanvien = new dsNhanvien();
        dsnhanvien.nhapDSnv();
        /*dsnhanvien.xuatDSnhanvien();*/
        dsnhanvien.timkiemtheoTen();
        



    }
}