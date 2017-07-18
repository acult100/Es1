using System;
namespace e1
{
    public class Alloggio
    {
        private int codice;


        public int getCodice(){
            return this.codice;
        }
        private double estensione;      //si suppone che possa essere un numero decimale
        private double costo;
        private double tasse;
        private double metriq;

        public Alloggio()
        {
            

        }

        public void Inserisci(int codice, double estensione, double costo, double metriq)
        {
            this.codice = codice;
            this.estensione = estensione;
            this.costo = costo;

            this.metriq = metriq;
            this.tasse = this.Valore();
        }

        public double Valore()
        {

            double PTasse;

            switch(metriq)
            {
                case 100: PTasse = 0.1;
                    break;
                case 150: PTasse = 0.32;
                    break;
                 default : PTasse = 0.4;
                    break;

    
            }
            return PTasse;
        }

        public string Stampa()
        {
            string rtn = "";
            return rtn = "codice" + codice + "estensione:" + estensione + "costo:" + costo + "tasse" + tasse;
            
            
        }
    }
}
