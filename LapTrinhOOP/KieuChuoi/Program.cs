using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KieuChuoi
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Khai bao de co the xuat tieng VIet ra man hinh
            //Console.OutputEncoding = Encoding.UTF8;
            //char a = '\u02a5'; //vị trí của ký tự trong bảng mã
            //Console.WriteLine(" Xin chào các bạn " + a);
            //string s = "Xin chao cac ban ";
            //Console.WriteLine(s);
            //sai hoten, HoTen, Hoten,
            string hoTen = " Nguyen Van Toan Van";
            
            //Console.Write("Nhap vao ho va ten ");
            //hoTen = Console.ReadLine();
            Console.WriteLine(hoTen);
            Console.WriteLine(hoTen[5]);
            //Hàm viet hoa
            Console.WriteLine(hoTen.ToUpper());
            //Viet thuong
            Console.WriteLine(hoTen.ToLower());
            //Lay chieu dai chuoi
            Console.WriteLine(hoTen.Length);
            //Lay 1 chuoi con Substring
            Console.WriteLine(hoTen.Substring(0,2));
            Console.WriteLine(hoTen.Substring(5, 2));
            //Hàm tìm vị trí đầu tiên của một chuỗi con trong chuỗi
            Console.WriteLine(hoTen.IndexOf("Van"));
            //Ham tim vi tri sau cung cua chuoi con trong chuoi cha
            Console.WriteLine(hoTen.LastIndexOf("Van"));
            //Hàm xóa khoảng trắng ở đầu và cuối chuỗi
            Console.WriteLine(hoTen.Trim());
            //Hàm cắt chuỗi thành các chuỗi con 
            string[] tu = hoTen.Trim().Split(' ');
            //Hàm thay the mot chuoi con bang 1 moi
            //Console.WriteLine(hoTen.Replace("Toan", "OOP"));
            Console.WriteLine(" Ho la " + tu[0]);
            Console.ReadKey();
        }
    }
}
