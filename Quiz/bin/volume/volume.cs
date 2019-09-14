using system;

namespace volume
{
    class vol
{
    public void volume()
    {
        int panjang, lebar, tinggi, volume;

        console.writeline("menghitung volue persegi panjang");
        console.writeline("------------------------------");

        console.writelne("masukkan Nilai Panjang : ");
        panjang = convert.ToInt32(console.Readline());

        console.writeline("Masukkan Nilai Lebar : ");
        lebar = convert.ToInt32(console.Readline());

        console.writeline("masukkan Nilai Tinggi : ");
        tinggi = convert.ToInt32(console.Readline());

        volume = panjang * lebar * tinggi;

        console.writeline("volume persegi panjang : ");


        }
    }
}

   