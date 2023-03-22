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

    public int RandomValue(){
            return Random.Range(1,10);
    }

    public void SetRandomValue(){
        this.aceh = RandomValue();
        this.bali = RandomValue();
        this.banten = RandomValue();
        this.bengkulu = RandomValue();
        this.dki_jakarta = RandomValue();
        this.gorontalo = RandomValue();
        this.jambi = RandomValue();
        this.jawa_barat = RandomValue();
        this.jawa_tengah = RandomValue();
        this.jawa_timur = RandomValue();
        this.kalimantan_barat = RandomValue();
        this.kalimantan_selatan = RandomValue();
        this.kalimantan_tengah = RandomValue();
        this.kalimantan_timur = RandomValue();
        this.kalimantan_utara = RandomValue();
        this.kepulauan_bangka_belitung = RandomValue();
        this.kepulauan_riau = RandomValue();
        this.lampung = RandomValue();
        this.luar_negeri = RandomValue();
        this.maluku = RandomValue();
        this.maluku_utara = RandomValue();
        this.ntb = RandomValue();
        this.ntt = RandomValue();
        this.papua = RandomValue();
        this.papua_barat = RandomValue();
        this.riau = RandomValue();
        this.sulawesi_barat = RandomValue();
        this.sulawesi_selatan = RandomValue();
        this.sulawesi_tengah = RandomValue();
        this.sulawesi_tenggara = RandomValue();
        this.sulawesi_utara = RandomValue();
        this.sumatera_selatan = RandomValue();
        this.sumatera_barat = RandomValue();
        this.sumatera_utara = RandomValue();
        this.yogyakarta = RandomValue();

    }

    public void SetZero(){
        this.aceh = 0;
        this.bali = 0;
        this.banten = 0;
        this.bengkulu = 0;
        this.dki_jakarta = 0;
        this.gorontalo = 0;
        this.jambi = 0;
        this.jawa_barat = 0;
        this.jawa_tengah = 0;
        this.jawa_timur = 0;
        this.kalimantan_barat = 0;
        this.kalimantan_selatan = 0;
        this.kalimantan_tengah = 0;
        this.kalimantan_timur = 0;
        this.kalimantan_utara = 0;
        this.kepulauan_bangka_belitung = 0;
        this.kepulauan_riau = 0;
        this.lampung = 0;
        this.luar_negeri = 0;
        this.maluku = 0;
        this.maluku_utara = 0;
        this.ntb = 0;
        this.ntt = 0;
        this.papua = 0;
        this.papua_barat = 0;
        this.riau = 0;
        this.sulawesi_barat = 0;
        this.sulawesi_selatan = 0;
        this.sulawesi_tengah = 0;
        this.sulawesi_tenggara = 0;
        this.sulawesi_utara = 0;
        this.sumatera_selatan = 0;
        this.sumatera_barat = 0;
        this.sumatera_utara = 0;
        this.yogyakarta = 0;
    }

}
