using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace _20200140023_Tugas2_B
{
    class Program
    {

        public SqlDataReader dataread;

        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=LAPTOP-1IV3PNL7\\BELINDAMERLANSYA;database=Exercise_1;Integrated Security = TRUE");
                con.Open();

                SqlCommand cm = new SqlCommand("create table karyawan(Id_Karyawan Char(10) primary key NOT NULL,Nama_Karyawan Varchar(60),No_telpn int,Alamat Varchar(20),"
                    + "create table pembeli(id_Pembeli  char (10)  primary key NOT NULL,nama_pembeli Varchar (30),jenis_kelamin char (10),alamat Varchar (20),No_telfn int,)"
                    + "create table obat(Id_Obat  Char (8) primary key NOT NULL,Nama_obat Varchar (12),Jenis_obat Varchar (10),Harga_satuan int,Stock int,Id_supplier char (8),)"
                    + "create table supplier(Id_supplier Char (5) primary key NOT NULL,Nama_supplier Varchar (20),No_telfn int,)"
                    + "create table Faktur_supplier(Id_nota char (10) primary key NOT NULL,Id_Karyawan char (10),Id_supplier Char (5),Id_Obat char (5),Jumlah_obat  int,Tanggal datetime,Total int,)"
                    + "create table Struk_Penjualan(Nama_Barang Varchar (30) primary key NOT NULL,tanggal datetime,Jumlah_Barang int,Harga_satuan int,Id_barang char (5), Id_karyawan char (5),Id_pembeli char (5),Total int,Dibayar int,)", con);
                cm.ExecuteNonQuery();

                Console.WriteLine("Tabel Sukses Dibuat !!!");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Tabel Yang Anda Buat Gagal : (" + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }
        }
        public void InsertData()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=LAPTOP-1IV3PNL7\\BELINDAMERLANSYA;database=Exercise_1;Integrated Security = TRUE");
                con.Open();
                SqlCommand cm = new SqlCommand("insert into karyawan(Id_Karyawan,Nama_Karyawan,No_telpn,Alamat) Values('011','Muhammad',200200,'Surakarta'),"
                    + "insert into karyawan(Id_Karyawan, Nama_Karyawan, No_telpn, Alamat) Values('012', 'Neymar', 20300, 'Jogja'), "
                    + "insert into karyawan(Id_Karyawan,Nama_Karyawan,No_telpn,Alamat) Values('013','Merlansyah',20400,'Kalimantan'),"
                    + "insert into karyawan(Id_Karyawan,Nama_Karyawan,No_telpn,Alamat) Values('014','Taehyung',20500,'Surabaya')"
                    + "insert into karyawan(Id_Karyawan,Nama_Karyawan,No_telpn,Alamat) Values('015','jimin',20600,'Jakarta')')"
                    + "insert into pembeli(id_Pembeli,nama_pembeli,jenis_kelamin,alamat,No_telfn) Values('000','Bella','perempuan','Surakarta',00221133),"
                    + "insert into pembeli(id_Pembeli,nama_pembeli,jenis_kelamin,alamat,No_telfn) Values('001','mika','perempuan','Kalimantan',11223344),"
                    + "insert into pembeli(id_Pembeli,nama_pembeli,jenis_kelamin,alamat,No_telfn) Values('002','Anwar','Laki-laki','Sulawesi',22334455),"
                    + "insert into pembeli(id_Pembeli,nama_pembeli,jenis_kelamin,alamat,No_telfn) Values('003','Miko','Laki-laki','Jakarta',44556677),"
                    + "insert into pembeli(id_Pembeli,nama_pembeli,jenis_kelamin,alamat,No_telfn) Values('004','Chika','perempuan','Riau',66778899)"
                    + "insert into obat (Id_Obat,Nama_obat,Jenis_obat,Harga_satuan,Stock,Id_supplier) values('000','Paracetamol','tablet',15.000,2,'00221133'),"
                    + "insert into obat(Id_Obat, Nama_obat, Jenis_obat, Harga_satuan, Stock, Id_supplier) values('001', 'Infalgin', 'tablet', 10.000, 3, '00221144'), "
                    + "insert into obat (Id_Obat,Nama_obat,Jenis_obat,Harga_satuan,Stock,Id_supplier) values('002','Diapet','tablet',12.000,4,'00221155'),"
                    + "insert into obat (Id_Obat,Nama_obat,Jenis_obat,Harga_satuan,Stock,Id_supplier) values('003','Amoksilin','tablet',20.000,1,'00221155'),"
                    + "insert into obat (Id_Obat,Nama_obat,Jenis_obat,Harga_satuan,Stock,Id_supplier) values('004','Mylanta','cair',25.000,4,'00221166')"
                    + "insert into supplier (Id_supplier,Nama_supplier,No_telfn) values('011','Taehyung',200200),"
                    + "insert into supplier (Id_supplier,Nama_supplier,No_telfn) values('012','Jimin',20300),"
                    + "insert into supplier (Id_supplier,Nama_supplier,No_telfn) values('013','Kim sokjin',20400),"
                    + "insert into supplier (Id_supplier,Nama_supplier,No_telfn) values('014','jungkook',20300),"
                    + "insert into supplier (Id_supplier,Nama_supplier,No_telfn) values('015','Kim nam joon',20400)"
                    + "insert into Faktur_supplier(Id_nota,Id_Karyawan,Id_supplier,Id_Obat,Jumlah_obat,Tanggal,Total) values('001','200200','011','A02',3,1-01-2022,15000),"
                    + "insert into Faktur_supplier(Id_nota,Id_Karyawan,Id_supplier,Id_Obat,Jumlah_obat,Tanggal,Total) values('002','200300','012','A03',4,2-01-2022,30000),"
                    + "insert into Faktur_supplier(Id_nota,Id_Karyawan,Id_supplier,Id_Obat,Jumlah_obat,Tanggal,Total) values('003','200400','013','A04',5,3-01-2022,40000),"
                    + "insert into Faktur_supplier(Id_nota,Id_Karyawan,Id_supplier,Id_Obat,Jumlah_obat,Tanggal,Total) values('004','200500','014','A05',6,4-01-2022,50000),"
                    + "insert into Faktur_supplier(Id_nota,Id_Karyawan,Id_supplier,Id_Obat,Jumlah_obat,Tanggal,Total) values('005','200600','015','A06',7,9-01-2022,25000)"
                    + "insert into Struk_Penjualan(Nama_Barang,tanggal,Jumlah_Barang,Harga_satuan,Id_barang,Id_karyawan,Id_pembeli,Total,Dibayar) values('paracetamol',1-03-2022,2,10.000,'111','023','002',30.000,30.000),"
                    + "insert into Struk_Penjualan(Nama_Barang,tanggal,Jumlah_Barang,Harga_satuan,Id_barang,Id_karyawan,Id_pembeli,Total,Dibayar) values('Infalgin',2-03-2022,5,20.000,'115','024','003',40.000,40.000),"
                    + "insert into Struk_Penjualan(Nama_Barang,tanggal,Jumlah_Barang,Harga_satuan,Id_barang,Id_karyawan,Id_pembeli,Total,Dibayar) values('Mylanta',3-03-2022,4,50.000,'113','025','004',60.000,60.000),"
                    + "insert into Struk_Penjualan(Nama_Barang,tanggal,Jumlah_Barang,Harga_satuan,Id_barang,Id_karyawan,Id_pembeli,Total,Dibayar) values('Diapet',4-03-2022,3,60.000,'114','026','006',70.000,70.000),"
                    + "insert into Struk_Penjualan(Nama_Barang,tanggal,Jumlah_Barang,Harga_satuan,Id_barang,Id_karyawan,Id_pembeli,Total,Dibayar) values('Amoksilin',5-03-2022,1,30.000,'116','022','007',40.000,40.000)", con);
                cm.ExecuteNonQuery();
                Console.WriteLine("Sukses Menambahkan Data");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Gagal Menambahkan Data" + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }
        }


        static void Main(string[] args)
        {
            new Program().CreateTable();
            new Program().InsertData();
        }
    }
}
