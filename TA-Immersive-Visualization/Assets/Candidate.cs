using UnityEngine;
public class Candidate
{
    public string name;
    public int aceh;
    public int bali;
    public int banten;
    public int bengkulu;
    public int dki_jakarta;
    public int gorontalo;
    public int jambi;
    public int jawa_barat;
    public int jawa_tengah;
    public int jawa_timur;
    public int kalimantan_barat;
    public int kalimantan_selatan;
    public int kalimantan_tengah;
    public int kalimantan_timur;
    public int kalimantan_utara;
    public int kepulauan_bangka_belitung;
    public int kepulauan_riau;
    public int lampung;
    public int luar_negeri;
    public int maluku;
    public int maluku_utara;
    public int ntb;
    public int ntt;
    public int papua;
    public int papua_barat;
    public int riau;
    public int sulawesi_barat;
    public int sulawesi_selatan;
    public int sulawesi_tengah;
    public int sulawesi_tenggara;
    public int sulawesi_utara;
    public int sumatera_barat;
    public int sumatera_selatan;
    public int sumatera_utara;
    public int yogyakarta;

    public Candidate(string candidate_name){
        this.name = candidate_name;
    }

    public int getProvince(int province){
        switch(province){
            case 0:
                return this.getTotalValue();
            case 1:
                return this.aceh;
            case 2:
                return this.bali;
            case 3:
                return this.banten;
            case 4:
                return this.bengkulu;
            case 5:
                return this.dki_jakarta;
            case 6:
                return this.gorontalo;
            case 7:
                return this.jambi;
            case 8:
                return this.jawa_barat;
            case 9:
                return this.jawa_tengah;
            case 10:
                return this.jawa_timur;
            case 11:
                return this.kalimantan_barat;
            case 12:
                return this.kalimantan_selatan;
            case 13:
                return this.kalimantan_tengah;
            case 14:
                return this.kalimantan_timur;
            case 15:
                return this.kalimantan_utara;
            case 16:
                return this.kepulauan_bangka_belitung;
            case 17:
                return this.kepulauan_riau;
            case 18:
                return this.kepulauan_riau;
            case 19:
                return this.lampung;
            case 20:
                return this.luar_negeri;
            case 21:
                return this.maluku;
            case 22:
                return this.maluku_utara;
            case 23:
                return this.ntb;
            case 24:
                return this.ntt;
            case 25:
                return this.papua;
            case 26:
                return this.papua_barat;
            case 27:
                return this.riau;
            case 28:
                return this.sulawesi_barat;
            case 29:
                return this.sulawesi_selatan;
            case 30:
                return this.sulawesi_tengah;
            case 31:
                return this.sulawesi_utara;
            case 32:
                return this.sumatera_barat;
            case 33:
                return this.sumatera_selatan;
            case 34:
                return this.sumatera_utara;
            case 35:
                return this.yogyakarta;
            default:
                return this.getTotalValue();
        }
    }

    public int getTotalValue(){
        int total = 0;
        total += this.aceh;
        total += this.bali;
        total += this.banten;
        total += this.bengkulu;
        total += this.dki_jakarta;
        total += this.gorontalo;
        total += this.jambi;
        total += this.jawa_barat;
        total += this.jawa_tengah;
        total += this.jawa_timur;
        total += this.kalimantan_barat;
        total += this.kalimantan_selatan;
        total += this.kalimantan_tengah;
        total += this.kalimantan_timur;
        total += this.kalimantan_utara;
        total += this.kepulauan_bangka_belitung;
        total += this.kepulauan_riau;
        total += this.lampung;
        total += this.luar_negeri;
        total += this.maluku;
        total += this.maluku_utara;
        total += this.ntb;
        total += this.ntt;
        total += this.papua;
        total += this.papua_barat;
        total += this.riau;
        total += this.sulawesi_barat;
        total += this.sulawesi_selatan;
        total += this.sulawesi_tengah;
        total += this.sulawesi_tenggara;
        total += this.sulawesi_utara;
        total += this.sumatera_barat;
        total += this.sumatera_selatan;
        total += this.sumatera_utara;
        total += this.yogyakarta;
        return total;
    }

    

}
