namespace PnProgram
{
    public class Gegner
    {
        private int STANDARTYOFFSET = 10;
        private int YOFFSET = 150;

        private GegnerKarte gegnerKarte;

        private Statuseffekt statuseffekte;

        string name = "";

        int maxLeben = 1;
        int aktLebel = 1;
        int angriffswert = 1;
        int astralenergie = 1;
        int rüestung = 1;
        int magieresistenz = 1;
        int ausdauer = 1;

        public Gegner(Kampf kampf, int gegnernummer)
        {
            gegnerKarte = new GegnerKarte(gegnernummer, kampf);
        }

        public GegnerKarte GetGegnerKarte()
        {
            return gegnerKarte;
        }

        public void setGegnerKarte(GegnerKarte spielerKarte)
        {
            this.gegnerKarte = spielerKarte;
        }

        public Statuseffekt getStatuseffekte()
        {
            return statuseffekte;
        }

        public void setStatuseffekte(Statuseffekt statuseffekte)
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
    }
}
