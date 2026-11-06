using System;
using System.Runtime.InteropServices;
public class Agen
{
    private object alamat;
    private object nomor;
    private Agen
        public Agen(
            string idAgen,
            string nameAgen,
            int stokAgen)
    {
        Console.WriteLine($"{idAgen} pengirim stok.");
        Console.WriteLine($"{nameAgen} nama penjual");
        Console.WriteLine($"{stokAgen} stok barang");
    }
    public void TampilkanInfo()
    {
        Console.WriteLine($"{alamat} alamat toko agen ");
        Console.WriteLine($"{nomor} nomor telepon toko ");
    }
}

public class produkGalon
{
    private object kurangiStok;
    private produkGalon
    public produkGalon(string idProduk, string namaProduk, int stokGudang)
    {
        Console.WriteLine($"{idProduk} nomor produk");
        Console.WriteLine($"{namaProduk} nama produk");
        Console.WriteLine($"{stokGudang} stok dalam gudang");
    }

    public void penguranganStok()
    {
        Console.WriteLine($"{kurangiStok} proses pengurangan stok gudang");
    }
}

