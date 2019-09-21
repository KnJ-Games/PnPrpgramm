using System;
using System.Collections.Generic;

namespace PnProgram
{
    public class Spieler
    {
        private String[] STANDARTSTATUSEFFEKTBEZEICHNUNGEN = { "Stunned", "Verhungert", "Verdurstet", "Vergiftet", "Brennt", "Blind", "Ertrinkt", "Silenced", "Schläft" };

        private List<Statuseffekt> statuseffekte = new List<Statuseffekt>();

        private SpielerKarte spielerKarte;

        string name = "";

        int maxLeben = 1;
        int aktLebel = 1;
        int angriffswert = 1;
        int astralenergie = 1;
        int rüestung = 1;
        int magieresistenz = 1;
        int ausdauer = 1;
        
        int bronze = 1;
        int silber = 1;
        int gold = 1;
        int diamanten = 1;

        int inventarplatz = 1;

        public Spieler(Spiel spiel, int spielernummer)
        {
            StandartStatuseffekteHinzufügen();

            spielerKarte = new SpielerKarte(spielernummer, this);
        }

        private void StandartStatuseffekteHinzufügen()
        {
            foreach (String bezeichnung in STANDARTSTATUSEFFEKTBEZEICHNUNGEN)
            {
                this.statuseffekte.Add(new Statuseffekt(bezeichnung, false, true));
            }
        }



        public SpielerKarte getSpielerKarte()
        {
            return spielerKarte;
        }

        public void setSpielerKarte(SpielerKarte spielerKarte)
        {
            this.spielerKarte = spielerKarte;
        }

        public List<Statuseffekt> getStatuseffekte()
        {
            return statuseffekte;
        }

        public void setStatuseffekte(List<Statuseffekt> statuseffekte)
        {
            this.statuseffekte = statuseffekte;
        }

        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public int getMaxLeben()
        {
            return maxLeben;
        }

        public void setMaxLeben(int maxLeben)
        {
            this.maxLeben = maxLeben;
        }

        public int getAktLebel()
        {
            return aktLebel;
        }

        public void setAktLebel(int aktLebel)
        {
            this.aktLebel = aktLebel;
        }

        public int getAngriffswert()
        {
            return angriffswert;
        }

        public void setAngriffswert(int angriffswert)
        {
            this.angriffswert = angriffswert;
        }

        public int getAstralenergie()
        {
            return astralenergie;
        }

        public void setAstralenergie(int astralenergie)
        {
            this.astralenergie = astralenergie;
        }

        public int getRüestung()
        {
            return rüestung;
        }

        public void setRüestung(int rüestung)
        {
            this.rüestung = rüestung;
        }

        public int getMagieresistenz()
        {
            return magieresistenz;
        }

        public void setMagieresistenz(int magieresistenz)
        {
            this.magieresistenz = magieresistenz;
        }

        public int getAusdauer()
        {
            return ausdauer;
        }

        public void setAusdauer(int ausdauer)
        {
            this.ausdauer = ausdauer;
        }

        public int getBronze()
        {
            return bronze;
        }

        public void setBronze(int bronze)
        {
            this.bronze = bronze;
        }

        public int getSilber()
        {
            return silber;
        }

        public void setSilber(int silber)
        {
            this.silber = silber;
        }

        public int getGold()
        {
            return gold;
        }

        public void setGold(int gold)
        {
            this.gold = gold;
        }

        public int getDiamanten()
        {
            return diamanten;
        }

        public void setDiamanten(int diamanten)
        {
            this.diamanten = diamanten;
        }

        public int getInventarplatz()
        {
            return inventarplatz;
        }

        public void setInventarplatz(int inventarslots)
        {
            this.inventarplatz = inventarslots;
        }
    }
}
